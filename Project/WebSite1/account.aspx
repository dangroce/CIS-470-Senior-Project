<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="account.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %>
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="full form_content">
       <h3>Edit Your Account Information</h3>
        <asp:Label ID="lblSearchE" runat="server" Text="Search by Email"></asp:Label>
        <asp:TextBox ID="txtSearchE" runat="server"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUserNameA" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="txtUserNameA" runat="server"></asp:TextBox>
        <asp:Label ID="lblFirstNameA" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstNameA" runat="server"></asp:TextBox>
        <asp:Label ID="lblLastNameA" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastNameA" runat="server"></asp:TextBox>
        <asp:Label ID="lblMiddleNameA" runat="server" Text="Middle Name"></asp:Label>
        <asp:TextBox ID="txtMiddleNameA" runat="server"></asp:TextBox>
        <asp:Label ID="lblAddressA" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddressA" runat="server"></asp:TextBox>
        <asp:Label ID="lblAddress2A" runat="server" Text="Address Line 2"></asp:Label>
        <asp:TextBox ID="txtAddress2A" runat="server"></asp:TextBox>
        <asp:Label ID="lblCityA" runat="server" Text="City"></asp:Label>
        <asp:TextBox ID="txtCityA" runat="server"></asp:TextBox>
        <asp:Label ID="lblStateA" runat="server" Text="State"></asp:Label>
        <asp:TextBox ID="txtStateA" runat="server"></asp:TextBox>
        <asp:Label ID="lblZipA" runat="server" Text="Zip Code"></asp:Label>
        <asp:TextBox ID="txtZipA" runat="server"></asp:TextBox>
        <asp:Label ID="lblEmailA" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmailA" runat="server"></asp:TextBox>
        <asp:Label ID="lblPhoneNumberA" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhoneNumberA" runat="server"></asp:TextBox>
        <asp:Label ID="lblPasswordA" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPasswordA" runat="server"></asp:TextBox>
        <asp:Label ID="lblNewPassword" runat="server" Text="Confirm New Password"></asp:Label>
        <asp:TextBox ID="txtNewPasswordA" runat="server"></asp:TextBox>
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <asp:Label ID="lblEndDate" runat="server" Text="End Date"></asp:Label>
        <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
        <asp:Label ID="lblStatus" runat="server" Text="Statuse"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <asp:Button ID="btnEditA" OnClick="btnEditA_Click" runat="server" Text="Edit" CssClass="btn"/>
        <asp:Button ID="btnSaveA" OnClick="btnSaveA_Click" runat="server" Text="Save" CssClass="btn"/>
        <asp:Button ID="btnCancelA" OnClick="btnCancelA_Click" runat="server" Text="Cancel" CssClass="btn"/>

    </div>
</asp:Content>