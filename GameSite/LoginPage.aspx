<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="GameSite.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-login">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-6 col-sm-offset-3">
                                <h3 class="bg-info text-center">Giriş Yap</h3>
                            </div>
             
                        </div>
                        <hr>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-lg-12">
                                <form id="login-form"  method="post" role="form" style="display: block;">
                                    <label id="lblUyari" class="text-danger" runat="server"></label>
                                    <div class="form-group">
                                        <input type="text" name="username" id="txtUserName"  tabindex="1" class="form-control" placeholder="Kullanıcı Adı" runat="server">
                                    </div>
                                    <div class="form-group">
                                        <input type="password" name="password" id="txtPassword" tabindex="2" class="form-control" placeholder="Şifre" runat="server">
                                    </div>
                                  
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-sm-6 col-sm-offset-3">
                                                <input type="submit" name="login-submit" tabindex="4" class="form-control btn btn-primary" value="Giriş Yap">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <div class="text-center">
                                                    <a href="https://phpoll.com/recover" tabindex="5" class="btn btn-danger">Şifrenizi mi Unuttunuz?</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                              </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
