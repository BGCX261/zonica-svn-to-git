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
	/// Representa a un Artista en el sistema Zónica.
	/// </summary>
	public class Artista : EntidadBaseNombrada {
		#region Campos privados

		/// <summary>
		/// Referencia a los <see cref="EstiloMusical">EstiloMusical</see>es de este Artista
		/// </summary>
		private ISet estilosMusicales = new HashedSet();

		/// <summary>
		/// Referencia a los <see cref="Album">Album</see>es de este Artista
		/// </summary>
		private ISet albumes = new HashedSet();

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Artista() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="Artista">Artista</see>.
		/// </summary>
		/// <param name="nombreArtista">el nombre del <see cref="Artista">Artista</see></param>
		public Artista(string nombreArtista) : this() {
			this.Nombre = nombreArtista;
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Referencia a los <see cref="EstiloMusical">EstiloMusical</see>es de este Artista
		/// </summary>
		public ISet EstilosMusicales {
			get { return estilosMusicales; }
			set { estilosMusicales = value; }
		}

		/// <summary>
		/// Referencia a los <see cref="Album">Album</see>es de este Artista
		/// </summary>
		public ISet Albumes {
			get { return albumes; }
			set { albumes = value; }
		}

		#endregion Propiedades

		/// <summary>
		/// Busca entre los álbumes del artista.
		/// </summary>
		/// <param name="nombreAlbum">el nombre del <see cref="Album">Album</see> a buscar</param>
		/// <returns>el <see cref="Album">Album</see> buscado o <code>null</code> si no se encontró nada</returns>
		public Album BuscarAlbum(string nombreAlbum) {
			Album album = null;
			foreach (Album a in this.Albumes) {
				if (String.Equals(nombreAlbum, a.Nombre)) {
					album = a;
					break;
				}
			}

			return album;
		}
	}
}