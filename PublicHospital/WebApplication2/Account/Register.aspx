<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication2.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    <br />
    <br />
    <div class="container" style="padding-top: 10px;">
        <div class="panel panel-default" style="width: 600px; vertical-align: middle; margin: auto;">
            <div class="panel-heading">
                <h3>Account Registration</h3>
            </div>
            <div class="panel-body">
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
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" Display="Dynamic"
                                CssClass="text-danger" ErrorMessage="The password field is required." />
                            <script type="text/javascript">
                                function ClientValidate(source, clientside_arguments) {
                                    if (clientside_arguments.Value.length >= 6) {
                                        clientside_arguments.IsValid = true;
                                    }
                                    else { clientside_arguments.IsValid = false };
                                }
                            </script>
                            <asp:CustomValidator ID="CustomValidator1" ClientValidationFunction="ClientValidate"
                                ControlToValidate="Password" runat="server" CssClass="text-danger" ErrorMessage="The password must be more than 6 characters."
                                Display="Dynamic"></asp:CustomValidator>
                            <asp:RegularExpressionValidator ID="regexpName" runat="server"
                                CssClass="text-danger"
                                ErrorMessage="The password has to contain at least one digit and one alphabetic character, and must not contain special characters."
                                ControlToValidate="Password"
                                ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,16})$" />
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
                            <asp:Button ID="RegisterBth" runat="server" Text="Register" OnClick="RegisterPatient" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
</asp:Content>
