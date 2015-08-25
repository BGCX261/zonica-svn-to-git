<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RatingGrid" Src="RatingGrid.ascx" %>
<%@ Page language="c#" Codebehind="MisDatos.aspx.cs" AutoEventWireup="false" Inherits="Zonica.Web.UI.MisDatos" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>MisDatos</title>
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
	    <uc1:Header id=Header1 runat="server" UnderTitle="Home"></uc1:Header>
	    <uc1:LeftMenu id=LeftMenu1 runat="server"></uc1:LeftMenu>
	    <div id="contenido">
	<h3>Z�nica - la primer comunidad virtual argentina</h3>
			<h4>Bienvenido a Zonica</h4>
			<p>Hola Diego!</p>
			<p>Esos son los datos que tenemos de tu perfil.</p>
			<div class="centerContent">
			<fieldset>
				<label>Contrase�a:</label><input type="password"> (dej�la en blanco para no modificar).<br>
				<label>Nombre:</label><input type="text" value="Diego"><br>
				<label>Apellido:</label><input type="text" value="Bresler"><br>
				<label>Direcci�n de email:</label><input type="text" value="dbresler@arnet.com.ar"><br>
				<label>Provincia</label>
					<select name="Provincia">
						<option value="Buenos Aires">Buenos Aires</option>
						<option value="Capital Federal" selected>Capital Federal</option>
						<option value="Catamarca">Catamarca</option>
						<option value="Chaco">Chaco</option>
						<option value="Chubut">Chubut</option>
						<option value="C�rdoba">C�rdoba</option>
						<option value="Corrientes">Corrientes</option>
						<option value="Entre R�os">Entre R�os</option>
						<option value="Formosa">Formosa</option>
						<option value="Jujuy">Jujuy</option>
						<option value="La Pampa">La Pampa</option>
						<option value="La Rioja">La Rioja</option>
						<option value="Mendoza">Mendoza</option>
						<option value="Misiones">Misiones</option>
						<option value="Neuqu�n">Neuqu�n</option>
						<option value="R�o Negro">R�o Negro</option>
						<option value="Salta">Salta</option>
						<option value="San Juan">San Juan</option>
						<option value="San Luis">San Luis</option>
						<option value="Santa Cruz">Santa Cruz</option>
						<option value="Santa Fe">Santa Fe</option>
						<option value="Santiago del Estero">Santiago del Estero</option>
						<option value="Tierra del Fuego">Tierra del Fuego</option>
						<option value="Tucum�n">Tucum�n</option>
					</select><br>
				<label>Ciudad</label>
					<select name="Provincia" ID="Select1">
						<option value="Capital Federal" selected>Capital Federal</option>
					</select><br>
					<input type="submit" value="Actualizar" class="button" onclick="alert('Esta funcionalidad no est� implementada a�n.\nFaltan s�lo dos semanas !!!'); return false;">
					<input type="submit" value="Cancelar" class="button">
				</fieldset>
				</div>
	</div>
	<div id="pie-wrapper"></div>
	</div>
	
	    <uc1:Footer id=Footer1 runat="server"></uc1:Footer>
     </form>
	
  </body>
</HTML>