<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="WebApplication2.Doctor" EnableViewStateMac="True" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<br /> <br /> <br /> <br /> <br />
List of Doctors:
<div>
<br />
<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
<br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</div>
</asp:Content>