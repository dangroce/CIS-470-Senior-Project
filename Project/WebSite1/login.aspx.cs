using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    // Connection to the BusinessLayer
    clsBusinessLayer myBusinessLayer = new clsBusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtUserName.Focus();
    }

    public string userName
    {
        get { return this.txtUserName.Text; }
        set { this.txtUserName.Text = value; }
    }
    public string password
    {
        get { return this.txtPassword.Text; }
        set { this.txtPassword.Text = value; }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        /*try
        {
            //Checking validation for the text boxes

        }*/
    }

    protected void btnLogin_Click( object sender, EventArgs e)
    {
        // create a datatable to load user information
        DataTable dtlogin = new DataTable();


        try
        {
            dtlogin = myBusinessLayer.loginUser(userName, password);
            Session["userid"] = dtlogin.Rows[0].Field<int>("userid").ToString();

            {
                if (dtlogin.Rows.Count > 0)
                Response.Redirect("~/catalog.aspx");
               
            }
        }
        catch(Exception error)
        {
            string msg = error.ToString();
        }
    }

}