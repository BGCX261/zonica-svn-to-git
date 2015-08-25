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
using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Representa a la escucha de un tema musical en un instante particular y con una
	/// determinada valoraci�n en el sistema Z�nica.
	/// </summary>
	public class Escucha : EntidadBase {
		#region Campos privados

		/// <summary>
		/// El <see cref="Usuario">Usuario</see> que realiz� la escucha
		/// </summary>
		private Usuario usuario;

		/// <summary>
		/// El <see cref="TemaMusical">TemaMusical</see> de la Escucha
		/// </summary>
		private TemaMusical temaMusical;

		/// <summary>
		/// Momento en que se realiza la escucha
		/// </summary>
		private DateTime momentoEscucha;

		/// <summary>
		/// Valoraci�n de la escucha
		/// </summary>
		private short valoracion;

		#endregion Campos privados

		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public Escucha() : base() {
			// Nothing to do
		}

		/// <summary>
		/// Crea una instancia de <see cref="Escucha">Escucha</see>.
		/// </summary>
		/// <param name="Usuario">el <see cref="Usuario">Usuario</see></param>
		/// <param name="temaMusical">el <see cref="TemaMusical">TemaMusical</see></param>
		/// <param name="momentoEscucha">el momonto en que se inici� la <see cref="Escucha">Escucha</see></param>
		/// <param name="valoracion">la valoraci�n de la <see cref="Escucha">Escucha</see></param>
		public Escucha(Usuario Usuario, TemaMusical temaMusical, DateTime momentoEscucha, short valoracion) : this() {
			this.Usuario = Usuario;
			this.TemaMusical = temaMusical;
			this.MomentoEscucha = momentoEscucha;
			this.Valoracion = valoracion;
		}

		#endregion Constructores

		#region Propiedades

		/// <summary>
		/// Obtiene/setea al <see cref="TemaMusical">TemaMusical</see> de la Escucha.
		/// </summary>
		public TemaMusical TemaMusical {
			get { return temaMusical; }
			set { temaMusical = value; }
		}

		/// <summary>
		/// Obtiene/setea el momento en que se realiza la escucha.
		/// </summary>
		public DateTime MomentoEscucha {
			get { return momentoEscucha; }
			set { momentoEscucha = value; }
		}

		/// <summary>
		/// Obtiene/setea la valoraci�n de la escucha.
		/// </summary>
		public short Valoracion {
			get { return valoracion; }
			set { valoracion = value; }
		}

		/// <summary>
		/// El <see cref="Usuario">Usuario</see> que realiz� la escucha
		/// </summary>
		public Usuario Usuario {
			get { return this.usuario; }
			set { this.usuario = value; }
		}

		#endregion Propiedades
	}
}