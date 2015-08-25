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
	/// Summary description for MisDatos.
	/// </summary>
	public class MisDatos : BasePage
	{
		protected System.Web.UI.WebControls.Label lblNombre;
		protected System.Web.UI.WebControls.Button btnUpdate;
		protected System.Web.UI.WebControls.Button btnCancel;
		protected System.Web.UI.WebControls.LinkButton lnkChangePassword;
		protected System.Web.UI.WebControls.LinkButton lnkChangeContacts;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.RequiredFieldValidator Requiredfieldvalidator2;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.TextBox txtConfirmPassword;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Panel pnlPerfil;
		protected System.Web.UI.WebControls.Panel pnlPassword;
		protected System.Web.UI.WebControls.Panel pnlContactos;
		protected System.Web.UI.WebControls.Button btnPassAccept;
		protected System.Web.UI.WebControls.Button btnContactAdd;
		protected System.Web.UI.WebControls.Button btnContactRemove;
		protected System.Web.UI.WebControls.Button btnContactDone;
		protected System.Web.UI.WebControls.Button btnPassCancel;
		protected System.Web.UI.WebControls.TextBox txtNombreCompleto;
		protected System.Web.UI.WebControls.DropDownList lstProvincia;
		protected System.Web.UI.WebControls.DropDownList lstCiudad;
		protected System.Web.UI.WebControls.ListBox lstContactos;
		protected System.Web.UI.WebControls.DropDownList lstTipoContactos;
		protected System.Web.UI.WebControls.TextBox txtContacto;
		protected System.Web.UI.WebControls.TextBox txtApodo;

//		protected bool ContactosWasBound 
//		{
//			get
//			{
//				if (this.ViewState["contactosWasBound"] != null)
//					return (bool)this.ViewState["contactosWasBound"];
//				else
//					return false;
//			}
//			set
//			{
//				this.ViewState["contactosWasBound"] = value;
//			}
//		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			this.EnsureValidSession();
			if (!Page.IsPostBack)
			{
				int id = (int)Session[SessionEntries.UserID];
				Usuario usuario = this.GetUsuarioService().Retrieve(id);
				this.lblNombre.Text = usuario.Nombre;
				this.txtNombreCompleto.Text = usuario.NombreCompleto;
				this.txtApodo.Text = usuario.Apodo;

				this.lstProvincia.DataSource = this.GetLocalidadService().RetrieveAllProvincias();
				this.lstProvincia.DataBind();
				this.AddEmptySelectedElement(this.lstProvincia);
				
				if (usuario.Ciudad != null)
				{
					int idProvincia = usuario.Ciudad.Provincia.Id;
					int idCiudad = usuario.Ciudad.Id;

					this.lstCiudad.DataSource = usuario.Ciudad.Provincia.Ciudades;
					this.lstCiudad.DataBind();
					this.AddEmptySelectedElement(this.lstCiudad);
					
					this.SetSelectedElement(this.lstProvincia, idProvincia);
					this.SetSelectedElement(this.lstCiudad, idCiudad);

				}
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.lstProvincia.SelectedIndexChanged += new System.EventHandler(this.lstProvincia_SelectedIndexChanged);
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.lnkChangePassword.Click += new System.EventHandler(this.lnkChangePassword_Click);
			this.lnkChangeContacts.Click += new System.EventHandler(this.lnkChangeContacts_Click);
			this.btnPassAccept.Click += new System.EventHandler(this.btnPassAccept_Click);
			this.btnPassCancel.Click += new System.EventHandler(this.btnPassCancel_Click);
			this.btnContactRemove.Click += new System.EventHandler(this.btnContactRemove_Click);
			this.btnContactAdd.Click += new System.EventHandler(this.btnContactAdd_Click);
			this.btnContactDone.Click += new System.EventHandler(this.btnContactDone_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			Usuario usuario = this.GetUsuarioService().Retrieve((int)Session[SessionEntries.UserID]);
			
			usuario.NombreCompleto = this.txtNombreCompleto.Text;
			usuario.Apodo = this.txtApodo.Text;
			if (this.lstCiudad.SelectedValue != null && this.lstCiudad.SelectedValue != string.Empty)
			{
				int ciudadId = int.Parse(this.lstCiudad.SelectedValue);
				usuario.Ciudad = this.GetLocalidadService().RetrieveCiudad(ciudadId);
			}

			this.GetUsuarioService().SaveOrUpdate(usuario);
		}

		private void lnkChangePassword_Click(object sender, System.EventArgs e)
		{
			this.Activate(this.pnlPassword);
		}

		private void btnPassAccept_Click(object sender, System.EventArgs e)
		{
			if (Page.IsValid)
			{
				Usuario usuario = this.GetUsuarioService().Retrieve((int)Session[SessionEntries.UserID]);
				usuario.Password = this.txtPassword.Text;
				this.GetUsuarioService().SaveOrUpdate(usuario);
				this.Activate(this.pnlPerfil);
			}
		}

		private void btnPassCancel_Click(object sender, System.EventArgs e)
		{
			this.Activate(this.pnlPerfil);
		}

		private void btnContactDone_Click(object sender, System.EventArgs e)
		{
			this.Activate(this.pnlPerfil);
		}

		private void lnkChangeContacts_Click(object sender, System.EventArgs e)
		{
			this.Activate(this.pnlContactos);
			this.lstTipoContactos.DataSource = this.GetContactoService().RetrieveAllTipoContactos();
			this.lstTipoContactos.DataBind();
			this.AddEmptySelectedElement(this.lstTipoContactos);

			Usuario usuario = this.GetUsuarioService().Retrieve((int)this.Session[SessionEntries.UserID]);
			
			this.lstContactos.DataSource = usuario.Contactos;
			this.lstContactos.DataBind();

		}

		private void btnContactCancel_Click(object sender, System.EventArgs e)
		{
			this.Activate(this.pnlPerfil);
		}

		private void Activate(Panel panel)
		{
			this.pnlContactos.Visible = false;
			this.pnlPassword.Visible = false;
			this.pnlPerfil.Visible = false;
			panel.Visible = true;
		}

		private void lstProvincia_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.lstProvincia.SelectedValue != null && this.lstProvincia.SelectedValue != string.Empty)
			{
				int provinciaId = int.Parse(this.lstProvincia.SelectedValue);
				Provincia provincia = this.GetLocalidadService().RetrieveProvincia(provinciaId);
				this.lstCiudad.DataSource = provincia.Ciudades;
				this.lstCiudad.DataBind();
				this.AddEmptySelectedElement(this.lstCiudad);
			}
		}

		private void AddEmptySelectedElement (DropDownList list)
		{
			ListItem item = new ListItem("");
			item.Selected = true;
			list.Items.Insert(0, item);
		}

		private void btnContactRemove_Click(object sender, System.EventArgs e)
		{
			if (this.lstContactos.SelectedIndex != -1)
			{
				//TODO: ver si se puede pasar algo de esta lógica al service! esta tocando índices y no me parece que esté muy bien.
				Usuario usuario = this.GetUsuarioService().Retrieve((int)Session[SessionEntries.UserID]);
				int id = int.Parse(this.lstContactos.SelectedValue);
				ContactoUsuario contactoEncontrado = null;
				IEnumerator cursor = usuario.Contactos.GetEnumerator();
				while (cursor.MoveNext() && contactoEncontrado == null)	
				{
					if (((ContactoUsuario)cursor.Current).Id == id)
						contactoEncontrado = (ContactoUsuario)cursor.Current;
				}
				if (contactoEncontrado != null)
				{
					usuario.Contactos.Remove(contactoEncontrado);
					this.GetUsuarioService().SaveOrUpdate(usuario);
					this.lstContactos.Items.RemoveAt(this.lstContactos.SelectedIndex);
				}
			}
		}

		private void btnContactAdd_Click(object sender, System.EventArgs e)
		{
			//TODO: validar contacto
			if (this.txtContacto.Text != null						//esto, 
				&& this.txtContacto.Text != string.Empty			//esto
				&& this.txtContacto.Text.IndexOf(" ") == -1			//y esto se va a ir cuando se agregue la validación correcta
				&& this.lstTipoContactos.SelectedValue != string.Empty )
			{

				Usuario usuario = this.GetUsuarioService().Retrieve((int)Session[SessionEntries.UserID]);
				int tipoId = int.Parse(this.lstTipoContactos.SelectedValue);
				TipoContacto tipo = this.GetContactoService().RetrieveTipoContacto(tipoId);
				
				ContactoUsuario contacto = new ContactoUsuario(tipo, usuario, this.txtContacto.Text);
				usuario.Contactos.Add(contacto);
				this.GetUsuarioService().SaveOrUpdate(usuario);
				this.lstContactos.Items.Add(new ListItem(this.txtContacto.Text, contacto.Id.ToString()));
				this.txtContacto.Text = string.Empty;
				this.lstTipoContactos.SelectedIndex = 0;
			}
		}
		
		private void SetSelectedElement(DropDownList ddl, int selectedItemValue) {
			ListItem selectedItem = ddl.Items.FindByValue(Convert.ToString(selectedItemValue));
			if (selectedItem == null) {
				throw new ArgumentException("No existe un item con id '" + selectedItemValue +
				                            "' en el DropDownList '" + ddl.ID + "'.");
			}
			
			// Pongo el resto de los itemes en false
			foreach (ListItem item in ddl.Items) {
				item.Selected = false;
			}
			
			selectedItem.Selected = true;
		}
	}
}
