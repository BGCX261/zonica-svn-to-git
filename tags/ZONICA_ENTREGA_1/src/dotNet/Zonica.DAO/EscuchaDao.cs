/// <summary>
/// UTN Frba 2006
/// Ingeniería en Sistemas de Información
/// Proyecto Final
/// 
/// Grupo 4 - Zónica
/// </summary>


using System;
using System.Collections;
using Zonica.Interfaces.Daos;
using Zonica.Model;

namespace Zonica.DAO {
	public class EscuchaDao : Dao, IEscuchaDao {
		/// <summary>
		/// Constructor default.
		/// </summary>
		public EscuchaDao() : base() {
			// Nothing to do
		}

		/// <see cref="Dao.MainType" />
		/// <summary>
		/// El <code>Type</code> principal de este <code>Dao</code> es <code>Escucha</code>.
		/// </summary>
		protected override Type MainType {
			get { return typeof (Escucha); }
		}

		/// <see cref="IEscuchaDao.RetrieveArtistasMasEscuchados()" />
		public IList RetrieveArtistasMasEscuchados() {
			return null;
		}

		/// <see cref="IEscuchaDao.RetrieveTemasMusicalesMasEscuchados()" />
		public IList RetrieveTemasMusicalesMasEscuchados() {
			return null;
		}


		/// <see cref="IEscuchaDao.SaveOrUpdateEscucha(Escucha)" />
		public void SaveOrUpdateEscucha(Escucha escucha) {
			base.SaveOrUpdate(escucha);
		}

		/// <see cref="IEscuchaDao.RetrieveEscuchasByUsuario(Usuario)" />
		public IList RetrieveEscuchasByUsuario(Usuario usuario) {
			return null;
		}

		/// <see cref="IEscuchaDao.RetrieveEscuchasByUsuario(Usuario, DateTime, DateTime)" />
		public IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde) {
			return null;
		}
	}
}