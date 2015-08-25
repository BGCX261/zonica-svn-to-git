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

using System.Collections;
using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Representa a un Pais en el sistema Zónica.
	/// </summary>
	public class Pais : EntidadBaseNombrada {
		/// <summary>
		/// Colección de <see cref="Provincia">Provincia</see>s que pertenecen a este <see cref="Pais">Pais</see>.
		/// </summary>
		private ICollection provincias = new ArrayList();

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Pais() : base() {
			// Nothing to do.
		}

		/// <summary>
		/// Colección de <see cref="Provincia">Provincia</see>s que pertenecen a este <see cref="Pais">Pais</see>.
		/// </summary>
		public ICollection Provincias {
			get { return provincias; }
			set { provincias = value; }
		}
	}
}