using System.Web.UI;
using Zonica.Interfaces.Services;

/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>
namespace Zonica.Framework.Web.UI.BaseClasses {
	/// <summary>
	/// Página base de todas las páginas del sistema Zónica.
	/// </summary>
	public abstract class BasePage : Page {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public BasePage() {
			// Nothing to do
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="IEscuchaService">IEscuchaService</see>.
		/// </summary>
		/// <returns>el <see cref="IEscuchaService">IEscuchaService</see></returns>
		protected IEscuchaService GetEscuchaService() {
			return ZonicaWebContext.GetEscuchaService();
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="ILocalidadService">ILocalidadService</see>.
		/// </summary>
		/// <returns>el <see cref="ILocalidadService">ILocalidadService</see></returns>
		protected ILocalidadService GetLocalidadService() {
			return ZonicaWebContext.GetLocalidadService();
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="IMusicaService">IEscuchaService</see>.
		/// </summary>
		/// <returns>el <see cref="IMusicaService">IMusicaService</see></returns>
		protected IMusicaService GetMusicaService() {
			return ZonicaWebContext.GetMusicaService();
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="IUsuarioService">IUsuarioService</see>.
		/// </summary>
		/// <returns>el <see cref="IUsuarioService">IUsuarioService</see></returns>
		protected IUsuarioService GetUsuarioService() {
			return ZonicaWebContext.GetUsuarioService();
		}
	}
}