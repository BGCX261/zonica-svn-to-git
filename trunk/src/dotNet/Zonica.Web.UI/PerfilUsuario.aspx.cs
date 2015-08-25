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
using Zonica.Framework.Web.UI;
using Zonica.Framework.Web.UI.BaseClasses;
using Zonica.Model;
namespace Zonica.Web.UI
{
	/// <summary>
	/// Summary description for PerfilUsuario.
	/// </summary>
	public class PerfilUsuario : BasePage
	{
		protected System.Web.UI.WebControls.Label lblNombre;
		protected System.Web.UI.WebControls.Label lblNoEncontrado;
		protected RatingGrid RatingArtistas;
		protected RatingGrid rtgAmigos;
		protected RatingGrid rtgEscuchas;
		protected System.Web.UI.WebControls.Label lblNombreCompleto;
		protected System.Web.UI.WebControls.Label lblApodo;
		protected System.Web.UI.WebControls.Label lblProvincia;
		protected System.Web.UI.WebControls.Label lblCiudad;
		protected Label lblCantidadEscuchas; 
		protected RatingGrid RatingTemasMusicales;
		protected System.Web.UI.WebControls.Literal pnlNoHayContactos;
		protected System.Web.UI.WebControls.Repeater contactosList;
		protected System.Web.UI.WebControls.Panel pnlUsuarioEncontrado;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!this.IsPostBack)
			{
				if (this.Request.QueryString["id"] == null)
				{
					this.UsuarioNoEncontrado();
					return;
				}
				int parsedId = 0;
				try
				{
					parsedId = int.Parse(this.Request.QueryString["id"]);
				}
				catch (Exception)
				{
					this.UsuarioNoEncontrado();
					return;
				}

				Usuario usuario = this.GetUsuarioService().Retrieve(parsedId);
				if (usuario == null)
				{
					this.UsuarioNoEncontrado();
					return;
				}

				this.lblNombre.Text = usuario.Nombre;
				this.lblCantidadEscuchas.Text = usuario.Escuchas.Count.ToString();

				this.RatingArtistas.DataSource = this.GetEscuchaService().RetrieveArtistasMasEscuchados(usuario);
				this.RatingArtistas.DataBind();

				this.RatingTemasMusicales.DataSource = this.GetEscuchaService().RetrieveTemasMusicalesMasEscuchados(usuario);
				this.RatingTemasMusicales.DataBind();
				
				this.rtgAmigos.DataSource = this.GetEscuchaService().RetrieveAmigos(usuario);
				this.rtgAmigos.DataBind();
				
				this.rtgEscuchas.DataSource = this.GetEscuchaService().RetrieveUltimasEscuchas(usuario, 10);
				this.rtgEscuchas.DataBind();

				if (usuario.NombreCompleto != null && usuario.NombreCompleto != string.Empty)
					this.lblNombreCompleto.Text = usuario.NombreCompleto;
				if (usuario.Apodo != null && usuario.Apodo != string.Empty)
					this.lblApodo.Text = usuario.Apodo;
				if (usuario.Ciudad != null)
				{
					this.lblCiudad.Text = usuario.Ciudad.Nombre;
					this.lblProvincia.Text = usuario.Ciudad.Provincia.Nombre;
				}
				this.contactosList.DataSource = usuario.Contactos;
				this.contactosList.DataBind();
				if (this.contactosList.Items.Count == 0)
					this.pnlNoHayContactos.Visible = true;
			}
		}

		private void UsuarioNoEncontrado()
		{
			this.lblNoEncontrado.Visible = true;
			this.pnlUsuarioEncontrado.Visible = false;
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
