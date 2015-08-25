using System;
using System.Web;
using log4net;
using Spring.Context;
using Spring.Context.Support;
using Zonica.Framework.Util;

namespace Zonica.Framework.Web {
	/// <summary>
	/// An HttpModule that handles NHibernate session connection with each request/response.
	/// It follows the pattern of session-per-request. 
	/// The session is placed under <see cref="NHContext"/>
	/// </summary>
	/// <remarks>
	/// To use this module in your ASP.NET application use 
	/// <httpModules>
	///		<add name="ZonicaHttpModule" type="Zonica.Framework.Web.ZonicaHttpModule, Zonica.Framework.Web"/> 
	///	</httpModules>
	/// </remarks>
	public class ZonicaHttpModule : IHttpModule {
		/// <summary>
		/// Logger de esta instancia
		/// </summary>
		private static readonly ILog log = LogManager.GetLogger(typeof (ZonicaHttpModule));

		/// <summary>
		/// Implements <see cref="IHttpModule"/> Init method.
		/// </summary>
		/// <param name="context">An System.Web.HttpApplication that provides access to the methods, 
		/// properties, and events common to all application objects within an ASP.NET application</param>
		public void Init(HttpApplication context) {
			log.Debug("Iniciando el contexto de Zónica...");
			//context.BeginRequest += new EventHandler(context_BeginRequest);
			//context.EndRequest += new EventHandler(context_EndRequest);
			context.Error += new EventHandler(context_Error);

			// Levanto el contexto de Spring
			log.Debug("Iniciando contexto de Spring...");
			using (IApplicationContext ctx = ContextRegistry.GetContext()) {
				ApplicationContext.getInstance().SpringApplicationContext = ctx;
			}
		}

		/// <summary>
		/// Dispose module resources.
		/// </summary>
		public void Dispose() {
			// void
		}

		/// <summary>
		/// Implements <see cref="IHttpModule">IHttpModule</see> <code>Init</code> method.
		/// </summary>
		private void context_Error(object sender, EventArgs e) {
			HttpContext ctx = HttpContext.Current;
			log.FatalFormat("Error en Zónica: ", ctx.Server.GetLastError());
		}
	}
}