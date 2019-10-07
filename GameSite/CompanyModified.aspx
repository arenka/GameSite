<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanyModified.aspx.cs" Inherits="GameSite.CompanyModified" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="register-form" method="post" role="form" style="display: none;">
        <label id="lblUyari" runat="server"></label>
        <input type="hidden" id="txtID" class="form-control" runat="server">
        <div class="form-group">
            <input type="text" name="Name" id="txtName" tabindex="1" class="form-control" placeholder="Firma Adı" runat="server">
        </div>

        <div class="form-group">
            <div class="row">
                <div class="col-sm-6">
                    <asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn-primary" OnClick="btnKaydet_Click" runat="server" />

                </div>
            </div>
        </div>
    </form>
</asp:Content>
