<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication2.Account.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    <br />
    <br />
    <div class="container" style="padding-top: 10px;">
        <div class="panel panel-default" style="vertical-align:middle;margin:auto;">
            <div class="panel-heading">
                <h3>Profile page</h3>
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-8 col-lg-8" style="width:600px; padding-left:10px">
                        <div class="form-group">
                    <label for="FName" class="control-label">Name:</label>
                    <div class="row">
                        <div class="col-md-6 col-lg-6">
                            <asp:TextBox ID="FName" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="FName"
                                CssClass="text-danger" ErrorMessage="The first name field is required." />
                        </div>
                        <div class="col-md-6 col-lg-6">
                            <asp:TextBox ID="LName" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="LName"
                                CssClass="text-danger" ErrorMessage="The last name field is required." />
                        </div>
                    </div>
                    <label for="DateOfBirth" class="control-label">Date of birth:</label>
                    <div class="row">
                        <div class="col-md-12 col-lg-12">
                            <asp:TextBox ID="DateOfBirth" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="DateOfBirth"
                                CssClass="text-danger" ErrorMessage="The date of birth field is required." />
                        </div>
                    </div>
                    <label for="Street" class="control-label">Address:</label>
                    <div class="row">
                        <div class="col-md-8 col-lg-8">
                            <asp:TextBox ID="Street" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Street"
                                CssClass="text-danger" ErrorMessage="The street field is required." />
                        </div>
                        <div class="col-md-4 col-lg-4">
                            <asp:TextBox ID="StreetNr" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="StreetNr"
                                CssClass="text-danger" ErrorMessage="The street number field is required." />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-8 col-lg-8">
                            <label for="City" class="control-label">City:</label>
                        </div>
                        <div class="col-md-4 col-lg-4">
                            <label for="Zip" class="control-label">Zipcode:</label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-8 col-lg-8">
                            <asp:TextBox ID="City" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="City"
                                CssClass="text-danger" ErrorMessage="The city field is required." />
                        </div>
                        <div class="col-md-4 col-lg-4">
                            <asp:TextBox ID="Zip" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Zip"
                                CssClass="text-danger" ErrorMessage="The zip field is required." />
                            <asp:RangeValidator runat="server" ControlToValidate="Zip" CssClass="text-danger"
                                MinimumValue="1000" MaximumValue="9999" Type="Integer"
                                Text="The value must be from 1000 to 9999!" />
                        </div>
                    </div>
                    <label for="Phone" class="control-label">Phone number:</label>
                    <div class="row">
                        <div class="col-md-12 col-lg-12">
                            <asp:TextBox ID="Phone" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Phone"
                                CssClass="text-danger" ErrorMessage="The phone number field is required." />
                        </div>
                    </div>
                    <label for="Username" class="control-label">Username:</label>
                    <div class="row">
                        <div class="col-md-12 col-lg-12">
                            <asp:TextBox ID="Username" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Username"
                                CssClass="text-danger" ErrorMessage="The username field is required." />
                        </div>
                    </div>
                    <label for="Password" class="control-label">Password:</label>
                    <div class="row">
                        <div class="col-md-12 col-lg-12">
                            <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                    <label for="ConfPassword" class="control-label">Confirm password:</label>
                    <div class="row">
                        <div class="col-md-12 col-lg-12">
                            <asp:TextBox ID="ConfPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                            <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                        </div>
                    </div>
                    <div class="row" style="padding-top: 20px;">
                        <div class="col-md-12 col-lg-12">
                            <asp:Button ID="UpdateBth" runat="server" Text="Update" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
                    </div>
                    <div class="col-md-4 col-lg-4 text-center" style="padding-top:40px; padding-left:10px;">
                        <asp:GridView ID="AppointmentsGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="Appointment" Width="400px" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                                <asp:BoundField DataField="serviceType" HeaderText="serviceType" SortExpression="serviceType" />
                                <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
                                <asp:CommandField ButtonType="Button"  ShowDeleteButton="True" ControlStyle-CssClass="btn btn-default" DeleteText="Delete"/>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                        <asp:ObjectDataSource ID="Appointment" runat="server" SelectMethod="GetAppointmentsAfterCurrentDateByPatient" TypeName="WebApplication2.AppointmentServiceRef.AppointmentServiceClient" DeleteMethod="DeleteAppointment" OnDeleting="Appointment_Deleting" OnSelecting="Appointment_Selecting">
                            <DeleteParameters>
                                <asp:Parameter Direction="InputOutput" Name="appointment" Type="Object" />
                                <asp:Parameter Direction="InputOutput" Name="message" Type="String" />
                            </DeleteParameters>
                            <SelectParameters>
                                <asp:Parameter Name="id" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </div>
                </div>
                
            </div>
        </div>
    </div>

    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
</asp:Content>
