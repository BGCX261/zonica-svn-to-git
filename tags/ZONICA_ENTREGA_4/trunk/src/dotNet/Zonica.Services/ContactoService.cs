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

using System;
using System.Collections;
using Zonica.Interfaces.Daos;
using Zonica.Interfaces.Services;
using Zonica.Model;

#endregion Usings

namespace Zonica.Services {
	/// <see cref="IContactoService"/>
	/// <see cref="Service"/>
	public class ContactoService : Service, IContactoService {
		#region Campos privados

		/// <summary>
		/// Dao de este servicio.
		/// </summary>
		private IContactoDao contactoDao;

		#endregion Campos privados

		#region Contructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public ContactoService() {
			// Nothing to do.
		}

		#endregion Contructores

		#region Propiedades

		/// <summary>
		/// Dao de este servicio.
		/// </summary>
		public IContactoDao ContactoDao {
			get { return this.contactoDao; }
			set { this.contactoDao = value; }
		}

		#endregion Propiedades

		public IList RetrieveAllTipoContactos() {
			return this.contactoDao.GetTipoContactos();
		}

		public TipoContacto RetrieveTipoContacto(int tipoContactoId) {
			return this.contactoDao.RetrieveTipoContacto(tipoContactoId);
		}
	}
}
