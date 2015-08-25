using System.Runtime.Remoting.Messaging;

namespace Zonica.Framework.Util {
	/// <summary>
	/// This class is a a helper to set up the nhibernate session context in a thred
	/// </summary>
	/// <remarks>Do not use this class to set the nhibernate session using HTTPModule since
	/// an HTTPModule in not garanteed to be serviced by the same thread as the request.</remarks>
	public class NHThreadContext : NHContext {
		private const string NH_CONTEXT_CALL_THREAD_CONTEXT_KEY = "HtCt";

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
			NHContext context = CallContext.GetData(NH_CONTEXT_CALL_THREAD_CONTEXT_KEY) as NHContext;

			if (context == null) {
				context = new NHThreadContext();
				SetNHContext(context);
			}

			return context;
		}

		/// <summary>
		/// Sets the NHcontext
		/// </summary>
		/// <param name="context">the context</param>
		protected static void SetNHContext(NHContext context) {
			log.Debug("Setting up NHThreadContext into CallContext");
			CallContext.SetData(NH_CONTEXT_CALL_THREAD_CONTEXT_KEY, context);
		}

		/// <summary>
		/// Cleans the context.
		/// </summary>
		public override void ClearContext() {
			log.Debug("Clearing NHThreadContext from CallContext");
			CallContext.FreeNamedDataSlot(NH_CONTEXT_CALL_THREAD_CONTEXT_KEY);
		}
	}
}