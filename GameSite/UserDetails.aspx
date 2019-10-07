<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="GameSite.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div class="row">
        <h3>Kullanıcı Bilgileri</h3>

        <asp:Label Text="İsim : " runat="server" />
        <asp:Label Text=" "  ID="lblUser" runat="server" />
        <hr />
         <asp:Label Text="Soyisim : " runat="server" />
        <asp:Label Text=" "  ID="lblLast" runat="server" />
         <hr />
         <asp:Label Text="Email : " runat="server" />
        <asp:Label Text=" "  ID="lblEmail" runat="server" />
         <hr />
         <asp:Label Text="Kullanıcı Adı : " runat="server" />
        <asp:Label Text=" "  ID="lblUsername" runat="server" />
         <hr />
         
          <a class="btn btn-primary" id="btnModified" runat="server">Kullanıcı Bilgileri Değiştir</a>
          <a class="btn btn-danger" id="btnDeleted" runat="server">Kullanıcı Sil</a>
      </div>

</asp:Content>
