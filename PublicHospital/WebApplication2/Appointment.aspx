<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="WebApplication2.Doctors" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>
    
    </div>
       <br> 
       <br> 
       <br> 
    <asp:Label ID="Label1" runat="server" Text="Choose a desired date"></asp:Label>
       <br> 
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

    <div>
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="sds" Height="146px" Width="244px">
               <Columns>
                   <asp:BoundField DataField="dd" SortExpression="dd" />
               </Columns>
           </asp:GridView>
           <br> 
           <br> 
    
    </div>
 
</asp:Content>
