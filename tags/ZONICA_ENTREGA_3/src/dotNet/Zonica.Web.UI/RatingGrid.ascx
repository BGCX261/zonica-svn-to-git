<%@ Control Language="c#" AutoEventWireup="false" Codebehind="RatingGrid.ascx.cs" Inherits="Zonica.Web.UI.RatingGrid" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<asp:Panel id=Wrapper runat="server">
	<h4><asp:literal id=TitleHolder runat="server" /></h4>
	<div style="display: inline; height: 250; overflow-y: auto;">
		<asp:datagrid id=Grid runat="server" AutoGenerateColumns="False" GridLines="None" ShowHeader="False">
			<Columns>
				<asp:HyperLinkColumn />
			</Columns>
		</asp:datagrid>
	</div>
</asp:Panel>
