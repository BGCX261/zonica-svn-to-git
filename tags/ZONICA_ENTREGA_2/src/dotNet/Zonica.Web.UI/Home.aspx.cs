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
using Zonica.Model;

namespace Zonica.Web.UI
{
	/// <summary>
	/// Summary description for Home.
	/// </summary>
	public class Home : BasePage
	{
		protected RatingGrid RatingArtistas;
		protected RatingGrid RatingTemasMusicales;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.CreateRatingArtistas();
			this.CreateRatingTemasMusicales();

			this.RatingArtistas.DataBind();
			this.RatingTemasMusicales.DataBind();

		}

		private void CreateRatingArtistas()
		{
			IList artistas = this.GetEscuchaService().RetrieveArtistasMasEscuchados();

			this.RatingArtistas.Title = "Artistas más escuchados";
			this.RatingArtistas.UrlTemplate = "Artista.aspx?Artista={0}";
			this.RatingArtistas.DataSource = artistas;
			this.RatingArtistas.NameProperty = "Nombre";
			this.RatingArtistas.IdentifierProperty = "Id";
		}

		private void CreateRatingTemasMusicales()
		{
			IList TemasMusicales = this.GetEscuchaService().RetrieveTemasMusicalesMasEscuchados();

			this.RatingTemasMusicales.Title = "Canciones más escuchadas";
			this.RatingTemasMusicales.UrlTemplate = "Cancion.aspx?Cancion={0}";
			this.RatingTemasMusicales.DataSource = TemasMusicales;
			this.RatingTemasMusicales.NameProperty = "Nombre";
			this.RatingTemasMusicales.IdentifierProperty = "Id";
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
