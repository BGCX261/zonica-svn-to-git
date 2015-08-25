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
using Spring.Context.Support;
using Zonica.Framework.Util;
using Zonica.Interfaces.Services;

#endregion Usings

namespace Zonica.Framework.Web {
	/// <summary>
	/// Contexto web de la aplicación Zónica.
	/// </summary>
	public class ZonicaWebContext {
		/// <summary>
		/// Key del IUsuarioService en el contexto de Spring.
		/// </summary>
		private static readonly String USUARIO_SVC_KEY = "usuarioService";

		/// <summary>
		/// Key del IMusicaService en el contexto de Spring.
		/// </summary>
		private static readonly String MUSICA_SVC_KEY = "musicaService";

		/// <summary>
		/// Key del ILocalidadService en el contexto de Spring.
		/// </summary>
		private static readonly String LOCALIDAD_SVC_KEY = "localidadService";

		/// <summary>
		/// Key del IEscuchaService en el contexto de Spring.
		/// </summary>
		private static readonly String ESCUCHA_SVC_KEY = "escuchaService";

		private static readonly String CONTACTO_SVC_KEY = "contactoService";

		/// <summary>
		/// Constructor default.
		/// Es private para no crear instancias.
		/// </summary>
		private ZonicaWebContext() {
			// Nothing to do.
		}

		/// <summary>
		/// Obtiene un objeto del contexto de Spring con la key especificada.
		/// </summary>
		/// <param name="key">La key del objeto a obtener</param>
		/// <returns>el objeto buscado</returns>
		private static Object GetObject(string key) {
			Validate.NotNull(key);
			return WebApplicationContext.Current.GetObject(key);
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="IUsuarioService">IUsuarioService</see>.
		/// </summary>
		/// <returns>el <see cref="IUsuarioService">IUsuarioService</see></returns>
		public static IUsuarioService GetUsuarioService() {
			return (IUsuarioService) GetObject(USUARIO_SVC_KEY);
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="IMusicaService">IMusicaService</see>.
		/// </summary>
		/// <returns>el <see cref="IMusicaService">IMusicaService</see></returns>
		public static IMusicaService GetMusicaService() {
			return (IMusicaService) GetObject(MUSICA_SVC_KEY);
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="ILocalidadService">ILocalidadService</see>.
		/// </summary>
		/// <returns>el <see cref="ILocalidadService">ILocalidadService</see></returns>
		public static ILocalidadService GetLocalidadService() {
			return (ILocalidadService) GetObject(LOCALIDAD_SVC_KEY);
		}

		/// <summary>
		/// Obtiene una instancia del <see cref="IEscuchaService">IEscuchaService</see>.
		/// </summary>
		/// <returns>el <see cref="IEscuchaService">IEscuchaService</see></returns>
		public static IEscuchaService GetEscuchaService() {
			return (IEscuchaService) GetObject(ESCUCHA_SVC_KEY);
		}

		public static IContactoService GetContactoService() {
			return (IContactoService) GetObject(CONTACTO_SVC_KEY);
		}
	}
}
