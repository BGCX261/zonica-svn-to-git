/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

using System.Collections;
using Zonica.Model.BaseClasses;

namespace Zonica.Model {
	/// <summary>
	/// Representa a una Provincia en el sistema Zónica.
	/// </summary>
	public class Provincia : EntidadBaseNombrada {
		/// <summary>
		/// Referencia al <see cref="Pais">Pais</see>.
		/// </summary>
		private Pais pais;

		/// <summary>
		/// Colección de <see cref="Ciudad">Ciudad</see>es que pertenecen a esta <see cref="Provincia">Provincia</see>.
		/// </summary>
		private ICollection ciudades = new ArrayList();

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Provincia() : base() {}

		/// <summary>
		/// Obtiene/setea el <see cref="Pais">Pais</see> de esta <see cref="Provincia">Provincia</see>.
		/// </summary>
		public Pais Pais {
			get { return pais; }
			set { pais = value; }
		}

		/// <summary>
		/// Colección de <see cref="Provincia">Provincia</see>s que pertenecen a este <see cref="Pais">Pais</see>.
		/// </summary>
		public ICollection Ciudades {
			get { return ciudades; }
			set { ciudades = value; }
		}
	}
}