<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="addproduct.aspx.cs" Inherits="addproduct" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %>
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="full form_content">
       <h3>Add a New Product</h3>
        <!-- only show this product ID when editing another product, we will search by ID to edit however do not update ID -->
        <asp:Label ID="lblProductID" runat="server" Text="Search By Product ID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
        <asp:Label ID="lblProductType" runat="server" Text="Product Type"></asp:Label>
        <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox>
        <asp:Label ID="lblWholeSale" runat="server" Text="Whole Sale Cost"></asp:Label>
        <asp:TextBox ID="txtWholeSale" runat="server"></asp:TextBox>
        <asp:Label ID="lblRetailCost" runat="server" Text="Retail Cost"></asp:Label>
        <asp:TextBox ID="txtRetailCost" runat="server"></asp:TextBox>
        <asp:Label ID="lblCurrentStock" runat="server" Text="Current Stock"></asp:Label>
        <asp:TextBox ID="txtCurrentStock" runat="server"></asp:TextBox>
        <asp:Label ID="lblImageUrl" runat="server" Text="Upload Image"></asp:Label>

        <div class="form_row">

            <asp:FileUpload ID="upProdImage" runat="server" CssClass="upload" />
            <asp:Button runat="server" id="UploadButton" CssClass="btn inverse" text="Upload" OnClick="UploadButton_Click" />
            <br />
            <asp:Label runat="server" id="StatusLabel" text="Upload status: " />
        </div>
        <asp:Button ID="btnProductAdd"  OnClick="btnProductAdd_Click" runat="server" Text="Submit" CssClass="btn"/>
        <asp:Button ID="btnProductEdit" OnClick="btnProductEdit_Click" runat="server" Text="Edit" CssClass="btn"/>

    </div>
</asp:Content>