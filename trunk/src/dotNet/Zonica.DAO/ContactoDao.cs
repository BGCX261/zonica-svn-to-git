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
using Zonica.Model;

#endregion Usings

namespace Zonica.DAO {
	/// <see cref="IContactoDao"/>
	/// <see cref="Dao"/>
	/// <see cref="TipoContacto"/>
	/// <see cref="ContactoUsuario"/>
	public class ContactoDao : Dao, IContactoDao {
		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public ContactoDao() {
			// Nothing to do.
		}

		#endregion Constructores

		/// <see cref="Dao.MainType" />
		/// <summary>
		/// El <code>Type</code> principal de este <code>Dao</code> es <see cref="ContactoUsuario">ContactoUsuario</see>.
		/// </summary>
		protected override Type MainType {
			get { return typeof (ContactoUsuario); }
		}

		/// <see cref="IContactoDao.SaveOrUpdate(ContactoUsuario)"/>
		public void SaveOrUpdate(ContactoUsuario contactoUsuario) {
			base.SaveOrUpdate(contactoUsuario);
		}

		/// <see cref="IContactoDao.GetTipoContactos()"/>
		public IList GetTipoContactos() {
			return this.HibernateTemplate.LoadAll(typeof(TipoContacto));
		}

		public TipoContacto RetrieveTipoContacto(int idTipoContacto) {
			return (TipoContacto) this.HibernateTemplate.Get(typeof (TipoContacto), idTipoContacto);
		}
	}
}