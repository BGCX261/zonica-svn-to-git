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
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using log4net;
using log4net.Config;
using Spring.Context;
using Spring.Context.Support;
using Zonica.Exceptions.BaseClasses;
using Zonica.Interfaces.Services;

#endregion Usings

namespace Zonica.Importer {
	/// <summary>
	/// Importa de los archivos de texto creados por el
	/// Proxy del plugin de Zónica la información musical de las escuchas de los
	/// usuarios de Zónica.
	/// </summary>
	public class MusicaImporter {
		private static readonly ILog log = LogManager.GetLogger(typeof (MusicaImporter));

		#region Default Config Values

		/// <summary>
		/// La máscara de búsqueda de archivos default.
		/// </summary>
		private static readonly string DEFAULT_FILE_PATTERN = "*.dat";

		/// <summary>
		/// El separador de campos del archivo default.
		/// </summary>
		private static readonly char DEFAULT_SEPARATOR_CHAR = '|';

		/// <summary>
		/// La máscara de formateo del instante de escucha default.
		/// </summary>
		private static readonly string DEFAULT_DATE_PARSING_MASK = "MM/dd/yy HH:mm:ss";

		/// <summary>
		/// Tiempo default entre ejecuciones.
		/// </summary>
		private static readonly int DEFAULT_SLEEP_TIME = 5000;

		#endregion Default Config Values

		#region Dictionary Keys

		/// <summary>
		/// Keys del diccionario de parámetros
		/// </summary>
		private static readonly string PATH_KEY = "PATH";

		private static readonly string FILE_PATTERN_KEY = "FILE_PATTERN";
		private static readonly string SEPARATOR_CHAR_KEY = "SEPARATOR_CHAR";
		private static readonly string DATE_PARSING_MASK_KEY = "DATE_PARSING_MASK";
		private static readonly string SLEEP_TIME_KEY = "SLEEP_TIME";
		private static readonly string IS_RERUN_KEY = "IS_RERUN";

		#endregion Dictionary Keys

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		private static void Main(string[] args) {
			// inicialización log4net
			XmlConfigurator.Configure();

			log.Info("Comenzando la ejecución...");
			IDictionary parameters = GetParameters(args);
			if (parameters == null) {
				// No se enviaron los parámetros mínimos indispensables
				// No se debe seguir con la ejecución
				return;
			}

			log.InfoFormat("Configurado con parámetros: {0}", parameters);

			try {
				using (IApplicationContext ctx = ContextRegistry.GetContext()) {
					IEscuchaService escuchaService = (IEscuchaService) ctx.GetObject("escuchaService");

					DirectoryInfo fd = new DirectoryInfo((string) parameters[PATH_KEY]);
					FileInfo[] fileInfos = fd.GetFiles((string) parameters[FILE_PATTERN_KEY]);
					log.InfoFormat("Importando {0} archivos de {1}.", fileInfos.Length, fd.Name);
					foreach (FileInfo fileInfo in fileInfos) {
						log.InfoFormat("Leyendo archivo {0}.", fileInfo.Name);
						FileStream fs = fileInfo.OpenRead();
						StreamReader sr = new StreamReader(fs);
						string[] datosDeEscucha = sr.ReadLine().Split((char) parameters[SEPARATOR_CHAR_KEY]);
						// HACK Si tiene mas de 7 comas (8 partes el split) es que los datos no son válidos
						// porque hay un título, nombre de album o artista que tiene comas !!!
						if (datosDeEscucha.Length != 8) {
							sr.Close();
							fileInfo.Delete();
							continue;
						}

						string inicio = datosDeEscucha[0] + " " + datosDeEscucha[1];
						DateTime momentoInicio = DateTime.ParseExact(inicio, (string) parameters[DATE_PARSING_MASK_KEY], CultureInfo.CurrentCulture);

						log.InfoFormat("Registrando escucha: {0}.", datosDeEscucha);
						try {
							escuchaService.RegistrarEscucha(datosDeEscucha[2], datosDeEscucha[3], datosDeEscucha[4], datosDeEscucha[6], datosDeEscucha[5], momentoInicio, 1);
						} catch (ZonicaBaseException e) {
							log.WarnFormat("Error de procesamiento de escucha {0}: {1}", datosDeEscucha, e.Message);
						}

						log.InfoFormat("Eliminando archivo {0}.", fileInfo.Name);
						sr.Close();
						fileInfo.Delete();
					}
				}
			} catch (Exception e) {
				log.FatalFormat("ERROR FATAL: {0}", e);
			}

			// Verifica si debe reejecutarse
			if ((bool) parameters[IS_RERUN_KEY]) {
				int sleepTime = (int) parameters[SLEEP_TIME_KEY];
				log.InfoFormat("Sleeping importador por {0} millis.", sleepTime);
				Thread.Sleep(sleepTime);
				Main(args);
			}
		}

		#region Utils

		/// <summary>
		/// Obtiene un <see cref="IDictionary"/> con los parámetros consolidados del importer.
		/// </summary>
		/// <param name="args">Los <code>args</code> recibidos por parámetro</param>
		/// <returns>Los parámetros de ejecución consolidados</returns>
		private static IDictionary GetParameters(string[] args) {
			IDictionary parameters = new Hashtable(args.Length);

			// Al menos debe llegar un valor
			if (args.Length < 2) {
				ImprimirAyuda();
				log.WarnFormat("Importador iniciado con parámetros incorrectos: {0}", args);
				return null;
			}

			if (args.Length >= 2) {
				// PATH y SLEEP_TIME
				parameters.Add(PATH_KEY, args[0]);
				string sleepTimeArg = args[1];
				if (sleepTimeArg.Equals("-1")) {
					parameters.Add(IS_RERUN_KEY, false);
					parameters.Add(SLEEP_TIME_KEY, -1);
				} else {
					parameters.Add(IS_RERUN_KEY, true);
					parameters.Add(SLEEP_TIME_KEY, Convert.ToInt32(args[1]));
				}
			}

			Object objectToAdd = null;
			if (args.Length >= 3) {
				// FILE_PATTERN
				objectToAdd = args[2];
			} else {
				objectToAdd = DEFAULT_FILE_PATTERN;
			}
			parameters.Add(FILE_PATTERN_KEY, objectToAdd);

			if (args.Length >= 4) {
				// SEPARATOR_CHAR
				objectToAdd = Convert.ToChar(args[3]);
			} else {
				objectToAdd = DEFAULT_SEPARATOR_CHAR;
			}
			parameters.Add(SEPARATOR_CHAR_KEY, objectToAdd);

			if (args.Length >= 5) {
				// DATE_PARSING_MASK
				objectToAdd = args[4];
			} else {
				objectToAdd = DEFAULT_DATE_PARSING_MASK;
			}
			parameters.Add(DATE_PARSING_MASK_KEY, objectToAdd);

			return parameters;
		}

		/// <summary>
		/// Imprime la página de ayuda.
		/// </summary>
		private static void ImprimirAyuda() {
			StringBuilder sb = new StringBuilder();
			sb.Append("Uso:\n");
			sb.Append("Zonica.Importer.MusicaImporter.exe PATH <SLEEP_TIME> <FILE_PATTERN> <SEPARATOR_CHAR> <DATE_PARSING_MASK>\n");
			sb.Append("  PATH - Path al directorio donde se encuentran los archivos de escuchas - Obligatorio\n");
			sb.AppendFormat("  SLEEP_TIME - Intervalo en milisegundos entre cada ejecución del Importador (default: {0}, con -1 no se vuelve a ejecutar) - Obligatorio\n", DEFAULT_SLEEP_TIME);
			sb.AppendFormat("  FILE_PATTERN - Patrón de búsqueda de archivos (default: {0}) - Opcional\n", DEFAULT_FILE_PATTERN);
			sb.AppendFormat("  SEPARATOR_CHAR - Caracter de separación de campos de archivo de escucha (default: {0}) - Opcional\n", DEFAULT_SEPARATOR_CHAR);
			sb.AppendFormat("  DATE_PARSING_MASK - Máscara de parseo de fecha (default: {0}) - Opcional\n", DEFAULT_DATE_PARSING_MASK);

			Console.WriteLine(sb);
		}

		#endregion Utils
	}
}