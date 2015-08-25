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
using Zonica.Exceptions;
using Zonica.Exceptions.Model;
using Zonica.Framework.Web.UI.BaseClasses;
using Zonica.Interfaces.Services;
using Zonica.Model;

namespace Zonica.Web.UI
{
	/// <summary>
	/// Page where user logs in.
	/// </summary>
	public class Login : BasePage
	{
		protected System.Web.UI.WebControls.TextBox txtUserName;
		protected System.Web.UI.WebControls.Button btnLogin;
		protected System.Web.UI.WebControls.RequiredFieldValidator UserNameValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.Label lblUserInvalid;
		protected System.Web.UI.WebControls.Label lblPasswordInvalid;
		protected System.Web.UI.WebControls.TextBox txtPassword;
	
		private void Page_Load(object sender, System.EventArgs e)
		{

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
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			if (Page.IsValid)
			{
				IUsuarioService usuarioService = this.GetUsuarioService();
				Usuario usuario;
				try {
					usuario = usuarioService.AutenticarUsuario(this.txtUserName.Text.Trim(),
						this.txtPassword.Text.Trim());

					Session[Global.SessionUserIdEntry] = this.txtUserName.Text.Trim();
					Response.Redirect("Home.aspx");
				} catch (UsuarioNotFoundException) {
					this.lblUserInvalid.Visible = true;
				} catch (LoginFailedException) {
					this.lblPasswordInvalid.Visible = true;
				}
			}
		}
	}
}
