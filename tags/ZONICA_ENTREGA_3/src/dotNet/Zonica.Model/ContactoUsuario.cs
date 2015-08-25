#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

#endregion Copyright

#region Usings

using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Contacto de un usuario en el sistema Zónica.
	/// </summary>
	public class ContactoUsuario : EntidadBaseNombrada {
		/// <summary>
		/// El <see cref="TipoContacto">TipoContacto</see> de este <see cref="ContactoUsuario">ContactoUsuario</see>.
		/// </summary>
		private TipoContacto tipoContacto;

		/// <summary>
		/// El <see cref="Usuario">Usuario</see> de este <see cref="ContactoUsuario">ContactoUsuario</see>.
		/// </summary>
		private Usuario usuario;

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public ContactoUsuario() : base() {
			// Nothing to do.
		}

		/// <summary>
		/// Obtiene una instancia de <see cref="ContactoUsuario">ContactoUsuario</see>.
		/// </summary>
		/// <param name="nombre">El <c>nombre</c> de este <see cref="ContactoUsuario">ContactoUsuario</see></param>
		/// <param name="Usuario">El <see cref="Usuario">Usuario</see> de este <see cref="ContactoUsuario">ContactoUsuario</see></param>
		/// <param name="tipoContacto">El <see cref="TipoContacto">TipoContacto</see> de este <see cref="ContactoUsuario">ContactoUsuario</see></param>
		public ContactoUsuario(TipoContacto tipoContacto, Usuario Usuario, string nombre) : base(nombre) {
			this.tipoContacto = tipoContacto;
			this.Usuario = Usuario;
		}

		#endregion Constructores

		/// <summary>
		/// El <see cref="TipoContacto">TipoContacto</see> de este <see cref="ContactoUsuario">ContactoUsuario</see>.
		/// </summary>
		public TipoContacto TipoContacto {
			get { return this.tipoContacto; }
			set { this.tipoContacto = value; }
		}

		/// <summary>
		/// El <see cref="Usuario">Usuario</see> de este <see cref="ContactoUsuario">ContactoUsuario</see>.
		/// </summary>
		public Usuario Usuario {
			get { return this.usuario; }
			set { this.usuario = value; }
		}
	}
}