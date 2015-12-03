<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Account.Login" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <div class="container" style="width:370px;">
        <h2></h2>
        <div class="panel panel-default">
            <div class="panel-heading"><h4 style="text-align:center;">Log in to continue</h4></div>
            <div class="panel-body">
                <div class="panel-body" style="vertical-align:middle;text-align:center;">
                <div class="form-group">
                    <label for="usr">Username:</label>
                    <input type="text" class="form-control" id="usr">
                </div>
                <div class="form-group">
                    <label for="pwd">Password:</label>
                    <input type="password" class="form-control" id="pwd">
                </div>
                <button type="button" class="btn btn-success" onclick="Login()">Log in</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>