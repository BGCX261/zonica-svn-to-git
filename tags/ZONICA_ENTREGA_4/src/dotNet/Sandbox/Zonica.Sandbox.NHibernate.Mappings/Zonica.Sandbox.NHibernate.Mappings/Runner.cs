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
using log4net;
using log4net.Config;
using NHibernate;
using NHibernate.Cfg;
using Zonica.Sandbox.NHibernate.Mappings.Model;

#endregion Usings

namespace Zonica.Sandbox.NHibernate.Mappings {
	/// <summary>
	/// Runner.
	/// </summary>
	internal class Runner {
		/// <summary>
		/// Un logger
		/// </summary>
		private static readonly ILog log = LogManager.GetLogger(typeof (Runner));

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			// log4net Config
			XmlConfigurator.Configure();

			// NHibernate Config
			try {
				Configuration cfg = new Configuration();
//				log.Info("Mapping Foo");
//				cfg.AddClass(typeof (Foo));
				log.Info("Mapping Bar");
				cfg.AddClass(typeof (Bar));

				ISessionFactory factory = cfg.BuildSessionFactory();
				ISession session = factory.OpenSession();

//				Foo foo = new Foo();
//				foo.Nombre = "Foo" + DateTime.Now.Millisecond;
				Bar bar = new Bar();
				bar.Nombre = "Bar" + DateTime.Now.Millisecond;

				//foo.Bar = bar;
				//bar.Foo = foo;

				//session.Save(foo);

				bar.Id = 33;
				session.Update(bar);

			} catch (Exception ex) {
				Console.WriteLine(ex);
			} finally {
				Console.ReadLine();
			}
		}
	}
}