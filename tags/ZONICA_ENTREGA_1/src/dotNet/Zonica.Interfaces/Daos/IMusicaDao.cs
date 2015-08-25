/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>


using System.Collections;
using Zonica.Model;

namespace Zonica.Interfaces.Daos {
	public interface IMusicaDao : IDao {
		/// 
		/// <param name="idTemaMusical"></param>
		TemaMusical RetrieveTemaMusical(int idTemaMusical);

		/// 
		/// <param name="temaMusical"></param>
		void SaveOrUpdateTemaMusical(TemaMusical temaMusical);

		/// 
		/// <param name="temaMusical"></param>
		void DeleteTemaMusical(TemaMusical temaMusical);

		/// 
		/// <param name="artista"></param>
		IList RetrieveTemasMusicalesByArtista(Artista artista);

		/// 
		/// <param name="idArtista"></param>
		Artista RetrieveArtista(int idArtista);

		/// 
		/// <param name="artista"></param>
		void SaveOrUpdateArtista(Artista artista);

		/// 
		/// <param name="artista"></param>
		void DeleteArtista(Artista artista);

		IList RetrieveAllArtistas();

		/// 
		/// <param name="idEstiloMusical"></param>
		EstiloMusical RetrieveEstiloMusical(int idEstiloMusical);

		/// 
		/// <param name="estiloMusical"></param>
		void DeleteEstiloMusical(EstiloMusical estiloMusical);

		/// 
		/// <param name="estiloMusical"></param>
		void SaveOrUpdateEstiloMusical(EstiloMusical estiloMusical);

		/// 
		/// <param name="album"></param>
		void SaveOrUpdateAlbum(Album album);

		/// 
		/// <param name="album"></param>
		void DeleteAlbum(Album album);

		/// 
		/// <param name="idAlbum"></param>
		Album RetrieveAlbum(int idAlbum);

		/// 
		/// <param name="artista"></param>
		IList RetrieveAlbumsByArtista(Artista artista);

		/// 
		/// <param name="estiloMusical"></param>
		IList RetrieveArtistasByEstiloMusical(EstiloMusical estiloMusical);

		/// 
		/// <param name="templateArtista"></param>
		IList BuscarArtistas(Artista templateArtista);
	} //end IMusicaDao

} //end namespace Daos