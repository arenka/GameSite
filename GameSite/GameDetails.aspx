<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameDetails.aspx.cs" Inherits="GameSite.GameDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="row">
        <h3>Oyun Detayları</h3>

        <asp:Label Text="Oyun Adı : " runat="server" />
        <asp:Label Text=" "  ID="lblGame" runat="server" />
        <hr />
         <asp:Label Text="Oyun Fiyatı : " runat="server" />
        <asp:Label Text=" "  ID="lblPrice" runat="server" />
         <hr />
         <asp:Label Text="Oyunu Yapan Firma : " runat="server" />
        <asp:Label Text=" "  ID="lblCompany" runat="server" />
         <hr />
         <asp:Label Text="Kategori : " runat="server" />
        <asp:Label Text=" "  ID="lblCategory" runat="server" />
         <hr />
        
    </div>
    

</asp:Content>
