<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Account.Login" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <div class="container" id="div1">
        <h2></h2>
        <div class="panel panel-default">
            <div class="panel-heading">
                <h4 id="h4_1">Log in to continue</h4>
            </div>
            <div class="panel-body">
                <div class="panel-body" id="div2">
                    <div class="form-group">
                        <label for="usr">Username:</label>
                        <asp:TextBox runat="server" ID="Loginn" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="pwd">Password:</label>
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                    </div>
                    <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-success" />
                </div>
                <div id="div3">
                    <asp:Label ID="Labell" runat="server" Text="Label" CssClass="label label-warning"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <link href="../Content/LoginStyleSheet.css" rel="stylesheet" />
</asp:Content>
