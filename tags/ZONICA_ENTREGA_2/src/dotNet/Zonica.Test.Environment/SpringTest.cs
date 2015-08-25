/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

using System;
using System.Collections;
using System.Text;
using NHibernate;
using Spring.Context;
using Spring.Context.Support;
using Zonica.Interfaces.Services;
using Zonica.Model;

namespace Zonica.Test.Environment {
	/// <summary>
	/// Test de la integración con Spring.
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
					//TestArtistasMasEscuchadosPorPerfilUsuario(ctx);
					//TestTemasMasEscuchadosPorPerfilUsuario(ctx);
					//TestAlbumesMasEscuchadosPorPerfilUsuario(ctx);
				}
			} catch (Exception ex) {
				Console.WriteLine(ex);
			} finally {
				Console.ReadLine();
			}
		}

		private static void TestPaises(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();
			StringBuilder sb = new StringBuilder();
			Pais p = (Pais) s.Load(typeof (Pais), 0);
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
			IList estilos = s.CreateCriteria(typeof (EstiloMusical)).List();
			foreach (EstiloMusical em in estilos) {
				Console.WriteLine("{0}.- {1}", em.Id, em.Nombre);
			}

			Console.WriteLine();
			Console.WriteLine("Artistas:");
			IList artistas = s.CreateCriteria(typeof (Artista)).List();
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

			IList artistas = s.CreateCriteria(typeof (Artista)).List();
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

		private static void TestTemasMasEscuchadosPorPerfilUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("temasMusicalesMasEscuchadosPorPerfilUsuario");
			q.SetInt32(0, 2);
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestArtistasMasEscuchadosPorPerfilUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("artistasMasEscuchadosPorPerfilUsuario");
			q.SetInt32(0, 1);
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}

		private static void TestAlbumesMasEscuchadosPorPerfilUsuario(IApplicationContext ctx) {
			ISessionFactory sf = (ISessionFactory) ctx.GetObject("sessionFactory");
			ISession s = sf.OpenSession();

			IQuery q = s.GetNamedQuery("albumesMasEscuchadosPorPerfilUsuario");
			q.SetInt32(0, 1);
			IList artistas = q.List();
			foreach (ItemRanking a in artistas) {
				Console.WriteLine("{0}.- {1}", a.Id, a.Nombre);
			}
		}
	}
}