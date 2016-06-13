<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="login.aspx.cs" Inherits="login" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 

<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="left">
            <h3>Please log in</h3>
            <p>Enter your username and password below.</p>
            <asp:Label ID="lblUserName" runat="server" Text="Label">User Name</asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" Text="Enter UserName"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label">Password</asp:Label>
            <asp:Textbox ID="txtPassword" runat="server" Text="Enter Password" type="password" />
            <asp:Button id="sbmtLogIn" class="btn" type="submit" value="Log In"/>
            <asp:Button ID="sbmtLogIn" runat="server" CssClass="btn" Text="Button"  onclick="btnLogin_Click" />
        </div>
        <div class="right">
            <h3>Create New Account</h3>
            <p>Don’t have an account? Click the button below to begin creating your own Williams Specialty Company account.</p>
            <a href="#"class="btn inverse">Create Account</a>
        </div>
    </div>
    <div class="cta">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>

