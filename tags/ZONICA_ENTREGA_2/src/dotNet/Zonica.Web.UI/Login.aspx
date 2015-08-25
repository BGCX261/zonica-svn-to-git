<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page CodeBehind="Login.aspx.cs" Language="c#" AutoEventWireup="false" Inherits="Zonica.Web.UI.Login" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<HTML 
lang=en>
  <HEAD>
		<title>Zónica</title>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
<meta http-equiv=content-type content="text/html; charset=iso-8859-1"><LINK media=all href="styles/estilos.css" type=text/css rel=stylesheet ><!--[if IE]><LINK media=screen href="styles/ie.css" 
type=text/css rel=stylesheet><![endif]-->
  </HEAD>
<body>
<div id=wrapper><uc1:header id=Header1 UnderTitle="Login" runat="server"></uc1:header><uc1:leftmenu id=LeftMenu1 runat="server"></uc1:leftmenu>
<div id=contenido>
<h3>Entrá en Zónica</h3>Escribí tu nombre de usuario y 
contraseña. 
<form class=smallForm runat="server">
<fieldset><legend>Logueo</legend><label>Nombre: </label><asp:textbox id=txtUserName runat="server" CssClass="nombre"></asp:textbox><asp:requiredfieldvalidator id=UserNameValidator1 runat="server" Display="Dynamic" ControlToValidate="txtUserName" ErrorMessage="Por favor, ingresa tu nombre de usuario.">*</asp:requiredfieldvalidator><br><label>Contraseña: </label><asp:textbox id=txtPassword runat="server" CssClass="pass" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id=RequiredFieldValidator1 runat="server" Display="Dynamic" ControlToValidate="txtPassword" ErrorMessage="Por favor, ingresa tu contraseña.">*</asp:requiredfieldvalidator><br><asp:button id=btnLogin runat="server" CssClass="submit" Text="Ingresar"></asp:button><br><asp:validationsummary id=ValidationSummary1 runat="server" DisplayMode="List"></asp:validationsummary>
<asp:Label id=lblUserInvalid runat="server" CssClass="error" Visible="False" EnableViewState="False">Usuario no reconocido. Por favor intentalo nuevamente.</asp:Label><asp:Label id=lblPasswordInvalid runat="server" CssClass="error" Visible="False" EnableViewState="False">Contraseña inválida. Por favor intenta nuevamente.</asp:Label>
</fieldset> 
</form></div>
<div id=pie-wrapper></div></div><uc1:footer id=Footer1 runat="server"></uc1:footer>
	</body>
</HTML>
