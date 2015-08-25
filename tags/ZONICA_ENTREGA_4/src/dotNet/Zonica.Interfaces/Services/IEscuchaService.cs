#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

#endregion Copyright

#region Imports

using System;
using System.Collections;

using Zonica.Exceptions;
using Zonica.Exceptions.Model;
using Zonica.Model;

#endregion Imports

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Implementa los métodos relacionados a la obtención de información sobre <see cref="Escucha">Escucha</see>s musicales.
	/// </summary>
	public interface IEscuchaService : IService {
		/// <summary>
		/// Obtiene una lista con los <see cref="Artista">Artista</see>s más escuchados
		/// en el sistema.
		/// </summary>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="Artista">Artista</see>s</returns>
		IList RetrieveArtistasMasEscuchados();

		/// <summary>
		/// Obtiene una lista con los <see cref="Artista">Artista</see>s más escuchados
		/// por el <see cref="Usuario">Usuario</see> en el sistema.
		/// </summary>
		/// <param name="usuario">El <see cref="Usuario">Usuario</see> a consultar</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="Artista">Artista</see>s</returns>
		IList RetrieveArtistasMasEscuchados(Usuario usuario);

		/// <summary>
		/// Obtiene una lista con los <see cref="Album">Album</see>es más escuchados
		/// en el sistema.
		/// </summary>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="ItemRanking">ItemRanking</see>s</returns>
		IList RetrieveAlbumesMasEscuchados();

		/// <summary>
		/// Obtiene una lista con los <see cref="Album">Album</see>es más escuchados
		/// por el <see cref="Usuario">Usuario</see> en el sistema.
		/// </summary>
		/// <param name="usuario">El <see cref="Usuario">Usuario</see> a consultar</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="ItemRanking">ItemRanking</see>s</returns>
		IList RetrieveAlbumesMasEscuchados(Usuario usuario);
		
		/// <summary>
		/// Obtiene una lista con los <see cref="Album">Album</see>es más escuchados
		/// en el sistema.
		/// </summary>
		/// <param name="artista">El <see cref="Artista">Artista</see> consultado</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="ItemRanking">ItemRanking</see>s</returns>
		IList RetrieveAlbumesMasEscuchados(Artista artista);

		/// <summary>
		/// Obtiene una lista con los <see cref="TemaMusical">TemaMusical</see>es más escuchados
		/// en el sistema.
		/// </summary>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="TemaMusical">TemaMusical</see>es</returns>
		IList RetrieveTemasMusicalesMasEscuchados();

		/// <summary>
		/// Obtiene una lista con los <see cref="TemaMusical">TemaMusical</see>es más escuchados
		/// por el <see cref="Usuario">Usuario</see> en el sistema.
		/// </summary>
		/// /// <param name="usuario">El <see cref="Usuario">Usuario</see> a consultar</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="TemaMusical">TemaMusical</see>es</returns>
		IList RetrieveTemasMusicalesMasEscuchados(Usuario usuario);
		
		/// <summary>
		/// Obtiene una lista con los <see cref="TemaMusical">TemaMusical</see>es más escuchados
		/// en el sistema.
		/// </summary>
		/// <param name="artista">El <see cref="Artista">Artista</see> consultado</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="TemaMusical">TemaMusical</see>es</returns>
		IList RetrieveTemasMusicalesMasEscuchados(Artista artista);

		/// <summary>
		/// Obtiene una <see cref="IList">IList</see> de <see cref="Usuario">Usuario</see>s
		/// con gustos musicales similares a los del <code>usuario</code>.
		/// </summary>
		/// <param name="usuario">El <see cref="Usuario">Usuario</see> a consultar</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="ItemRanking">ItemRanking</see>s</returns>
		IList RetrieveAmigos(Usuario usuario);

		/// <summary>
		/// Guarda la <see cref="Escucha">Escucha</see>.
		/// </summary>
		/// <param name="escucha">La <see cref="Escucha">Escucha</see> a guardar</param>
		void SaveOrUpdateEscucha(Escucha escucha);

		/// <summary>
		/// Se verifica que el <see cref="Usuario">Usuario</see> definido por <code>nombreUsuario</code>
		/// y <code>password</code> exista en el sistema y luego se procede a registrar una
		/// <see cref="Escucha">Escucha</see> en el momento determinado por <code>inicio</code>
		/// y con <code>valoracion</code>.
		/// </summary>
		/// <param name="nombreUsuario">El nombre del <see cref="Usuario">Usuario</see></param>
		/// <param name="password">El password del <see cref="Usuario">Usuario</see></param>
		/// <param name="nombreTemaMusical">El nombre del <see cref="TemaMusical">TemaMusical</see> a registrar</param>
		/// <param name="nombreArtista">El nombre del <see cref="Artista">Artista</see> a registrar</param>
		/// <param name="nombreAlbum">El nombre del <see cref="Album">Album</see> a registrar</param>
		/// <param name="inicio">El momento de inicio de la escucha</param>
		/// <param name="valoracion">La valoración dada por el <see cref="Usuario">Usuario</see> a la <c>Escucha</c> realizada</param>
		/// <exception cref="ArgumentException">Si alguno de los argumentos no es especificado</exception>
		/// <exception cref="UsuarioNotFoundException">Si no existe ningún <see cref="Usuario">Usuario</see> con el <c>nombreUsuario</c> especificado</exception>
		/// <exception cref="LoginFailedException">Si falla la autenticación del <see cref="Usuario">Usuario</see></exception>
		void RegistrarEscucha(string nombreUsuario, string password, string nombreArtista, string nombreAlbum, string nombreTemaMusical, DateTime inicio, short valoracion);

		/// <summary>
		/// Obtiene una lista de <see cref="Escucha">Escucha</see>s realizadas por el
		/// <see cref="Usuario">Usuario</see>.
		/// </summary>
		/// <param name="usuario">El <see cref="Usuario">Usuario</see> del cual obtener las escuchas</param>
		/// <returns>Una <see cref="IList">IList</see> con las <see cref="Escucha">Escucha</see>s del <see cref="Usuario">Usuario</see></returns>
		IList RetrieveEscuchasByUsuario(Usuario usuario);

		/// <summary>
		/// Obtiene una lista de <see cref="Escucha">Escucha</see>s realizadas por el
		/// <see cref="Usuario">Usuario</see> en el período especificado por
		/// <code>fechaDesde</code> y <code>fechaHasta</code>.
		/// </summary>
		/// <param name="usuario">El <see cref="Usuario">Usuario</see> del cual obtener las escuchas</param>
		/// <param name="fechaHasta">Las fecha desde la cual consultar</param>
		/// <param name="fechaDesde">La fecha hasta la cual consultar</param>
		/// <returns>Una <see cref="IList">IList</see> con las <see cref="Escucha">Escucha</see>s del <see cref="Usuario">Usuario</see></returns>
		IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde);

		/// <summary>
		/// Obtiene una <see cref="IList">IList</see> con objetos <see cref="ItemRanking">ItemRanking</see>
		/// con los usuarios mas activos del sistema. Los mas activos son los que mas escuchas tienen.
		/// </summary>
		/// <returns>una <see cref="IList">IList</see> de <see cref="ItemRanking">ItemRanking</see></returns>
		IList RetrieveUsuariosMasActivos();
		
		/// <summary>
		/// Obtiene una <see cref="IList">IList</see> con objetos <see cref="ItemRanking">ItemRanking</see>
		/// con los usuarios mas activos del sistema. Los mas activos son los que mas escuchas del <see cref="Artista">Artista</see> tienen.
		/// </summary>
		/// <param name="artista">El <see cref="Artista">Artista</see> seleccionado</param>
		/// <returns>una <see cref="IList">IList</see> de <see cref="ItemRanking">ItemRanking</see></returns>
		IList RetrieveUsuariosMasActivos(Artista artista);

		/// <summary>
		/// Obtiene las últimas <c>cantidad</c> <see cref="Escucha">Escucha</see>s que realizó el <see cref="Usuario">Usuario</see> especificado.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see> especificado</param>
		/// <param name="cantidad">la <c>cantidad de escuchas</c></param>
		/// <returns>una <see cref="IList">IList</see> con objetos <see cref="ItemRanking">ItemRanking</see></returns>
		IList RetrieveUltimasEscuchas(Usuario usuario, int cantidad);
	}
}