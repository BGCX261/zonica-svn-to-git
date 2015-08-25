

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
	/// Entidad base para el sistema Zónica. Agrega a todos los que la extiendan la
	/// propiedad 'Id'.
	/// </summary>
	public abstract class EntidadBase {
		/// <summary>
		/// Id de la entidad
		/// </summary>
		private int id = -1;

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public EntidadBase() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="EntidadBase"/>.
		/// </summary>
		/// <param name="id">el <code>id</code> del <see cref="EntidadBase"/></param>
		public EntidadBase(int id) : this() {
			this.id = id;
		}

		#endregion Constructores

		/// <summary>
		/// Obtiene/setea el Id de esta entidad.
		/// </summary>
		public int Id {
			get { return id; }
			set { id = value; }
		}
	}
}