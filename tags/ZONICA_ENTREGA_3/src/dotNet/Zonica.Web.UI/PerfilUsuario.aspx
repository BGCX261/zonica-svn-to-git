<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Codebehind="PerfilUsuario.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.PerfilUsuario" %>
<%@ Register TagPrefix="uc1" TagName="RatingGrid" Src="RatingGrid.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>Usuario</title>
	<meta http-equiv=content-type content="text/html; charset=iso-8859-1">
    <meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
    <LINK media=all href="styles/estilos.css" type=text/css rel=stylesheet ><!--[if IE]><LINK media=screen 
href="styles/ie.css" type=text/css rel=stylesheet><![endif]-->
  </HEAD>
  <body MS_POSITIONING="FlowLayout">
    <form id="Form1" method="post" runat="server" class="smallForm">
		<div id="wrapper">
		    <uc1:Header id=Header1 runat="server" UnderTitle="Ver usuario"></uc1:Header>
		    <uc1:LeftMenu id=LeftMenu1 runat="server"></uc1:LeftMenu>
		    <div id="contenido">
				<asp:Label ID="lblNoEncontrado" Runat="server" Visible="False" CssClass="error">El usuario indicado no fue encontrado. </asp:Label>
				<asp:Panel ID="pnlUsuarioEncontrado" Runat="server" Visible="True">
					<h3>Perfil de <asp:Label ID="lblNombre" Runat="server"></asp:Label></h3>
					<uc1:RatingGrid id=RatingArtistas runat="server" CssClass="rating" Title="Artistas más escuchados" UrlTemplate="Artista.aspx?id={0}" NameProperty="Nombre" IdentifierProperty="Id"></uc1:RatingGrid>
					<uc1:RatingGrid id=RatingTemasMusicales runat="server" CssClass="rating" Title = "Canciones más escuchadas" UrlTemplate = "Cancion.aspx?Cancion={0}" NameProperty = "Nombre" IdentifierProperty = "Id" DisableLinks="true"></uc1:RatingGrid>
					<div class=centerContent> 
						<fieldset>
						<LABEL>Nombre completo:</LABEL><asp:Label Runat="server" ID="lblNombreCompleto" CssClass="readOnlyField">[no especificó]</asp:Label>
						<LABEL>Apodo:</LABEL><asp:Label Runat="server" ID="lblApodo" CssClass="readOnlyField">[no especificó]</asp:Label>
						<LABEL>Provincia:</LABEL><asp:Label Runat="server" ID="lblProvincia" CssClass="readOnlyField">[no especificó]</asp:Label>
						<LABEL>Ciudad:</LABEL><asp:Label Runat="server" ID="lblCiudad" CssClass="readOnlyField">[no especificó]</asp:Label>
						<asp:Repeater runat="server" id="contactosList">
							<ItemTemplate>
								<LABEL><%# DataBinder.Eval(Container.DataItem, "TipoContacto.Nombre") %>:</LABEL>
								<span class="readOnlyField"><%# DataBinder.Eval(Container.DataItem, "Nombre") %></span>
							</ItemTemplate>
						</asp:Repeater>
						<asp:Literal ID="pnlNoHayContactos" Runat="server" Visible="False"><LABEL>Contactos:</LABEL><span class="readOnlyField">[no especificó]</span></asp:Literal>
						</fieldset>
					</div>
				</asp:Panel>
		    </div>
			<div id="pie-wrapper">
			</div>
		</div>
		<uc1:Footer id=Footer1 runat="server"></uc1:Footer>
     </form>
  </body>
</HTML>