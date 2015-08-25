<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RatingGrid" Src="RatingGrid.ascx" %>
<%@ Page language="c#" Codebehind="Home.aspx.cs" AutoEventWireup="true" Inherits="Zonica.Web.UI.Home" codePage="28605"%>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>Home</title>
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
			<H3>Zónica - la primer comunidad virtual argentina</H3>
			<H4>Bienvenido a Zónica</H4>
			<p>Acá vas a poder compartir tus gustos musicales, conocer grupos nuevos, y conectarte
			con gente que escucha lo mismo que vos!</p>
			<p>Podes <a href="registro.aspx">registrarte</a> ahora mismo.</p>
			<uc1:RatingGrid id=RatingArtistas runat="server" CssClass=rating></uc1:RatingGrid>
			<uc1:RatingGrid id=RatingTemasMusicales runat="server" CssClass=rating></uc1:RatingGrid>
	    </div>
	<div id="pie-wrapper"></div>
	</div>
	
	    <uc1:Footer id=Footer1 runat="server"></uc1:Footer>
     </form>
	
  </body>
</HTML>