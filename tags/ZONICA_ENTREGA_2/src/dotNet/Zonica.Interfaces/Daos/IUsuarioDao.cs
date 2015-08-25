/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>


using System.Collections;
using Zonica.Model;

namespace Zonica.Interfaces.Daos {
	/// <summary>
	/// Interfaz del Servicio del objeto de negocio <see cref="Zonica.Model.
	/// Usuario">Usuario</see>.
	/// </summary>
	public interface IUsuarioDao : IDao {
		/// <summary>
		/// Obtiene todos los objetos <see cref="Zonica.Model.Usuario">Usuario</see> del
		/// sistema Zónica.
		/// </summary>
		new IList RetrieveAll();

		/// <summary>
		/// Obtiene el objeto <see cref="Zonica.Model.Usuario">Usuario</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="usuarioId">el Id del <see cref="Zonica.Model.
		/// Usuario">Usuario</see> a obtener</param>
		Usuario Retrieve(int usuarioId);

		/// <summary>
		/// Elimina al <see cref="Zonica.Model.Usuario">Usuario</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="usuario">el <see cref="Zonica.Model.Usuario">Usuario</see> a
		/// eliminar</param>
		void Delete(Usuario usuario);

		/// <summary>
		/// Actualiza al objeto <see cref="Zonica.Model.Usuario">Usuario</see> especificado.
		/// 
		/// </summary>
		/// <param name="usuario">el <see cref="Zonica.Model.Usuario">Usuario</see> a
		/// guardar</param>
		void SaveOrUpdate(Usuario usuario);

		/// 
		/// <param name="usuario"></param>
		/// <param name="oldPassword"></param>
		/// <param name="newPassword"></param>
		Usuario ChangePassword(Usuario usuario, string oldPassword, string newPassword);

		/// 
		/// <param name="templateUsuario"></param>
		IList BuscarUsuarios(Usuario templateUsuario);

		/// 
		/// <param name="nombreUsuario"></param>
		Usuario BuscarPorNombre(string nombreUsuario);

		/// 
		/// <param name="templateEscuchaMusical"></param>
		IList BuscarPorEscuchaMusical(Escucha templateEscuchaMusical);
	} //end IUsuarioDao

} //end namespace Daos