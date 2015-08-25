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

using Zonica.Exceptions;
using Zonica.Exceptions.Model;
using Zonica.Interfaces.Daos;
using Zonica.Interfaces.Services;
using Zonica.Model;

#endregion Imports

namespace Zonica.Services {
	/// <see cref="IUsuarioService"/>
	/// <see cref="Service"/>
	public class UsuarioService : Service, IUsuarioService {
		#region Campos privados

		/// <summary>
		/// Instancia del Dao de acceso a datos.
		/// </summary>
		private IUsuarioDao usuarioDao;

		#endregion Campos privados

		#region Propiedades

		/// <summary>
		/// Instancia del Dao de acceso a datos.
		/// </summary>
		public IUsuarioDao UsuarioDao {
			set { usuarioDao = value; }
		}

		#endregion Propiedades

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public UsuarioService() : base() {
			// Nothing to do
		}

		#endregion Constructores

		/// <see cref="IUsuarioService.SaveOrUpdate(Usuario)"/>
		public void SaveOrUpdate(Usuario usuario) {
			this.usuarioDao.SaveOrUpdate(usuario);
		}

		/// <see cref="IUsuarioService.Retrieve(int)"/>
		public Usuario Retrieve(Int32 usuarioId) {
			return this.usuarioDao.Retrieve(usuarioId);
		}

		/// <see cref="IUsuarioService.Delete(Usuario)"/>
		public void Delete(Usuario usuario) {
			this.usuarioDao.Delete(usuario);
		}

		/// <see cref="IUsuarioService.AutenticarUsuario(string, string)"/>
		public Usuario AutenticarUsuario(string nombreUsuario, string password) {
			Usuario usuario = this.BuscarPorNombre(nombreUsuario);

			if (usuario == null) {
				throw new UsuarioNotFoundException();
			}

			// Verifico el password
			if (!password.Equals(usuario.Password)) {
				throw new LoginFailedException(nombreUsuario, password);
			}

			return usuario;
		}

		/// <see cref="IUsuarioService.ChangePassword(string, string, string)"/>
		public Usuario ChangePassword(string nombreUsuario, string oldPassword, string newPassword) {
			Usuario usuario = this.AutenticarUsuario(nombreUsuario, oldPassword);
			usuario.Password = newPassword;

			return usuario;
		}

		/// <see cref="IUsuarioService.BuscarUsuarios(Usuario)"/>
		public IList BuscarUsuarios(Usuario templateUsuario) {
			return this.usuarioDao.BuscarUsuarios(templateUsuario);
		}

		/// <see cref="IUsuarioService.BuscarPorNombre(string)"/>
		public Usuario BuscarPorNombre(string nombreUsuario) {
			return this.usuarioDao.BuscarPorNombre(nombreUsuario);
		}

		/// <see cref="IUsuarioService.GetCantidadUsuariosRegistrados()"/>
		public int GetCantidadUsuariosRegistrados() {
			// HACK Las fechas Min y Max !!!
			return this.usuarioDao.GetCantidadUsuariosRegistrados(DateTime.Now.AddYears(-100), DateTime.Now.AddYears(100));
		}
		
		/// <see cref="IUsuarioService.GetCantidadUsuariosRegistradosHoy()"/>
		public int GetCantidadUsuariosRegistradosHoy() {
			return this.usuarioDao.GetCantidadUsuariosRegistrados(DateTime.Now.AddDays(-1), DateTime.Now);
		}
	}
}