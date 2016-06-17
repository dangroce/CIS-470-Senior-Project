using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebSite1_create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtZip.MaxLength = 5;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            //Checking validation for the text boxes
            //this.lblError.Text = null;

            bool isValid = true;
            //UserName
            if (string.IsNullOrEmpty((txtUserName.Text ?? string.Empty).Trim()))
            {
                this.txtUserName.BackColor = System.Drawing.Color.Yellow;
                //this.lblError.Text += "Please enter user name! <br />";
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
                //lblError.Text += "Please enter password! <br />";
                isValid = false;
            }
            else
            {
                txtPassword.BackColor = System.Drawing.Color.White;
            }
            //Email
           /* if (string.IsNullOrEmpty((txtEmail.Text ?? string.Empty).Trim()))
            {
                txtEmail.BackColor = System.Drawing.Color.Yellow;
                //lblError.Text += "Please enter email! <br />";
                isValid = false;
            }
            else
            {
                txtEmail.BackColor = System.Drawing.Color.White;
            }*/
            //First Name
            if (string.IsNullOrEmpty((txtFirstName.Text ?? string.Empty).Trim()))
            {
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                //lblError.Text += "Please enter first name! <br />";
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
                //lblError.Text += "Please enter last name! <br />";
                isValid = false;
            }
            else
            {
                txtLastName.BackColor = System.Drawing.Color.White;
            }
            //Address
            if (string.IsNullOrEmpty((txtAddress1.Text ?? string.Empty).Trim()))
            {
                txtAddress1.BackColor = System.Drawing.Color.Yellow;
                //lblError.Text += "Please enter Address1! <br />";
                isValid = false;
            }
            else
            {
                txtAddress1.BackColor = System.Drawing.Color.White;
            }
            //Address2
            if (string.IsNullOrEmpty((txtAddress2.Text ?? string.Empty).Trim()))
            {
                txtAddress2.BackColor = System.Drawing.Color.Yellow;
                //lblError.Text += "Please enter Address2! <br />";
                isValid = false;
            }
            else
            {
                txtAddress2.BackColor = System.Drawing.Color.White;
            }

            //City
            if (string.IsNullOrEmpty((txtCity.Text ?? string.Empty).Trim()))
            {
                txtCity.BackColor = System.Drawing.Color.Yellow;
                //lblError.Text += "Please enter City! <br />";
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
                //lblError.Text += "Please enter Zip code! <br />";
                isValid = false;
            }
            else if (zipNumberCheck())
            {
                txtZip.BackColor = System.Drawing.Color.Yellow;
                //lblError.Text += "Please Enter only numbers into the zip code! <br />";
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
                //Session["eMail"] = this.txtEmail.Text;
                Session["firstName"] = txtFirstName.Text;
                Session["lastName"] = txtLastName.Text;
                Session["Address"] = txtAddress1.Text;
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
        //lblError.Text = null;

        txtUserName.Text = null;
        txtUserName.BackColor = System.Drawing.Color.White;
        txtPassword.Text = null;
        txtPassword.BackColor = System.Drawing.Color.White;
        //txtEmail.Text = null;
       // txtEmail.BackColor = System.Drawing.Color.White;
        txtFirstName.Text = null;
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.Text = null;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtAddress1.Text = null;
        txtAddress1.BackColor = System.Drawing.Color.White;
        txtAddress2.Text = null;
        txtAddress2.BackColor = System.Drawing.Color.White;
        txtCity.Text = null;
        txtCity.BackColor = System.Drawing.Color.White;
        txtZip.Text = null;
        txtZip.BackColor = System.Drawing.Color.White;
    }
    //check to see if zip code is all numbers
    protected bool zipNumberCheck()
    {


        bool valid = false;

        int size = 5;

        string test = txtZip.Text;

        for (int y = 0; y < size; y++)
        {

            switch (test[y].ToString())
            {
                case "0":
                    break;
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                default:
                    valid = true;
                    break;
            }
        }




        return valid;

    }

}
