<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="WebApplication2.Doctors" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>
    
    </div>
       <br> 
       <br> 
       <br> 
    <asp:Label ID="Label1" runat="server" Text="Choose a desired date"></asp:Label>
       <br> 

    <div>
           <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
           <br> 
           <br> 
    
    </div>
 
</asp:Content>
