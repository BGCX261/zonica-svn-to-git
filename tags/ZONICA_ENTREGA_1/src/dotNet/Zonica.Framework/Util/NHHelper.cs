using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using log4net;
using NHibernate;
using Zonica.Framework.NH;

namespace Zonica.Framework.Util {
	/// <summary>
	/// Helper class for handling nhibernate related stuff with threads.
	/// </summary>
	public class NHHelper {
		private static readonly ILog log = LogManager.GetLogger(typeof (NHHelper));

		/// <summary>
		/// Builds an NHSessionWrapper and NHContext objects and associates them
		/// with the current thread.
		/// This method will also start an nhibernate transaction
		/// </summary>
		/// <remarks>
		/// The nhibernate configuration will be read from the current assembly (Hexacta.Framework.NH.Util)
		/// </remarks>
		public static void PrepareNHSessionWithThread(NHContext context) {
			try {
				NHSessionWrapper wrapper = context.NHSessionWraper;

				wrapper.OpenSession();
				//start the NH transaction
				wrapper.BeginTransaction();
			} catch (Exception) {
				log.Fatal("add error message"); //TODO: Add error message
				throw;
			}
		}

		/// <summary>
		/// Releases all nhibernate resources allocated to the current thread.
		/// It will also commit any started transactions and close the connection as necesary
		/// </summary>
		/// <param name="context">the context to use.</param>
		/// <param name="clearContex">wheather to realse the nhibernate context. 
		/// If a thread is going to be reused leave this option as false
		/// </param>
		public static void ReleaseNHSessionFromThread(NHContext context, bool clearContex) {
			log.Debug("Method:" + "ReleaseNHSessionFromThread");
			NHSessionWrapper wrapper = context.NHSessionWraper;

			object threadId = CallContext.GetData("threadID");
			if (threadId != null) {
				log.Debug(threadId.ToString());
			} else {
				log.Debug("No thread id found on CallContext");
			}
			log.Debug("Current ThreadID=" + AppDomain.GetCurrentThreadId().ToString());

			if (wrapper != null) {
				try {
					log.Debug("Try: Checking seesion and transaction for commit");
					if (!wrapper.IsSessionNull) {
						if (!wrapper.Transaction.WasCommitted) {
							log.Debug("Transaction not commited; about to commit");
							wrapper.CommitTransaction();
						}
					}
				} catch (Exception ex) {
					//log.Fatal(SR.UnrecoverableNHibernateCommitException, ex);
					try {
						log.Debug("Try: about to roll back transaction");
						wrapper.RollbackTransaction();
					} catch (HibernateException hEx) {
						//log.Fatal(SR.UnrecoverableNHibernateRollbackException, hEx); 
						throw;
					}
					throw;
				} finally {
					try {
						if (!wrapper.IsSessionNull) {
							log.Debug("Try: about to close session");
							wrapper.CloseSession();
						}
					} catch {
						log.Fatal("Error closing session"); //TODO: Add error message
						throw;
					}
					SyncContext.Current.ReleaseMonitored();
					//ApplicationContext.Current.Release();
				}
			}

			if (clearContex) {
				log.Debug("Clearing context...");
				context.ClearContext();
				SyncContext.Current.ClearContext();
				//ApplicationContext.Current.ClearContext();
			}
		}

		/// <summary>
		/// Releases all nhibernate resources allocated to the current thread when 
		/// an exception has occured. 
		/// This method is similar to ReleaseNHSessionFromThread except that it will
		/// not try to commit the transaction
		/// </summary>
		/// <param name="context">the context to use.</param>
		/// <param name="clearContex">wheather to realse the nhibernate context. 
		/// If a thread is going to be reused leave this option as false
		/// </param>
		public static void ReleaseNHSessionFromThreadException(NHContext context, bool clearContex) {
			log.Debug("Method:" + "ReleaseNHSessionFromThreadException");

			NHSessionWrapper wrapper = context.NHSessionWraper;

			if (wrapper != null && !wrapper.Transaction.WasRolledBack) {
				try {
					wrapper.RollbackTransaction();
				} catch (HibernateException hEx) {
					//log.Fatal(SR.UnrecoverableNHibernateCommitException, hEx);
					throw hEx;
				} finally {
					try {
						if (!wrapper.IsSessionNull) {
							wrapper.CloseSession();
						}
					} catch {
						//TODO: log exception
						throw;
					}

					SyncContext.Current.ReleaseMonitored();
					//ApplicationContext.Current.Release();
				}
			}

			if (clearContex) {
				context.ClearContext();
				SyncContext.Current.ClearContext();
				//ApplicationContext.Current.ClearContext();
			}
		}

		/// <summary>
		/// This closes commits the current transaciton and prepares a new one with
		/// ReadUncomitted isolation level.
		/// Use this method while performing reports operations
		/// </summary>
		public static void PrepareTransctionForReadUncomiited() {
			NHContext.Current.NHSessionWraper.SessionFlushMode = FlushMode.Never;
			NHContext.Current.NHSessionWraper.Transaction.Commit();
			NHContext.Current.NHSessionWraper.BeginTransaction(IsolationLevel.ReadUncommitted);
		}
	}
}