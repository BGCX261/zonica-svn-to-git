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
	/// Summary description for Registro.
	/// </summary>
	public class Registro : BasePage
	{
		protected System.Web.UI.WebControls.Panel pnlStep0;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Panel pnlStep1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Panel pnlStep2;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button5;
		protected System.Web.UI.WebControls.TextBox txtUserName;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator UserNameValidator1;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.TextBox txtConfirmPassword;
		protected System.Web.UI.WebControls.RequiredFieldValidator Requiredfieldvalidator2;
		protected System.Web.UI.WebControls.LinkButton lnkDownload;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button6;
		protected System.Web.UI.WebControls.Panel pnlStep3;
		protected System.Web.UI.WebControls.Button btnSiguiente;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
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
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.lnkDownload.Click += new System.EventHandler(this.lnkDownload_Click);
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnSiguiente_Click(object sender, System.EventArgs e)
		{
			this.ActivatePanel(this.pnlStep1);
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Usuario usuario = new Usuario();
			usuario.Nombre = this.txtUserName.Text.Trim();
			usuario.Password = this.txtPassword.Text.Trim();

			this.GetUsuarioService().SaveOrUpdate(usuario);

			this.ActivatePanel(this.pnlStep2);
		}

		private void ActivatePanel(Panel panel)
		{
			this.pnlStep0.Visible = false;
			this.pnlStep1.Visible = false;
			this.pnlStep2.Visible = false;
			this.pnlStep3.Visible = false;
			panel.Visible = true;
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			this.ActivatePanel(this.pnlStep0);
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			this.ActivatePanel(this.pnlStep1);
		}

		private void Button6_Click(object sender, System.EventArgs e)
		{
			this.ActivatePanel(this.pnlStep2);
		}

		private void lnkDownload_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("setup.exe",true);
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("MisDatos.aspx");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.ActivatePanel(this.pnlStep3);
		}
	}
}
