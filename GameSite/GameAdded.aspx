<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameAdded.aspx.cs" Inherits="GameSite.GameAdded" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-xs-6 col-sm-offset-3">
            <h3 class="bg-info text-center">Kayıt Ol</h3>
        </div>

    </div>
    <form id="register-form" method="post" role="form" style="display: none;">
        <label id="lblUyari" runat="server"></label>
        <div class="form-group">
            <input type="text" name="Name" id="txtName" tabindex="1" class="form-control" placeholder="Oyun Adı" runat="server">
        </div>
        <div class="form-group">
            <input type="text" name="Price" id="txtPrice" tabindex="1" class="form-control" placeholder="Fiyat" runat="server">
        </div>
        <div class="form-group">
            <input type="text" name="Stock" id="txtStock" tabindex="1" class="form-control" placeholder="Stok Adeti" runat="server">
        </div>
         <div class="form-group row">
            <div class="form-group col-md-6">
                <label for="exampleInputEmail1">Oyun Firması</label>
                <asp:dropdownlist runat="server" id="ddlCompany" cssclass="form-control">
                       <asp:ListItem Text="Lütfen Seçim Yapınız..." Value="" />
            </asp:dropdownlist>
            </div>
           
        </div>
        <div class="form-group row">
            <div class="form-group col-md-6">
                <label for="exampleInputEmail1">Kategori</label>
                <asp:dropdownlist runat="server" id="ddlCategory" cssclass="form-control">
                       <asp:ListItem Text="Lütfen Seçim Yapınız..." Value="" />
            </asp:dropdownlist>
            </div>
          
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
