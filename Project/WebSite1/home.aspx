<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="home.aspx.cs" Inherits="WebSite1_home" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="home_hero">
           <div class="image_holder">
               <div class="content">
                   <h2>
                       Custom Engraving<br /> and Printing Services
                   </h2>
                   <h4>
                       Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
                   </h4>
                   <a href="catalog.aspx" class="btn inverse">view catalog</a>
                   <a href="login.aspx" class="btn">log in</a>
               </div>
              </div>
       </div>
       <div class="products_holder">
           <h3>Featured Products View</h3>
           <p>View our featured products to find the perfect print or engraving that is right for your needs. </p>
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
          </div>
           <a href="#" class="btn">view all</a>
       </div>
        <div class="cta clr">
            <h3>need a custom order?</h3>
            <a href="#"class="btn inverse">call now</a>
        </div>
</asp:Content>
