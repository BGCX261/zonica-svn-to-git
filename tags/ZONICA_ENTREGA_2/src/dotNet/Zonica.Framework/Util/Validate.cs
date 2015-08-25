using System;
using System.Collections;

/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>
namespace Zonica.Framework.Util {
	/// <summary>
	/// Helper de validación de argumentos.
	/// </summary>
	public class Validate {
		/// <summary>
		/// Constructor privado, tiene métodos estáticos.
		/// </summary>
		private Validate() {}

		/// <summary>
		/// Valida un argumento, lanzando <see cref="ArgumentNullException">ArgumentNullException</see> si el mismo es <code>null</code>.
		/// </summary>
		/// <param name="obj">El objeto a verificar</param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NotNull(Object obj, String message) {
			if (obj == null) {
				throw new ArgumentNullException(message);
			}
		}

		/// <summary>
		/// Valida un argumento, lanzando <see cref="ArgumentNullException">ArgumentNullException</see> si el mismo es <code>null</code>.
		/// </summary>
		/// <param name="obj">El objeto a verificar</param>
		public static void NotNull(Object obj) {
			Validate.NotNull(obj, "El objeto validado es null.");
		}

		/// <summary>
		/// Valida el <code>array</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si el mismo es <code>null</code> o está vacío.
		/// </summary>
		/// <param name="array">El <code>array</code> a validar, distinto de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NotEmpty(Object[] array, String message) {
			if (array == null || array.Length == 0) {
				throw new ArgumentException(message);
			}
		}

		/// <summary>
		/// Valida el <code>array</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si el mismo es <code>null</code> o está vacío.
		/// </summary>
		/// <param name="array">El <code>array</code> a validar, distinto de <code>null</code></param>
		public static void NotEmpty(Object[] array) {
			Validate.NotEmpty(array, "El arreglo validado está vacío.");
		}

		/// <summary>
		/// Valida la <code>collection</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si la misma es <code>null</code> o está vacía.
		/// </summary>
		/// <param name="collection">La <see cref="ICollection">ICollection</see> a validar, distinta de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NotEmpty(ICollection collection, String message) {
			if (collection == null || collection.Count == 0) {
				throw new ArgumentException(message);
			}
		}

		/// <summary>
		/// Valida la <code>collection</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si la misma es <code>null</code> o está vacía.
		/// </summary>
		/// <param name="collection">La <see cref="ICollection">ICollection</see> a validar, distinta de <code>null</code></param>
		public static void NotEmpty(ICollection collection) {
			Validate.NotEmpty(collection, "La colección validada está vacía.");
		}

		/// <summary>
		/// Valida el <code>dictionary</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si el mismo es <code>null</code> o está vacío.
		/// </summary>
		/// <param name="dictionary">El <see cref="IDictionary">IDictionary</see> a validar, distinto de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NotEmpty(IDictionary dictionary, String message) {
			if (dictionary == null || dictionary.Count == 0) {
				throw new ArgumentException(message);
			}
		}

		/// <summary>
		/// Valida el <code>dictionary</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si el mismo es <code>null</code> o está vacío.
		/// </summary>
		/// <param name="dictionary">El <see cref="IDictionary">IDictionary</see> a validar, distinto de <code>null</code></param>
		public static void NotEmpty(IDictionary dictionary) {
			Validate.NotEmpty(dictionary, "El diccionario validado está vacío.");
		}

		/// <summary>
		/// Valida el <code>str</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si la misma es <code>null</code> o está vacía.
		/// </summary>
		/// <param name="str">El <see cref="string">string</see> a validar, distinto de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NotEmpty(String str, String message) {
			if (str == null || str.Length == 0) {
				throw new ArgumentException(message);
			}
		}

		/// <summary>
		/// Valida el <code>str</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si la misma es <code>null</code> o está vacía.
		/// </summary>
		/// <param name="str">El <see cref="string">string</see> a validar</param>
		public static void NotEmpty(String str) {
			Validate.NotEmpty(str, "La cadena de caracteres validada está vacía.");
		}

		/// <summary>
		/// Valida el <code>array</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si el mismo es <code>null</code> o si contiene algún elemento <code>null</code>.
		/// </summary>
		/// <param name="array">El <code>array</code> a validar, distinto de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NoNullElements(Object[] array, String message) {
			Validate.NotNull(array);
			for (int i = 0; i < array.Length; i++) {
				if (array[i] == null) {
					throw new ArgumentException(message);
				}
			}
		}

		/// <summary>
		/// Valida el <code>array</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si el mismo es <code>null</code> o si contiene algún elemento <code>null</code>.
		/// </summary>
		/// <param name="array">El <code>array</code> a validar, distinto de <code>null</code></param>
		public static void NoNullElements(Object[] array) {
			Validate.NoNullElements(array, "El arreglo enviado como parámetro es null o uno de sus elementos es null.");
		}

		/// <summary>
		/// Valida la <see cref="ICollection">ICollection</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si la misma es <code>null</code> o si contiene algún elemento <code>null</code>.
		/// </summary>
		/// <param name="collection">La <see cref="ICollection">ICollection</see> a validar, distinta de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void NoNullElements(ICollection collection, String message) {
			Validate.NotNull(collection, message);
			for (IEnumerator it = collection.GetEnumerator(); it.MoveNext(); ) {
				if (it.Current == null) {
					throw new ArgumentException(message);
				}
			}
		}

		/// <summary>
		/// Valida la <see cref="ICollection">ICollection</code>, lanzando una <see cref="ArgumentException">ArgumentException</see> si la misma es <code>null</code> o si contiene algún elemento <code>null</code>.
		/// </summary>
		/// <param name="collection">La <see cref="ICollection">ICollection</see> a validar, distinta de <code>null</code></param>
		public static void NoNullElements(ICollection collection) {
			Validate.NoNullElements(collection, "La colección validada es null o uno de sus elementos es null.");
		}

		/// <summary>
		/// Valida cada elemento de la <see cref="ICollection">ICollection</see>, lanzando una <see cref="ArgumentException">ArgumentException</see> si alguno de sus elementos no es de tipo <code>clazz</code>.
		/// </summary>
		/// <param name="collection">La <see cref="ICollection">ICollection</see> a validar, distinta de <code>null</code></param>
		/// <param name="clazz">El tipo que se espera que sean los elementos de <code>collection</code>, distinto de <code>null</code></param>
		/// <param name="message">El mensaje a mostrar en caso de que la validación falle</param>
		public static void AllElementsOfType(ICollection collection, Type clazz, String message) {
			Validate.NotNull(collection);
			Validate.NotNull(clazz);
			for (IEnumerator it = collection.GetEnumerator(); it.MoveNext(); ) {
				if (clazz.IsAssignableFrom(it.Current.GetType())) {
					throw new ArgumentException(message);
				}
			}
		}

		/// <summary>
		/// Valida cada elemento de la <see cref="ICollection">ICollection</see>, lanzando una <see cref="ArgumentException">ArgumentException</see> si alguno de sus elementos no es de tipo <code>clazz</code>.
		/// </summary>
		/// <param name="collection">La <see cref="ICollection">ICollection</see> a validar, distinta de <code>null</code></param>
		/// <param name="clazz">El tipo que se espera que sean los elementos de <code>collection</code>, distinto de <code>null</code></param>
		public static void AllElementsOfType(ICollection collection, Type clazz) {
			Validate.AllElementsOfType(collection, clazz, "La colección validada contiene un elemento que no es de tipo '" + clazz + "'.");
		}
	}
}