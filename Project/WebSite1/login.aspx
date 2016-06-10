<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="login.aspx.cs" Inherits="WebSite1_Default" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 

<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="left">
            <h3>Please log in</h3>
            <p>Enter your username and password below.</p>
            <asp:Label ID="lblUserName" runat="server" Text="Label">User Name</asp:Label>
            <input id="txtUserName" placeholder="Enter UserName" type="text" />
            <asp:Label ID="Label1" runat="server" Text="Label">Password</asp:Label>
            <input id="txtPassword" placeholder="Enter Password" type="password" />
            <input id="sbmtLogIn" class="btn" type="submit" value="Log In" />
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

