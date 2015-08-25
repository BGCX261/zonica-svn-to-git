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
	/// Representa a un Artista en el sistema Zónica.
	/// </summary>
	public class Artista : EntidadBaseNombrada {
		#region Campos privados

		/// <summary>
		/// Referencia a los <see cref="EstiloMusical">EstiloMusical</see>es de este Artista
		/// </summary>
		private ICollection estilosMusicales = new ArrayList();

		/// <summary>
		/// Referencia a los <see cref="Album">Album</see>es de este Artista
		/// </summary>
		private ICollection albumes = new ArrayList();

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Artista() : base() {
			// Nothing to do
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Referencia a los <see cref="EstiloMusical">EstiloMusical</see>es de este Artista
		/// </summary>
		public ICollection EstilosMusicales {
			get { return estilosMusicales; }
			set { estilosMusicales = value; }
		}

		/// <summary>
		/// Referencia a los <see cref="Album">Album</see>es de este Artista
		/// </summary>
		public ICollection Albumes {
			get { return albumes; }
			set { albumes = value; }
		}

		#endregion Propiedades
	}
}