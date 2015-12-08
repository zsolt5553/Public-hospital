<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <div class="container" style="background-color: #CCCCCC; margin-bottom: 50px; white-space: nowrap;">
        <div class="panel panel-default" style="background-color: #CCCCCC; margin-bottom: 50px; white-space: nowrap;">
             <div class="panel-heading" style="margin:0px; background-image: url('http://localhost:56391/Images/Scrubs - Zach Braff In Hospital11.jpg');">
                 <div class="jumbotron" style="background:rgba(0,0,0,0); background-size: cover;margin:0px;">
                 </div>
             </div>
            <div class ="panel-body" style="background-color: #CCCCCC; margin-bottom: 50px; white-space: nowrap;">
                <div class="row">
                    <div class="col-md-4 col-lg-4 text-center">
                         <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;" itemscope="itemscope">Making an appointment</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/appointmentMake.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/Appointment.aspx" />
                    </p>
                    </div>
                    <div class="col-md-4 col-lg-4 text-center">
                        <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;" itemscope="itemscope">Service type</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/servicetype.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/ServicesPage.aspx" />
                    </p>
                    </div>
                    <div class="col-md-4 col-lg-4 text-center">
                        <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;" itemscope="itemscope">Doctors</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/doctorgondolkodik.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/Doctors.aspx" />
                    </p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6 col-lg-6 text-center">
                        <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Visiting the hospital</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/visithosp.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                    </div>
                     <div class="col-md-6 col-lg-6 text-center" >
                          <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Profile</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/profile.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/Account/Profile.aspx" />
                    </p>
                    </div>
                </div>
            </div>
        </div>
    </div>

      <%-- </div>
        <div class="jumbotron" style="border: thin groove #000000; background-image: url('http://localhost:56391/Images/Scrubs - Zach Braff In Hospital11.jpg'); ">
    </div>
   
    </div>
   
    <div class="container" style="background-color: #CCCCCC; margin-bottom: 50px; white-space: nowrap;">
        <div class="row">
            <div class="col-md-9">
            </div>
            <div class="row">
                <div class="col-md-4">
                   <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;" itemscope="itemscope">Making an appointment</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/appointmentMake.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/Appointment.aspx" />
                    </p>
                  
                </div>
                <div class="col-md-4">
                    <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;" itemscope="itemscope">Service type</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/servicetype.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/ServicesPage.aspx" />
                    </p>
                      </div>
                <div class="col-md-4">
                       </div>
                <div class="col-md-4">
                    <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;" itemscope="itemscope">Doctors</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/doctorgondolkodik.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/Doctors.aspx" />
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
                   <h2 style="font-family: 'times New Roman', Times, serif; font-size: x-large; color: #000000; font-style: inherit; text-transform: uppercase;">Profile</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/history.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" PostBackUrl="~/Account/Profile.aspx" />
                    </p>
                      </div>
                <div class="col-md-4">
    </div>
    </div>
    </div>
    </div>--%>
</asp:Content>
