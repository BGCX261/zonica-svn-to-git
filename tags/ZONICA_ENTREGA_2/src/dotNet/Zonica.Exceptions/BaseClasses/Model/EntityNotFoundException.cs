using System;
using System.Runtime.Serialization;

namespace Zonica.Exceptions.BaseClasses.Model {
	/// <summary>
	/// Excepción lanzada por los servicios cuando no se encuerntra una entidad de tipo <code>clazz</code>.
	/// </summary>
	// TODO Agregar el parámetro ID !!!
	public abstract class EntityNotFoundException : ZonicaBaseException {
		/// <summary>
		/// El <see cref="Type"/> de la entidad no encontrada.
		/// </summary>
		private Type clazz;

		/// <summary>
		/// Template del mensaje a mostrar default.
		/// </summary>
		public readonly static string MESSAGE_TEMPLATE = "No se encontró una entidad de tipo {0} con id {1}.";

		/// <summary>
		/// El <see cref="Type"/> de la entidad no encontrada.
		/// </summary>
		public Type Clazz {
			get { return clazz; }
			set { clazz = value; }
		}

		/// <see cref="ApplicationException" />
		public EntityNotFoundException(Type clazz) : this(clazz, String.Format(MESSAGE_TEMPLATE, clazz.ToString(), String.Empty)) {}

		/// <see cref="ApplicationException" />
		public EntityNotFoundException(Type clazz, string message) : base(message) {
			this.clazz = clazz;
		}

		/// <see cref="ApplicationException" />
		public EntityNotFoundException(Type clazz, string message, Exception innerException) : base(message, innerException) {
			this.clazz = clazz;
		}

		/// <see cref="ApplicationException" />
		public EntityNotFoundException(Type clazz, SerializationInfo info, StreamingContext context) : base(info, context) {
			this.clazz = clazz;
		}
	}
}