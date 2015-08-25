<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Codebehind="MisDatos.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.MisDatos" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" >
<HTML>
  <HEAD>
    <title>Zónica - Mis Datos</title>
<meta http-equiv=content-type content="text/html; charset=iso-8859-1">
<meta content="Microsoft Visual Studio .NET 7.1" name=GENERATOR>
<meta content=C# name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema><LINK media=all href="styles/estilos.css" type=text/css rel=stylesheet ><!--[if IE]><LINK media=screen 
href="styles/ie.css" type=text/css rel=stylesheet><![endif]-->
  </HEAD>
<body MS_POSITIONING="FlowLayout">
<form class=smallForm id=Form1 method=post runat="server">
<div id=wrapper><uc1:header id=Header1 runat="server" UnderTitle="Mis Datos"></uc1:header><uc1:leftmenu id=LeftMenu1 runat="server"></uc1:leftmenu>
<div id=contenido>
<h3>Zónica - la primer comunidad virtual argentina</h3>
<h4>Bienvenido a Zonica</h4>
<p>Hola <asp:label id=lblNombre runat="server"></asp:label>!</p>
<p>Esos son los datos que tenemos de tu perfil.</p>
<div class=centerContent>
<fieldset><asp:panel id=pnlPerfil 
runat="server"><LABEL>Nombre completo:</LABEL><asp:TextBox id=txtNombreCompleto runat="server" CssClass="textField"></asp:TextBox><BR><LABEL>Apodo:</LABEL><asp:TextBox id=txtApodo runat="server" CssClass="textField"></asp:TextBox><BR><LABEL>Provincia</LABEL> 
<asp:DropDownList id=lstProvincia runat="server" CssClass="textField" DataValueField="Id" DataTextField="Nombre" AutoPostBack="True">

</asp:DropDownList><BR><LABEL>Ciudad</LABEL><asp:DropDownList id=lstCiudad runat="server" CssClass="textField" DataValueField="Id" DataTextField="Nombre"></asp:DropDownList><BR>
<P><asp:Button id=btnUpdate runat="server" Text="Actualizar"></asp:Button><asp:Button id=btnCancel runat="server" Text="Cancelar" CausesValidation="False"></asp:Button></P>
<P><asp:LinkButton id=lnkChangePassword runat="server">Cambiar mi contraseña</asp:LinkButton></P>
<P><asp:LinkButton id=lnkChangeContacts runat="server">Cambiar mis datos de contacto</asp:LinkButton></P></asp:panel><asp:panel 
id=pnlPassword runat="server" 
Visible="False"><LABEL>Contraseña:</LABEL><asp:textbox id=txtPassword runat="server" CssClass="textField" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id=RequiredFieldValidator1 runat="server" Display="Dynamic" ControlToValidate="txtPassword" ErrorMessage="Por favor, ingresa tu contraseña.">*</asp:requiredfieldvalidator> 
<BR><LABEL>Confirma tu Contraseña:</LABEL><asp:textbox id=txtConfirmPassword runat="server" CssClass="textField" TextMode="Password"></asp:textbox><asp:CompareValidator id=CompareValidator1 runat="server" ControlToValidate="txtPassword" ErrorMessage="Las contraseñas que ingresaste son distintas, por favor intentalo nuevamente." ControlToCompare="txtConfirmPassword">*</asp:CompareValidator><asp:requiredfieldvalidator id=Requiredfieldvalidator2 runat="server" Display="Dynamic" ControlToValidate="txtConfirmPassword" ErrorMessage="Por favor, ingresá tu contraseña nuevamente." Enabled="False">*</asp:requiredfieldvalidator><div class="errorSummary"><asp:validationsummary id=ValidationSummary1 runat="server" DisplayMode="List"></asp:validationsummary></div><asp:Button id=btnPassAccept runat="server" Text="Actualizar"></asp:Button><asp:Button id=btnPassCancel runat="server" Text="Cancelar" CausesValidation="False"></asp:Button></asp:panel><asp:panel 
id=pnlContactos runat="server" Visible="False"><LABEL 
class=newLinelabel>Tus direcciones:</LABEL> <asp:ListBox id=lstContactos runat="server" CssClass="bigTextField" DataValueField="Id" DataTextField="Nombre"></asp:ListBox><BR><asp:Button id=btnContactRemove runat="server" Text="Borrar"></asp:Button>
<HR>
<LABEL>Nuevo contacto:</LABEL> <asp:textbox id=txtContacto runat="server" CssClass="textField" EnableViewState="False"></asp:textbox><BR><LABEL>Selecciona 
el tipo:</LABEL> <asp:DropDownList id=lstTipoContactos runat="server" CssClass="textField" DataValueField="Id" DataTextField="Nombre"></asp:DropDownList><BR><asp:Button id=btnContactAdd runat="server" Text="Agregar" CausesValidation="False"></asp:Button>
<HR>
<asp:Button id=btnContactDone runat="server" Text="Listo!" CausesValidation="False"></asp:Button></asp:panel></fieldset> 
</div></div>
<div id=pie-wrapper></div></div><uc1:footer id=Footer1 runat="server"></uc1:footer></form>
	
  </body>
</HTML>
