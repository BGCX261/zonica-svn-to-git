<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Codebehind="Artista.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.Artista" %>
<%@ Register TagPrefix="uc1" TagName="RatingGrid" Src="RatingGrid.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" >
<HTML>
  <HEAD>
    <title>Zónica - Artista</title>
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
			<uc1:Header id=Header1 runat="server" UnderTitle="Ver Artista"></uc1:Header>
			<uc1:LeftMenu id=LeftMenu1 runat="server"></uc1:LeftMenu>
			<div id="contenido">
				<asp:Label ID="lblNoEncontrado" Runat="server" Visible="False" CssClass="error">El Artista indicado no fue encontrado. </asp:Label>
				<asp:Panel ID="pnlArtistaEncontrado" Runat="server">
					<h3>Estas viendo a <asp:Label ID="lblNombre" Runat="server"></asp:Label></h3>
					<uc1:RatingGrid id="RatingTemasMusicales" title="Canciones más escuchadas de este artista" runat="server" CssClass="rating" IdentifierProperty="Id" NameProperty="Nombre" UrlTemplate="cancion.aspx?id={0}" DisableLinks="true"></uc1:RatingGrid>
					<uc1:RatingGrid id="RatingUsuarios" title="Usuarios que más esuchan este artista" runat="server" CssClass="rating" UrlTemplate="PerfilUsuario.aspx?id={0}" NameProperty="Nombre" IdentifierProperty="Id"></uc1:RatingGrid>
					<uc1:RatingGrid id="RatingAlbumes" title="Albumes más escuchados" runat="server" CssClass="rating" UrlTemplate="" NameProperty="Nombre" IdentifierProperty="Id" DisableLinks="true"></uc1:RatingGrid>
					<uc1:RatingGrid id="rtgArtistasSimilares" title="Artistas similares" runat="server" CssClass="rating" NameProperty="Nombre" IdentifierProperty="Id" UrlTemplate="Artista.aspx?id={0}"/>
				</asp:Panel>
		    </div>
			<div id="pie-wrapper">
			</div>
		</div>
		<uc1:Footer id=Footer1 runat="server"></uc1:Footer>
     </form>
	
  </body>
</HTML>