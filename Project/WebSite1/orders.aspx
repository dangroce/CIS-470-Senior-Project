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
                <asp:BoundField AccessibleHeaderText="Total" DataField="Total" HeaderText="Total" />
            </Columns>
        </asp:GridView>
        <div class="purchase">
            <asp:Button ID="btnComplete"  OnClick="btnComplete_Click" runat="server" Text="Complete Order" CssClass="btn"/>
        </div>

        <div class="previous_orders">
            <asp:GridView ID="gvPurchases" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField AccessibleHeaderText="Order Number" DataField="orderid" HeaderText="Order Number" />
                    <asp:BoundField AccessibleHeaderText="Sales Person ID" DataField="salerid" HeaderText="Sales Person ID" />
                    <asp:BoundField AccessibleHeaderText="Order Amount" DataField="orderamount" HeaderText="Order Amount" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>