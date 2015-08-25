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

#endregion Usings

namespace Zonica.Sandbox.NHibernate.Mappings.Model {
	/// <summary>
	/// Foo.
	/// </summary>
	public class Foo {
		/// <summary>
		/// El id del Foo.
		/// </summary>
		private Int32 id;

		/// <summary>
		/// El Nombre del Foo
		/// </summary>
		private string nombre;

		/// <summary>
		/// El Bar de este Foo.
		/// </summary>
		private Bar bar;

		/// <summary>
		/// El Nombre del Foo
		/// </summary>
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// El id del Foo.
		/// </summary>
		public Int32 Id {
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// El Bar de este Foo.
		/// </summary>
		public Bar Bar {
			get { return bar; }
			set { bar = value; }
		}

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Foo() {
		}
	}
}