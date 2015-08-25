/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>


using System.Collections;
using Zonica.Model;

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Interfaz del servicio que permite acceder a los objetos de negocio <see
	/// cref="Zonica.Model.Pais">Pais</see>, <see cref="Zonica.Model.
	/// Provincia">Provincia</see> y <see cref="Zonica.Model.Ciudad">Ciudad</see>.
	/// </summary>
	public interface ILocalidadService : IService {
		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Pais">Pais</see> especificado.
		/// </summary>
		/// <param name="pais">el <see cref="Zonica.Model.Pais">Pais</see> a guardar</param>
		void SaveOrUpdatePais(Pais pais);

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Pais">Pais</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="paisId">el Id de la <see cref="Zonica.Model.Pais">Pais</see> a
		/// obtener</param>
		Pais RetrievePais(int paisId);

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Pais">Pais</see> especificado del sistema
		/// Zónica.
		/// </summary>
		/// <param name="pais">el <see cref="Zonica.Model.Pais">Pais</see> a
		/// eliminar</param>
		void DeletePais(Pais pais);

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Pais">Pais</see> del sistema
		/// Zónica.
		/// </summary>
		IList RetrieveAllPaises();

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Provincia">Provincia</see>
		/// especificado.
		/// </summary>
		/// <param name="provincia">la <see cref="Zonica.Model.Provincia">Provincia</see> a
		/// guardar</param>
		void SaveOrUpdateProvincia(Provincia provincia);

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Ciudad">Ciudad</see> especificado.
		/// </summary>
		/// <param name="ciudad">la <see cref="Zonica.Model.Ciudad">Ciudad</see> a
		/// guardar</param>
		void SaveOrUpdateCiudad(Ciudad ciudad);

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Provincia">Provincia</see>
		/// del sistema Zónica.
		/// </summary>
		IList RetrieveAllProvincias();

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Ciudad">Ciudad</see> del
		/// sistema Zónica.
		/// </summary>
		IList RetrieveAllCiudades();

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Ciudad">Ciudad</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="ciudad">la <see cref="Zonica.Model.Ciudad">Ciudad</see> a
		/// eliminar</param>
		void DeleteCiudad(Ciudad ciudad);

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Provincia">Provincia</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="provincia">la <see cref="Zonica.Model.Provincia">Provincia</see> a
		/// eliminar</param>
		void DeleteProvincia(Provincia provincia);

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Provincia">Provincia</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="provinciaId">el Id de la <see cref="Zonica.Model.
		/// Provincia">Provincia</see> a obtener</param>
		Provincia RetrieveProvincia(int provinciaId);

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Ciudad">Ciudad</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="ciudadId">el Id de la <see cref="Zonica.Model.Ciudad">Ciudad</see>
		/// a obtener</param>
		Ciudad RetrieveCiudad(int ciudadId);

		/// <summary>
		/// Obtiene todas los objetos <see cref="Zonica.Model.Provincia">Provincia</see>
		/// del <see cref="Zonica.Model.Pais">Pais</see> especificado.
		/// </summary>
		/// <param name="pais">el <see cref="Zonica.Model.Pais">Pais</see> del cual obtener
		/// los objetos <see cref="Zonica.Model.Provincia">Provincia</see></param>
		IList GetProvinciasByPais(Pais pais);

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Ciudad">Ciudad</see> de la
		/// <see cref="Zonica.Model.Provincia">Provincia</see> especificada.
		/// </summary>
		/// <param name="provincia">la <see cref="Zonica.Model.Provincia">Provincia</see>
		/// de donde obtener los objetos <see cref="Zonica.Model.
		/// Ciudad">Ciudad</see></param>
		void GetCiudadesByProvincia(Provincia provincia);
	} //end ILocalidadService

} //end namespace Services