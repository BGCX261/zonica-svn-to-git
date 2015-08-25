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
	/// <see cref="IMusicaDao" />
	/// <see cref="Dao" />
	/// <see cref="TemaMusical" />
	/// <see cref="Album" />
	/// <see cref="Artista" />
	/// <see cref="EstiloMusical" />
	public class MusicaDao : Dao, IMusicaDao {
		/// <summary>
		/// Contructor default.
		/// </summary>
		public MusicaDao() : base() {
			// Nothing to do
		}

		/// <see cref="Dao.MainType" />
		/// <summary>
		/// El <code>Type</code> principal de este <code>Dao</code> es <code>Artista</code>.
		/// </summary>
		protected override Type MainType {
			get { return typeof (Artista); }
		}

		/// 
		/// <param name="idTemaMusical"></param>
		public TemaMusical RetrieveTemaMusical(int idTemaMusical) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="temaMusical"></param>
		public void SaveOrUpdateTemaMusical(TemaMusical temaMusical) {
			this.HibernateTemplate.SaveOrUpdate(temaMusical);
		}

		/// 
		/// <param name="temaMusical"></param>
		public void DeleteTemaMusical(TemaMusical temaMusical) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="artista"></param>
		public IList RetrieveTemasMusicalesByArtista(Artista artista) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="idArtista"></param>
		public Artista RetrieveArtista(int idArtista) {
			return (Artista) this.HibernateTemplate.Get(typeof(Artista), idArtista);
		}

		/// 
		/// <param name="artista"></param>
		public void SaveOrUpdateArtista(Artista artista) {
			this.HibernateTemplate.SaveOrUpdate(artista);
		}

		/// 
		/// <param name="artista"></param>
		public void DeleteArtista(Artista artista) {
			throw new NotImplementedException();
		}

		/// <see cref="IMusicaDao.RetrieveAllArtistas()" />
		public IList RetrieveAllArtistas() {
			return this.HibernateTemplate.LoadAll(typeof(Artista));
		}

		/// 
		/// <param name="idEstiloMusical"></param>
		public EstiloMusical RetrieveEstiloMusical(int idEstiloMusical) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="estiloMusical"></param>
		public void DeleteEstiloMusical(EstiloMusical estiloMusical) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="estiloMusical"></param>
		public void SaveOrUpdateEstiloMusical(EstiloMusical estiloMusical) {
			this.HibernateTemplate.SaveOrUpdate(estiloMusical);
		}

		/// 
		/// <param name="album"></param>
		public void SaveOrUpdateAlbum(Album album) {
			this.HibernateTemplate.SaveOrUpdate(album);
		}

		/// 
		/// <param name="album"></param>
		public void DeleteAlbum(Album album) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="idAlbum"></param>
		public Album RetrieveAlbum(int idAlbum) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="artista"></param>
		public IList RetrieveAlbumsByArtista(Artista artista) {
			throw new NotImplementedException();
		}

		/// <see cref="IMusicaDao.RetrieveArtistasByEstiloMusical(EstiloMusical)"/>
		public IList RetrieveArtistasByEstiloMusical(EstiloMusical estiloMusical) {
			Artista artista = new Artista();
			artista.EstilosMusicales.Add(estiloMusical);

			return this.BuscarArtistas(artista);
		}

		/// <see cref="IMusicaDao.BuscarArtistas(Artista)"/>
		public IList BuscarArtistas(Artista templateArtista) {
			ICriteria criteria = this.HibernateTemplate.Session.CreateCriteria(typeof(Artista));
			criteria.Add(new LikeExpression("nombre", templateArtista.Nombre, MatchMode.Anywhere));
			criteria.AddOrder(new Order("nombre", true));
			return criteria.List();
		}

		/// <see cref="IMusicaDao.BuscarTemasMusicales(TemaMusical)"/>
		public IList BuscarTemasMusicales(TemaMusical template) {
			ICriteria criteria = this.HibernateTemplate.Session.CreateCriteria(typeof(TemaMusical));
			return criteria.Add(Example.Create(template)).List();
		}
		
		/// <see cref="IMusicaDao.GetCantidadEscuchas()"/>
		public Int32 GetCantidadEscuchas() {
			return this.HibernateTemplate.LoadAll(typeof (Escucha)).Count;
		}

		/// <see cref="IMusicaDao.GetArtistasSimilaresA(int)"/>
		public IList GetArtistasSimilaresA(int id) {
			return this.HibernateTemplate.FindByNamedQueryAndNamedParam("artistasSimilares", "idArtista", id);
		}
	}
}