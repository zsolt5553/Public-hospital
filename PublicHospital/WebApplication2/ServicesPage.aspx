<%@ Page Title="Services" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ServicesPage.aspx.cs" Inherits="WebApplication2.ServicesPage" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <br />

    <br />
    <br />
<%--    <div class="container" style="padding-top: 10px;">
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3>Services page</h3>
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-mg-6 col-lg-6 text-center">
                        <asp:TreeView ID="TreeView1" runat="server" CssClass="media" BorderStyle="None" ExpandDepth="1" LineImagesFolder="~/TreeLineImages" Width="130px" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" on>
                        </asp:TreeView>
                    </div>
                    <div class="col-mg-6 col-lg-6 text-center">
                        <asp:FormView ID="DoctorFormView" runat="server"></asp:FormView>
                    </div>
                </div>

            </div>

        </div>
    </div>--%>

         <div style="width: 100%; background-image: url('Images/Bupa-Cromwell-Hospital-Website-Wallpaper-For-Health-Professionals.jpg'); margin-left: 40px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

         <asp:Panel ID="Panel1" runat="server" Height="270px" HorizontalAlign="Center" style="margin-top: 0px">
             <br />
             <br />
             <asp:TreeView ID="TreeView1" runat="server" CssClass="media" BorderStyle="None" ExpandDepth="1" LineImagesFolder="~/TreeLineImages" Width="130px" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large">
             </asp:TreeView>
         </asp:Panel>
        
         </div>
</asp:Content>

