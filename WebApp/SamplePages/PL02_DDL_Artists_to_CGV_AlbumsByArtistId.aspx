<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PL02_DDL_Artists_to_CGV_AlbumsByArtistId.aspx.cs" Inherits="WebApp.SamplePages.PL02_DDL_Artists_to_CGV_AlbumsByArtistId" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Label ID="Label1" runat="server" Text="Select Artist"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="DLL_Artists" runat="server"
            DataSourceID="DDLODS_Artists"
            DataTextField="VName"
            DataValueField="VArtistId"
            Width="350px"
            AppendDataBoundItems="true">
            <asp:ListItem Text="Select..." Value="0"></asp:ListItem>
        </asp:DropDownList>&nbsp;&nbsp;
        <asp:LinkButton 
            ID="LB_FetchArtistInfo" 
            runat="server" OnClick="LB_FetchArtistInfo_Click">
            Fetch Artist Info
        </asp:LinkButton>
    </div>
    <br /><br />
    <div class="row">
        <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
    </div>
    <asp:ObjectDataSource ID="DDLODS_Artists" runat="server" 
      OldValuesParameterFormatString="original_{0}" 
      SelectMethod="Artist_List" 
      TypeName="SystemDB.BLL.BLL01_Artist">
    </asp:ObjectDataSource>
</asp:Content>
