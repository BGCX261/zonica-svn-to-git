/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>

using System;
using System.Collections;
using Zonica.Model.BaseClasses;

namespace Zonica.Model {
	/// <summary>
	/// Representa a un Perfil de Usuario en el sistema Z�nica, contiene los datos
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
		/// Referencia a la fecha de creaci�n de este PerfilUsuario.
		/// </summary>
		private DateTime fechaCreacion;

		/// <summary>
		/// Referencia a la fecha de �ltima actualizaci�n de este PerfilUsuario.
		/// </summary>
		private DateTime fechaActualizacion;

		/// <summary>
		/// Fecha de nacimiento del PerfilUsuario.
		/// </summary>
		private DateTime fechaNacimiento;

		/// <summary>
		/// Referencia a las <see cref="Escucha">Escucha</see>s de este Usuario.
		/// </summary>
		private ICollection escuchas = new ArrayList();

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public PerfilUsuario() : base() {
			// Nothing to do
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea la fecha de creaci�n de este PerfilUsuario.
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
		/// Obtiene/setea la fecha de �ltima actualizaci�n de este PerfilUsuario.
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
		public ICollection Escuchas {
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