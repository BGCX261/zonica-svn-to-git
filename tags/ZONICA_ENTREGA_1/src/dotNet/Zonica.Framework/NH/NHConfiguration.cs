using log4net;
using NHibernate.Cfg;

namespace Zonica.Framework.NH {
	/// <summary>
	/// Descripción breve de NHConfiguration.
	/// </summary>
	public class NHConfiguration : Configuration {

		private static readonly ILog log = LogManager.GetLogger(typeof (NHConfiguration));

		/// <summary>
		/// Constructor default.
		/// </summary>
		public NHConfiguration() : base() {}

		/// <summary>
		/// Configura el contexto de Hibernate.
		/// </summary>
		/// <param name="resource">El recurso a utilizar para la configuración</param>
		public NHConfiguration(string resource) : this() {
			log.DebugFormat("Configurando con: {0}", resource);
			base.Configure(resource);
		}
	}
}