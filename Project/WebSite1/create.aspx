<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="create.aspx.cs" Inherits="create" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form_content create">
        <div class="left">
            <h3>Create New Account</h3>
            <p>Please enter your information for your account.</p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <asp:Label ID="lblCreateUserName" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox id="txtUserName" runat="server"/>
            <asp:Label ID="lblCreatePassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox id="txtPassword" runat="server"/>
            <asp:Label ID="lblCreateFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox id="txtFirstName" runat="server"/>
            <asp:Label ID="lblCreateLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox id="txtLastName" runat="server"/>
            <asp:Label ID="lblAddress1" runat="server" Text="Address"></asp:Label>
            <asp:TextBox id="txtAddress" runat="server"/>
            <asp:Label ID="lblAddress2" runat="server" Text="Address 2"></asp:Label>
            <asp:TextBox id="txtAddress2" runat="server"/>
            <asp:Label ID="lblCreateCity" runat="server" Text="City"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"/>
            <asp:Label ID="lblCreateState" runat="server" Text="State"></asp:Label>
            <asp:TextBox ID="txtState" runat="server"/>
            <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label>
            <asp:TextBox ID="txtZip" runat="server"/>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" />
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:Button ID="sbmtCreat" CssClass="btn" runat="server" Text="Create Account" OnClick="btnSubmit_Click"/>
        </div>
        <div class="right">
            <h3>Have an Account?</h3>
            <p>Already have an account? Click the Log In button below to sign in with your existing Williams Specialty Company account. You must have an account to log in.</p>
            <a href="login.aspx"class="btn inverse">Log In</a>
        </div>
    </div>
    <div class="cta clr">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>

