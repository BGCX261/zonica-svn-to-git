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
using Zonica.Interfaces.Daos;
using Zonica.Interfaces.Services;
using Zonica.Model;

#endregion Usings

namespace Zonica.Services {
	/// <see cref="IMusicaService"/>
	/// <see cref="Service"/>
	/// <seealso cref="TemaMusical"/>
	/// <seealso cref="Album"/>
	/// <seealso cref="Artista"/>
	public class MusicaService : Service, IMusicaService {
		#region Miembros privados

		/// <summary>
		/// El DAO de música
		/// </summary>
		private IMusicaDao musicaDao;

		#endregion Miembros privados

		#region Propiedades

		/// <summary>
		/// El DAO de música
		/// </summary>
		public IMusicaDao MusicaDao {
			set { musicaDao = value; }
		}

		#endregion Propiedades

		#region Contructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public MusicaService() : base() {
			// Nothing to do
		}

		#endregion Contructores

		#region TemaMusical

		/// <see cref="IMusicaService.RetrieveTemaMusical(int)"/>
		public TemaMusical RetrieveTemaMusical(int idTemaMusical) {
			return this.musicaDao.RetrieveTemaMusical(idTemaMusical);
		}

		/// <see cref="IMusicaService.SaveOrUpdateTemaMusical(TemaMusical)"/>
		public void SaveOrUpdateTemaMusical(TemaMusical temaMusical) {
			this.musicaDao.SaveOrUpdateTemaMusical(temaMusical);
		}

		/// <see cref="IMusicaService.DeleteTemaMusical(TemaMusical)"/>
		public void DeleteTemaMusical(TemaMusical temaMusical) {
			this.musicaDao.DeleteTemaMusical(temaMusical);
		}

		/// <see cref="IMusicaService.BuscarTemasMusicales(string)"/>
		public IList BuscarTemasMusicales(string nombreTemaMusical) {
			TemaMusical template = new TemaMusical(nombreTemaMusical);
			return musicaDao.BuscarTemasMusicales(template);
		}

		#endregion TemaMusical

		#region Artista

		/// <see cref="IMusicaService.RetrieveArtista(int)"/>
		public Artista RetrieveArtista(int idArtista) {
			return this.musicaDao.RetrieveArtista(idArtista);
		}

		/// <see cref="IMusicaService.SaveOrUpdateArtista(Artista)"/>
		public void SaveOrUpdateArtista(Artista artista) {
			this.musicaDao.SaveOrUpdateArtista(artista);
		}

		/// <see cref="IMusicaService.DeleteArtista(Artista)"/>
		public void DeleteArtista(Artista artista) {
			this.musicaDao.DeleteArtista(artista);
		}

		/// <see cref="IMusicaService.RetrieveAllArtistas()"/>
		public IList RetrieveAllArtistas() {
			return this.musicaDao.RetrieveAllArtistas();
		}

		/// <see cref="IMusicaService.BuscarArtistas(string)"/>
		public IList BuscarArtistas(string nombreArtista) {
			Artista template = new Artista(nombreArtista);
			return this.musicaDao.BuscarArtistas(template);
		}

		#endregion Artista

		#region EstiloMusical

		/// <see cref="IMusicaService.RetrieveEstiloMusical(int)"/>
		public EstiloMusical RetrieveEstiloMusical(int idEstiloMusical) {
			return this.musicaDao.RetrieveEstiloMusical(idEstiloMusical);
		}

		/// <see cref="IMusicaService.DeleteEstiloMusical(EstiloMusical)"/>
		public void DeleteEstiloMusical(EstiloMusical estiloMusical) {
			this.musicaDao.DeleteEstiloMusical(estiloMusical);
		}

		/// <see cref="IMusicaService.SaveOrUpdateEstiloMusical(EstiloMusical)"/>
		public void SaveOrUpdateEstiloMusical(EstiloMusical estiloMusical) {
			this.musicaDao.SaveOrUpdateEstiloMusical(estiloMusical);
		}

		#endregion EstiloMusical

		#region Album

		/// <see cref="IMusicaService.SaveOrUpdateAlbum(Album)"/>
		public void SaveOrUpdateAlbum(Album album) {
			this.musicaDao.SaveOrUpdateAlbum(album);
		}

		/// <see cref="IMusicaService.DeleteAlbum(Album)"/>
		public void DeleteAlbum(Album album) {
			this.musicaDao.DeleteAlbum(album);
		}

		/// <see cref="IMusicaService.RetrieveAlbum(int)"/>
		public Album RetrieveAlbum(int idAlbum) {
			return this.musicaDao.RetrieveAlbum(idAlbum);
		}

		#endregion Album

		/// <see cref="IMusicaService.RetrieveArtistasByEstiloMusical(EstiloMusical)"/>
		public IList RetrieveArtistasByEstiloMusical(EstiloMusical estiloMusical) {
			throw new NotImplementedException();
		}

		/// <see cref="IMusicaService.RetrieveTemasMusicalesByArtista(Artista)"/>
		public IList RetrieveTemasMusicalesByArtista(Artista artista) {
			throw new NotImplementedException();
		}

		/// <see cref="IMusicaService.GetCantidadEscuchas()"/>
		public int GetCantidadEscuchas() {
			return this.musicaDao.GetCantidadEscuchas();
		}

		/// <see cref="IMusicaService.GetArtistasSimilaresA(Artista)"/>
		public IList GetArtistasSimilaresA(Artista artista) {
			return this.musicaDao.GetArtistasSimilaresA(artista.Id);
		}
	}
}