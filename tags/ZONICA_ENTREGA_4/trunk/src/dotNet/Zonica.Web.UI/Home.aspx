<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RatingGrid" Src="RatingGrid.ascx" %>
<%@ Page language="c#" Codebehind="Home.aspx.cs" AutoEventWireup="true" Inherits="Zonica.Web.UI.Home" codePage="28605"%>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" >
<HTML>
  <HEAD>
    <title>Zónica - Home</title>
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
			<H3>Zónica - la primer comunidad virtual musical argentina</H3>
			<asp:Panel ID="pnlBienVenido" Runat="server">
				<H4>Bienvenido a Zónica</H4>
				<P>Acá vas a poder compartir tus gustos musicales, conocer grupos nuevos, y 
				conectarte con gente que escucha lo mismo que vos!</P>
				<P>Podes <A href="registro.aspx">registrarte</A> ahora mismo.</P>
			</asp:Panel>
			<uc1:RatingGrid id=RatingArtistas 
				runat="server" 
				IdentifierProperty = "Id"
				Title = "Artistas más escuchados"
				NameProperty = "Nombre"
				UrlTemplate = "Artista.aspx?id={0}"
				CssClass="rating"/>
			<uc1:RatingGrid id=RatingTemasMusicales
				runat="server"
				Title = "Canciones más escuchadas"
				UrlTemplate = "Cancion.aspx?Cancion={0}"
				NameProperty = "Nombre"
				IdentifierProperty = "Id"
				CssClass = "rating"
				DisableLinks = "true"/>
			<uc1:RatingGrid id="rgrUsuariosActivos"
				runat="server"
				IdentifierProperty="Id"
				Title="Usuarios más activos"
				NameProperty="Nombre"
				UrlTemplate="PerfilUsuario.aspx?id={0}"
				CssClass="rating"/>
			<div id="datosDeZonica" class="rating">
				<h4>Datos de Z&oacute;nica</h4>
				<p>En esta seci&oacute;n podr&aacute;s ver datos estad&iacute;sticos de Z&oacute;nica !!!</p>
				<ul>
					<li>Cantidad de usuarios registrados: <asp:Label id="lblCantidadUsuarios" Runat="server"/>
					<li>Cantidad de usuarios registrados hoy: <asp:Label id="lblCantidadUsuariosDelDia" Runat="server"/>
					<li>Cantidad de escuchas realizadas: <asp:Label id="lblCantidadEscuchas" Runat="server"/>
					<li>Cantidad de artistas: <asp:Label id="lblCantidadArtistas" Runat="server"/>
				</ul>
			</div><!-- Fin del div datosDeZonica-->
		</div>
	<div id="pie-wrapper">
	</div>
	</div>
	    <uc1:Footer id=Footer1 runat="server"></uc1:Footer>
     </form>
	
  </body>
</HTML>
