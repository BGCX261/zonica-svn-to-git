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

using Zonica.Model;

#endregion Usings

namespace Zonica.Interfaces.Daos {
	/// <summary>
	/// Interfaz del Servicio del objeto de negocio <see cref="Usuario">Usuario</see>.
	/// </summary>
	public interface IUsuarioDao : IDao {
		/// <summary>
		/// Obtiene todos los objetos <see cref="Usuario">Usuario</see> del
		/// sistema Zónica.
		/// </summary>
		new IList RetrieveAll();

		/// <summary>
		/// Obtiene el objeto <see cref="Usuario">Usuario</see> con el Id
		/// especificado del sistema Zónica.
		/// </summary>
		/// <param name="usuarioId">el Id del <see cref="Usuario">Usuario</see> a obtener</param>
		Usuario Retrieve(int usuarioId);

		/// <summary>
		/// Elimina al <see cref="Usuario">Usuario</see> especificado del
		/// sistema Zónica.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see> a
		/// eliminar</param>
		void Delete(Usuario usuario);

		/// <summary>
		/// Actualiza al objeto <see cref="Usuario">Usuario</see> especificado.
		/// </summary>
		/// <param name="usuario">el <see cref="Usuario">Usuario</see> a
		/// guardar</param>
		void SaveOrUpdate(Usuario usuario);

		/// 
		/// <param name="templateUsuario"></param>
		IList BuscarUsuarios(Usuario templateUsuario);

		/// <summary>
		/// Busca un usuario con un determinado <c>nombreUsuario</c>.
		/// </summary>
		/// <param name="nombreUsuario">el <c>nombre</c> del <see cref="Usuario">Usuario</see></param>
		/// <returns>El <see cref="Usuario">Usuario</see> buscado o <c>null</c> si no se encontró</returns>
		Usuario BuscarPorNombre(string nombreUsuario);

		/// 
		/// <param name="templateEscuchaMusical"></param>
		IList BuscarPorEscuchaMusical(Escucha templateEscuchaMusical);

		/// <summary>
		/// Obtiene la cantidad de usuarios registrados entre las fechas especificadas.
		/// </summary>
		/// <param name="fechaIncial">la fecha inicial del período</param>
		/// <param name="fechaFinal">la fecha final del período</param>
		/// <returns>la cantidad de usuarios registrados</returns>
		int GetCantidadUsuariosRegistrados(DateTime fechaIncial, DateTime fechaFinal);
	}
}