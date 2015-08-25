using System.Web.UI;
using Zonica.Interfaces.Services;

/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>
namespace Zonica.Framework.Web.UI.BaseClasses {
	/// <summary>
	/// P�gina base de todas las p�ginas del sistema Z�nica.
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

		protected IContactoService GetContactoService() {
			return ZonicaWebContext.GetContactoService();
		}
		/// <summary>
		/// Verifica que hay una sesi�n iniciada. Si no la hay, redirecciona a la pagina <b>SessionExpired</b>.
		/// </summary>
		protected void EnsureValidSession()	{
			if (!this.SessionIsValid()) {
				string redirPath = this.Request.FilePath.ToLower();
				string baseDir = this.Request.ApplicationPath.ToLower();
				if (redirPath.StartsWith(baseDir))
					redirPath = redirPath.Remove(0, baseDir.Length + 1);
				Response.Redirect(string.Format("SessionExpired.aspx?{0}={1}", RequestEntries.RedirectPage, redirPath));
			}
		}

		/// <summary>
		/// Obtiene un valor indicando si la sesi�n es v�lida o no.
		/// </summary>
		/// <returns><b>True</b> si la sesi�n es v�lida; si no, <b>False</b>.</returns>
		/// <remarks>
		/// Para verificar si la sesi�n es v�lida, se fija que haya un valor en 
		/// <see cref="Session"/> bajo la clave <see cref="SessionEntries.
		/// SessionUserIdEntry"/>.
		/// </remarks>
		public bool SessionIsValid () {
			return this.Session[SessionEntries.UserName] != null;
		}
	}
}
