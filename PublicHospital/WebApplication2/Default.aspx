<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       </div>
        <div class="jumbotron" style="border: thin groove #000000; background-image: url('http://localhost:56391/Images/Scrubs - Zach Braff In Hospital11.jpg'); ">
    </div>
    <!--end_.jumbo-->
    </div><!--end_container-->
    <div class="container" style="background-color: #CCCCCC; margin-bottom: 50px; white-space: nowrap;">
        <div class="row">
            <div class="col-md-9">
            </div>
            <div class="row">
                <div class="col-md-4">
                   <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Making an appointment</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/appointmentMake.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                  
                </div>
                <div class="col-md-4">
                    <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Service type</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/servicetype.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">
                       </div>
                <div class="col-md-4">
                    <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Doctors</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/doctorgondolkodik.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">
                  
            </div>
                <br> 
                   <div class="col-md-4">
                   <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Visiting the hospital</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/visithosp.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">

        </div>
                    <div class="col-md-4">
                   <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">History</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/history.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">
    </div>
    </div>
    </div>
    </div>
</asp:Content>
