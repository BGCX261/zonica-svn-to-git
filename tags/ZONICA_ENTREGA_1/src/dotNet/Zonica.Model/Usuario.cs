/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

using Zonica.Model.BaseClasses;

namespace Zonica.Model {
	/// <summary>
	/// Representa a un Usuario en el sistema Zónica, con información de Login del
	/// mismo.
	/// </summary>
	public class Usuario : EntidadBaseNombrada {
		/// <summary>
		/// Referencia a PerfilUsuario
		/// </summary>
		private PerfilUsuario perfilUsuario;

		/// <summary>
		/// Referencia al Password de este Usuario
		/// </summary>
		private string password;

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Usuario() : base() {}

		/// <summary>
		/// Obtiene/setea el PerfilUsuario de este Usuario.
		/// </summary>
		public PerfilUsuario PerfilUsuario {
			get { return perfilUsuario; }
			set { perfilUsuario = value; }
		}

		/// <summary>
		/// Obtiene/setea al Password de este Usuario.
		/// </summary>
		public string Password {
			get { return password; }
			set { password = value; }
		}
	}
}