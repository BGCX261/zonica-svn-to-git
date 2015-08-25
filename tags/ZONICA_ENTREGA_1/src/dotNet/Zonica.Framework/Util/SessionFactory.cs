// Created 


using System.Reflection;
using log4net;
using NHibernate;
using NHibernate.Cfg;

namespace Zonica.Framework.Util {
	/// <summary>
	/// The SessionFactory provides the NHibernate a singleton class for nhibernate configration
	/// </summary>
	public class SessionFactory {
		private static readonly ILog log = LogManager.GetLogger(typeof (SessionFactory));

		private static readonly SessionFactory sessionFactory = new SessionFactory();

		private Configuration cnfg;
		private ISessionFactory nhSessionFactory;

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected SessionFactory() {
			RegisterCoreClasses();
		}

		/// <summary>
		/// Gets the one instance of the SessionFactory. This is done with a singleton so we don't have
		/// to register mappings etc. with every request.
		/// </summary>
		/// <returns></returns>
		public static SessionFactory GetInstance() {
			return sessionFactory;
		}

		/// <summary>
		/// returns the current NHibernate ISessionFactory.
		/// </summary>
		public ISessionFactory NHibernateFactory {
			get { return this.nhSessionFactory; }
		}

		/// <summary>
		/// returns the current NHibernate Configuration.
		/// </summary>
		public Configuration NHibernateConfiguration {
			get { return this.cnfg; }
		}


		private void RegisterCoreClasses() {
			/* Decrypt some parameters */
			Configuration config = new Configuration();

			log.Debug("Reading nhibernate configuration file ");

			config.Configure(Assembly.GetExecutingAssembly(), "Zonica.Framework.NH.Util.hibernate.cfg.xml");

			this.cnfg = config;

			log.Debug("Constructing nhibernate session factory");
			this.nhSessionFactory = cnfg.BuildSessionFactory();
		}
	}
}