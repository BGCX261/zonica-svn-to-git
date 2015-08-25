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

using System;
using Iesi.Collections;
using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Representa a un Perfil de Usuario en el sistema Zónica, contiene los datos
	/// personales y los gustos musicales del <see cref="Usuario">Usuario</see>.
	/// </summary>
	public class PerfilUsuario : EntidadBase {
		#region Campos privados

		/// <summary>
		/// Referencia al <see cref="Usuario">Usuario</see> de este PerfilUsuario.
		/// </summary>
		private Usuario usuario;

		/// <summary>
		/// Referencia a la <see cref="Ciudad">Ciudad</see> de este PerfilUsuario.
		/// </summary>
		private Ciudad ciudad;

		/// <summary>
		/// Referencia al nombre completo de este PerfilUsuario.
		/// </summary>
		private string nombreCompleto;

		/// <summary>
		/// Referencia al apodo de este PerfilUsuario.
		/// </summary>
		private string apodo;

		/// <summary>
		/// Referencia a la fecha de creación de este PerfilUsuario.
		/// </summary>
		private DateTime fechaCreacion;

		/// <summary>
		/// Referencia a la fecha de última actualización de este PerfilUsuario.
		/// </summary>
		private DateTime fechaActualizacion;

		/// <summary>
		/// Fecha de nacimiento del PerfilUsuario.
		/// </summary>
		private DateTime fechaNacimiento;

		/// <summary>
		/// Referencia a las <see cref="Escucha">Escucha</see>s de este Usuario.
		/// </summary>
		private ISet escuchas = new HashedSet();

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public PerfilUsuario() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Construye una instancia de <see cref="PerfilUsuario"/>.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario"/> de este <see cref="PerfilUsuario"/></param>
		public PerfilUsuario(Usuario usuario) : this() {
			this.usuario = usuario;
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea la fecha de creación de este PerfilUsuario.
		/// </summary>
		public DateTime FechaCreacion {
			get { return fechaCreacion; }
			set { fechaCreacion = value; }
		}

		/// <summary>
		/// Obtiene/setea la <see cref="Ciudad">Ciudad</see> de este PerfilUsuario.
		/// </summary>
		public Ciudad Ciudad {
			get { return ciudad; }
			set { ciudad = value; }
		}

		/// <summary>
		/// Obtiene/setea el nombre completo de este PerfilUsuario.
		/// </summary>
		public string NombreCompleto {
			get { return nombreCompleto; }
			set { nombreCompleto = value; }
		}

		/// <summary>
		/// Obtiene/setea la fecha de última actualización de este PerfilUsuario.
		/// </summary>
		public DateTime FechaActualizacion {
			get { return fechaActualizacion; }
			set { fechaActualizacion = value; }
		}

		/// <summary>
		/// Obtiene/setea la fecha de nacimiento del PerfilUsuario.
		/// </summary>
		public DateTime FechaNacimiento {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		/// <summary>
		/// Obtiene/setea las escuchas de este PerfilUsuario.
		/// </summary>
		public ISet Escuchas {
			get { return escuchas; }
			set { escuchas = value; }
		}

		/// <summary>
		/// Referencia al apodo de este PerfilUsuario.
		/// </summary>
		public string Apodo {
			get { return apodo; }
			set { apodo = value; }
		}

		/// <summary>
		/// Referencia al <see cref="Usuario">Usuario</see> de este PerfilUsuario.
		/// </summary>
		public Usuario Usuario {
			get { return usuario; }
			set { usuario = value; }
		}

		#endregion Propiedades
	}
}