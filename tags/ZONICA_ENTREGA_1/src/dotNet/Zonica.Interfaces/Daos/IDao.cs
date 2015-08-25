/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>

using System;
using System.Collections;

namespace Zonica.Interfaces.Daos {
	/// <summary>
	/// Interfase Base de todos los DAOs. Contiene los m�todos que deben implementar
	/// todos los DAOs del sistema Z�nica.
	/// </summary>
	public interface IDao {
		/// <summary>
		/// Devuelve una lista con todos los objetos.
		/// </summary>
		IList RetrieveAll();

		/// <summary>
		/// Guarda un objeto.
		/// </summary>
		/// <param name="obj">el objeto a guardar</param>
		void SaveOrUpdate(object obj);

		/// <summary>
		/// Elimina el objeto especificado.
		/// </summary>
		/// <param name="obj">el objeto a eliminar</param>
		void Delete(object obj);

		/// <summary>
		/// Obtiene el objeto con el ID especificado.
		/// </summary>
		/// <param name="objectId">el ID del objeto a obtener</param>
		Object Retrieve(object objectId);
	}
}