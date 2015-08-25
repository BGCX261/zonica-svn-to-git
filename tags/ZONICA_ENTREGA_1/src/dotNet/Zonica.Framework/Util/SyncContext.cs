using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using log4net;

namespace Zonica.Framework.Util {
	/// <summary>
	/// Summary description for SyncContext.
	/// </summary>
	public class SyncContext {
		private static readonly ILog log = LogManager.GetLogger(typeof (SyncContext));

		private const string NH_MONITORED_OBJECTS = "__Hexacta.Framework.NH.Util.SyncContext";
		private ArrayList monitors = new ArrayList();

		private SyncContext() {}

		/// <summary>
		/// Returns the SyncContext associated with the current thread
		/// </summary>
		public static SyncContext Current {
			get { return GetSyncContext(); }
		}

		/// <summary>
		/// Returns the current SyncContext
		/// </summary>
		/// <returns>the SyncContext</returns>
		private static SyncContext GetSyncContext() {
			SyncContext context = null;

			if (CallContext.GetData(NH_MONITORED_OBJECTS) != null) {
				context = CallContext.GetData(NH_MONITORED_OBJECTS) as SyncContext;
			}

			//This is the first time that the SyncContext has been requested, so when need to create a new one.
			if (context == null) {
				context = new SyncContext();
				SetSyncContext(context);
			}

			return context;
		}

		/// <summary>
		/// Sets the SyncContext
		/// </summary>
		/// <param name="context">the SyncContext to set</param>
		private static void SetSyncContext(SyncContext context) {
			log.Debug("Setting up SyncContext into CallContext");

			CallContext.FreeNamedDataSlot(NH_MONITORED_OBJECTS);
			CallContext.SetData(NH_MONITORED_OBJECTS, context);
		}

		/// <summary>
		/// Cleans the SyncContext contents.
		/// </summary>
		public void ClearContext() {
			log.Debug("Clearing SyncContext from CallContext");
			CallContext.FreeNamedDataSlot(NH_MONITORED_OBJECTS);
		}

		/// <summary>
		/// Use this method to use a Monitor that will be released after
		/// the nhibernate transaction has commited or rollback
		/// </summary>
		/// <param name="obj">the object to monitor</param>
		public void MonitorEnterUntilCommit(object obj) {
			if (obj != null) {
				log.Debug("About to enter Monitor section for object " + obj.ToString());
				Monitor.TryEnter(obj, new TimeSpan(0, 2, 0));
				log.Debug("Monitor aquired for object " + obj.ToString());
				log.Debug("Adding object '" + obj.ToString() + "' to monitored objects");
				monitors.Add(obj);
			} else {
				throw new Exception(); //TODO: agregar msj
			}
		}

		internal void ReleaseMonitored() {
			foreach (object obj in monitors) {
				log.Debug("Releasing monitored object " + obj.ToString());
				Monitor.Exit(obj);
			}
			monitors.Clear();
		}
	}
}