<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="orders.aspx.cs" Inherits="WebSite1_orders" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <h3>Complete Your Order</h3>
    </div>
    <div class="content center">
        <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField AccessibleHeaderText="Item Count" DataField="itemcount" HeaderText="Item Count" />
                <asp:BoundField AccessibleHeaderText="Description" DataField="Description" HeaderText="Description" />
                <asp:BoundField AccessibleHeaderText="Order Date" DataField="orderdate" HeaderText="Order Date" />
                <asp:BoundField AccessibleHeaderText="Amount" DataField="amount" HeaderText="Amount" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>