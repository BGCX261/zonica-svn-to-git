///////////////////////////////////////////////////////////
//  Service.cs
//  Implementation of the Class Service
//  Generated by Enterprise Architect
//  Created on:      04-Sep-2006 21:22:00
///////////////////////////////////////////////////////////


using System;
using System.Collections;
using System.Runtime.Serialization;
using Zonica.Interfaces.Services;

namespace Zonica.Services {
	/// <summary>
	/// Clase Base de todos los Services. Contiene los m�todos que deben implementar todos
	/// los Services del sistema Z�nica.
	/// </summary>
	public class Service : IService {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public Service() : base() {}

		~Service() {}

		public virtual void Dispose() {}

		/// <summary>
		/// Devuelve una lista con todos los objetos.
		/// </summary>
		public IList RetrieveAll() {
			return null;
		}

		/// <summary>
		/// Guarda un objeto.
		/// </summary>
		/// <param name="obj">el objeto a guardar</param>
		public void SaveOrUpdate(Object obj) {}

		/// <summary>
		/// Elimina el objeto especificado.
		/// </summary>
		/// <param name="obj">el objeto a eliminar</param>
		public void Delete(Object obj) {}

		/// <summary>
		/// Obtiene el objeto con el ID especificado.
		/// </summary>
		/// <param name="objectId">el ID del objeto a obtener</param>
		public Object Retrieve(ISerializable objectId) {
			return null;
		}

	} //end Service

} //end namespace Zonica.Services