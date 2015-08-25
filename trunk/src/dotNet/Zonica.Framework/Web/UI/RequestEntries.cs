using System;

namespace Zonica.Framework.Web.UI
{
	/// <summary>
	/// Clase que sirve como diccionario para los valores a asignar en el diccionario <see cref="System.Web.HttpRequest.QueryString"/> de un <see cref="System.Web.UI.Page.Request"/>.
	/// </summary>
	public abstract class RequestEntries {
		/// <summary>
		/// Clave bajo la cual se guarda una página a la cual se debe redireccionar.
		/// </summary>
		public const string RedirectPage = "redirectPage";
	}
}
