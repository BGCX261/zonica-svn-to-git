///////////////////////////////////////////////////////////
//  LocalidadService.cs
//  Implementation of the Class LocalidadService
//  Generated by Enterprise Architect
//  Created on:      04-Sep-2006 21:22:00
///////////////////////////////////////////////////////////


using System.Collections;
using Zonica.Interfaces.Services;
using Zonica.Model;

namespace Zonica.Services {
	/// <summary>
	/// Interfaz del servicio que permite acceder a los objetos de negocio <see
	/// cref="Zonica.Model.Pais">Pais</see>, <see cref="Zonica.Model.
	/// Provincia">Provincia</see> y <see cref="Zonica.Model.Ciudad">Ciudad</see>.
	/// </summary>
	public class LocalidadService : Service, ILocalidadService {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public LocalidadService() : base() {}

		~LocalidadService() {}

		public override void Dispose() {}

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Pais">Pais</see> especificado.
		/// </summary>
		/// <param name="pais">el <see cref="Zonica.Model.Pais">Pais</see> a guardar</param>
		public void SaveOrUpdatePais(Pais pais) {}

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Pais">Pais</see> con el Id
		/// especificado del sistema Z�nica.
		/// </summary>
		/// <param name="paisId">el Id de la <see cref="Zonica.Model.Pais">Pais</see> a
		/// obtener</param>
		public Pais RetrievePais(int paisId) {
			return null;
		}

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Pais">Pais</see> especificado del sistema
		/// Z�nica.
		/// </summary>
		/// <param name="pais">el <see cref="Zonica.Model.Pais">Pais</see> a
		/// eliminar</param>
		public void DeletePais(Pais pais) {}

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Pais">Pais</see> del sistema
		/// Z�nica.
		/// </summary>
		public IList RetrieveAllPaises() {
			return null;
		}

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Provincia">Provincia</see>
		/// especificado.
		/// </summary>
		/// <param name="provincia">la <see cref="Zonica.Model.Provincia">Provincia</see> a
		/// guardar</param>
		public void SaveOrUpdateProvincia(Provincia provincia) {}

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Ciudad">Ciudad</see> especificado.
		/// </summary>
		/// <param name="ciudad">la <see cref="Zonica.Model.Ciudad">Ciudad</see> a
		/// guardar</param>
		public void SaveOrUpdateCiudad(Ciudad ciudad) {}

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Provincia">Provincia</see>
		/// del sistema Z�nica.
		/// </summary>
		public IList RetrieveAllProvincias() {
			return null;
		}

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Ciudad">Ciudad</see> del
		/// sistema Z�nica.
		/// </summary>
		public IList RetrieveAllCiudades() {
			return null;
		}

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Ciudad">Ciudad</see> especificado del
		/// sistema Z�nica.
		/// </summary>
		/// <param name="ciudad">la <see cref="Zonica.Model.Ciudad">Ciudad</see> a
		/// eliminar</param>
		public void DeleteCiudad(Ciudad ciudad) {}

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Provincia">Provincia</see> especificado del
		/// sistema Z�nica.
		/// </summary>
		/// <param name="provincia">la <see cref="Zonica.Model.Provincia">Provincia</see> a
		/// eliminar</param>
		public void DeleteProvincia(Provincia provincia) {}

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Provincia">Provincia</see> con el Id
		/// especificado del sistema Z�nica.
		/// </summary>
		/// <param name="provinciaId">el Id de la <see cref="Zonica.Model.Provincia">Provincia</see> a obtener</param>
		public Provincia RetrieveProvincia(int provinciaId) {
			return null;
		}

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Ciudad">Ciudad</see> con el Id
		/// especificado del sistema Z�nica.
		/// </summary>
		/// <param name="ciudadId">el Id de la <see cref="Zonica.Model.Ciudad">Ciudad</see>
		/// a obtener</param>
		public Ciudad RetrieveCiudad(int ciudadId) {
			return null;
		}

		/// <summary>
		/// Obtiene todas los objetos <see cref="Zonica.Model.Provincia">Provincia</see>
		/// del <see cref="Zonica.Model.Pais">Pais</see> especificado.
		/// </summary>
		/// <param name="pais">el <see cref="Zonica.Model.Pais">Pais</see> del cual obtener
		/// los objetos <see cref="Zonica.Model.Provincia">Provincia</see></param>
		public IList GetProvinciasByPais(Pais pais) {
			return null;
		}

		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Ciudad">Ciudad</see> de la
		/// <see cref="Zonica.Model.Provincia">Provincia</see> especificada.
		/// </summary>
		/// <param name="provincia">la <see cref="Zonica.Model.Provincia">Provincia</see>
		/// de donde obtener los objetos <see cref="Zonica.Model.Ciudad">Ciudad</see></param>
		public void GetCiudadesByProvincia(Provincia provincia) {}

	} //end LocalidadService

} //end namespace Zonica.Services