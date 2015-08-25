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
using Zonica.Interfaces.Daos;
using Zonica.Model;

#endregion Usings

namespace Zonica.DAO {
	/// <see cref="IEscuchaDao"/>
	/// <see cref="Dao"/>
	/// <see cref="Escucha"/>
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
			// Se usa este horrible hack porque hasta la fecha el método HibernateTemplate.FindByNamedQuery no está implementado (ver ItemRanking.hbm.xml) !
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("artistasMasEscuchados", "idPerfilUsuario", 0);
		}

		/// <see cref="IEscuchaDao.RetrieveArtistasMasEscuchados(Usuario)" />
		public IList RetrieveArtistasMasEscuchados(Usuario usuario) {
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("artistasMasEscuchadosPorPerfilUsuario", "idPerfilUsuario", usuario.PerfilUsuario.Id);
		}

		/// <see cref="IEscuchaDao.RetrieveAlbumesMasEscuchados()" />
		public IList RetrieveAlbumesMasEscuchados() {
			// Se usa este horrible hack porque hasta la fecha el método HibernateTemplate.FindByNamedQuery no está implementado (ver ItemRanking.hbm.xml) !
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("albumesMasEscuchados", "idPerfilUsuario", 0);
		}

		/// <see cref="IEscuchaDao.RetrieveAlbumesMasEscuchados(Usuario)" />
		public IList RetrieveAlbumesMasEscuchados(Usuario usuario) {
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("albumesMasEscuchadosPorPerfilUsuario", "idPerfilUsuario", usuario.PerfilUsuario.Id);
		}

		/// <see cref="IEscuchaDao.RetrieveTemasMusicalesMasEscuchados()" />
		public IList RetrieveTemasMusicalesMasEscuchados() {
			// Se usa este horrible hack porque hasta la fecha el método HibernateTemplate.FindByNamedQuery no está implementado (ver ItemRanking.hbm.xml) !
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("temasMusicalesMasEscuchados", "idPerfilUsuario", 0);
		}

		/// <see cref="IEscuchaDao.RetrieveTemasMusicalesMasEscuchados(Usuario)" />
		public IList RetrieveTemasMusicalesMasEscuchados(Usuario usuario) {
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("temasMusicalesMasEscuchadosPorPerfilUsuario", "idPerfilUsuario", usuario.PerfilUsuario.Id);
		}


		/// <see cref="IEscuchaDao.SaveOrUpdateEscucha(Escucha)" />
		public void SaveOrUpdateEscucha(Escucha escucha) {
			base.SaveOrUpdate(escucha);
		}

		/// <see cref="IEscuchaDao.RetrieveEscuchasByUsuario(Usuario, DateTime, DateTime)" />
		public IList RetrieveEscuchasByUsuario(Usuario usuario, DateTime fechaHasta, DateTime fechaDesde) {
			throw new NotImplementedException("RetrieveEscuchasByUsuario(Usuario, DateTime, DateTime)");
		}
	}
}