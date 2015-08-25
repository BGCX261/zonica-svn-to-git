/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>


using System;
using System.Collections;
using System.Runtime.Serialization;

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Inferfaz que contiene los m�todos comunes a todos los servicios de Z�nica.
	/// </summary>
	public interface IService {
		/// <summary>
		/// Crea un objeto en el sistema Z�nica.
		/// </summary>
		/// <param name="object">El objeto a crear</param>
		void SaveOrUpdate(Object obj);

		/// <summary>
		/// Obtiene un objeto del sistema Z�nica con el Id especificado.
		/// </summary>
		/// <param name="objectId"></param>
		Object Retrieve(ISerializable objectId);

		/// <summary>
		/// Elimina un objeto del sistema Z�nica.
		/// </summary>
		/// <param name="object">el objeto a eliminar</param>
		void Delete(Object obj);

		/// <summary>
		/// Obtiene todos los
		/// </summary>
		IList RetrieveAll();
	} //end IService

} //end namespace Services