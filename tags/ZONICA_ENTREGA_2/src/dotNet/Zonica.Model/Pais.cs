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
	/// Representa a un Pais en el sistema Z�nica.
	/// </summary>
	public class Pais : EntidadBaseNombrada {
		/// <summary>
		/// Colecci�n de <see cref="Provincia">Provincia</see>s que pertenecen a este <see cref="Pais">Pais</see>.
		/// </summary>
		private ICollection provincias = new ArrayList();

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Pais() : base() {}

		/// <summary>
		/// Colecci�n de <see cref="Provincia">Provincia</see>s que pertenecen a este <see cref="Pais">Pais</see>.
		/// </summary>
		public ICollection Provincias {
			get { return provincias; }
			set { provincias = value; }
		}
	}
}