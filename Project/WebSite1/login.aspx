<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="login.aspx.cs" Inherits="login" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 

<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form_content">
        <div class="left">
            <h3>Please log in</h3>
            <p>Enter your username and password below.</p>
            <div class="form_row">
                 <asp:Label ID="lblUserName" runat="server" Text="Label">User Name</asp:Label>
                 <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter UserName"></asp:TextBox>
            </div>
            <div class="form_row">
                <asp:Label ID="Label1" runat="server" Text="Label">Password</asp:Label>
                <asp:Textbox ID="txtPassword" runat="server" placeholder="Enter Password" type="password" />
            </div>
            <div class="form_row">
                <asp:Button ID="sbmtLogIn" runat="server" CssClass="btn" Text="Log In"  onclick="btnLogin_Click" />
            </div>
        </div>
        <div class="right">
            <h3>Create New Account</h3>
            <p>Don’t have an account? Click the button below to begin creating your own Williams Specialty Company account.</p>
            <a href="create.aspx"class="btn inverse">Create Account</a>
        </div>
    </div>
    <div class="cta clr">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>

