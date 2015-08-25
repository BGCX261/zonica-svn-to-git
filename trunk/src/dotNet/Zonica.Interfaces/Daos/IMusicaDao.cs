#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>

#endregion Copyright

#region Usings

using System;
using System.Collections;

using Zonica.Model;

#endregion Usings

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

		IList BuscarTemasMusicales(TemaMusical template);

		/// <summary>
		/// Obtiene la cantidad total de escuchas realizadas en el sistema.
		/// </summary>
		/// <returns>la cantidad total de escuchas realizadas</returns>
		Int32 GetCantidadEscuchas();

		/// <summary>
		/// Obtiene una lista de <see cref="ItemRanking">ItemRanking</see> contiendo los artistas mas escuchados
		/// por aquellas personas que escuchan al <see cref="Artista">Artista</see> especificado por el <c>id</c>.
		/// </summary>
		/// <param name="id">el <c>id</c> del <see cref="Artista">Artista</see> del cual se quiere la informaci�n</param>
		/// <returns>una lista de <see cref="ItemRanking">ItemRanking</see></returns>
		IList GetArtistasSimilaresA(int id);
	}
}