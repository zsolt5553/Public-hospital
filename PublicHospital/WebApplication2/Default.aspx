<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    </div><!--end_col-md-3-->
    </div><!--end_row-->
    <div class="jumbotron" style="background-image: url('Images/hospital_1300x400.jpg');">
    </div>
    <!--end_.jumbo-->
    </div><!--end_container-->
    <div class="container">
        <div class="row">
            <div class="col-md-9">
            </div>
            <div class="row">
                <div class="col-md-4">
                    <h2>Making an appointment</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/appointmentMake.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                  
                </div>
                <div class="col-md-4">
                    <h2>Service type</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/servicetype.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">
                       </div>
                <div class="col-md-4">
                    <h2>Doctors</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/doctorgondolkodik.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">
                  
            </div>
                <br> 
                   <div class="col-md-4">
                    <h2>Visiting the hospital</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/visithosp.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">

        </div>
                    <div class="col-md-4">
                    <h2>History</h2>
                    <p>
                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/history.jpg" BorderStyle="Ridge" BorderWidth="5px" BorderColor="#0033CC" />
                    </p>
                      </div>
                <div class="col-md-4">
    </div>
    </div>
    </div>
</asp:Content>
