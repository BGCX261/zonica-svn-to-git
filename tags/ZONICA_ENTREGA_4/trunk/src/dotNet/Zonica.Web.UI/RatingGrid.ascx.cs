namespace Zonica.Web.UI
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Collections;

	/// <summary>
	///		Summary description for RatingGrid.
	/// </summary>
	public class RatingGrid : System.Web.UI.UserControl
	{
		private string urlTemplate;
		private string nameProperty;
		private string identifierProperty;
		private bool disableLinks;

		protected System.Web.UI.WebControls.Literal TitleHolder;
		protected System.Web.UI.HtmlControls.HtmlGenericControl Wrapper;
		protected System.Web.UI.WebControls.DataGrid Grid;

		/// <summary>
		/// Encabezado que se dar� al rating.
		/// </summary>
		/// <remarks>
		/// Puede ser texto HTML, no solamente un <see cref="string"/>.
		/// </remarks>
		public string Title
		{
			get
			{
				return this.TitleHolder.Text;
			}
			set
			{
				this.TitleHolder.Text = value;
			}
		}

		public object DataSource
		{
			get
			{
				return this.Grid.DataSource;
			}
			set
			{
				this.Grid.DataSource = value;
			}
		}
		
		public string CssClass
		{
			get
			{
				return this.Wrapper.Attributes["class"];
			}
			set
			{
				this.Wrapper.Attributes["class"] = value;
			}
		}

		/// <summary>
		/// Plantilla de url a utilizar para redireccionar a la descripci�n detallada del item.
		/// </summary>
		/// <example>
		/// <code>Artista.aspx?Artista={0}</code> terminar� siendo <code>Artista.aspx?Artista=UnArtista</code>.
		/// </example>
		public string UrlTemplate
		{
			get
			{
				return this.urlTemplate;
			}
			set
			{
				this.urlTemplate = value;
			}
		}

		/// <summary>
		/// Propiedad del DataSource que ser� utilizada para mostrar los items.
		/// </summary>
		public string NameProperty
		{
			get
			{
				return this.nameProperty;
			}
			set
			{
				this.nameProperty = value;
			}
		}

		/// <summary>
		/// Propiedad que indica si los items se muestran como links o como texto.
		/// </summary>
		public bool DisableLinks
		{
			get
			{
				return this.disableLinks;
			}
			set
			{
				this.disableLinks = value;
			}
		}
		/// <summary>
		/// Identifica al campo Id del item bindeado. Se usa para renderear la url del <see cref="UrlTemplate"/>.
		/// </summary>
		public string IdentifierProperty {
			get {return this.identifierProperty;}
			set{this.identifierProperty = value;}
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
		}

		public override void DataBind()
		{
			if (this.disableLinks)
			{
				BoundColumn bc = (BoundColumn)Grid.Columns[1];
				bc.DataField = this.NameProperty;
				bc.Visible = true;
				Grid.Columns[0].Visible = false;
			}
			else
			{
				HyperLinkColumn hlc = ((HyperLinkColumn)Grid.Columns[0]);
				hlc.DataTextField = this.NameProperty;
				hlc.DataNavigateUrlField = this.IdentifierProperty ;
				hlc.DataNavigateUrlFormatString = this.UrlTemplate;
			}

			base.DataBind();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}

		#endregion
	}
}
