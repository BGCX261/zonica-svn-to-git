///////////////////////////////////////////////////////////
//  EscuchaService.cs
//  Implementation of the Class EscuchaService
//  Generated by Enterprise Architect
//  Created on:      04-Sep-2006 21:22:00
///////////////////////////////////////////////////////////


using System;
using System.Collections;
using Zonica.Interfaces.Services;
using Zonica.Model;

namespace Zonica.Services {
	public class EscuchaService : Service, IEscuchaService {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public EscuchaService() : base() {}

		~EscuchaService() {}

		public override void Dispose() {}

		public IList RetrieveArtistasMasEscuchados() {
			return null;
		}

		public IList RetrieveTemasMusicalesMasEscuchados() {
			return null;
		}

		/// 
		/// <param name="escucha"></param>
		public void SaveOrUpdateEscucha(Escucha escucha) {}

		/// 
		/// <param name="usuario"></param>
		public IList RetrieveEscuchasByUsuario(Usuario usuario) {
			return null;
		}

		/// 
		/// <param name="usuario"></param>
		/// <param name="fechaHasta"></param>
		/// <param name="fechaDesde"></param>
		public IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde) {
			return null;
		}

	} //end EscuchaService

} //end namespace Zonica.Services