<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GameSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater ID="rptGames" runat="server">
        <ItemTemplate>

            <div class="col-md-3 text-center">

                <div class="thumbnail product-box" runat="server">

                    <div class="caption" runat="server">
                        <h3><a href="/GameDetails.aspx?Id=<%# Eval("Id") %>"><%# Eval("Name")%></a></h3>
                        <p>Price : <strong><%# Eval("Price") %></strong> TL </p>
                        <p><a href="#"><%# Eval("Category.Name") %></a></p>
                        <p><%# Eval("Company.Name") %></p>
                        <p><a href="#" class="btn btn-success" role="button">Sepete Ekle</a> <a href="/GameDetails.aspx?Id=<%# Eval("Id") %>" class="btn btn-primary">Detay</a></p>
                        <p>
                            <asp:Button Text="<%# Eval("Liked") %>" runat="server" ID="GameLiked" OnClick="GameLiked_Click" />
                        </p>
                    </div>
                </div>
        </ItemTemplate>
    </asp:Repeater>


</asp:Content>
