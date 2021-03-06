﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" MaintainScrollPositionOnPostback="true" CodeFile="catalog.aspx.cs" Inherits="WebSite1_catalog" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <h3 class="Catlog">Catalog</h3>

        <asp:Label ID="lblCart" CssClass="lblCart" runat="server" Text="Items in Your Order: "></asp:Label>
        <asp:Label ID="lblCartCount" CssClass="lblCart" runat="server" ></asp:Label>
    </div>
    <div class="products_holder">
        <asp:Repeater ID="dlCatalogs" runat="server" OnItemCommand="dlCatalogs_ItemCommand">
            <ItemTemplate>
                <div class="prod">
                    <asp:Image ID="ProdImg" ImageUrl='<%# Eval("ImageUrl") %>' runat="server" AlternateText="Alternate Text" />
                    <h5> <%# Eval("productdescription") %></h5>
                    <p>May the Force be with you.</p>
                    <h5>$<%# Eval("retailcost")%></h5>
                    <p>Type: <%# Eval("producttype")%></p>                    
                    <asp:Label ID="lblProductAdded" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Button ID="btnPurchase" CommandName="addtocart" CommandArgument='<%# Eval("itemid") %>' UseSubmitBehavior="false" class="btn inverse" runat="server" Text="Purchase" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
    </div>
    <div class="cta">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>