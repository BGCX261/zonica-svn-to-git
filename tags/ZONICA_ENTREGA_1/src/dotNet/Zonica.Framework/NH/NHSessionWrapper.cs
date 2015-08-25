/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

using System;
using System.Collections;
using System.Data;
using log4net;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Type;

namespace Zonica.Framework.NH {
	/// <summary>
	/// Wrapea y simplifica la interfaz de un objeto <see cref="ISession"/>.
	/// </summary>
	[Serializable]
	public class NHSessionWrapper {
		/// <summary>
		/// Logger default.
		/// </summary>
		private static readonly ILog log = LogManager.GetLogger(typeof (NHSessionWrapper));

		/// <summary>
		/// El <see cref="ISessionFactory"/>.
		/// </summary>
		private ISessionFactory sessionFactory;

		/// <summary>
		/// El <see cref="ITransaction"/>.
		/// </summary>
		private ITransaction transaction;

		/// <summary>
		/// El <see cref="ISession"/>.
		/// </summary>
		private ISession session;

		/// <summary>
		/// La <see cref="Configuration"/>.
		/// </summary>
		private Configuration configuration;

		/// <summary>
		/// El <see cref="FlushMode"/>.
		/// </summary>
		private FlushMode flushMode;

		/// <summary>
		/// Constructor default.
		/// </summary>
		public NHSessionWrapper() {
			log.Debug("Construyendo NHSessionWrapper...");

			this.session = null;
			this.flushMode = FlushMode.Auto;
		}

		/// <summary>
		/// Construye una instancia de este <see cref="NHSessionWrapper"/>.
		/// </summary>
		/// <param name="config">La configuración de NHibernate a utilizar</param>
		public NHSessionWrapper(Configuration config) : this() {
			this.configuration = config;
			this.sessionFactory = this.configuration.BuildSessionFactory();
		}

		/// <summary>
		/// Abre una <see cref="ISession"/> de NHibernate.
		/// </summary>
		public ISession OpenSession() {
			if ((this.session == null) || (!this.session.IsOpen)) {
				log.Debug("Abriendo una ISession de NHibernate...");
				session = this.sessionFactory.OpenSession();
				session.FlushMode = this.flushMode;

			}
			return session;
		}

		/// <summary>
		/// Setea el <see cref="FlushMode"/> para utilizar en la <see cref="ISession"/> de NHibernate.
		/// </summary>
		public FlushMode SessionFlushMode {
			get { return this.flushMode; }
			set {
				log.DebugFormat("Seteando FlushMode: {0}", flushMode);
				this.flushMode = value;
			}
		}

		/// <summary>
		/// Cierra la <see cref="ISession"/> de NHibernate.
		/// </summary>
		public void CloseSession() {
			if (this.session.IsOpen) {
				log.Debug("Cerrando ISession...");
				this.session.Close();
			}
		}

		/// <summary>
		/// Ejecuta un flush en la <see cref="ISession"/> de NHibernate.
		/// </summary>
		public void FlushSession() {
			log.Debug("Realizando Flush...");
			this.session.Flush();
		}

		/// <summary>
		/// Ejecuta un flush y cierra la <see cref="ISession"/> de NHibernate.
		/// </summary>
		public void FlushAndCloseSession() {
			this.FlushSession();
			this.CloseSession();
		}

		/// <summary>
		/// Desconecta la <see cref="ISession"/> de NHibernate.
		/// </summary>
		public void DisconnectSession() {
			if (this.session.IsConnected) {
				log.Debug("Desconectando la ISession...");
				this.session.Disconnect();
			}
		}

		/// <summary>
		/// Verifica si la <see cref="ISession"/> es null.
		/// </summary>
		public bool IsSessionNull {
			get { return session == null; }
		}

		/// <summary>
		/// Inicia una nueva <see cref="ITransaction"/> de NHibernate.
		/// </summary>
		/// <returns>La <see cref="ITransaction"/> creada</returns>
		public ITransaction BeginTransaction() {
			log.Debug("Comenzando una nueva Transacción...");
			this.transaction = this.session.BeginTransaction();
			return this.transaction;
		}

		/// <summary>
		/// Inicia una nueva <see cref="ITransaction"/> de NHibernate con un determinado <see cref="IsolationLevel"/>.
		/// </summary>
		/// <param name="isolationLevel">El <see cref="IsolationLevel"/> definido para la transacción</param>
		/// <returns>La <see cref="ITransaction"/> creada</returns>
		public ITransaction BeginTransaction(IsolationLevel isolationLevel) {
			log.DebugFormat("Comenzando una nueva Transacción con IsolationLevel {0}...", isolationLevel);
			this.transaction = this.session.BeginTransaction(isolationLevel);
			return this.transaction;
		}

		/// <summary>
		/// Commitea la <see cref="ITransaction"/> actual.
		/// </summary>
		public void CommitTransaction() {
			if (this.session != null && this.transaction != null) {
				log.Debug("Commiteando la transacción...");
				this.transaction.Commit();
			}
		}

		/// <summary>
		/// Realiza un rollback en la <see cref="ITransaction"/> actual. 
		/// </summary>
		public void RollbackTransaction() {
			if (this.session != null && this.transaction != null) {
				log.Debug("Rollbackeando la transacción...");
				this.transaction.Rollback();
			}
		}

		/// <summary>
		/// Retorna la <see cref="Configuration"/> actual.
		/// </summary>
		public Configuration CurrentConfig {
			get { return this.configuration; }
		}

		/// <summary>
		/// Retorna la <see cref="ITransaction"/> actual.
		/// </summary>
		public ITransaction Transaction {
			get { return this.transaction; }
		}

		/// <see cref="ISession" />
		public IList Find(string query) {
			return this.OpenSession().Find(query);
		}
	}
}