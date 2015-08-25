<%@ Control Language="c#" AutoEventWireup="false" Codebehind="RatingGrid.ascx.cs" Inherits="Zonica.Web.UI.RatingGrid" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<div class=rating>
<h4><asp:literal id=TitleHolder 
runat="server"></asp:literal></H4><asp:datagrid id=Grid runat="server" AutoGenerateColumns="False" GridLines="None" ShowHeader="False">
<Columns>
<asp:HyperLinkColumn></asp:HyperLinkColumn>
</Columns>
</asp:datagrid></DIV>
