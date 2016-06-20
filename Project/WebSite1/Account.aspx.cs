using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    clsBusinessLayer myBusinessLayer = new clsBusinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/login.aspx");
        }
        //If statement for visibility on Access Level
        lblSearchE.Visible = false;
        txtSearchE.Visible = false;
        //button visible
        btnSaveA.Visible = false;
        btnCancelA.Visible = false;
        //txt box not able to edit
        txtUserNameA.ReadOnly = true;
        txtFirstNameA.ReadOnly = true;
        txtLastNameA.ReadOnly = true;
        txtAddressA.ReadOnly = true;
        txtAddress2A.ReadOnly = true;
        txtCityA.ReadOnly = true;
        //the state text field might need to be changed do to style choice 
        //I think we are using a dropdown list box for this
        txtStateA.ReadOnly = true;
        txtZipA.ReadOnly = true;
        txtEmailA.ReadOnly = true;
        txtPhoneNumberA.ReadOnly = true;
        txtPasswordA.ReadOnly = true;

        //these will only be visible in edit mode to change password
        lblNewPassword.Visible = false;
        txtNewPasswordA.Visible = false;
        // prepopulate data from session
        txtUserNameA.Text = Convert.ToString(Session["userlogin"]);
        txtFirstNameA.Text = Convert.ToString(Session["firstname"]);
        txtLastNameA.Text = Convert.ToString(Session["lastname"]);
        txtCityA.Text = Convert.ToString(Session["city"]);
        txtStateA.Text = Convert.ToString(Session["state"]);
        txtPhoneNumberA.Text = Convert.ToString(Session["phone"]);


        //myBusinessLayer.getUserInfo(Convert.ToString(Session["userid"])));
    }

    protected void btnEditA_Click(object sender, EventArgs e)
    {
        txtUserNameA.Text = Convert.ToString(Session["userlogin"]);
        txtFirstNameA.Text = Convert.ToString(Session["firstname"]);
        txtLastNameA.Text = Convert.ToString(Session["lastname"]);
        txtCityA.Text = Convert.ToString(Session["city"]);
        txtStateA.Text = Convert.ToString(Session["state"]);
        txtPhoneNumberA.Text = Convert.ToString(Session["phone"]);
        //button visible
        btnSaveA.Visible = true;
        btnCancelA.Visible = true;
        //txt box not able to edit
        txtAddressA.ReadOnly = false;
        txtAddress2A.ReadOnly = false;
        txtCityA.ReadOnly = false;
        //the state edit field will be different just including to know where what goes where.             
        txtStateA.ReadOnly = false;
        txtZipA.ReadOnly = false;
        txtEmailA.ReadOnly = false;
        txtPhoneNumberA.ReadOnly = false;
        txtPasswordA.ReadOnly = false;

        //these will only be visible in edit mode to change password
        lblNewPassword.Visible = true;
        txtNewPasswordA.Visible = true;

    }

    protected void btnSaveA_Click(object sender, EventArgs e)
    {
        try
        {

            //Checking validation for the text boxes
            lblError.Text = null;

            bool isValid = true;

            //Password
            if (string.IsNullOrEmpty((txtPasswordA.Text ?? string.Empty).Trim()))
            {
                txtPasswordA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter password! <br />";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPasswordA.Text, @"^[0-9a-zA-Z\?\!\@]+$"))
            {
                txtPasswordA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter password! <br />";
                isValid = false;
            }
            else
            {
                txtPasswordA.BackColor = System.Drawing.Color.White;
            }
            //Password
            if (string.IsNullOrEmpty((txtNewPasswordA.Text ?? string.Empty).Trim()))
            {
                txtNewPasswordA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter password! <br />";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtNewPasswordA.Text, @"^[0-9a-zA-Z\?\!\@]+$"))
            {
                txtNewPasswordA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter password! <br />";
                isValid = false;
            }
            else
            {
                txtNewPasswordA.BackColor = System.Drawing.Color.White;
            }
            //Email
            if (string.IsNullOrEmpty((txtEmailA.Text ?? string.Empty).Trim()))
            {
                txtEmailA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter email! <br />";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtEmailA.Text, "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
            {
                txtEmailA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter email valid email! <br />";
                isValid = false;
            }
            else
            {
                txtEmailA.BackColor = System.Drawing.Color.White;
            }

            //Address
            if (string.IsNullOrEmpty((txtAddressA.Text ?? string.Empty).Trim()))
            {
                txtAddressA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter Address! <br />";
                isValid = false;
            }

            else
            {
                txtAddressA.BackColor = System.Drawing.Color.White;
            }
            //Address2

            //City
            if (string.IsNullOrEmpty((txtCityA.Text ?? string.Empty).Trim()))
            {
                txtCityA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter City! <br />";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtCityA.Text, @"^[^0-9\#\$\@\+\*]*$"))
            {
                txtCityA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter City! <br />";
                isValid = false;
            }
            else
            {
                txtCityA.BackColor = System.Drawing.Color.White;
            }

            //zip code

            if (string.IsNullOrEmpty((txtZipA.Text ?? string.Empty).Trim()))
            {
                txtZipA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter Zip code! <br />";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtZipA.Text, "^[0-9]+$"))
            {
                txtZipA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please Enter only numbers into the zip code! <br />";
                isValid = false;
            }
            else
            {
                txtZipA.BackColor = System.Drawing.Color.White;
            }
            if (string.IsNullOrEmpty((txtPhoneNumberA.Text ?? string.Empty).Trim()))
            {
                txtPhoneNumberA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter Zip code! <br />";
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPhoneNumberA.Text, @"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{4}"))
            {
                txtPhoneNumberA.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please Enter only numbers into the zip code! <br />";
                isValid = false;
            }
            else
            {
                txtPhoneNumberA.BackColor = System.Drawing.Color.White;
            }





            if (isValid)
            {
                //update information in the database

                //this will include address, address2, city,state, zip, email, and password
            }
            else
            {
                btnSaveA.Visible = true;
                btnCancelA.Visible = true;

                lblNewPassword.Visible = true;
                txtNewPasswordA.Visible = true;


            }

        }

        catch (Exception)
        {

        }
    }

    protected void btnCancelA_Click(object sender, EventArgs e)
    {
        Response.Redirect("Account.aspx");
    }
}