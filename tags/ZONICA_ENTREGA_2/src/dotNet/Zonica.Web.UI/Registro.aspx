<%@ Page language="c#" Codebehind="Registro.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.Registro" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>Registro</title>
<meta http-equiv=content-type content="text/html; charset=iso-8859-1">
<meta content="Microsoft Visual Studio .NET 7.1" name=GENERATOR>
<meta content=C# name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema><LINK media=all href="styles/estilos.css" type=text/css rel=stylesheet ><!--[if IE]><LINK media=screen 
href="styles/ie.css" type=text/css rel=stylesheet><![endif]-->
  </HEAD>
<body MS_POSITIONING="FlowLayout">
<form id=Form1 method=post runat="server" class="smallForm">
<div id=wrapper><uc1:header id=Header1 runat="server" UnderTitle="Registro"></uc1:header><uc1:leftmenu id=LeftMenu1 runat="server"></uc1:leftmenu>
<div id=contenido><asp:panel id=pnlStep0 runat="server">
<H3>Zónica - Registro</H3>
<P>Antes que nada, queremos agradecerte por tu interés en Zónica.</P>
<P>Este wizzard de guiará por unos muy simples pasos para convertirte en un 
miembro de Zónica. Solo tomará unos segundos.</P>
<DIV class=footer><asp:Button id=btnSiguiente Runat="server" Text="Siguiente" CssClass="submit"></asp:Button></DIV></asp:panel><asp:panel 
id=pnlStep1 runat="server" Visible="False" CssClass="centerContent">
<H3>Zónica - Registro paso 1 de 3</H3>
<H4>Crea tu cuenta.</H4>
<FIELDSET><LABEL>Nombre: </LABEL><asp:textbox id=txtUserName runat="server" CssClass="nombre"></asp:textbox><asp:requiredfieldvalidator id=UserNameValidator1 runat="server" Display="Dynamic" ControlToValidate="txtUserName" ErrorMessage="Por favor, ingresa tu nombre de usuario.">*</asp:requiredfieldvalidator><LABEL>Contraseña:</LABEL><asp:textbox id=txtPassword runat="server" CssClass="pass" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id=RequiredFieldValidator1 runat="server" Display="Dynamic" ControlToValidate="txtPassword" ErrorMessage="Por favor, ingresa tu contraseña.">*</asp:requiredfieldvalidator> 
<LABEL>Confirma tu Contraseña:</LABEL><asp:textbox id=txtConfirmPassword runat="server" CssClass="pass" TextMode="Password"></asp:textbox><asp:CompareValidator id=CompareValidator1 runat="server" ControlToValidate="txtPassword" ErrorMessage="Las contraseñas que ingresaste son distintas, por favor intentalo nuevamente." ControlToCompare="txtConfirmPassword">*</asp:CompareValidator><asp:requiredfieldvalidator id=Requiredfieldvalidator2 runat="server" Display="Dynamic" ControlToValidate="txtConfirmPassword" ErrorMessage="Por favor, ingresá tu contraseña nuevamente." Enabled="False">*</asp:requiredfieldvalidator><asp:validationsummary id=ValidationSummary1 runat="server" DisplayMode="List"></asp:validationsummary></FIELDSET> 

<DIV class=footer><asp:Button id=Button4 Runat="server" Text="Anterior" CssClass="submit" CausesValidation="False"></asp:Button><asp:Button id=Button1 Runat="server" Text="Siguiente" CssClass="submit"></asp:Button></DIV></asp:panel><asp:panel 
id=pnlStep2 runat="server" Visible="False">
<H3>Zónica - Registro paso 2 de 3</H3>
<H4>Descarga el plug in.</H4>
<P>Ahora que creaste tu usuario solo queda descargar e instalar el plug-in. Es 
muy facil!</P>
<P>Podes descargarlo haciendo click <asp:LinkButton id=lnkDownload runat="server">Aca</asp:LinkButton></P>
<DIV class=footer><asp:Button id=Button5 Runat="server" Text="Anterior" CssClass="submit" CausesValidation="False"></asp:Button><asp:Button id=Button2 Runat="server" Text="Siguiente" CssClass="submit"></asp:Button></DIV></asp:panel>
<asp:panel id=pnlStep3 runat="server" Visible="False">
<H3>Zónica - Registro paso 3 de 3</H3>
<H4>Listo!</H4>
<P>¿Ya descargaste e instalaste el plug-in? ¡Buenisimo! Ahora solo resta 
escuchar música. Felicitaciones, ¡ya sos miembro de Zónica!</P>
<P>No te olvides de terminar de cargar los datos de tu perfil. Haciendo 
click&nbsp;<A href="misDatos.aspx">aca</A>, o en "¡Listo!" te vamos a 
redireccionar a tu perfil, donde&nbsp;podés cargar en qué region&nbsp;vivís, y 
qué música te gusta escuchar, entre otras cosas. ¡Nos vemos pronto!</P>
<DIV class=footer><asp:Button id=Button6 Runat="server" Text="Anterior" CssClass="submit" CausesValidation="False"></asp:Button><asp:Button id=Button3 Runat="server" Text="¡Listo!" CssClass="submit"></asp:Button></DIV>
</asp:panel></div>

<div id=pie-wrapper></div></div><uc1:footer id=Footer1 runat="server"></uc1:footer></form>
	
  </body>
</HTML>