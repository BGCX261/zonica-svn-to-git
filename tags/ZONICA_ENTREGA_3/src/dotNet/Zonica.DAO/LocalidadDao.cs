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
using Zonica.Interfaces.Daos;
using Zonica.Model;

#endregion Imports

namespace Zonica.DAO {
	/// <summary>
	/// Interfaz del servicio que permite acceder a los objetos de negocio <see
	/// cref="Pais">Pais</see>, <see cref="Zonica.Model.
	/// Provincia">Provincia</see> y <see cref="Ciudad">Ciudad</see>.
	/// </summary>
	public class LocalidadDao : Dao, ILocalidadDao {
		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public LocalidadDao() : base() {
			// Nothing to do
		}

		#endregion Constructores

		/// <see cref="Dao.MainType" />
		/// <summary>
		/// El <code>Type</code> principal de este <code>Dao</code> es <code>Pais</code>.
		/// </summary>
		protected override Type MainType {
			get { return typeof (Pais); }
		}

		#region Pais

		/// <see cref="ILocalidadDao.SaveOrUpdatePais(Pais)" />
		public void SaveOrUpdatePais(Pais pais) {
			base.SaveOrUpdate(pais);
		}

		/// <see cref="ILocalidadDao.RetrievePais(int)" />
		public Pais RetrievePais(int paisId) {
			return (Pais) base.Retrieve(paisId);
		}

		/// <see cref="ILocalidadDao.DeletePais(Pais)" />
		public void DeletePais(Pais pais) {
			base.Delete(pais);
		}

		/// <see cref="ILocalidadDao.RetrieveAllPaises()" />
		public IList RetrieveAllPaises() {
			return base.RetrieveAll();
		}

		#endregion Pais

		#region Provincia

		/// <see cref="ILocalidadDao.SaveOrUpdateProvincia(Provincia)" />
		public void SaveOrUpdateProvincia(Provincia provincia) {
			base.SaveOrUpdate(provincia);
		}

		/// <see cref="ILocalidadDao.RetrieveProvincia(int)" />
		public Provincia RetrieveProvincia(int provinciaId) {
			return (Provincia) this.HibernateTemplate.Get(typeof (Provincia), provinciaId);
		}

		/// <see cref="ILocalidadDao.DeleteProvincia(Provincia)" />
		public void DeleteProvincia(Provincia provincia) {
			base.Delete(provincia);
		}

		/// <see cref="ILocalidadDao.RetrieveAllProvincias()" />
		public IList RetrieveAllProvincias() {
			return this.HibernateTemplate.LoadAll(typeof (Provincia));
		}

		#endregion Provincia

		#region Ciudad

		/// <see cref="ILocalidadDao.SaveOrUpdateCiudad(Ciudad)" />
		public void SaveOrUpdateCiudad(Ciudad ciudad) {
			base.SaveOrUpdate(ciudad);
		}

		/// <see cref="ILocalidadDao.RetrieveCiudad(int)" />
		public Ciudad RetrieveCiudad(int ciudadId) {
			return (Ciudad) this.HibernateTemplate.Get(typeof (Ciudad), ciudadId);
		}

		/// <see cref="ILocalidadDao.DeleteCiudad(Ciudad)" />
		public void DeleteCiudad(Ciudad ciudad) {
			base.Delete(ciudad);
		}

		/// <see cref="ILocalidadDao.RetrieveAllCiudades()" />
		public IList RetrieveAllCiudades() {
			return this.HibernateTemplate.LoadAll(typeof (Ciudad));
		}

		#endregion Ciudad

		/// <see cref="ILocalidadDao.GetProvinciasByPais(int)" />
		public ICollection GetProvinciasByPais(int paisId) {
			return this.RetrievePais(paisId).Provincias;
		}

		/// <see cref="ILocalidadDao.GetCiudadesByProvincia(int)" />
		public ICollection GetCiudadesByProvincia(int provinciaId) {
			return this.RetrieveProvincia(provinciaId).Ciudades;
		}
	}
}