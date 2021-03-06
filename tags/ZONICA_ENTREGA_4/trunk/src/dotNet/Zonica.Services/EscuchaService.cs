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

using Zonica.Framework.Util;
using Zonica.Interfaces.Daos;
using Zonica.Interfaces.Services;
using Zonica.Model;

#endregion Usings

namespace Zonica.Services {
	/// <see cref="IEscuchaService"/>
	/// <see cref="Service"/>
	public class EscuchaService : Service, IEscuchaService {
		#region Campos privados

		/// <summary>
		/// Dao de Escuchas
		/// </summary>
		private IEscuchaDao escuchaDao;

		/// <summary>
		/// Servicio de usuarios
		/// </summary>
		private IUsuarioService usuarioService;

		/// <summary>
		/// El Servicio de m�sica
		/// </summary>
		private IMusicaService musicaService;

		#endregion Campos privados

		#region Propiedades

		/// <summary>
		/// Dao de Escuchas
		/// </summary>
		public IEscuchaDao EscuchaDao {
			set { escuchaDao = value; }
		}

		/// <summary>
		/// Servicio de usuarios
		/// </summary>
		public IUsuarioService UsuarioService {
			set { usuarioService = value; }
		}

		/// <summary>
		/// El Servicio de m�sica
		/// </summary>
		public IMusicaService MusicaService {
			set { musicaService = value; }
		}

		#endregion Propiedades

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public EscuchaService() : base() {
			// Do nothing
		}

		#endregion Constructores

		#region M�todos P�blicos

		#region Artistas

		/// <see cref="IEscuchaService.RetrieveArtistasMasEscuchados()" />
		public IList RetrieveArtistasMasEscuchados() {
			return this.escuchaDao.RetrieveArtistasMasEscuchados();
		}

		/// <see cref="IEscuchaService.RetrieveArtistasMasEscuchados(Usuario)" />
		public IList RetrieveArtistasMasEscuchados(Usuario usuario) {
			return this.escuchaDao.RetrieveArtistasMasEscuchados(usuario);
		}

		#endregion Artistas

		#region �lbumes

		/// <see cref="IEscuchaService.RetrieveAlbumesMasEscuchados()" />
		public IList RetrieveAlbumesMasEscuchados() {
			return this.escuchaDao.RetrieveAlbumesMasEscuchados();
		}

		/// <see cref="IEscuchaService.RetrieveAlbumesMasEscuchados(Usuario)" />
		public IList RetrieveAlbumesMasEscuchados(Usuario usuario) {
			return this.escuchaDao.RetrieveAlbumesMasEscuchados(usuario);
		}

		/// <see cref="IEscuchaService.RetrieveTemasMusicalesMasEscuchados(Artista)" />
		public IList RetrieveAlbumesMasEscuchados(Artista artista) {
			return this.escuchaDao.RetrieveAlbumesMasEscuchados(artista);
		}

		#endregion �lbumes

		#region Temas Musicales

		/// <see cref="IEscuchaService.RetrieveTemasMusicalesMasEscuchados()" />
		public IList RetrieveTemasMusicalesMasEscuchados() {
			return this.escuchaDao.RetrieveTemasMusicalesMasEscuchados();
		}

		/// <see cref="IEscuchaService.RetrieveTemasMusicalesMasEscuchados(Usuario)" />
		public IList RetrieveTemasMusicalesMasEscuchados(Usuario usuario) {
			return this.escuchaDao.RetrieveTemasMusicalesMasEscuchados(usuario);
		}

		/// <see cref="IEscuchaService.RetrieveTemasMusicalesMasEscuchados(Artista)" />
		public IList RetrieveTemasMusicalesMasEscuchados(Artista artista) {
			return this.escuchaDao.RetrieveTemasMusicalesMasEscuchados(artista);
		}

		#endregion Temas Musicales

		/// <see cref="IEscuchaService.RetrieveAmigos(Usuario)" />
		public IList RetrieveAmigos(Usuario usuario) {
			return this.escuchaDao.RetrieveAmigos(usuario.Id);
		}

		#region Escuchas

		/// <see cref="IEscuchaService.SaveOrUpdateEscucha(Escucha)" />
		public void SaveOrUpdateEscucha(Escucha escucha) {
			this.escuchaDao.SaveOrUpdateEscucha(escucha);
		}

		/// <see cref="IEscuchaService.RegistrarEscucha(string, string, string, string, string, DateTime, short)" />
		public void RegistrarEscucha(string nombreUsuario, string password, string nombreArtista, string nombreAlbum, string nombreTemaMusical, DateTime inicio, short valoracion) {
			Validate.NotEmpty(nombreUsuario, "El nombre de Usuario debe ser especificado.");
			Validate.NotEmpty(password, "El password debe ser especificado.");
			Validate.NotEmpty(nombreArtista, "El nombre del Artista debe ser especificado.");
			Validate.NotEmpty(nombreAlbum, "El nombre del Album debe ser especificado.");
			Validate.NotEmpty(nombreTemaMusical, "El nombre del Tema Musical debe ser especificado.");

			// Primero autentico el usuario
			Usuario usuario = this.usuarioService.AutenticarUsuario(nombreUsuario, password);

			// Busco el Artista por nombre
			Artista artista;
			IList artistas = musicaService.BuscarArtistas(nombreArtista);
			if (artistas.Count == 0) {
				artista = new Artista(nombreArtista);
			} else {
				// Asumo los nombres de los artistas �nicos
				artista = (Artista) artistas[0];
			}

			// Busco el �lbum entre los �lbumes del artista
			Album album = artista.BuscarAlbum(nombreAlbum);
			if (album == null) {
				album = new Album(nombreAlbum);
				album.Artista = artista;

				artista.Albumes.Add(album);
			}

			// Busco el tema musical por nombre
			TemaMusical temaMusical = album.BuscarTemaMusical(nombreTemaMusical);
			if (temaMusical == null) {
				temaMusical = new TemaMusical(nombreTemaMusical);
				temaMusical.Album = album;
				temaMusical.Autor = artista;

				album.TemasMusicales.Add(temaMusical);
			}

			// Creo la escucha
			Escucha escucha = new Escucha(usuario, temaMusical, inicio, valoracion);
			usuario.Escuchas.Add(escucha);

			this.musicaService.SaveOrUpdateArtista(artista);
			this.musicaService.SaveOrUpdateAlbum(album);
			this.musicaService.SaveOrUpdateTemaMusical(temaMusical);
			this.escuchaDao.SaveOrUpdateEscucha(escucha);
			this.usuarioService.SaveOrUpdate(usuario);
		}

		/// <see cref="IEscuchaService.RetrieveEscuchasByUsuario(Usuario)" />
		public IList RetrieveEscuchasByUsuario(Usuario usuario) {
			return new ArrayList(usuario.Escuchas);
		}

		/// <see cref="IEscuchaService.RetrieveEscuchasByUsuario(Usuario, DateTime, DateTime)" />
		public IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde) {
			return this.escuchaDao.RetrieveEscuchasByUsuario(usuario, fechaHasta, fechaDesde);
		}

		/// <see cref="IEscuchaService.RetrieveUsuariosMasActivos()" />
		public IList RetrieveUsuariosMasActivos() {
			return this.escuchaDao.RetrieveUsuariosMasActivos();
		}
		
		/// <see cref="IEscuchaService.RetrieveUsuariosMasActivos(Artista)" />
		public IList RetrieveUsuariosMasActivos(Artista artista) {
			return this.escuchaDao.RetrieveUsuariosMasActivos(artista);
		}

		/// <see cref="IEscuchaService.RetrieveUltimasEscuchas(Usuario, int)" />
		public IList RetrieveUltimasEscuchas(Usuario usuario, int cantidad) {
			return this.escuchaDao.RetrieveUltimasEscuchas(usuario.Id, cantidad);
		}

		#endregion Escuchas

		#endregion M�todos P�blicos
	}
}