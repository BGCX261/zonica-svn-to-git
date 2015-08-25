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

using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Representa a un Tema Musical en el sistema Zónica,
	/// </summary>
	public class TemaMusical : EntidadBaseNombrada {
		#region Campos privados

		/// <summary>
		/// Referencia al Álbum de este tema musical
		/// </summary>
		private Album album;

		/// <summary>
		/// Referencia al Autor de este tema musical
		/// </summary>
		private Artista autor;

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public TemaMusical() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="TemaMusical">TemaMusical</see>.
		/// </summary>
		/// <param name="nombreTemaMusical">el nombre del <see cref="TemaMusical">TemaMusical</see></param>
		public TemaMusical(string nombreTemaMusical) : this() {
			this.Nombre = nombreTemaMusical;
		}

		/// <summary>
		/// Crea una instancia de <see cref="TemaMusical">TemaMusical</see>.
		/// </summary>
		/// <param name="id">el <code>id</code> del <see cref="TemaMusical">TemaMusical</see></param>
		/// <param name="nombreTemaMusical">el <code>nombre</code> del <see cref="TemaMusical">TemaMusical</see></param>
		public TemaMusical(int id, string nombreTemaMusical) : this(nombreTemaMusical) {
			this.Nombre = nombreTemaMusical;
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea el Álbum de este tema musical.
		/// </summary>
		public Album Album {
			get { return album; }
			set { album = value; }
		}

		/// <summary>
		/// Obtiene/setea al Autor de este tema musical.
		/// </summary>
		public Artista Autor {
			get { return autor; }
			set { autor = value; }
		}

		#endregion Propiedades
	}
}