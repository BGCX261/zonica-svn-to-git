/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>


using System;
using System.Collections;
using Zonica.Interfaces.Daos;
using Zonica.Model;

namespace Zonica.DAO {
	public class MusicaDao : Dao, IMusicaDao {
		/// <summary>
		/// Contructor default.
		/// </summary>
		public MusicaDao() : base() {
			// Nothing to do
		}

		/// <see cref="Dao.MainType" />
		/// <summary>
		/// El <code>Type</code> principal de este <code>Dao</code> es <code>Artista</code>.
		/// </summary>
		protected override Type MainType {
			get { return typeof (Artista); }
		}

		/// 
		/// <param name="idTemaMusical"></param>
		public TemaMusical RetrieveTemaMusical(int idTemaMusical) {
			return null;
		}

		/// 
		/// <param name="temaMusical"></param>
		public void SaveOrUpdateTemaMusical(TemaMusical temaMusical) {}

		/// 
		/// <param name="temaMusical"></param>
		public void DeleteTemaMusical(TemaMusical temaMusical) {}

		/// 
		/// <param name="artista"></param>
		public IList RetrieveTemasMusicalesByArtista(Artista artista) {
			return null;
		}

		/// 
		/// <param name="idArtista"></param>
		public Artista RetrieveArtista(int idArtista) {
			return null;
		}

		/// 
		/// <param name="artista"></param>
		public void SaveOrUpdateArtista(Artista artista) {}

		/// 
		/// <param name="artista"></param>
		public void DeleteArtista(Artista artista) {}

		public IList RetrieveAllArtistas() {
			return null;
		}

		/// 
		/// <param name="idEstiloMusical"></param>
		public EstiloMusical RetrieveEstiloMusical(int idEstiloMusical) {
			return null;
		}

		/// 
		/// <param name="estiloMusical"></param>
		public void DeleteEstiloMusical(EstiloMusical estiloMusical) {}

		/// 
		/// <param name="estiloMusical"></param>
		public void SaveOrUpdateEstiloMusical(EstiloMusical estiloMusical) {}

		/// 
		/// <param name="album"></param>
		public void SaveOrUpdateAlbum(Album album) {}

		/// 
		/// <param name="album"></param>
		public void DeleteAlbum(Album album) {}

		/// 
		/// <param name="idAlbum"></param>
		public Album RetrieveAlbum(int idAlbum) {
			return null;
		}

		/// 
		/// <param name="artista"></param>
		public IList RetrieveAlbumsByArtista(Artista artista) {
			return null;
		}

		/// 
		/// <param name="estiloMusical"></param>
		public IList RetrieveArtistasByEstiloMusical(EstiloMusical estiloMusical) {
			return null;
		}

		/// 
		/// <param name="templateArtista"></param>
		public IList BuscarArtistas(Artista templateArtista) {
			return null;
		}

	}

}