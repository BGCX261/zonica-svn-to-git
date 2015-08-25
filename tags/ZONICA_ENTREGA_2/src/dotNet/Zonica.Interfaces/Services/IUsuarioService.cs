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
using Zonica.Model;

#endregion Imports

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Interfaz del Servicio del objeto de negocio <see cref="Usuario">Usuario</see>.
	/// </summary>
	public interface IUsuarioService : IService {
		/// <summary>
		/// Actualiza al objeto <see cref="Usuario">Usuario</see> especificado.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see> a guardar</param>
		void SaveOrUpdate(Usuario usuario);

		/// <summary>
		/// Obtiene el objeto <see cref="Usuario">Usuario</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="usuarioId">el Id del <see cref="Usuario">Usuario</see> a obtener</param>
		Usuario Retrieve(Int32 usuarioId);

		/// <summary>
		/// Elimina al <see cref="Usuario">Usuario</see> especificado del sistema Zónica.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see> a eliminar</param>
		void Delete(Usuario usuario);

		/// <summary>
		/// Autentica a un <see cref="Usuario">Usuario</see> en el sistema, usando las credenciales.
		/// </summary>
		/// <param name="nombreUsuario">El nombre del <see cref="Usuario">Usuario</see> a autenticar</param>
		/// <param name="password">El password del <see cref="Usuario">Usuario</see> a autenticar</param>
		/// <returns>Al <see cref="Usuario">Usuario</see> autenticado, si las credenciales son válidas</returns>
		/// <exception cref="UsuarioNotFoundException">Si no existe ningún <see cref="Usuario">Usuario</see> con el <code>nombreUsuario</code> especificado</exception>
		/// <exception cref="LoginFailedException">Si falla la autenticación del <see cref="Usuario">Usuario</see></exception>
		Usuario AutenticarUsuario(string nombreUsuario, string password);

		/// <summary>
		/// Cambia el password del <see cref="Usuario">Usuario</see> especificado por el <code>nombreUsuario</code>.
		/// </summary>
		/// <param name="nombreUsuario">El nombre del <see cref="Usuario">Usuario</see> a autenticar</param>
		/// <param name="oldPassword">El password actual del <see cref="Usuario">Usuario</see></param>
		/// <param name="newPassword">El nuevo password a usar</param>
		/// <returns>El <see cref="Usuario">Usuario</see> con el password cambiado</returns>
		/// <exception cref="UsuarioNotFoundException">Si no existe ningún <see cref="Usuario">Usuario</see> con el <code>nombreUsuario</code> especificado</exception>
		/// <exception cref="LoginFailedException">Si el <code>oldPassword</code> no sirve para autenticar al <see cref="Usuario">Usuario</see></exception>
		Usuario ChangePassword(string nombreUsuario, string oldPassword, string newPassword);

		/// <summary>
		/// Busca <see cref="Usuario">Usuario</see>s en el sistema.
		/// </summary>
		/// <param name="templateUsuario">Un <see cref="Usuario">Usuario</see>s a usar como template de búsqueda</param>
		/// <returns>Una <see cref="IList">IList</see> de <see cref="Usuario">Usuario</see>s</returns>
		IList BuscarUsuarios(Usuario templateUsuario);

		/// <summary>
		/// Busca un <see cref="Usuario">Usuario</see> en el sistema, con un determinado nombre.
		/// </summary>
		/// <param name="nombreUsuario">El nombre del <see cref="Usuario">Usuario</see> buscado</param>
		/// <returns>El <see cref="Usuario">Usuario</see> buscado</returns>
		/// <exception cref="UsuarioNotFoundException">Si no existe ningún <see cref="Usuario">Usuario</see> con el <code>nombreUsuario</code> especificado</exception>
		Usuario BuscarPorNombre(string nombreUsuario);
	}
}