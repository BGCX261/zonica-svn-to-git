using System;
using System.Runtime.Remoting.Messaging;
using System.Web;
using log4net;
using NHibernate;
using Zonica.Framework.NH;

namespace Zonica.Framework.Util {
	/// <summary>
	/// Encapsulates the methods necesarry to set and get a <see cref="NHSessionWrapper"/> into a Thread Context
	/// </summary>
	[Serializable]
	public abstract class NHContext {
		/// <summary>
		/// Log4Net logger
		/// </summary>
		protected static readonly ILog log = LogManager.GetLogger(typeof (NHContext));

		/// <summary>
		/// Context key value
		/// </summary>
		protected const string NH_CONTEXT_CALL_CONTEXT_KEY = "__Hexacta.Framework.NH.Util.NHContext";

		private NHSessionWrapper sessionWrapper;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <remarks>Builds a NHSessionWrapper object to use with the thread execution. </remarks>
		protected NHContext() {
			sessionWrapper = new NHSessionWrapper();
		}

		/// <summary>
		/// Returns the NHContext associated with the current thread
		/// </summary>
		public static NHContext Current {
			get {
				log.Debug("Retrieving context in thread" + AppDomain.GetCurrentThreadId().ToString());
				object context = CallContext.GetData("HtCt");
				if (context != null) {
					if (context is HttpContext) {
						log.Debug("Found HttpContext");
						return ((HttpContext) context).Items[NH_CONTEXT_CALL_CONTEXT_KEY] as NHWebContext;
					} else if (context is NHThreadContext) {
						log.Debug("Found NHThreadContext");
						return context as NHThreadContext;
					}
				}
				log.Debug("No context found");
				return null;
			}
		}

		/// <summary>
		/// Gets an opened nhibernate <see cref="ISession"/> object. The session is opened.
		/// </summary>
		public ISession NHibernateSession {
			get { return sessionWrapper.OpenSession(); }
		}

		/// <summary>
		/// Returns the underlying <see cref="NHSessionWrapper"/> used to handle nhibernate session
		/// </summary>
		public NHSessionWrapper NHSessionWraper {
			get { return sessionWrapper; }
		}

		/// <summary>
		/// Cleans the NHContext contents.
		/// </summary>
		public abstract void ClearContext();

		/// <summary>
		/// Implementation of ToString
		/// </summary>
		/// <returns></returns>
		public override string ToString() {
			string returnVal = string.Empty;
			string sessionWrapperValue = "None";
			if (sessionWrapper != null) {
				sessionWrapperValue = sessionWrapper.ToString();

				returnVal += "SessionWrapper: " + sessionWrapperValue + "; SessionWrapper Transaction: " + sessionWrapper.Transaction.ToString() + "Transaction Was commited:" + sessionWrapper.Transaction.WasCommitted.ToString();
			} else {
				returnVal += "SessionWrapper: " + sessionWrapperValue;
			}

			return returnVal;
		}

	}
}