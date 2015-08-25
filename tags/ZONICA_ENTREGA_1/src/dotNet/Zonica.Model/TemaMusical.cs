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
	/// Representa a un Tema Musical en el sistema Z�nica,
	/// </summary>
	public class TemaMusical : EntidadBaseNombrada {
		#region Campos privados

		/// <summary>
		/// Referencia al n�mero de orden de este tema musical
		/// </summary>
		private short orden;

		/// <summary>
		/// Referencia al �lbum de este tema musical
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

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea el n�mero de orden de este tema musical.
		/// </summary>
		public short Orden {
			get { return orden; }
			set { orden = value; }
		}

		/// <summary>
		/// Obtiene/setea el �lbum de este tema musical.
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