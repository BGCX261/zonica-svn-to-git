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

using System;
using System.Collections;
using System.Text;

using NHibernate;

using Spring.Context;
using Spring.Context.Support;

using Zonica.Interfaces.Services;
using Zonica.Model;

#endregion Usings

namespace Zonica.Test.Environment {
	/// <summary>
	/// Test de la integraci�n con Spring.
	/// </summary>
	internal class SpringTest {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			try {
				// Test code here
				using (IApplicationContext ctx = ContextRegistry.GetContext()) {
					//TestArtistasMasEscuchados(ctx);
					//TestTemasMasEscuchados(ctx);
					//TestAlbumesMasEscuchados(ctx);
					//TestArtistasMasEscuchadosPorUsuario(ctx);
					//TestTemasMasEscuchadosPorUsuario(ctx);
					//TestAlbumesMasEscuchadosPorUsuario(ctx);
					//TestUltimasEscuchasPorUsuario(ctx);
//					TestContactoUsuario(ctx);
					//TestPaises(ctx);
					TestRetrieveUsuariosMasActivos(ctx);
					//TestCrearUsuario(ctx);
//					TestAutenticacionUsuario(ctx);
					//TestBuscarUsuario(ctx);
					//TestEstiloMusical(ctx);
					//TestArtistaAlbum(ctx);
				}
			} catch (Exception ex) {
				Console.WriteLine(ex);
			} finally {
				Console.ReadLine();
			}
		}
		
		private static void TestCrearUsuario(IApplicationContext ctx) {
			IUsuarioService usuarioService = (IUsuarioService) ctx.GetObject("usuarioService");
			Usuario usuario = new Usuario();
			usuario.Nombre = "poligarcia";
			usuario.Password = "zonica";

			usuarioService.SaveOrUpdate(usuario);
		}

		private static void TestUltimasEscuchasPorUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			Usuario u = (Usuario) s.Get(typeof(Usuario), 0);
			IQuery q = s.GetNamedQuery("ultimasEscuchasPorUsuario");
			q.SetEntity("usuario", u);
			q.SetMaxResults(10);
			IList escuchas;
			while (true) {
				escuchas = q.List();
				foreach (Escucha escucha in escuchas) {
					Console.WriteLine("{0}.- {1}", escucha.Id, escucha.TemaMusical.Nombre);
				}

				Console.ReadLine();
			}
		}

		private static void TestPaises(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();
			StringBuilder sb = new StringBuilder();
			Pais p = (Pais) s.Load(typeof(Pais), 0);
			sb.AppendFormat("Provincias de {0}\n", p.Nombre);
			foreach (Provincia pr in p.Provincias) {
				sb.AppendFormat(" + {0}\n", pr.Nombre);
				if (pr.Ciudades.Count > 0) {
					sb.AppendFormat("  Ciudades de de {0}\n", pr.Nombre);
					foreach (Ciudad c in pr.Ciudades) {
						sb.AppendFormat("  - {0}\n", c.Nombre);
					}
				}
			}
			Console.WriteLine(sb);
		}

		private static void TestAutenticacionUsuario(IApplicationContext ctx) {
			IUsuarioService us = (IUsuarioService) ctx.GetObject("usuarioService");
			Usuario poligarcia = us.AutenticarUsuario("poligarcia", "zonica");
			Console.WriteLine(poligarcia);
		}

		private static void TestBuscarUsuario(IApplicationContext ctx) {
			IUsuarioService us = (IUsuarioService) ctx.GetObject("usuarioService");
			Usuario usuario = new Usuario();
			usuario.Nombre = "poligarcia";
			IList res = us.BuscarUsuarios(usuario);
			usuario = (Usuario) res[0];
			Console.WriteLine(usuario.Id);
		}

		private static void TestEstiloMusical(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			Console.WriteLine("Estilos:");
			IList estilos = s.CreateCriteria(typeof(EstiloMusical)).List();
			foreach (EstiloMusical em in estilos) {
				Console.WriteLine("{0}.- {1}", em.Id, em.Nombre);
			}

			Console.WriteLine();
			Console.WriteLine("Artistas:");
			IList artistas = s.CreateCriteria(typeof(Artista)).List();
			foreach (Artista a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
				foreach (EstiloMusical em in a.EstilosMusicales) {
					Console.WriteLine(" + {0}.- {1}", em.Id, em.Nombre);
				}
			}
		}

		private static void TestArtistaAlbum(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IList artistas = s.CreateCriteria(typeof(Artista)).List();
			foreach (Artista a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
				foreach (Album al in a.Albumes) {
					Console.WriteLine(" + {0}.- ({1}) {2}", al.Id, al.AnioPublicacion, al.Nombre);
				}
			}
		}

		private static void TestTemasMasEscuchados(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("temasMusicalesMasEscuchados");
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestArtistasMasEscuchados(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("artistasMasEscuchados");
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestAlbumesMasEscuchados(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("albumesMasEscuchados");
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestTemasMasEscuchadosPorUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("temasMusicalesMasEscuchadosPorUsuario");
			q.SetInt32(0, 2);
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestArtistasMasEscuchadosPorUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("artistasMasEscuchadosPorUsuario");
			q.SetInt32(0, 1);
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestAlbumesMasEscuchadosPorUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("albumesMasEscuchadosPorUsuario");
			q.SetInt32(0, 1);
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestContactoUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IUsuarioService usuarioService = (IUsuarioService) ctx.GetObject("usuarioService");
			IContactoService contactoService = (IContactoService) ctx.GetObject("contactoService");

			Usuario poli = usuarioService.Retrieve(0);

			foreach (ContactoUsuario cu in poli.Contactos) {
				Console.WriteLine("({0}) {1}", cu.TipoContacto.Nombre, cu.Nombre);
			}

			TipoContacto msn = (TipoContacto) s.Get(typeof(TipoContacto), 1);
			//contactoService.AgregarContacto(msn, poli, "poligarcia" + DateTime.Now.Millisecond + "@hotmail.com");
			ContactoUsuario contactoUsuario = new ContactoUsuario(msn, poli, "poligarcia" + DateTime.Now.Millisecond + "@hotmail.com");
			
			poli.Contactos.Add(contactoUsuario);
			
			usuarioService.SaveOrUpdate(poli);
		}
		
		private static void TestRetrieveUsuariosMasActivos(IApplicationContext ctx) {
			IEscuchaService escuchaService = (IEscuchaService) ctx.GetObject("escuchaService");
			Artista a = new Artista();
			a.Id = 4;
			IList list = escuchaService.RetrieveUsuariosMasActivos(a);
			foreach (ItemRanking item in list) {
				Console.WriteLine("{0} - {1}", item.Id, item.Nombre);
			}
		}
	}
}