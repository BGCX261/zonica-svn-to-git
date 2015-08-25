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
using System.Collections;
using Zonica.Model;

#endregion Usings

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Interfaz del servicio que accede a elementos de música.
	/// <see cref="TemaMusical"/>
	/// <see cref="Artista"/>
	/// <see cref="EstiloMusical"/>
	/// <see cref="Album"/>
	/// <seealso cref="IService"/>
	/// </summary>
	public interface IMusicaService : IService {
		#region Métodos ABM de TemaMusical

		/// <summary>
		/// Obtiene el <see cref="TemaMusical">TemaMusical</see> identificado por el <code>idTemaMusical</code>.
		/// </summary>
		/// <param name="idTemaMusical">id del <see cref="TemaMusical">TemaMusical</see> buscado</param>
		/// <returns>el <see cref="TemaMusical">TemaMusical</see> buscado</returns>
		TemaMusical RetrieveTemaMusical(int idTemaMusical);

		/// <summary>
		/// Guarda el <see cref="TemaMusical">TemaMusical</see>.
		/// </summary>
		/// <param name="temaMusical">el <see cref="TemaMusical">TemaMusical</see> a guardar</param>
		void SaveOrUpdateTemaMusical(TemaMusical temaMusical);

		/// <summary>
		/// Elimina el <see cref="TemaMusical">TemaMusical</see>.
		/// </summary>
		/// <param name="temaMusical">el <see cref="TemaMusical">TemaMusical</see> a eliminar</param>
		void DeleteTemaMusical(TemaMusical temaMusical);

		/// <summary>
		/// Busca <see cref="TemaMusical">TemaMusical</see>es cuyos nombres sean como el especificado.
		/// </summary>
		/// <param name="nombreTemaMusical">el nombre de los temas musicales a buscar</param>
		/// <returns>una lista de <see cref="TemaMusical">TemaMusical</see>es</returns>
		IList BuscarTemasMusicales(String nombreTemaMusical);

		#endregion Métodos ABM de TemaMusical

		#region Métodos ABM de Artista

		/// <summary>
		/// Obtiene el <see cref="Artista">Artista</see> cuyo id es el especificado.
		/// </summary>
		/// <param name="idArtista">el id del <see cref="Artista">Artista</see> buscado</param>
		/// <returns>el <see cref="Artista">Artista</see> buscado</returns>
		Artista RetrieveArtista(int idArtista);

		/// <summary>
		/// Guarda el <see cref="Artista">Artista</see> especificado.
		/// </summary>
		/// <param name="artista">el <see cref="Artista">Artista</see> a guardar</param>
		void SaveOrUpdateArtista(Artista artista);

		/// <summary>
		/// Elimina el <see cref="Artista">Artista</see> especificado.
		/// </summary>
		/// <param name="artista">el <see cref="Artista">Artista</see> a eliminar</param>
		void DeleteArtista(Artista artista);

		/// <summary>
		/// Obtiene todos los <see cref="Artista">Artista</see>s del sistema.
		/// </summary>
		/// <returns>una lista con todos los <see cref="Artista">Artista</see>s</returns>
		IList RetrieveAllArtistas();

		/// <summary>
		/// Busca <see cref="Artista">Artista</see>s usando el nombre del artista.
		/// </summary>
		/// <param name="nombreArtista">el nombre del <see cref="Artista">Artista</see> a usar para la búsqueda</param>
		/// <returns>Una lista de <see cref="Artista">Artista</see>s que se matchean con el <code>nombreArtista</code></returns>
		IList BuscarArtistas(String nombreArtista);

		#endregion Métodos ABM de Artista

		#region Métodos ABM de EstiloMusical

		/// <summary>
		/// Obtiene el <see cref="EstiloMusical">EstiloMusical</see> cuyo id es el especificado.
		/// </summary>
		/// <param name="idEstiloMusical">el id del <see cref="EstiloMusical">EstiloMusical</see></param>
		/// <returns>el <see cref="EstiloMusical">EstiloMusical</see> buscado</returns>
		EstiloMusical RetrieveEstiloMusical(int idEstiloMusical);

		/// <summary>
		/// Elimina el <see cref="EstiloMusical">EstiloMusical</see>.
		/// </summary>
		/// <param name="estiloMusical">el <see cref="EstiloMusical">EstiloMusical</see> a eliminar</param>
		void DeleteEstiloMusical(EstiloMusical estiloMusical);

		/// <summary>
		/// Guarda el <see cref="EstiloMusical">EstiloMusical</see>.
		/// </summary>
		/// <param name="estiloMusical">el <see cref="EstiloMusical">EstiloMusical</see> a persistir</param>
		void SaveOrUpdateEstiloMusical(EstiloMusical estiloMusical);

		#endregion Métodos ABM de EstiloMusical

		#region Métodos ABM de Album
		/// <summary>
		/// Guarda el <see cref="Album">Album</see>.
		/// </summary>
		/// <param name="album">el <see cref="Album">Album</see>a guardar</param>
		void SaveOrUpdateAlbum(Album album);

		/// <summary>
		/// Elimina el <see cref="Album">Album</see> especificado.
		/// </summary>
		/// <param name="album">el <see cref="Album">Album</see> a eliminar</param>
		void DeleteAlbum(Album album);

		/// <summary>
		/// Obtiene un <see cref="Album">Album</see> cuyo id es el especificado.
		/// </summary>
		/// <param name="idAlbum"></param>
		/// <returns></returns>
		Album RetrieveAlbum(int idAlbum);

		#endregion Métodos ABM de Album

		/// <summary>
		/// Obtiene todos los <see cref="Artista">Artista</see>s relacionados al <see cref="EstiloMusical">EstiloMusical</see>.
		/// </summary>
		/// <param name="estiloMusical">el <see cref="EstiloMusical">EstiloMusical</see></param>
		/// <returns>una lista de <see cref="Artista">Artista</see>s</returns>
		IList RetrieveArtistasByEstiloMusical(EstiloMusical estiloMusical);

		/// <summary>
		/// Obtiene los <see cref="TemaMusical">TemaMusical</see>s del <see cref="Artista">Artista</see> especificado.
		/// </summary>
		/// <param name="artista">el <see cref="Artista">Artista</see></param>
		/// <returns>una lista de <see cref="TemaMusical">TemaMusical</see>s</returns>
		IList RetrieveTemasMusicalesByArtista(Artista artista);
	}
}