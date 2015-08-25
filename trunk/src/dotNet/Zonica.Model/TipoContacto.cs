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
	/// Representa a un tipo de contacto a un usuario en el Sistema Zónica.
	/// </summary>
	public class TipoContacto : EntidadBaseNombrada {
		/// <summary>
		/// Nombre del archivo ícono del <see cref="TipoContacto">TipoContacto</see>.
		/// </summary>
		private string icono;

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public TipoContacto() : base() {
			// Nothing to do.
		}

		/// <summary>
		/// Obtiene una instancia de <see cref="TipoContacto">TipoContacto</see>.
		/// </summary>
		/// <param name="nombre">El <c>nombre</c> de este <see cref="TipoContacto">TipoContacto</see></param>
		/// <param name="icono">El <c>ícono</c> de este <see cref="TipoContacto">TipoContacto</see></param>
		public TipoContacto(string nombre, string icono) : base(nombre) {
			this.Nombre = nombre;
			this.icono = icono;
		}

		#endregion Constructores

		/// <summary>
		/// Nombre del archivo ícono del <see cref="TipoContacto">TipoContacto</see>.
		/// </summary>
		public string Icono {
			get { return this.icono; }
			set { this.icono = value; }
		}
	}
}