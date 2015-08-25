<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Page language="c#" Codebehind="SessionExpired.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.SessionExpired" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>SessionExpired</title>
	<meta http-equiv=content-type content="text/html; charset=iso-8859-1">
    <meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
    <LINK media=all href="styles/estilos.css" type=text/css rel=stylesheet ><!--[if IE]><LINK media=screen 
href="styles/ie.css" type=text/css rel=stylesheet><![endif]-->
  </HEAD>
  <body MS_POSITIONING="FlowLayout">
	
	<form id="Form1" method="post" runat="server">
	<div id="wrapper">
	    <uc1:Header id=Header1 runat="server" UnderTitle="Home"></uc1:Header>
	    <uc1:LeftMenu id=LeftMenu1 runat="server"></uc1:LeftMenu>
	    <div id="contenido">
			<H3>Tu sesión ha expirado</H3>
			<p>Para ver la pagina a la que estabas intentando necesitás haber iniciado una sesión.</p>
			<p>Es posible que tu sesión haya expirado, o que no hayas iniciado una sesión todavía. Por favor, ingresá nuevamente a Zónica haciendo click <a href="login.aspx" id=lnkLogin runat="server">acá</a>.</p>
		</div>
	<div id="pie-wrapper">
	</div>
	</div>
	    <uc1:Footer id=Footer1 runat="server"></uc1:Footer>
     </form>
	
  </body>
</HTML>