using log4net;
using Spring.Context;

namespace Zonica.Framework {

	/// <summary>
	/// Contexto de la aplicación Zónica.
	/// </summary>
	public class ApplicationContext {

		private static readonly ILog log = LogManager.GetLogger(typeof (ApplicationContext));
		
		/// <summary>
		/// Guarda la instancia singleton del contexto.
		/// </summary>
		private static ApplicationContext instance;

		private Spring.Context.IApplicationContext springApplicationContext;

		/// <summary>
		/// Obtiene/setea el SpringApplicationContext.
		/// </summary>
		public IApplicationContext SpringApplicationContext {
			get { return springApplicationContext; }
			set { this.springApplicationContext = value; }
		}

		/// <summary>
		/// Constructor default.
		/// </summary>
		private ApplicationContext() {
		}

		/// <summary>
		/// Obtiene la única instancia del contexto.
		/// </summary>
		/// <returns>La instancia del contexto</returns>
		public static ApplicationContext getInstance() {
			if (ApplicationContext.instance == null) {
				log.Debug("Creando un nuevo ApplicationContext...");
				ApplicationContext.instance = new ApplicationContext();
			}

			return instance;
		}
	}
}