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
	/// Representa a una Ciudad en el sistema Zónica.
	/// </summary>
	public class Ciudad : EntidadBaseNombrada {
		/// <summary>
		/// Referencia a la <see cref="Provincia">Provincia</see> de la <see cref="Ciudad">Ciudad</see>.
		/// </summary>
		private Provincia provincia;

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Ciudad() : base() {}

		/// <summary>
		/// Obtiene/setea la <see cref="Provincia">Provincia</see> de la <see cref="Ciudad">Ciudad</see>.
		/// </summary>
		public Provincia Provincia {
			get { return provincia; }
			set { provincia = value; }
		}
	}
}