/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>

using Zonica.Model.BaseClasses;

namespace Zonica.Model {
	/// <summary>
	/// Representa a una Ciudad en el sistema Z�nica.
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