<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDeleted.aspx.cs" Inherits="GameSite.UserDeleted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <div class="col-md-4 col-sm-12">
            <input type="hidden" id="txtHidden" runat="server" />


            <label id="lblArac" runat="server"></label>



            <label>Bu kullanıcıyı silmek istediğinizden emin misiniz?</label>


            <asp:Button Text="Sil" runat="server" CssClass="btn btn-danger" ID="btnUserDeleted" OnClick="btnUserDeleted_Click" />
            <asp:Button Text="Vazgeç" runat="server" CssClass="btn btn-warning" ID="btnCancel" OnClick="btnCancel_Click" />

        </div>
    </div>
</asp:Content>
