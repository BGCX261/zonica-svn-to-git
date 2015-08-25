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

namespace Zonica.Interfaces.Daos {
	/// <summary>
	/// Define la interfaz del DAO que permite acceder al modelo de datos de una <see cref="Escucha">Escucha</see>.
	/// </summary>
	public interface IEscuchaDao : IDao {
		/// <summary>
		/// Obtiene una lista de <see cref="ItemRanking">ItemRanking</see> con los <see cref="Artista">Artista</see>s mas escuchados en el sistema Zónica.
		/// </summary>
		/// <returns>una lista de <see cref="ItemRanking">ItemRanking</see></returns>
		IList RetrieveArtistasMasEscuchados();

		/// <summary>
		/// Obtiene una lista de <see cref="ItemRanking">ItemRanking</see> con los <see cref="Artista">Artista</see>s mas escuchados por el <see cref="Usuario">Usuario</see> en el sistema Zónica.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see></param>
		/// <returns>una lista de <see cref="ItemRanking">ItemRanking</see></returns>
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
		/// Obtiene una lista de <see cref="ItemRanking">ItemRanking</see> con los <see cref="TemaMusical">TemaMusical</see>es mas escuchados en el sistema Zónica.
		/// </summary>
		/// <returns>una lista de <see cref="ItemRanking">ItemRanking</see></returns>
		IList RetrieveTemasMusicalesMasEscuchados();

		/// <summary>
		/// Obtiene una lista de <see cref="ItemRanking">ItemRanking</see> con los <see cref="TemaMusical">TemaMusical</see>es mas escuchados por el <see cref="Usuario">Usuario</see> en el sistema Zónica.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see></param>
		/// <returns>una lista de <see cref="ItemRanking">ItemRanking</see></returns>
		IList RetrieveTemasMusicalesMasEscuchados(Usuario usuario);

		/// <summary>
		/// Actualiza o gusrda una <see cref="Escucha">Escucha</see>.
		/// </summary>
		/// <param name="escucha">la  <see cref="Escucha">Escucha</see> a guardar</param>
		void SaveOrUpdateEscucha(Escucha escucha);

		/// <summary>
		/// Obtiene las <see cref="Escucha">Escucha</see>s para un <see cref="Usuario">Usuario</see> en un determinado intervalo de tiempo.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see></param>
		/// <param name="fechaHasta">la fecha desde la cual consultar</param>
		/// <param name="fechaDesde">la fecha hasta la cual consultar</param>
		/// <returns>una lista de <see cref="Escucha">Escucha</see>s</returns>
		IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde);
	}
}