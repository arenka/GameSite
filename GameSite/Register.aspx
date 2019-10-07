<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GameSite.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-xs-6 col-sm-offset-3">
            <h3 class="bg-info text-center">Kayıt Ol</h3>
        </div>

    </div>
        <form id="register-form" action="https://phpoll.com/register/process" method="post" role="form" style="display: none;">
            <label id="lblUyari" runat="server"></label>
        <div class="form-group">
            <input type="text" name="FirstName" id="txtFirstName" tabindex="1" class="form-control" placeholder="İsim" runat="server">
        </div>
        <div class="form-group">
            <input type="text" name="LastName" id="txtLastName" tabindex="1" class="form-control" placeholder="Soyisim" runat="server">
        </div>
        <div class="form-group">
            <input type="text" name="Username" id="txtUsername" tabindex="1" class="form-control" placeholder="Kullanıcı Adı" runat="server">
        </div>
        <div class="form-group">
            <input type="email" name="Email" id="txtEmail" tabindex="1" class="form-control" placeholder="Email Adres" runat="server">
        </div>
        <div class="form-group">
            <input type="password" name="Password" id="txtPassword" tabindex="2" class="form-control" placeholder="Şifre" runat="server">
        </div>

        <div class="form-group">
            <div class="row">
                <div class="col-sm-6 col-sm-offset-3">
                    <asp:Button Text="Kayıt Ol" ID="btnKayıtOl" CssClass="btn-primary" OnClick="btnKayıtOl_Click" runat="server" />

                </div>
            </div>
        </div>
    </form>
</asp:Content>
