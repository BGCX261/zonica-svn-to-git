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
	/// Summary description for BuscarUnAmigo.
	/// </summary>
	public class BuscarAUnAmigo : BasePage
	{
		protected System.Web.UI.WebControls.TextBox txtBusqueda;
		protected System.Web.UI.WebControls.Button btnBuscar;
		protected System.Web.UI.WebControls.Label lblNoEncontrado;
		protected System.Web.UI.WebControls.DataGrid grdUsuarios;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.EnsureValidSession();
			// Put user code to initialize the page here
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
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnBuscar_Click(object sender, System.EventArgs e)
		{
			if (this.txtBusqueda.Text.Length > 0)
			{
				Usuario template = new Usuario();
				template.Nombre = this.txtBusqueda.Text;
				IList usuarios = this.GetUsuarioService().BuscarUsuarios(template);
				if (usuarios == null || usuarios.Count == 0)
					this.lblNoEncontrado.Visible = true;
				else
				{
					this.grdUsuarios.DataSource = usuarios;
					this.grdUsuarios.DataBind();
				}
			}
				//TODO: traer todos y mostrarlos
//			else
//				this.grdUsuarios.DataSource = this.GetUsuarioService().
//				this.grdArtistas.DataBind();

		}
	}
}
