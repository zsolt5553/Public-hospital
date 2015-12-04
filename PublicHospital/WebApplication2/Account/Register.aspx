<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication2.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br/><br/><br/><br/>

    <h2><asp:Label ID="Label1" runat="server" Text="Create a new account"></asp:Label>
    </h2>
    <br/><br/>
    <p>
        <asp:Label ID="FNameLb" runat="server" Text="First name:" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="FName" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="FName"
            CssClass="text-danger" ErrorMessage="The first name field is required." />
    </p>
    <p>
        <asp:Label ID="LNameLb" runat="server" Text="Last name:" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="LName" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="LName"
            CssClass="text-danger" ErrorMessage="The last name field is required." />
    </p>
    <p>
        <asp:Label ID="DateOfBirthLb" runat="server" Text="Date of birth:"></asp:Label>
        <asp:TextBox ID="DateOfBirth" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="DateOfBirth"
            CssClass="text-danger" ErrorMessage="The date of birth field is required." />
    </p>
    <p>
        <asp:Label ID="ZipLb" runat="server" Text="Zip:"></asp:Label>
        <asp:TextBox ID="Zip" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="Zip"
            CssClass="text-danger" ErrorMessage="The zip field is required." />
        <asp:RangeValidator runat="server" ControlToValidate="Zip"
            CssClass="text-danger" MinimumValue="1000" MaximumValue="9999" Type="Integer"
            Text="The value must be from 1000 to 9999!" />
    </p>
    <p>
        <asp:Label ID="CityLb" runat="server" Text="City:"></asp:Label>
        <asp:TextBox ID="City" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="City"
            CssClass="text-danger" ErrorMessage="The city field is required." />
    </p>
    <p>
        <asp:Label ID="StreetLb" runat="server" Text="Street:"></asp:Label>
        <asp:TextBox ID="Street" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="Street"
            CssClass="text-danger" ErrorMessage="The street field is required." />
    </p>
    <p>
        <asp:Label ID="StreetNrLb" runat="server" Text="Street number:"></asp:Label>
        <asp:TextBox ID="StreetNr" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="StreetNr"
            CssClass="text-danger" ErrorMessage="The street number field is required." />
    </p>
    <p>
        <asp:Label ID="PhoneLb" runat="server" Text="Phone number:"></asp:Label>
        <asp:TextBox ID="Phone" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="Phone"
            CssClass="text-danger" ErrorMessage="The phone number field is required." />
    </p>
    <p>
        <asp:Label ID="UsernameLb" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="Username" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="Username"
            CssClass="text-danger" ErrorMessage="The username field is required." />
    </p>
    <p>
        <asp:Label ID="PasswordLb" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
            CssClass="text-danger" ErrorMessage="The password field is required." />
    </p>
    <p>
        <asp:Label ID="CPasswordLb" runat="server" Text="Confirm password:"></asp:Label>
        <asp:TextBox ID="ConfPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfPassword"
            CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfPassword"
            CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
    </p>
    <p>
        <asp:Button ID="RegisterBth" runat="server" Text="Register" OnClick="RegisterPatient" CssClass="btn btn-default" />
    </p>

    <%--<div class="col-lg-12 col-md-12">
        <h4 style="text-align: center">Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="col-lg-2 col-md-2"></div>
        <div class="col-lg-8 col-md-8">

            <div class="col-lg-12 col-md-12">
                <div class="col-lg-6 col-md-6">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-3 control-label">First name:</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                                CssClass="text-danger" ErrorMessage="The first name field is required." />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6 col-md-6">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-3 control-label">Last name:</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="LastName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                                CssClass="text-danger" ErrorMessage="The last name field is required." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="DateOfBirth" CssClass="col-md-3 control-label">Date of birth:</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="DateOfBirth" CssClass="form-control" TextMode="Date" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="DateOfBirth"
                            CssClass="text-danger" ErrorMessage="The date of birth field is required." />
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="col-lg-4 col-md-4">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Zip" CssClass="col-md-6 control-label">Zip code:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="Zip" CssClass="form-control" TextMode="Number" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Zip"
                                CssClass="text-danger" ErrorMessage="The zip field is required." />
                            <asp:RangeValidator runat="server" ControlToValidate="Zip"
                                MinimumValue="1000" MaximumValue="9999" Type="Integer"
                                Text="The value must be from 1000 to 9999!" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-8 col-md-8">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="City" CssClass="col-md-3 control-label">City:</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="City" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="City"
                                CssClass="text-danger" ErrorMessage="The city field is required." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="col-lg-8 col-md-8">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Street" CssClass="col-md-2 control-label">Street:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Street" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Street"
                                CssClass="text-danger" ErrorMessage="The street field is required." />
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-4">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="StreetNr" CssClass="col-md-6 control-label">Street number:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="StreetNr" CssClass="form-control" TextMode="Number" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="StreetNr"
                                CssClass="text-danger" ErrorMessage="The street number field is required." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Phone" CssClass="col-md-3 control-label">Phone number:</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="Phone" CssClass="form-control" TextMode="Phone" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Phone"
                            CssClass="text-danger" ErrorMessage="The phone number field is required." />
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Username" CssClass="col-md-3 control-label">Username:</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="Username" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Username"
                            CssClass="text-danger" ErrorMessage="The username field is required." />
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-3 control-label">Password</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                            CssClass="text-danger" ErrorMessage="The password field is required." />
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-3 control-label">Confirm password</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                    </div>
                </div>
            </div>
            <div class="col-lg-12 col-md-12">
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server" OnClick="RegisterPatient" Text="Register" CssClass="btn btn-default" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-2 col-md-2"></div>
    </div>--%>


    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
</asp:Content>
