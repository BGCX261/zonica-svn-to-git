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
	/// Representa a un Usuario en el sistema Zónica, con información de Login del
	/// mismo y los datos de su pefil.
	/// </summary>
	public class Usuario : EntidadBaseNombrada {
		#region Campos privados

		/// <summary>
		/// Referencia a la <see cref="Ciudad">Ciudad</see> de este Usuario.
		/// </summary>
		private Ciudad ciudad;

		/// <summary>
		/// Referencia al nombre completo de este Usuario.
		/// </summary>
		private string nombreCompleto;

		/// <summary>
		/// Referencia al apodo de este Usuario.
		/// </summary>
		private string apodo;

		/// <summary>
		/// Referencia a la fecha de creación de este Usuario.
		/// </summary>
		private DateTime fechaCreacion = DateTime.Now;

		/// <summary>
		/// Referencia a la fecha de última actualización de este Usuario.
		/// </summary>
		private DateTime fechaActualizacion = DateTime.Now;

		/// <summary>
		/// Fecha de nacimiento del Usuario.
		/// </summary>
		private DateTime fechaNacimiento = DateTime.Now;

		/// <summary>
		/// Referencia a las <see cref="Escucha">Escucha</see>s de este Usuario.
		/// </summary>
		private ISet escuchas = new HashedSet();

		/// <summary>
		/// Referencia a los <see cref="ContactoUsuario">ContactoUsuario</see>s de este <see cref="Usuario">Usuario</see>.
		/// </summary>
		private ISet contactos = new HashedSet();

		/// <summary>
		/// Referencia al Password de este Usuario
		/// </summary>
		private string password;

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Usuario() : base() {
			// Nothing to do
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea la fecha de creación de este Usuario.
		/// </summary>
		public DateTime FechaCreacion {
			get { return fechaCreacion; }
			set { fechaCreacion = value; }
		}

		/// <summary>
		/// Obtiene/setea la <see cref="Ciudad">Ciudad</see> de este Usuario.
		/// </summary>
		public Ciudad Ciudad {
			get { return ciudad; }
			set { ciudad = value; }
		}

		/// <summary>
		/// Obtiene/setea el nombre completo de este Usuario.
		/// </summary>
		public string NombreCompleto {
			get { return nombreCompleto; }
			set { nombreCompleto = value; }
		}

		/// <summary>
		/// Obtiene/setea la fecha de última actualización de este Usuario.
		/// </summary>
		public DateTime FechaActualizacion {
			get { return fechaActualizacion; }
			set { fechaActualizacion = value; }
		}

		/// <summary>
		/// Obtiene/setea la fecha de nacimiento del Usuario.
		/// </summary>
		public DateTime FechaNacimiento {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		/// <summary>
		/// Obtiene/setea las escuchas de este Usuario.
		/// </summary>
		public ISet Escuchas {
			get { return escuchas; }
			set { escuchas = value; }
		}

		/// <summary>
		/// Referencia al apodo de este Usuario.
		/// </summary>
		public string Apodo {
			get { return apodo; }
			set { apodo = value; }
		}

		/// <summary>
		/// Referencia a los <see cref="ContactoUsuario">ContactoUsuario</see>s de este <see cref="Usuario">Usuario</see>.
		/// </summary>
		public ISet Contactos {
			get { return contactos; }
			set { contactos = value; }
		}

		/// <summary>
		/// Obtiene/setea al Password de este Usuario.
		/// </summary>
		public string Password {
			get { return password; }
			set { password = value; }
		}

		#endregion Propiedades
	}
}