<%@ Control Language="c#" AutoEventWireup="false" Codebehind="RatingGrid.ascx.cs" Inherits="Zonica.Web.UI.RatingGrid" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<DIV id="Wrapper" runat="server">
	<h4><asp:literal id=TitleHolder runat="server" /></h4>
	<div>
		<asp:datagrid id=Grid runat="server" AutoGenerateColumns="False" GridLines="None" ShowHeader="False">
			<Columns>
				<asp:HyperLinkColumn />
				<asp:BoundColumn Visible="False" />
			</Columns>
		</asp:datagrid>
	</div>
</DIV>
