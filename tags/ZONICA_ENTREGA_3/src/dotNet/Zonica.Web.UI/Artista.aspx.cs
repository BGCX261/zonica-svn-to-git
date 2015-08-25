using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Zonica.Framework.Web.UI.BaseClasses;
using Zonica.Interfaces.Services;
using ModelArtista = Zonica.Model.Artista;
namespace Zonica.Web.UI
{
	/// <summary>
	/// Summary description for Artista.
	/// </summary>
	public class Artista : BasePage
	{
		protected System.Web.UI.WebControls.Label lblNombre;
		protected System.Web.UI.WebControls.Label lblNoEncontrado;
		protected System.Web.UI.WebControls.Panel pnlArtistaEncontrado;
		protected RatingGrid RatingTemasMusicales;
		protected RatingGrid RatingUsuarios;
		protected RatingGrid RatingAlbumes;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!this.IsPostBack)
			{
				if (this.Request.QueryString["id"] == null)
				{
					this.MostrarNoEncontrado();
					return;
				}
				int id = 0;
				try
				{
					id = int.Parse(this.Request.QueryString["id"]);
				}
				catch (Exception)
				{
					this.MostrarNoEncontrado();
				}
				ModelArtista artista = this.GetMusicaService().RetrieveArtista(id);
				if (artista == null)
				{
					this.MostrarNoEncontrado();
					return;
				}

				this.lblNombre.Text = artista.Nombre;
				
				IEscuchaService escuchaService = this.GetEscuchaService();
				this.RatingTemasMusicales.DataSource = escuchaService.RetrieveTemasMusicalesMasEscuchados(artista);
				this.RatingTemasMusicales.DataBind();

				this.RatingUsuarios.DataSource = escuchaService.RetrieveUsuariosMasActivos(artista);
				this.RatingUsuarios.DataBind();

				this.RatingAlbumes.DataSource = escuchaService.RetrieveAlbumesMasEscuchados(artista);
				this.RatingAlbumes.DataBind();
			}
		}

		private void MostrarNoEncontrado()
		{
			this.lblNoEncontrado.Visible = true;
			this.pnlArtistaEncontrado.Visible = false;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
