<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="GameSite.Games" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="col-md-3 text-center">

        <table class="table">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Firma Adı</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="rptCompany" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Container.ItemIndex + 1 %></td>
                            <td><%# Eval("Name") %></td>
                            
                            <td>
                                <a href='GameModified.aspx?Id=<%# Eval("Id") %>' class="btn btn-warning btn-sm">Güncelle </a>
                                <a href='GameDeleted.aspx?Id=<%# Eval("Id") %>' class="btn btn-danger btn-sm">Sil</a>
                               
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

    </div>
</asp:Content>
