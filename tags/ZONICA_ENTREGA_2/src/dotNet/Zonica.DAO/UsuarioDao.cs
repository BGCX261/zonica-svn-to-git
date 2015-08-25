/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>


using System;
using System.Collections;
using NHibernate;
using NHibernate.Expression;
using Zonica.Interfaces.Daos;
using Zonica.Model;

namespace Zonica.DAO {
	/// <summary>
	/// Interfaz del Servicio del objeto de negocio <see cref="Zonica.Model.Usuario">Usuario</see>.
	/// </summary>
	public class UsuarioDao : Dao, IUsuarioDao {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public UsuarioDao() : base() {
			// Nothing to do
		}

		/// <see cref="Dao.MainType" />
		protected override Type MainType {
			get { return typeof (Usuario); }
		}

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Usuario">Usuario</see> especificado.
		/// </summary>
		/// <param name="usuario">el <see cref="Zonica.Model.Usuario">Usuario</see> a guardar</param>
		public void SaveOrUpdate(Usuario usuario) {
			base.SaveOrUpdate(usuario);
		}

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Usuario">Usuario</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="usuarioId">el Id del <see cref="Zonica.Model.Usuario">Usuario</see> a obtener</param>
		public Usuario Retrieve(int usuarioId) {
			return null;
		}

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Usuario">Usuario</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="usuario">el <see cref="Zonica.Model.Usuario">Usuario</see> a
		/// eliminar</param>
		public void Delete(Usuario usuario) {}

		/// 
		/// <param name="usuario"></param>
		/// <param name="oldPassword"></param>
		/// <param name="newPassword"></param>
		public Usuario ChangePassword(Usuario usuario, string oldPassword, string newPassword) {
			return null;
		}

		/// 
		/// <param name="templateUsuario"></param>
		public IList BuscarUsuarios(Usuario templateUsuario) {
			ICriteria criteria = this.HibernateTemplate.Session.CreateCriteria(typeof(Usuario));
			return criteria.Add(Example.Create(templateUsuario)).List();
		}

		/// 
		/// <param name="nombreUsuario"></param>
		public Usuario BuscarPorNombre(string nombreUsuario) {
			return null;
		}

		/// 
		/// <param name="templateEscuchaMusical"></param>
		public IList BuscarPorEscuchaMusical(Escucha templateEscuchaMusical) {
			return null;
		}
	}
}