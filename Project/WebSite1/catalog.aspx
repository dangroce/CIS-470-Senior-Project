<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="catalog.aspx.cs" Inherits="WebSite1_catalog" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <h3>Catalog</h3>
    </div>
    <div class="products_holder">
        <div class="product_row">
            <!-- use a loop to for each div.prod -->
            <div class="prod">
                  <img src="../images/prod1.png" alt="Alternate Text" />
                  <h5>Product Name</h5>
                  <p>For Winners Only. No exceptions.</p>
                  <h5>Dimensions:</h5>
                  <p>label</p>
                  <a href="#" class="btn inverse">Purchase</a>
              </div>
               <div class="prod">
                  <img src="../images/prod2.png" alt="Alternate Text" />
                  <h5>Product Name</h5>
                  <p>For Winners Only. No exceptions.</p>
                  <h5>Dimensions:</h5>
                  <p>label</p>
                  <a href="#" class="btn inverse">Purchase</a>
              </div>
               <div class="prod">
                  <img src="../images/prod3.png" alt="Alternate Text" />
                  <h5>Product Name</h5>
                  <p>For Winners Only. No exceptions.</p>
                  <h5>Dimensions:</h5>
                  <p>label</p>
                  <a href="#" class="btn inverse">Purchase</a>
              </div>
            <div class="prod">
                  <img src="../images/prod1.png" alt="Alternate Text" />
                  <h5>Product Name</h5>
                  <p>For Winners Only. No exceptions.</p>
                  <h5>Dimensions:</h5>
                  <p>label</p>
                  <a href="#" class="btn inverse">Purchase</a>
              </div>
               <div class="prod">
                  <img src="../images/prod2.png" alt="Alternate Text" />
                  <h5>Product Name</h5>
                  <p>For Winners Only. No exceptions.</p>
                  <h5>Dimensions:</h5>
                  <p>label</p>
                  <a href="#" class="btn inverse">Purchase</a>
              </div>
               <div class="prod">
                  <img src="../images/prod3.png" alt="Alternate Text" />
                  <h5>Product Name</h5>
                  <p>For Winners Only. No exceptions.</p>
                  <h5>Dimensions:</h5>
                  <p>label</p>
                  <a href="#" class="btn inverse">Purchase</a>
              </div>
        </div>
        <div class="pagination">
            <a href="#" class="txt prev"><< Previous</a>
            <a href="#"class="txt current">1</a>
            <a href="#"class="txt">2</a>
            <a href="#"class="txt">3</a>
            <a href="#"class="txt">4</a>
            <a href="#"class="txt">5</a>
            <a href="#"class="txt">6</a>
            <a href="#" class="txt next">Next >></a>
        </div>
        
    </div>
    <div class="cta">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>