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
using System.ComponentModel;
using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Esta clase se usa para mostrar los rankings en forma ID:Nombre.
	/// </summary>
	public class ItemRanking : EntidadBaseNombrada, IEditableObject {
		/// <summary>
		/// El puntaje que tiene el item en el sistema
		/// </summary>
		private int valoracion;

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public ItemRanking() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="ItemRanking"/>.
		/// </summary>
		/// <param name="id">el <code>id</code> del <see cref="ItemRanking"/></param>
		/// <param name="nombre">el <code>nombre</code> del <see cref="ItemRanking"/></param>
		public ItemRanking(int id, string nombre) : base(id, nombre) {
			// Nothing to do
		}

		#endregion Constructores

		/// <summary>
		/// El puntaje que tiene el item en el sistema
		/// </summary>
		public int Valoracion {
			get { return valoracion; }
			set { valoracion = value; }
		}

		#region IEditableObject Members

		/// <see cref="IEditableObject.BeginEdit()"/>
		public void BeginEdit() {
			// Nothing to do
		}

		/// <see cref="IEditableObject.EndEdit()"/>
		public void EndEdit() {
			// Nothing to do
		}

		/// <see cref="IEditableObject.CancelEdit()"/>
		public void CancelEdit() {
			// Nothing to do
		}

		#endregion IEditableObject Members
	}
}