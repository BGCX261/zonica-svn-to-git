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
			throw new NotImplementedException();
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

		public IList RetrieveAllArtistas() {
			throw new NotImplementedException();
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

		/// 
		/// <param name="estiloMusical"></param>
		public IList RetrieveArtistasByEstiloMusical(EstiloMusical estiloMusical) {
			throw new NotImplementedException();
		}

		/// 
		/// <param name="templateArtista"></param>
		public IList BuscarArtistas(Artista templateArtista) {
			ICriteria criteria = this.HibernateTemplate.Session.CreateCriteria(typeof(Artista));
			return criteria.Add(Example.Create(templateArtista)).List();
		}

		public IList BuscarTemasMusicales(TemaMusical template) {
			throw new NotImplementedException();
		}
	}
}