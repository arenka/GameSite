<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserModified.aspx.cs" Inherits="GameSite.UserModified" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    
   
        <div class="container">
            <div class="form-group">
                <label id="lblUyari" runat="server"></label>

                <input type="hidden" id="txtID" class="form-control" runat="server">
                <input type="hidden" id="txtAdmin" class="form-control" runat="server" />


                <div class="form-group row">
                    <div class="form-group col-md-6">
                        <label for="exampleInputEmail1">İsim : </label>
                        <input type="text" class="form-control" id="txtName" runat="server" placeholder="İsim Giriniz">
                    </div>
                </div>
                <div class="form-group row">
                    <div class="form-group col-md-6">
                        <label for="exampleInputEmail1">Soyisim : </label>
                        <input type="text" class="form-control" id="txtLast" runat="server" placeholder="Soyisim Giriniz">
                    </div>
                </div>
                <div class="form-group row">
                    <div class="form-group col-md-6">
                        <label for="exampleInputEmail1">Kullanıcı Adı : </label>
                        <input type="text" class="form-control" id="txtUsername" runat="server" placeholder="Kullanıcı Adı Giriniz">
                    </div>
                </div>
                <div class="form-group row">
                    <div class="form-group col-md-6">
                        <label for="exampleInputEmail1">Şifre : </label>
                        <input type="number" class="form-control" id="txtPassword" runat="server" placeholder="Şifrenizi Giriniz">
                    </div>
                </div>

                <asp:Label Text="Email : " runat="server" />
                <asp:Label ID="lblEmail" runat="server" />
                <hr />

                <asp:Button ID="btnKaydet" Text="Kaydet" CssClass="btn btn-info" OnClick="btnKaydet_Click" runat="server" />

            </div>
        </div>
   
</asp:Content>
