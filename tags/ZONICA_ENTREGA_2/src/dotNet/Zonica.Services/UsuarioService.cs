#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
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
			Usuario usuario = new Usuario();
			usuario.Nombre = nombreUsuario;

			IList usuarios = this.BuscarUsuarios(usuario);
			// Espero un solo usuario
			if (usuarios.Count == 0) {
				throw new UsuarioNotFoundException();
			}
			return (Usuario) usuarios[0];
		}
	}
}