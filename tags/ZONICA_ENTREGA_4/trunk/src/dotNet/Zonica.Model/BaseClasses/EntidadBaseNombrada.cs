

#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

#endregion Copyright
namespace Zonica.Model.BaseClasses {
	/// <summary>
	/// Entidad base de todas las entidades con nombre. Otorga a los implementadores
	/// las propiedades 'Nombre' y 'Id'.
	/// </summary>
	public abstract class EntidadBaseNombrada : EntidadBase {
		/// <summary>
		/// Nombre de la Entidad
		/// </summary>
		private string nombre;

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public EntidadBaseNombrada() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="EntidadBaseNombrada"/>.
		/// </summary>
		/// <param name="nombre">el <code>nombre</code> del <see cref="EntidadBaseNombrada"/></param>
		public EntidadBaseNombrada(string nombre) : this() {
			this.nombre = nombre;
		}

		/// <summary>
		/// Crea una instancia de <see cref="EntidadBaseNombrada"/>.
		/// </summary>
		/// <param name="id">el <code>id</code> del <see cref="EntidadBaseNombrada"/></param>
		/// <param name="nombre">el <code>nombre</code> del <see cref="EntidadBaseNombrada"/></param>
		public EntidadBaseNombrada(int id, string nombre) : base(id) {
			this.nombre = nombre;
		}

		#endregion Constructores

		/// <summary>
		/// Nombre de la Entidad
		/// </summary>
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
	}
}