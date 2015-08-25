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
using ModelArtista = Zonica.Model.Artista;
using Zonica.Model;

namespace Zonica.Web.UI
{
	/// <summary>
	/// Summary description for BuscarUnArtista.
	/// </summary>
	public class BuscarUnArtista : BasePage
	{
		protected System.Web.UI.WebControls.TextBox txtBusqueda;
		protected System.Web.UI.WebControls.Button btnBuscar;
		protected System.Web.UI.WebControls.DataGrid grdArtistas;
		protected System.Web.UI.WebControls.Label lblNoEncontrado;
	
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
			this.Load += new System.EventHandler(this.Page_Load);
			this.btnBuscar.Click += new EventHandler(btnBuscar_Click);
			this.grdArtistas.ItemDataBound +=new DataGridItemEventHandler(grdArtistas_ItemDataBound);

		}
		#endregion

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (this.txtBusqueda.Text.Length > 0)
			{
				IList artistas = this.GetMusicaService().BuscarArtistas(this.txtBusqueda.Text);
				if (artistas == null || artistas.Count == 0)
					this.lblNoEncontrado.Visible = true;
				else
				{
					this.grdArtistas.DataSource = artistas;
					this.grdArtistas.DataBind();
				}
			}
				//TODO: traer todos y mostrarlos
			else
			{
				this.grdArtistas.DataSource = this.GetMusicaService().RetrieveAllArtistas();
				this.grdArtistas.DataBind();
			}
		}

		private void grdArtistas_ItemDataBound(object sender, DataGridItemEventArgs e)
		{
			ModelArtista a =(ModelArtista)e.Item.DataItem;
			if (a == null)
				return;
			IList itemRankings = this.GetEscuchaService().RetrieveAlbumesMasEscuchados(a);
			if (itemRankings != null && itemRankings.Count > 0)
			{
				IEnumerator enumerator = itemRankings.GetEnumerator();
				enumerator.MoveNext();
				//int count = 0;
				string descripcionAlbumes = ((ItemRanking)enumerator.Current).Nombre;
				while (enumerator.MoveNext() && descripcionAlbumes.Length < 35)
				{
					descripcionAlbumes += ", " + ((ItemRanking)enumerator.Current).Nombre;
					//count ++;
				}
				if (itemRankings.Count>3)
					descripcionAlbumes += " ...";

				e.Item.Cells[1].Text = descripcionAlbumes;
			}
		}
	}
}
