using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            //Checking validation for the text boxes


            bool isValid = true;
            if (string.IsNullOrEmpty((changeUserName.Text ?? string.Empty).Trim()))
            {
                changeUserName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter user name! <br />";
                isValid = false;
            }

            if (string.IsNullOrEmpty((changePassWord.Text ?? string.Empty).Trim()))
            {
                changePassWord.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter last name! <br />";
                isValid = false;
            }
            if (string.IsNullOrEmpty((eMail.Text ?? string.Empty).Trim()))
            {
                eMail.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter pay rate! <br />";
                isValid = false;
            }
            if (string.IsNullOrEmpty((firstName.Text ?? string.Empty).Trim()))
            {
                firstName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter start date! <br />";
                isValid = false;
            }
            if (string.IsNullOrEmpty((lastName.Text ?? string.Empty).Trim()))
            {
                lastName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please enter end date! <br />";
                isValid = false;
            }

    


            if (isValid)
            {
                //output information if correct validation
                Session["changeUserName"] = changeUserName.Text;
                Session["changePassWord"] = changePassWord.Text;
                Session["eMail"] = eMail.Text;
                Session["firstName"] = firstName.Text;
                Session["lastName"] = lastName.Text;
                Server.Transfer("Default2.aspx");
            }
        }
        catch (Exception)
        {

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        changeUserName.Text = " ";
        changePassWord.Text = " ";
        eMail.Text = " ";
        firstName.Text = " ";
        lastName.Text = " ";
    }
}