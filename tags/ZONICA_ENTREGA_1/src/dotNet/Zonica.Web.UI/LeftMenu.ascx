<%@ Control Language="c#" AutoEventWireup="false" Codebehind="LeftMenu.ascx.cs" Inherits="Zonica.Web.UI.LeftMenu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<div id=menu>
<UL id=publicAccess runat="server">
  <LI><A href="Home.aspx" >Home</A> 
  <LI><A href="login.aspx" >Ingres�</A> 
  <LI><A href="registro.aspx" >Registrate en z�nica</A> </LI></UL>
<UL id=restrictedAccess runat="server">
  <LI><A href="Home.aspx" >Home</A> 
  <LI><A href="index.aspx" >Mis escuchas</A> 
  <LI><A href="logout.aspx" >Salir</A> </LI></UL></DIV>
