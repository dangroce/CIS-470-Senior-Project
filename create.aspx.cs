﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Website3
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtZip.MaxLength = 5;
            
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Checking validation for the text boxes
                lblError.Text = null;

                bool isValid = true;
                //UserName
                if (string.IsNullOrEmpty((txtUserName.Text ?? string.Empty).Trim()))
                {
                    txtUserName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter user name! <br />";
                    isValid = false;
                }
                else if(!Regex.IsMatch(txtUserName.Text,"^[a-zA-Z]+$"))
                {
                    txtUserName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "user name can only be upper and lower case letters <br />";
                    isValid = false;
                }
                else
                {
                    txtUserName.BackColor = System.Drawing.Color.White;
                }
                //Password
                if (string.IsNullOrEmpty((txtPassword.Text ?? string.Empty).Trim()))
                {
                    txtPassword.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter password! <br />";
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtPassword.Text, @"^[0-9a-zA-Z\?\!\@]+$"))
                {
                    txtPassword.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter password! <br />";
                    isValid = false;
                }
                else
                {
                    txtPassword.BackColor = System.Drawing.Color.White;
                }
                //Email
                if (string.IsNullOrEmpty((txtEmail.Text ?? string.Empty).Trim()))
                {
                    txtEmail.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter email! <br />";
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtEmail.Text, "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
                {
                     txtEmail.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter email valid email! <br />";
                    isValid = false;
                }
                else
                {
                    txtEmail.BackColor = System.Drawing.Color.White;
                }
                //First Name
                if (string.IsNullOrEmpty((txtFirstName.Text ?? string.Empty).Trim()))
                {
                    txtFirstName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter first name! <br />";
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtFirstName.Text, "^[a-zA-Z]+$"))
                {
                    txtFirstName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter first name! <br />";
                    isValid = false;
                }

                else
                {
                    txtFirstName.BackColor = System.Drawing.Color.White;
                }
                //Last Name
                if (string.IsNullOrEmpty((txtLastName.Text ?? string.Empty).Trim()))
                {
                    txtLastName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter last name! <br />";
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtLastName.Text, "^[a-zA-Z]+$"))
                {
                    txtLastName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter last name ! <br />";
                    isValid = false;
                }
                else
                {
                    txtLastName.BackColor = System.Drawing.Color.White;
                }
                //Address
                if (string.IsNullOrEmpty((txtAddress.Text ?? string.Empty).Trim()))
                {
                    txtAddress.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter Address! <br />";
                    isValid = false;
                }
              
                else
                {
                    txtAddress.BackColor = System.Drawing.Color.White;
                }
                //Address2
                
                //City
                if (string.IsNullOrEmpty((txtCity.Text ?? string.Empty).Trim()))
                {
                    txtCity.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter City! <br />";
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtCity.Text, @"^[^0-9\#\$\@\+\*]*$"))
                {
                    txtCity.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter City! <br />";
                    isValid = false;
                }
                else
                {
                    txtCity.BackColor = System.Drawing.Color.White;
                }

                //zip code
               
                if (string.IsNullOrEmpty((txtZip.Text ?? string.Empty).Trim()))
                {
                    txtZip.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter Zip code! <br />";
                    isValid = false;
                }
                else if (!Regex.IsMatch(txtZip.Text, "^[0-9]+$"))
                {
                    txtZip.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please Enter only numbers into the zip code! <br />";
                    isValid = false;
                }
                else
                {
                    txtZip.BackColor = System.Drawing.Color.White;
                }



                if (isValid)
                {
                    //output information if correct validation
                    Session["changeUserName"] = txtUserName.Text;
                    Session["changePassWord"] = txtPassword.Text;
                    Session["eMail"] = txtEmail.Text;
                    Session["firstName"] = txtFirstName.Text;
                    Session["lastName"] = txtLastName.Text;
                    Session["Address"] = txtAddress.Text;
                    Session["Address 2"] = txtAddress2.Text;
                    Session["City"] = txtCity.Text;
                    Session["Zip Code"] = txtZip.Text;
                    Server.Transfer("Default2.aspx");
                }
            }
            catch (Exception)
            {

            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblError.Text = null;

            txtUserName.Text = null;
            txtUserName.BackColor = System.Drawing.Color.White;
            txtPassword.Text = null;
            txtPassword.BackColor = System.Drawing.Color.White;
            txtEmail.Text = null;
            txtEmail.BackColor = System.Drawing.Color.White;
            txtFirstName.Text = null;
            txtFirstName.BackColor = System.Drawing.Color.White;
            txtLastName.Text = null;
            txtLastName.BackColor = System.Drawing.Color.White;
            txtAddress.Text = null;
            txtAddress.BackColor = System.Drawing.Color.White;
            txtAddress2.Text = null;
            txtAddress2.BackColor = System.Drawing.Color.White;
            txtCity.Text = null;
            txtCity.BackColor = System.Drawing.Color.White;
            txtZip.Text = null;
            txtZip.BackColor = System.Drawing.Color.White;
        }
       
    }
}