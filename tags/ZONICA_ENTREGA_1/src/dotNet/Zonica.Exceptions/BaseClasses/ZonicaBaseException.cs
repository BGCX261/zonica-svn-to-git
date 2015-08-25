using System;
using System.Runtime.Serialization;

namespace Zonica.Exceptions.BaseClasses {
	/// <summary>
	/// Excepción base para la aplicación Zónica.
	/// </summary>
	/// <see cref="ApplicationException" />
	public abstract class ZonicaBaseException : ApplicationException {
		/// <see cref="ApplicationException" />
		public ZonicaBaseException() : base() {}

		/// <see cref="ApplicationException" />
		public ZonicaBaseException(string message) : base(message) {}

		/// <see cref="ApplicationException" />
		public ZonicaBaseException(string message, Exception innerException) : base(message, innerException) {}

		/// <see cref="ApplicationException" />
		public ZonicaBaseException(SerializationInfo info, StreamingContext context) : base(info, context) {}
	}
}