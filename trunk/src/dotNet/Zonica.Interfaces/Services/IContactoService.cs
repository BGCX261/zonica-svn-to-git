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

using System.Collections;
using Zonica.Model;

#endregion Imports

namespace Zonica.Interfaces.Services {
	/// <summary>
	/// Implementa los m�todos relacionados a la obtenci�n de informaci�n sobre <see cref="TipoContacto">TipoContacto</see>s.
	/// </summary>
	public interface IContactoService : IService {

		IList RetrieveAllTipoContactos();

		TipoContacto RetrieveTipoContacto(int tipoContactoId);
	}
}
