/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

using System;
using System.Collections;
using Spring.Data.NHibernate.Support;
using Zonica.Interfaces.Daos;

namespace Zonica.DAO {
	/// <summary>
	/// Clase Base de todos los DAOs. Contiene los métodos que deben implementar todos
	/// los DAOs del sistema Zónica.
	/// </summary>
	public abstract class Dao : HibernateDaoSupport, IDao {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public Dao() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Obtiene el tipo principal al que accede este Dao.
		/// </summary>
		protected abstract Type MainType { get; }

		/// <summary>
		/// Devuelve una lista con todos los objetos.
		/// </summary>
		public IList RetrieveAll() {
			return this.HibernateTemplate.LoadAll(this.MainType);
		}

		/// <summary>
		/// Guarda un objeto.
		/// </summary>
		/// <param name="obj">el objeto a guardar</param>
		public void SaveOrUpdate(object obj) {
			this.HibernateTemplate.SaveOrUpdate(obj);
		}

		/// <summary>
		/// Elimina el objeto especificado.
		/// </summary>
		/// <param name="obj">el objeto a eliminar</param>
		public void Delete(object obj) {
			this.HibernateTemplate.Delete(obj);
		}

		/// <summary>
		/// Obtiene el objeto con el ID especificado.
		/// </summary>
		/// <param name="objectId">el ID del objeto a obtener</param>
		public Object Retrieve(object objectId) {
			return this.HibernateTemplate.Get(this.MainType, objectId);
		}
	}
}