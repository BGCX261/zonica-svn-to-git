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

		protected System.Web.UI.WebControls.Literal TitleHolder;
		protected System.Web.UI.WebControls.DataGrid Grid;

		/// <summary>
		/// Encabezado que se dará al rating.
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
		
		/// <summary>
		/// Plantilla de url a utilizar para redireccionar a la descripción detallada del item.
		/// </summary>
		/// <example>
		/// <code>Artista.aspx?Artista={0}</code> terminará siendo <code>Artista.aspx?Artista=UnArtista</code>.
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
		/// Propiedad del DataSource que será utilizada para mostrar los items, y también 
		/// para completar la url de <see cref="UrlTemplate"/>.
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

		private void Page_Load(object sender, System.EventArgs e)
		{
		}

		public override void DataBind()
		{
			((HyperLinkColumn)Grid.Columns[0]).DataTextField = this.NameProperty;
			((HyperLinkColumn)Grid.Columns[0]).DataNavigateUrlField = this.NameProperty;
			((HyperLinkColumn)Grid.Columns[0]).DataNavigateUrlFormatString = this.UrlTemplate;
			base.DataBind ();
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
