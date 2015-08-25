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

using System.Collections;
using Zonica.Model;

#endregion Usings

namespace Zonica.Interfaces.Daos {
	/// <summary>
	/// Define la interfaz del DAO que permite acceder al modelo de datos de una <see cref="ContactoUsuario">ContactoUsuario</see>.
	/// </summary>
	public interface IContactoDao : IDao {
		/// <summary>
		/// Guarda un <see cref="ContactoUsuario">ContactoUsuario</see> en la base de datos.
		/// </summary>
		/// <param name="contactoUsuario">El <see cref="ContactoUsuario">ContactoUsuario</see> a guardar</param>
		void SaveOrUpdate(ContactoUsuario contactoUsuario);

		/// <summary>
		/// Obtiene una lista con los <see cref="TipoContacto">TipoContacto</see>s del sistema.
		/// </summary>
		/// <returns>una lista de <see cref="TipoContacto">TipoContacto</see>s</returns>
		IList GetTipoContactos();

		TipoContacto RetrieveTipoContacto(int idTipoContacto);
	}
}