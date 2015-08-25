/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

using System.Collections;
using Zonica.Exceptions;
using Zonica.Exceptions.Model;
using Zonica.Interfaces.Daos;
using Zonica.Interfaces.Services;
using Zonica.Model;

namespace Zonica.Services {
	/// <summary>
	/// Interfaz del Servicio del objeto de negocio <see cref="Zonica.Model.
	/// Usuario">Usuario</see>.
	/// </summary>
	public class UsuarioService : Service, IUsuarioService {
		/// <summary>
		/// Instancia del Dao de acceso a datos.
		/// </summary>
		private IUsuarioDao usuarioDao;

		/// <summary>
		/// Instancia del Dao de acceso a datos.
		/// </summary>
		public IUsuarioDao UsuarioDao {
			set { usuarioDao = value; }
		}

		/// <summary>
		/// Constructor default.
		/// </summary>
		public UsuarioService() : base() {}

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Usuario">Usuario</see> especificado.
		/// 
		/// </summary>
		/// <param name="usuario">el <see cref="Zonica.Model.Usuario">Usuario</see> a
		/// guardar</param>
		public void SaveOrUpdate(Usuario usuario) {}

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
		/// <param name="nombreUsuario"></param>
		/// <param name="password"></param>
		public Usuario AutenticarUsuario(string nombreUsuario, string password) {
			Usuario usuario = new Usuario();
			usuario.Nombre = nombreUsuario;

			IList usuarios = this.usuarioDao.BuscarUsuarios(usuario);

			// Espero un usuario
			if (usuarios.Count == 0) {
				throw new UsuarioNotFoundException();
			}
			usuario = usuarios[0] as Usuario;

			// Verifico el password
			if (!password.Equals(usuario.Password)) {
				throw new LoginFailedException(nombreUsuario, password);
			}

			return usuario;
		}

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
			return this.usuarioDao.BuscarUsuarios(templateUsuario);
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