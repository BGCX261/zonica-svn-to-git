namespace Zonica.Web.UI
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for LeftMenu.
	/// </summary>
	public class LeftMenu : System.Web.UI.UserControl
	{
		protected System.Web.UI.HtmlControls.HtmlGenericControl restrictedAccess;
		protected System.Web.UI.WebControls.LinkButton btnLogOut;
		protected System.Web.UI.HtmlControls.HtmlGenericControl publicAccess;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if (Session[Global.SessionUserIdEntry] != null) //user has logged in
			{
				restrictedAccess.Visible = true;
				publicAccess.Visible = false;
			}
			else
			{
				publicAccess.Visible = true;
				restrictedAccess.Visible = false;
			}
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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnLogOut_Click(object sender, System.EventArgs e)
		{
			Session.Remove(Global.SessionUserIdEntry);
			Response.Redirect("home.aspx");
		}
	}
}
