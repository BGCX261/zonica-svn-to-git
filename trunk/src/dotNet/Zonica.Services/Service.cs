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

using Zonica.Interfaces.Services;

#endregion Usings

namespace Zonica.Services {
	/// <summary>
	/// Clase Base de todos los Services. Contiene los métodos que deben implementar todos
	/// los Services del sistema Zónica.
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