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
using System.Text;

#endregion Usings

namespace Zonica.Framework.Util {
	/// <summary>
	/// Contiene métodos útiles para el manejo de <c>strings</c>.
	/// </summary>
	public class StringUtils {
		/// <summary>
		/// Tiene sólo métodos estáticos.
		/// </summary>
		private StringUtils() {
			// Nothing to do.
		}

		/// <summary>
		/// Pasa a mayúsculas las primeras letras de cada palabra del string enviado como parámetro.
		/// </summary>
		/// <param name="str">El <c>string</c> a cambiar</param>
		/// <returns>el <c>string</c> con las primeras letras de cada palabra en mayúscula</returns>
		public static string ToCamelCasePhrase(string str) {
			Validate.NotNull(str);

			// Primero Paso todo a minúsculas
			str = str.ToLower().Trim();
			if (str.Length == 0) {
				return str;
			}
			
			StringBuilder sb = new StringBuilder();

			string[] words = str.Split(' ');
			for (int i = 0; i < words.Length; i++) {
				if (words[i].Length == 0) {
					continue;
				}

				sb.AppendFormat("{0} ", CapitalizeFirstChar(words[i]));
			}

			return sb.ToString().Trim();
		}

		/// <summary>
		/// Pasa a mayúsculas la primer letra de la palabra.
		/// </summary>
		/// <param name="word">el <c>string</c> a cambiar</param>
		/// <returns>el string con la primer letra en mayúsculas</returns>
		public static string CapitalizeFirstChar(string word) {
			Validate.NotNull(word);

			// Primero Paso todo a minúsculas
			word = word.ToLower().Trim();
			if (word.Length == 0) {
				return word;
			}

			return word.Substring(0, 1).ToUpper() + word.Substring(1);
		}
	}
}