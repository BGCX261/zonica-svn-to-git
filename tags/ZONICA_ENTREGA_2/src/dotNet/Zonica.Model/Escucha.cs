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
using Zonica.Model.BaseClasses;

#endregion Usings

namespace Zonica.Model {
	/// <summary>
	/// Representa a la escucha de un tema musical en un instante particular y con una
	/// determinada valoración en el sistema Zónica.
	/// </summary>
	public class Escucha : EntidadBase {
		#region Campos privados

		/// <summary>
		/// El <see cref="PerfilUsuario">PerfilUsuario</see> que realizó la escucha
		/// </summary>
		private PerfilUsuario perfilUsuario;

		/// <summary>
		/// El <see cref="TemaMusical">TemaMusical</see> de la Escucha
		/// </summary>
		private TemaMusical temaMusical;

		/// <summary>
		/// Momento en que se realiza la escucha
		/// </summary>
		private DateTime momentoEscucha;

		/// <summary>
		/// Valoración de la escucha
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
		/// <param name="perfilUsuario">el <see cref="PerfilUsuario">PerfilUsuario</see></param>
		/// <param name="temaMusical">el <see cref="TemaMusical">TemaMusical</see></param>
		/// <param name="momentoEscucha">el momonto en que se inició la <see cref="Escucha">Escucha</see></param>
		/// <param name="valoracion">la valoración de la <see cref="Escucha">Escucha</see></param>
		public Escucha(PerfilUsuario perfilUsuario, TemaMusical temaMusical, DateTime momentoEscucha, short valoracion) : this() {
			this.PerfilUsuario = perfilUsuario;
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
		/// Obtiene/setea la valoración de la escucha.
		/// </summary>
		public short Valoracion {
			get { return valoracion; }
			set { valoracion = value; }
		}

		/// <summary>
		/// El <see cref="PerfilUsuario">PerfilUsuario</see> que realizó la escucha
		/// </summary>
		public PerfilUsuario PerfilUsuario {
			get { return perfilUsuario; }
			set { perfilUsuario = value; }
		}

		#endregion Propiedades
	}
}