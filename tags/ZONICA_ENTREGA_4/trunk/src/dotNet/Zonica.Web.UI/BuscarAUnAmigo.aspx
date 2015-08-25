<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Codebehind="BuscarAUnAmigo.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.BuscarAUnAmigo" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" >
<HTML>
  <HEAD>
    <title>Zónica - Buscando a un amigo</title>
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
	    <uc1:Header id=Header1 runat="server" UnderTitle="Buscando a un amigo"></uc1:Header>
	    <uc1:LeftMenu id=LeftMenu1 runat="server"></uc1:LeftMenu>
		<div id="contenido">
			<h3>Buscando a un amigo</h3>
			<p>Ingresá el nombre de tu amigo abajo y apretá <b>Buscar</b>.</p>
			<asp:TextBox id="txtBusqueda" runat="server"></asp:TextBox>
			<asp:Button id="btnBuscar" runat="server" Text="Buscar"></asp:Button>
			<asp:DataGrid id="grdUsuarios" CssClass="displayGrid" runat="server" AutoGenerateColumns="False" HeaderStyle-CssClass="head" AlternatingItemStyle-CssClass="alternate">
				<Columns>
					<asp:BoundColumn DataField="Nombre" HeaderText="Nombre"></asp:BoundColumn>
					<asp:BoundColumn DataField="Apodo" HeaderText="Apodo"></asp:BoundColumn>
					<asp:BoundColumn DataField="NombreCompleto" HeaderText="Nombre Completo"></asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Ciudad">
						<ItemTemplate>
							<%#DataBinder.Eval(Container.DataItem, "Ciudad.Nombre") %>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Provincia">
						<ItemTemplate>
							<%#DataBinder.Eval(Container.DataItem, "Ciudad.Provincia.Nombre") %>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn ItemStyle-CssClass="details" HeaderStyle-CssClass="detailsHeader">
						<ItemTemplate>
							<a href='perfilusuario.aspx?id=<%# DataBinder.Eval(Container.DataItem, "Id") %>' ><img src ="images/search-icon-blue.gif" title="Ver Perfil"></a>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:DataGrid>
			<asp:Label id="lblNoEncontrado" runat="server" Visible="False" EnableViewState="False">No se encontró ningún usuario con ese nombre.</asp:Label>
		</div>
	<div id="pie-wrapper">
	</div>
	</div>
		<uc1:Footer id=Footer1 runat="server"></uc1:Footer>
	</form>
  </body>
</HTML>