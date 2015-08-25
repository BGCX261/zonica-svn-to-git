<%@ Page language="c#" Codebehind="Registro.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.Registro" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" >
<HTML>
  <HEAD>
    <title>Z�nica - Registro</title>
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
<H3>Z�nica - Registro</H3>
<P>Gracias por tu inter�s en Z�nica.</P>
<P>Esta gu�a consiste en tres simples que te convertir�n en un miembro de 
Z�nica. Solo tomar� unos segundos.</P>
<DIV class=footer><asp:Button id=btnSiguiente Runat="server" Text="Siguiente" CssClass="submit"></asp:Button></DIV></asp:panel><asp:panel 
id=pnlStep1 runat="server" Visible="False" CssClass="centerContent">
<H3>Z�nica - Registro paso 1 de 3</H3>
<H4>Crea tu cuenta.</H4>
<FIELDSET><LABEL>Nombre: </LABEL><asp:textbox id=txtUserName runat="server" CssClass="textField"></asp:textbox><asp:requiredfieldvalidator id=UserNameValidator1 runat="server" Display="Dynamic" ControlToValidate="txtUserName" ErrorMessage="Por favor, ingresa tu nombre de usuario.">*</asp:requiredfieldvalidator><LABEL>Contrase�a:</LABEL><asp:textbox id=txtPassword runat="server" CssClass="textField" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id=RequiredFieldValidator1 runat="server" Display="Dynamic" ControlToValidate="txtPassword" ErrorMessage="Por favor, ingresa tu contrase�a.">*</asp:requiredfieldvalidator> 
<LABEL>Confirma tu Contrase�a:</LABEL><asp:textbox id=txtConfirmPassword runat="server" CssClass="textField" TextMode="Password"></asp:textbox><asp:CompareValidator id=CompareValidator1 runat="server" ControlToValidate="txtPassword" ErrorMessage="Las contrase�as que ingresaste son distintas, por favor intentalo nuevamente." ControlToCompare="txtConfirmPassword">*</asp:CompareValidator><asp:requiredfieldvalidator id=Requiredfieldvalidator2 runat="server" Display="Dynamic" ControlToValidate="txtConfirmPassword" ErrorMessage="Por favor, ingres� tu contrase�a nuevamente." Enabled="False">*</asp:requiredfieldvalidator>
<DIV class="errorSummary">
	<asp:validationsummary id=ValidationSummary1 runat="server" DisplayMode="List"></asp:validationsummary>
	<asp:Label id=lblUsuarioDuplicado Runat="server" Visible="False" EnableViewState="False">
		Este nombre de usuario ya fue utilizado por alguien m�s. Por favor ingres� otro nombre.
	</asp:Label>
</DIV>
</FIELDSET> 
<DIV class=footer><asp:Button id=Button4 Runat="server" Text="Anterior" CssClass="submit" CausesValidation="False"></asp:Button><asp:Button id=Button1 Runat="server" Text="Siguiente" CssClass="submit"></asp:Button></DIV></asp:panel><asp:panel 
id=pnlStep2 runat="server" Visible="False">
<H3>Z�nica - Registro paso 2 de 3</H3>
<H4>Descarg� el plug in.</H4>
<P>Ahora que creaste tu usuario s�lo queda descargar e instalar el plug-in. Es 
muy f�cil!</P>
<P>Pod�s descargarlo haciendo click <asp:LinkButton id=lnkDownload runat="server">Ac�</asp:LinkButton></P>
<DIV class=footer><asp:Button id=Button5 Runat="server" Text="Anterior" CssClass="submit" CausesValidation="False"></asp:Button><asp:Button id=Button2 Runat="server" Text="Siguiente" CssClass="submit"></asp:Button></DIV></asp:panel>
<asp:panel id=pnlStep3 runat="server" Visible="False">
<H3>Z�nica - Registro paso 3 de 3</H3>
<H4>Listo!</H4>
<P>�Ya descargaste e instalaste el plug-in? �Buen�simo! Ahora s�lo resta 
escuchar m�sica. Felicitaciones, �Ya sos miembro de Z�nica!</P>
<P>No te olvides de terminar de cargar los datos de tu perfil. Haciendo 
click&nbsp;<A href="misDatos.aspx">ac�</A>, o en el bot�n "�Listo!", te vamos a 
redireccionar a tu perfil, donde&nbsp;pod�s cargar en qu� regi�n&nbsp;viv�s, y datos de conntacto, entre otras cosas. �Nos vemos pronto!</P>
<DIV class=footer><asp:Button id=Button6 Runat="server" Text="Anterior" CssClass="submit" CausesValidation="False"></asp:Button><asp:Button id=Button3 Runat="server" Text="�Listo!" CssClass="submit"></asp:Button></DIV>
</asp:panel></div>

<div id=pie-wrapper></div></div><uc1:footer id=Footer1 runat="server"></uc1:footer></form>
	
  </body>
</HTML>
