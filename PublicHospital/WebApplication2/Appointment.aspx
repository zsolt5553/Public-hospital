<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="WebApplication2.Appointment" EnableViewStateMac="True" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <br />
    <br />

    <div class="container" style="padding-top: 10px;">
        <div class="panel panel-default" style="width:600px;vertical-align:middle;margin:auto;">
            <div class="panel-heading">
                <h3>New appointment</h3>
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-mg-6 col-lg-6 text-center">
                        <asp:Label ID="Label2" runat="server" Text="Please choose your desired doctor" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>
                    </div>
                    <div class="col-mg-6 col-lg-6 text-center">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True" OnLoad="DropDownList1_Load" AutoPostBack="True" ViewStateMode="Enabled">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row" style="padding-top:10px">
                    <div class="col-mg-12 col-lg-12 text-center">
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="277px" Width="556px" OnDayRender="Calendar1_DayRender" CellPadding="1">
                            <DayHeaderStyle BackColor="#99CCCC" Height="1px" ForeColor="#336666" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" BorderColor="#3366CC" BorderWidth="1px" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                    </div>
                </div>
                <div class="row" style="padding-top:10px">
                    <div class="col-mg-12 col-lg-12">
                        <asp:Label ID="Label1" runat="server" Text="Choose your desired time" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" Visible="False" BorderStyle="None"></asp:Label>
                    </div>
                </div>
                <asp:Panel ID="Panel1" runat="server" Height="27px" Visible="False">
                <div class="row" style="padding-top:10px">
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button730" runat="server" Text="07:30" width=80% CssClass="btn btn-default"/>
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button800" runat="server" Text="08:00" width=80% CssClass="btn btn-default"/>
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button830" runat="server" Text="08:30"  width=80% CssClass="btn btn-default"/>
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                         <asp:Button ID="Button900" runat="server" Text="09:00"  width=80% CssClass="btn btn-default"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button930" runat="server" Text="09:30" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1000" runat="server" Text="10:00" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1030" runat="server" Text="10:30" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1100" runat="server" Text="11:00" width=80% CssClass="btn btn-default" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1130" runat="server" Text="11:30" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1200" runat="server" Text="12:00" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1230" runat="server" Text="12:30" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1300" runat="server" Text="13:00" width=80% CssClass="btn btn-default" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1330" runat="server" Text="13:30" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1400" runat="server" Text="14:00" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1430" runat="server" Text="14:30" width=80% CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1500" runat="server" Text="15:00" width=80% CssClass="btn btn-default" />
                    </div>
                </div>
                    </asp:Panel>
                <div class="row">
                    <div class="col-mg-3 col-lg-3 text-center"></div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1502" runat="server" OnClick="Button1502_Click" Text="Yes" Visible="False" BackColor="#999999" Font-Bold="True" Font-Size="Large" CssClass="btn btn-default" />
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center">
                        <asp:Button ID="Button1501" runat="server" OnClick="Button1501_Click" Text="No" Visible="False" BackColor="#999999" Font-Bold="True" Font-Size="Large"  CssClass="btn btn-default"/>
                    </div>
                    <div class="col-mg-3 col-lg-3 text-center"></div>
                </div>
            </div>
        </div>
    </div>

    <%-- <div style="width: 100%; background-image: url('Images/Bupa-Cromwell-Hospital-Website-Wallpaper-For-Health-Professionals.jpg'); margin-left: 40px; height: 610px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Please choose your desired doctor" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True" OnLoad="DropDownList1_Load" AutoPostBack="True" ViewStateMode="Enabled" >
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="277px" ShowGridLines="True" Width="556px" OnDayRender="Calendar1_DayRender">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        &nbsp;&nbsp;&nbsp;
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Choose your desired time" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" Visible="False" BorderStyle="None"></asp:Label>
    
        <asp:Panel ID="Panel1" runat="server" Height="27px" Visible="False" Width="988px" BackColor="#CCCCCC" BorderColor="Silver" BorderStyle="Solid" BorderWidth="5px">
            <asp:Button ID="Button730" runat="server" Height="22px" Text="07:30" Width="47px" />
&nbsp;
            <asp:Button ID="Button800" runat="server" Height="22px" Text="08:00" Width="47px" />
&nbsp;
            <asp:Button ID="Button830" runat="server" BackColor="Red" Height="22px" Text="08:30" Width="47px" />
&nbsp;
            <asp:Button ID="Button900" runat="server" Height="22px" Text="09:00" Width="47px" />
&nbsp;
            <asp:Button ID="Button930" runat="server" Height="22px" Text="09:30" Width="47px" />
            &nbsp;
            <asp:Button ID="Button1000" runat="server" Height="22px" Text="10:00" Width="47px" />
&nbsp;
            <asp:Button ID="Button1030" runat="server" Height="22px" Text="10:30" Width="47px" />
&nbsp;
            <asp:Button ID="Button1100" runat="server" Height="22px" Text="11:00" Width="47px" />
            &nbsp;
            <asp:Button ID="Button1130" runat="server" Height="22px" Text="11:30" Width="47px" />
            &nbsp;
            <asp:Button ID="Button1200" runat="server" Height="22px" Text="12:00" Width="47px" />
            &nbsp;
            <asp:Button ID="Button1230" runat="server" Height="22px" Text="12:30" Width="47px" />
&nbsp;
            <asp:Button ID="Button1300" runat="server" Height="22px" Text="13:00" Width="47px" />
&nbsp;
            <asp:Button ID="Button1330" runat="server" Height="22px" Text="13:30" Width="47px" />
            &nbsp;
            <asp:Button ID="Button1400" runat="server" Height="22px" Text="14:00" Width="47px" />
&nbsp;
            <asp:Button ID="Button1430" runat="server" Height="22px" Width="47px" Text="14:30" />
            &nbsp;
            <asp:Button ID="Button1500" runat="server" Height="22px" Text="15:00" Width="47px" />
            <br />
            <br />
            <br />
        </asp:Panel>
&nbsp;
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1502" runat="server" OnClick="Button1502_Click" Text="Yes" Visible="False" BackColor="#999999" Font-Bold="True" Font-Size="Large" />
        &nbsp;
        <asp:Button ID="Button1501" runat="server" OnClick="Button1501_Click" Text="No" Visible="False" BackColor="#999999" Font-Bold="True" Font-Size="Large" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;
    
    </div>

    <br />
    <br />--%>
 

</asp:Content>
