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

using System.Collections;
using Zonica.Model;

#endregion Usings

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Interfaz del servicio que permite acceder a los objetos de negocio <see cref="Pais">Pais</see>, <see cref="Provincia">Provincia</see> y <see cref="Ciudad">Ciudad</see>.
	/// </summary>
	public interface ILocalidadService : IService {
		/// <summary>
		/// Actualiza al objeto <see cref="Pais">Pais</see> especificado.
		/// </summary>
		/// <param name="pais">el <see cref="Pais">Pais</see> a guardar</param>
		void SaveOrUpdatePais(Pais pais);

		/// <summary>
		/// Obtiene el objeto <see cref="Pais">Pais</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="paisId">el Id de la <see cref="Pais">Pais</see> a
		/// obtener</param>
		Pais RetrievePais(int paisId);

		/// <summary>
		/// Elimina al <see cref="Pais">Pais</see> especificado del sistema
		/// Zónica.
		/// </summary>
		/// <param name="pais">el <see cref="Pais">Pais</see> a
		/// eliminar</param>
		void DeletePais(Pais pais);

		/// <summary>
		/// Obtiene todos los objetos <see cref="Pais">Pais</see> del sistema
		/// Zónica.
		/// </summary>
		IList RetrieveAllPaises();

		/// <summary>
		/// Actualiza al objeto <see cref="Provincia">Provincia</see>
		/// especificado.
		/// </summary>
		/// <param name="provincia">la <see cref="Provincia">Provincia</see> a
		/// guardar</param>
		void SaveOrUpdateProvincia(Provincia provincia);

		/// <summary>
		/// Actualiza al objeto <see cref="Ciudad">Ciudad</see> especificado.
		/// </summary>
		/// <param name="ciudad">la <see cref="Ciudad">Ciudad</see> a
		/// guardar</param>
		void SaveOrUpdateCiudad(Ciudad ciudad);

		/// <summary>
		/// Obtiene todos los objetos <see cref="Provincia">Provincia</see>
		/// del sistema Zónica.
		/// </summary>
		IList RetrieveAllProvincias();

		/// <summary>
		/// Obtiene todos los objetos <see cref="Ciudad">Ciudad</see> del
		/// sistema Zónica.
		/// </summary>
		IList RetrieveAllCiudades();

		/// <summary>
		/// Elimina al <see cref="Ciudad">Ciudad</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="ciudad">la <see cref="Ciudad">Ciudad</see> a
		/// eliminar</param>
		void DeleteCiudad(Ciudad ciudad);

		/// <summary>
		/// Elimina al <see cref="Provincia">Provincia</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="provincia">la <see cref="Provincia">Provincia</see> a
		/// eliminar</param>
		void DeleteProvincia(Provincia provincia);

		/// <summary>
		/// Obtiene el objeto <see cref="Provincia">Provincia</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="provinciaId">el Id de la <see cref="Provincia">Provincia</see> a obtener</param>
		Provincia RetrieveProvincia(int provinciaId);

		/// <summary>
		/// Obtiene el objeto <see cref="Ciudad">Ciudad</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="ciudadId">el Id de la <see cref="Ciudad">Ciudad</see>
		/// a obtener</param>
		Ciudad RetrieveCiudad(int ciudadId);
	}
}