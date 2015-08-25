using System;
using System.Runtime.Serialization;
using Zonica.Exceptions.BaseClasses;

namespace Zonica.Exceptions {
	/// <summary>
	/// Excepci�n lanzada cuando falla la autenticaci�n de usuario.
	/// </summary>
	public class LoginFailedException : ZonicaBaseException {

		private static readonly string MESSAGE_TEMPLATE = "No se pudo autenticar en Z�nica con las credenciales {0} y {1}.";

		/// <see cref="ZonicaBaseException" />
		public LoginFailedException(string nombreUsuario, string password) : base(string.Format(MESSAGE_TEMPLATE, nombreUsuario, password)) {}
	}
}