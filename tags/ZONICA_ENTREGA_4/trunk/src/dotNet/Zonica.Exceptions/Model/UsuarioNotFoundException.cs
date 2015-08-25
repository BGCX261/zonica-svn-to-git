using System;
using System.Runtime.Serialization;
using Zonica.Exceptions.BaseClasses.Model;
using Zonica.Model;

namespace Zonica.Exceptions.Model {
	/// <summary>
	/// Lanzada cuando no se encuantra un Usuario.
	/// </summary>
	public class UsuarioNotFoundException : EntityNotFoundException {
		/// <summary>
		/// La clase que representa a esta excepción de tipo <see cref="EntityNotFoundException"/>
		/// </summary>
		private static readonly Type MY_CLAZZ = typeof (Usuario);

		/// <see cref="EntityNotFoundException" />
		public UsuarioNotFoundException() : base(MY_CLAZZ) {}

		/// <see cref="EntityNotFoundException" />
		public UsuarioNotFoundException(string message) : base(MY_CLAZZ, message) {}

		/// <see cref="EntityNotFoundException" />
		public UsuarioNotFoundException(string message, Exception innerException) : base(MY_CLAZZ, message, innerException) {}

		/// <see cref="EntityNotFoundException" />
		public UsuarioNotFoundException(SerializationInfo info, StreamingContext context) : base(MY_CLAZZ, info, context) {}
	}
}