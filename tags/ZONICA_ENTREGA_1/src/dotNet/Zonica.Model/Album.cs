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
	/// Representa a un Álbum en el sistema Zónica,
	/// </summary>
	public class Album : EntidadBaseNombrada {
		#region Campos privados

		/// <summary>
		/// Referencia al año de publicación de este Album
		/// </summary>
		private int anioPublicacion;

		/// <summary>
		/// Referencia al <see cref="Artista">Artista</see> de este Album
		/// </summary>
		private Artista artista;

		/// <summary>
		/// Referencia a los <see cref="TemaMusical">TemaMusical</see>es de este Album
		/// </summary>
		private ICollection temasMusicales = new ArrayList();

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Album() : base() {
			// Nothing to do
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea al Artista de este Album.
		/// </summary>
		public Artista Artista {
			get { return artista; }
			set { artista = value; }
		}

		/// <summary>
		/// Obtiene/setea el año de publicación de este Album.
		/// </summary>
		public int AnioPublicacion {
			get { return anioPublicacion; }
			set { anioPublicacion = value; }
		}

		/// <summary>
		/// Obtiene/setea los temas musicales de este Album.
		/// </summary>
		public ICollection TemasMusicales {
			get { return temasMusicales; }
			set { temasMusicales = value; }
		}

		#endregion Propiedades
	}
}