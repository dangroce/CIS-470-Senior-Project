<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="catalog.aspx.cs" Inherits="WebSite1_catalog" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <h3 class="Catlog">Catalog</h3>

        <asp:Label ID="lblCart" CssClass="lblCart" runat="server" Text="Shoping Cart"></asp:Label>
        <asp:Label ID="lblCartCount" CssClass="lblCart" runat="server" ></asp:Label>
    </div>
    <div class="products_holder">
        <asp:Repeater ID="dlCatalogs" runat="server">
            <ItemTemplate>
                <div class="prod">
                    <img src="../images/prod1.png" alt="Alternate Text" />
                    <h5> <%# Eval("productdescription") %></h5>
                    <p>May the Force be with you.</p>
                    <h5>$<%# Eval("retailcost")%></h5>
                    <p>Type: <%# Eval("producttype")%></p>
                    <asp:Button ID="btnProduct1_1" class="btn inverse" OnClick="btnProduct" runat="server" Text="Purchase" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
    </div>
    <div class="cta">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>