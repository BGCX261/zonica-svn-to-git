using System;

#region Copyright

/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>

#endregion Copyright
namespace Zonica.Sandbox.NHibernate.Mappings.Model {
	/// <summary>
	/// Bar.
	/// </summary>
	public class Bar {
		/// <summary>
		/// El id del Bar.
		/// </summary>
		private Int32 id;

		/// <summary>
		/// El Nombre del Bar
		/// </summary>
		private string nombre;

		/// <summary>
		/// El Foo de este Bar.
		/// </summary>
//		private Foo foo;

		/// <summary>
		/// El Nombre del Bar
		/// </summary>
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// El id del Bar.
		/// </summary>
		public Int32 Id {
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// El Foo de este Bar.
		/// </summary>
//		public Foo Foo {
//			get { return foo; }
//			set { foo = value; }
//		}

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Bar() {
		}
	}
}