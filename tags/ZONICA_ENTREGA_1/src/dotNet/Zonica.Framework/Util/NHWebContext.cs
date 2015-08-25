using System;
using System.Web;

namespace Zonica.Framework.Util {
	/// <summary>
	/// This class is a a helper to set up the nhibernate session context in a HTTPContext
	/// </summary>
	/// <remarks>
	/// Use this class to set the nhibernate session in a way that is safe to use in a HTTPModule/ASP.NET 
	/// scenario
	/// </remarks>
	public class NHWebContext : NHContext {
		/// <summary>
		/// Return the curren NHContext. If none exists it creates one
		/// </summary>
		new public static NHContext Current {
			get { return GetNHContext(); }
		}

		/// <summary>
		/// Gets the context in the thread
		/// </summary>
		/// <returns>the NHContext</returns>
		protected static NHContext GetNHContext() {
			NHContext context = HttpContext.Current.Items[NH_CONTEXT_CALL_CONTEXT_KEY] as NHContext;

			string contextString = "null";
			if (context != null) {
				contextString = context.ToString();
			}

			log.Debug("NHWebContext value:" + contextString);
			if (context == null) {
				log.Debug("No context found, creating a new one on thread " + AppDomain.GetCurrentThreadId().ToString());
				context = new NHWebContext();
				SetNHContext(context);
			} else {
				log.Debug("Context found on thread " + AppDomain.GetCurrentThreadId().ToString());
			}

			return context;
		}

		/// <summary>
		/// Sets the NHcontext
		/// </summary>
		/// <param name="context">the context</param>
		protected static void SetNHContext(NHContext context) {
			log.Debug("Setting up NHWebContext into CallContext");
			if (HttpContext.Current.Items[NH_CONTEXT_CALL_CONTEXT_KEY] == null) {
				log.Debug("NHWebContext was null. Adding context");
				//in strange cases the key is set but the value is null 
				if (HttpContext.Current.Items.Contains(NH_CONTEXT_CALL_CONTEXT_KEY) && HttpContext.Current.Items[NH_CONTEXT_CALL_CONTEXT_KEY] == null) {
					log.Debug("NHWebContext was null but key was found in context");
					HttpContext.Current.Items[NH_CONTEXT_CALL_CONTEXT_KEY] = context;
				}
				HttpContext.Current.Items.Add(NH_CONTEXT_CALL_CONTEXT_KEY, context);
			} else {
				log.Debug("NHWebContext was not null. Replacing older context");
				HttpContext.Current.Items[NH_CONTEXT_CALL_CONTEXT_KEY] = context;
			}
		}

		/// <summary>
		/// Cleans the context.
		/// </summary>
		public override void ClearContext() {
			log.Debug("Clearing up NHWebContext");
			SetNHContext(null);
		}
	}
}