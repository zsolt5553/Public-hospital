<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="WebApplication2.Appointment" EnableViewStateMac="True" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br /> <br /> <br /> <br /> <br />

    <div>
        <asp:Label ID="Label2" runat="server" Text="Please choose your desired doctor"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True" OnLoad="DropDownList1_Load" AutoPostBack="True" ViewStateMode="Enabled" >
        </asp:DropDownList>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
 

</asp:Content>
