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
using Zonica.Framework.Web.UI;

namespace Zonica.Web.UI
{
	/// <summary>
	/// Summary description for Home.
	/// </summary>
	public class Home : BasePage
	{
		protected System.Web.UI.WebControls.Panel pnlBienVenido;
		protected RatingGrid RatingArtistas;
		protected RatingGrid RatingTemasMusicales;
		protected RatingGrid rgrUsuariosActivos;
		protected Label lblCantidadArtistas;
		protected Label lblCantidadEscuchas;
		protected Label lblCantidadUsuarios;
		protected Label lblCantidadUsuariosDelDia;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!this.IsPostBack)
			{
				this.RatingArtistas.DataSource = this.GetEscuchaService().RetrieveArtistasMasEscuchados();
				this.RatingTemasMusicales.DataSource = this.GetEscuchaService().RetrieveTemasMusicalesMasEscuchados();

				this.RatingArtistas.DataBind();
				this.RatingTemasMusicales.DataBind();

				// RatingGrid de Usaurios mas activos
				this.rgrUsuariosActivos.DataSource = this.GetEscuchaService().RetrieveUsuariosMasActivos();
				this.rgrUsuariosActivos.DataBind();
			}
			
			this.lblCantidadArtistas.Text = Convert.ToString(this.GetMusicaService().RetrieveAllArtistas().Count);
			this.lblCantidadUsuarios.Text = Convert.ToString(this.GetUsuarioService().GetCantidadUsuariosRegistrados());
			this.lblCantidadUsuariosDelDia.Text = Convert.ToString(this.GetUsuarioService().GetCantidadUsuariosRegistradosHoy());
			this.lblCantidadEscuchas.Text = Convert.ToString(this.GetMusicaService().GetCantidadEscuchas());
			
			if (Session[SessionEntries.UserName] != null)
				this.pnlBienVenido.Visible = false;
			else
				this.pnlBienVenido.Visible = true;
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
