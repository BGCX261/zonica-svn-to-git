using System;

namespace Zonica.Framework.Web.UI
{
	/// <summary>
	/// Clase que sirve como diccionario para los valores a asignar en el diccionario de sesión <see cref="System.Web.UI.Page.Session"/>.
	/// </summary>
	public abstract class SessionEntries {
		/// <summary>
		/// Clave bajo la cual se guarda el user name del usuario.
		/// </summary>
		public const string UserName = "UserName";
		public const string UserID = "UserID";
	}
}
