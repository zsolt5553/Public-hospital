<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServiceList.aspx.cs" Inherits="WebApplication2.SrviceList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="panel panel-info">
        <div class="panel-heading">
            <h4 id="h4_1">Types of services</h4>
        </div>
        <div class="panel-body">
            <div class="table-responsive">
                <asp:table runat="server" ID="Tablee" CssClass="table table-striped"></asp:Table>
            </div>
        </div>
    </div>
</asp:Content>
