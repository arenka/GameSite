<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="GameSite.Logout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="col-md-4 col-sm-12">
            <input type="hidden" id="txtHidden" runat="server" />
            <label>Sistemden çıkmak istediğinize emin misiniz?</label>
            <asp:Button Text="Çıkış Yap" runat="server" CssClass="btn btn-danger" ID="btnLogout" OnClick="btnLogout_Click" />
        </div>
    </div>
</asp:Content>
