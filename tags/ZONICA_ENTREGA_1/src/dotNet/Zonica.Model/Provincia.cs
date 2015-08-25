/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>

using System.Collections;
using Zonica.Model.BaseClasses;

namespace Zonica.Model {
	/// <summary>
	/// Representa a una Provincia en el sistema Z�nica.
	/// </summary>
	public class Provincia : EntidadBaseNombrada {
		/// <summary>
		/// Referencia al <see cref="Pais">Pais</see>.
		/// </summary>
		private Pais pais;

		/// <summary>
		/// Colecci�n de <see cref="Ciudad">Ciudad</see>es que pertenecen a esta <see cref="Provincia">Provincia</see>.
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
		/// Colecci�n de <see cref="Provincia">Provincia</see>s que pertenecen a este <see cref="Pais">Pais</see>.
		/// </summary>
		public ICollection Ciudades {
			get { return ciudades; }
			set { ciudades = value; }
		}
	}
}