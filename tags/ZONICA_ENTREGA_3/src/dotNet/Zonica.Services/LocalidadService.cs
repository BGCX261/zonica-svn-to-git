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
using Zonica.Interfaces.Daos;
using Zonica.Interfaces.Services;
using Zonica.Model;

#endregion Usings

namespace Zonica.Services {
	/// <see cref="ILocalidadService"/>
	/// <see cref="Service"/>
	public class LocalidadService : Service, ILocalidadService {
		#region Campos privados

		private ILocalidadDao localidadDao;

		#endregion Campos privados

		#region Propiedades

		public ILocalidadDao LocalidadDao {
			set { localidadDao = value; }
		}

		#endregion Propiedades

		#region Contructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public LocalidadService() : base() {
			// Nothing to do
		}

		#endregion Contructores

		#region Pais

		/// <see cref="ILocalidadService.SaveOrUpdatePais(Pais)"/>
		public void SaveOrUpdatePais(Pais pais) {
			this.localidadDao.SaveOrUpdatePais(pais);
		}

		/// <see cref="ILocalidadService.RetrievePais(int)"/>
		public Pais RetrievePais(int paisId) {
			return this.localidadDao.RetrievePais(paisId);
		}

		/// <see cref="ILocalidadService.DeletePais(Pais)"/>
		public void DeletePais(Pais pais) {
			this.localidadDao.DeletePais(pais);
		}

		/// <see cref="ILocalidadService.RetrieveAllPaises()"/>
		public IList RetrieveAllPaises() {
			return this.localidadDao.RetrieveAllPaises();
		}

		#endregion Pais

		#region Provincia
		/// <see cref="ILocalidadService.SaveOrUpdateProvincia(Provincia)"/>
		public void SaveOrUpdateProvincia(Provincia provincia) {
			this.localidadDao.SaveOrUpdateProvincia(provincia);
		}

		/// <see cref="ILocalidadService.RetrieveAllProvincias()"/>
		public IList RetrieveAllProvincias() {
			return this.localidadDao.RetrieveAllProvincias();
		}
		
		/// <see cref="ILocalidadService.DeleteProvincia(Provincia)"/>
		public void DeleteProvincia(Provincia provincia) {
			this.localidadDao.DeleteProvincia(provincia);
		}

		/// <see cref="ILocalidadService.RetrieveProvincia(int)"/>
		public Provincia RetrieveProvincia(int provinciaId) {
			return this.localidadDao.RetrieveProvincia(provinciaId);
		}

		#endregion Provincia

		#region Ciudad
		/// <see cref="ILocalidadService.SaveOrUpdateCiudad(Ciudad)"/>
		public void SaveOrUpdateCiudad(Ciudad ciudad) {
			this.localidadDao.SaveOrUpdateCiudad(ciudad);
		}

		/// <see cref="ILocalidadService.RetrieveAllCiudades()"/>
		public IList RetrieveAllCiudades() {
			return this.localidadDao.RetrieveAllCiudades();
		}

		/// <see cref="ILocalidadService.DeleteCiudad(Ciudad)"/>
		public void DeleteCiudad(Ciudad ciudad) {
			this.localidadDao.DeleteCiudad(ciudad);
		}

		/// <see cref="ILocalidadService.RetrieveCiudad(int)"/>
		public Ciudad RetrieveCiudad(int ciudadId) {
			return this.localidadDao.RetrieveCiudad(ciudadId);
		}

		#endregion Ciudad
	}
}