<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="GameSite.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="col-md-3 text-center">

        <table class="table">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Oyun Adı</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="rptCompany" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Container.ItemIndex + 1 %></td>
                            <td><%# Eval("Name") %></td>
                            
                           
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

    </div>
</asp:Content>
