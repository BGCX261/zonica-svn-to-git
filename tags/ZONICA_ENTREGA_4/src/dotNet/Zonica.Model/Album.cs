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

using System;
using Iesi.Collections;
using Zonica.Model.BaseClasses;

#endregion Usings

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
		private ISet temasMusicales = new HashedSet();

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Album() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="Album">Album</see>.
		/// </summary>
		/// <param name="nombreAlbum">el nombre del <see cref="Album">Album</see></param>
		public Album(string nombreAlbum) : this() {
			this.Nombre = nombreAlbum;
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
		public ISet TemasMusicales {
			get { return temasMusicales; }
			set { temasMusicales = value; }
		}

		#endregion Propiedades

		/// <summary>
		/// Busca entre los temas del álbum.
		/// </summary>
		/// <param name="nombreTemaMusical">el nombre del <see cref="TemaMusical">TemaMusical</see> a buscar</param>
		/// <returns>el <see cref="TemaMusical">TemaMusical</see> buscado o <code>null</code> si no se encontró nada</returns>
		public TemaMusical BuscarTemaMusical(string nombreTemaMusical) {
			TemaMusical temaMusical = null;
			foreach (TemaMusical tm in this.TemasMusicales) {
				if (String.Equals(nombreTemaMusical, tm.Nombre)) {
					temaMusical = tm;
					break;
				}
			}

			return temaMusical;
		}
	}
}