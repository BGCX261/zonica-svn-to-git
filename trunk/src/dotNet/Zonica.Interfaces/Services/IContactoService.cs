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

using System.Collections;
using Zonica.Model;

#endregion Imports

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Implementa los métodos relacionados a la obtención de información sobre <see cref="TipoContacto">TipoContacto</see>s.
	/// </summary>
	public interface IContactoService : IService {

		IList RetrieveAllTipoContactos();

		TipoContacto RetrieveTipoContacto(int tipoContactoId);
	}
}
