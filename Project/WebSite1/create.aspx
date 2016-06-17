<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="create.aspx.cs" Inherits="WebSite1_create" %>
<%@ MasterType VirtualPath ="~/MasterPage.master" %> 
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form_content create">
        <div class="left">
            <h3>Create New Account</h3>
            <p>Please enter your information for your account.</p>
            <asp:Label ID="lblCreateUserName" runat="server" Text="Label">User Name</asp:Label>
            <input id="txtCreateUserName" placeholder="Enter UserName" type="text" />
            <asp:Label ID="lblCreatePassword" runat="server" Text="Label">Password</asp:Label>
            <input id="txtCreatePassword" placeholder="Enter Password" type="text" />
            <asp:Label ID="lblCreateFirstName" runat="server" Text="Label">First Name</asp:Label>
            <input id="txtCreateFirstName" placeholder="Enter Name" type="text" />
            <asp:Label ID="lblCreateLastName" runat="server" Text="Label">Last Name</asp:Label>
            <input id="txtCreateLastName" placeholder="Enter Last Name" type="text" />
            <asp:Label ID="lblCreateAddress" runat="server" Text="Label">Address</asp:Label>
            <input id="txtCreateAddress" placeholder="Address Line 1" type="text" />
            <asp:Label ID="lblCreateAddress2" runat="server" Text="Label">Address 2</asp:Label>
            <input id="txtCreateAddress2" placeholder="Address Line 2" type="text" />
            <asp:Label ID="lblCreateCity" runat="server" Text="Label">City</asp:Label>
            <input id="txtCreateCity" placeholder="Enter City" type="text" />
            <asp:Label ID="lblCreateState" runat="server" Text="Label">State</asp:Label>
            <select id="slctState">
                <option value="#"  selected disabled>Select a State</option>
                <option value="AL">Alabama</option>
	            <option value="AK">Alaska</option>
	            <option value="AZ">Arizona</option>
	            <option value="AR">Arkansas</option>
	            <option value="CA">California</option>
	            <option value="CO">Colorado</option>
	            <option value="CT">Connecticut</option>
	            <option value="DE">Delaware</option>
	            <option value="DC">District Of Columbia</option>
	            <option value="FL">Florida</option>
	            <option value="GA">Georgia</option>
	            <option value="HI">Hawaii</option>
	            <option value="ID">Idaho</option>
	            <option value="IL">Illinois</option>
	            <option value="IN">Indiana</option>
	            <option value="IA">Iowa</option>
	            <option value="KS">Kansas</option>
	            <option value="KY">Kentucky</option>
	            <option value="LA">Louisiana</option>
	            <option value="ME">Maine</option>
	            <option value="MD">Maryland</option>
	            <option value="MA">Massachusetts</option>
	            <option value="MI">Michigan</option>
	            <option value="MN">Minnesota</option>
	            <option value="MS">Mississippi</option>
	            <option value="MO">Missouri</option>
	            <option value="MT">Montana</option>
	            <option value="NE">Nebraska</option>
	            <option value="NV">Nevada</option>
	            <option value="NH">New Hampshire</option>
	            <option value="NJ">New Jersey</option>
	            <option value="NM">New Mexico</option>
	            <option value="NY">New York</option>
	            <option value="NC">North Carolina</option>
	            <option value="ND">North Dakota</option>
	            <option value="OH">Ohio</option>
	            <option value="OK">Oklahoma</option>
	            <option value="OR">Oregon</option>
	            <option value="PA">Pennsylvania</option>
	            <option value="RI">Rhode Island</option>
	            <option value="SC">South Carolina</option>
	            <option value="SD">South Dakota</option>
	            <option value="TN">Tennessee</option>
	            <option value="TX">Texas</option>
	            <option value="UT">Utah</option>
	            <option value="VT">Vermont</option>
	            <option value="VA">Virginia</option>
	            <option value="WA">Washington</option>
	            <option value="WV">West Virginia</option>
	            <option value="WI">Wisconsin</option>
	            <option value="WY">Wyoming</option>
            </select>
            <input id="sbmtCreat" class="btn" type="submit" value="Create Account" />
        </div>
        <div class="right">
            <h3>Have an Account?</h3>
            <p>Already have an account? Click the Log In button below to sign in with your existing Williams Specialty Company account. You must have an account to log in.</p>
            <a href="login.aspx"class="btn inverse">Log In</a>
        </div>
    </div>
    <div class="cta clr">
        <h3>need a custom order?</h3>
        <a href="#"class="btn inverse">call now</a>
    </div>
</asp:Content>

