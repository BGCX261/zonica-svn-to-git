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
using System.Text;

#endregion Usings

namespace Zonica.Framework.Util {
	/// <summary>
	/// Contiene m�todos �tiles para el manejo de <c>strings</c>.
	/// </summary>
	public class StringUtils {
		/// <summary>
		/// Tiene s�lo m�todos est�ticos.
		/// </summary>
		private StringUtils() {
			// Nothing to do.
		}

		/// <summary>
		/// Pasa a may�sculas las primeras letras de cada palabra del string enviado como par�metro.
		/// </summary>
		/// <param name="str">El <c>string</c> a cambiar</param>
		/// <returns>el <c>string</c> con las primeras letras de cada palabra en may�scula</returns>
		public static string ToCamelCasePhrase(string str) {
			Validate.NotNull(str);

			// Primero Paso todo a min�sculas
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
		/// Pasa a may�sculas la primer letra de la palabra.
		/// </summary>
		/// <param name="word">el <c>string</c> a cambiar</param>
		/// <returns>el string con la primer letra en may�sculas</returns>
		public static string CapitalizeFirstChar(string word) {
			Validate.NotNull(word);

			// Primero Paso todo a min�sculas
			word = word.ToLower().Trim();
			if (word.Length == 0) {
				return word;
			}

			return word.Substring(0, 1).ToUpper() + word.Substring(1);
		}
	}
}