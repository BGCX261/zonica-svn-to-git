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
using NHibernate;
using NHibernate.Expression;
using Zonica.Interfaces.Daos;
using Zonica.Model;

#endregion Usings

namespace Zonica.DAO {
	/// <see cref="IUsuarioDao" />
	/// <see cref="Dao" />
	/// <see cref="Usuario" />
	public class UsuarioDao : Dao, IUsuarioDao {
		#region Queries
		
		/// <summary>
		/// Query de cantidad de usuarios por fecha.
		/// </summary>
		private static readonly string CANTIDAD_USUARIOS_REGISTRADOS_POR_FECHA_QUERY = @"
			FROM
				Usuario
			WHERE
				fechaCreacion
				BETWEEN
					:fechaInicial
					AND :fechaFinal
			";
		
		#endregion Queries
		
		#region Constructores

		/// <summary>
		/// Constructor default.
		/// </summary>
		public UsuarioDao() : base() 
		{
			// Nothing to do
		}

		#endregion Constructores

		/// <see cref="Dao.MainType" />
		protected override Type MainType {
			get { return typeof (Usuario); }
		}

		/// <see cref="IUsuarioDao.SaveOrUpdate(Usuario)" />
		public void SaveOrUpdate(Usuario usuario) {
			base.SaveOrUpdate(usuario);
		}

		/// <see cref="IUsuarioDao.Retrieve(int)" />
		public Usuario Retrieve(int usuarioId) {
			return (Usuario) base.Retrieve(usuarioId);
		}

		/// <see cref="IUsuarioDao.Delete(Usuario)" />
		public void Delete(Usuario usuario) {
			base.Delete(usuario);
		}

		/// <see cref="IUsuarioDao.BuscarUsuarios(Usuario)" />
		public IList BuscarUsuarios(Usuario templateUsuario) {
			ICriteria criteria = this.HibernateTemplate.Session.CreateCriteria(typeof(Usuario));
			return criteria.Add(Example.Create(templateUsuario)).List();
		}

		/// <see cref="IUsuarioDao.BuscarPorNombre(string)" />
		public Usuario BuscarPorNombre(string nombreUsuario) {
			ICriteria criteria = this.HibernateTemplate.Session.CreateCriteria(typeof(Usuario));
			criteria.Add(new EqExpression("nombre", nombreUsuario, true));
			Usuario usuario = (Usuario) criteria.UniqueResult();

			return usuario;
		}

		/// <see cref="IUsuarioDao.BuscarPorEscuchaMusical(Escucha)" />
		public IList BuscarPorEscuchaMusical(Escucha templateEscuchaMusical) {
			throw new NotImplementedException("IUsuarioDao.BuscarPorEscuchaMusical(Escucha)");
		}

		/// <see cref="IUsuarioDao.GetCantidadUsuariosRegistrados(DateTime, DateTime)" />
		public int GetCantidadUsuariosRegistrados(DateTime fechaInicial, DateTime fechaFinal) {
//			IQuery query = this.HibernateTemplate.Session.GetNamedQuery("cantidadDeUsuariosRegistradosPorPeriodo");
			IQuery query = this.HibernateTemplate.Session.CreateQuery(
				CANTIDAD_USUARIOS_REGISTRADOS_POR_FECHA_QUERY);
			
			query.SetDateTime("fechaInicial", fechaInicial);
			query.SetDateTime("fechaFinal", fechaFinal);

			return query.List().Count;
		}
	}
}