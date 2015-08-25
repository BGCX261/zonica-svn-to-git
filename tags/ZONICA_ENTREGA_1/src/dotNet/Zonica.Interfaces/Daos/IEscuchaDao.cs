/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>


using System;
using System.Collections;
using Zonica.Model;

namespace Zonica.Interfaces.Daos {
	public interface IEscuchaDao : IDao {
		IList RetrieveArtistasMasEscuchados();

		IList RetrieveTemasMusicalesMasEscuchados();

		/// 
		/// <param name="escucha"></param>
		void SaveOrUpdateEscucha(Escucha escucha);

		/// 
		/// <param name="usuario"></param>
		IList RetrieveEscuchasByUsuario(Usuario usuario);

		/// 
		/// <param name="usuario"></param>
		/// <param name="fechaHasta"></param>
		/// <param name="fechaDesde"></param>
		IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde);
	} //end IEscuchaDao

} //end namespace Daos