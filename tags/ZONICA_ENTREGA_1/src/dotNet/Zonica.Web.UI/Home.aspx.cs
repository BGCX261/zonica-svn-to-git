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

using Zonica.Model;

namespace Zonica.Web.UI
{
	/// <summary>
	/// Summary description for Home.
	/// </summary>
	public class Home : System.Web.UI.Page
	{
		protected RatingGrid RatingArtistas;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//TODO: remove hard coded information and retrieve real information.
			ArrayList mockSource = new ArrayList();
			string[] nombres = new string[]{"Piola Vago", "Gilda", "Mike & the mechanics"};
			for (int i= 0; i<3; i++)
			{
				Artista art = new Artista();
				art.Nombre = nombres[i];
				mockSource.Add(art);
			}

			this.RatingArtistas.Title = "Artistas más escuchados";
			this.RatingArtistas.UrlTemplate = "Artista.aspx?Artista={0}";
			this.RatingArtistas.DataSource = mockSource;
			this.RatingArtistas.NameProperty = "Nombre";

			this.RatingArtistas.DataBind();

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
