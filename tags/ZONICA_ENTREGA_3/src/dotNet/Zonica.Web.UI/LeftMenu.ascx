<%@ Control Language="c#" AutoEventWireup="false" Codebehind="LeftMenu.ascx.cs" Inherits="Zonica.Web.UI.LeftMenu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<div id=menu>
<UL id=publicAccess runat="server">
  <LI><A href="Home.aspx" >Home</A> 
  <LI><A href="login.aspx" >Ingresá</A> 
  <LI><A href="registro.aspx" >Registrate en zónica</A> </LI></UL>
<UL id=restrictedAccess runat="server">
  <LI><A href="Home.aspx" >Home</A> 
  <LI><A href="index.aspx" onclick="alert('No está implementado aún !!!');return false;">Mis escuchas</A> 
  <LI><A href="MisDatos.aspx">Mis datos</A> 
  <LI><asp:LinkButton ID="lnkMiPerfil" Runat=server CausesValidation="False">Mi perfil</asp:LinkButton>
  <LI><asp:LinkButton ID="btnLogOut" Runat=server CausesValidation="False">Salir</asp:LinkButton></LI>
</UL></div>
