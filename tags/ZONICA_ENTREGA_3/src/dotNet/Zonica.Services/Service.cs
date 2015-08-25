#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingenier�a en Sistemas de Informaci�n
/// Proyecto Final
/// 
/// Grupo 4 - Z�nica
/// </summary>

#endregion Copyright

#region Usings

using Zonica.Interfaces.Services;

#endregion Usings

namespace Zonica.Services {
	/// <summary>
	/// Clase Base de todos los Services. Contiene los m�todos que deben implementar todos
	/// los Services del sistema Z�nica.
	/// </summary>
	public class Service : IService {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public Service() : base() {
			// Nothing to do
		}
	}
}