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
            Session["userlogin"] = dtlogin.Rows[0].Field<string>("userlogin").ToString();
            Session["password"] = dtlogin.Rows[0].Field<string>("passwrd").ToString();
            Session["firstname"] = dtlogin.Rows[0].Field<string>("firstname").ToString();
            Session["lastname"] = dtlogin.Rows[0].Field<string>("lastname").ToString();
            if(dtlogin.Rows[0].Field<string>("middlename") != null)
            {
                Session["middlename"] = dtlogin.Rows[0].Field<string>("middlename").ToString();
            }
            else
            {
                Session["middlename"] = "";
            }
            if(dtlogin.Rows[0].Field<string>("email") != null)
            {
                Session["email"] = dtlogin.Rows[0].Field<string>("email").ToString();
            }
            else
            {
                Session["email"] = "";
            }
            Session["address1"] = dtlogin.Rows[0].Field<string>("Address1").ToString();
            if(dtlogin.Rows[0].Field<string>("Address2") != null)
            {
                 Session["address2"] = dtlogin.Rows[0].Field<string>("Address2").ToString();
            }
            else
            {
                Session["address2"] = "";
            }
            Session["city"] = dtlogin.Rows[0].Field<string>("City").ToString();
            Session["state"] = dtlogin.Rows[0].Field<string>("ustate").ToString();
            Session["zipcode"] = dtlogin.Rows[0].Field<string>("zipcode").ToString();
            Session["phone"] = dtlogin.Rows[0].Field<string>("phonenumber").ToString();
            Session["startdate"] = dtlogin.Rows[0].Field<DateTime>("startdate").ToString();
            if (dtlogin.Rows[0].Field<string>("enddate") != null)
            {
            Session["enddate"] = dtlogin.Rows[0].Field<DateTime>("enddate").ToString();
            }
            else
            {
                Session["enddate"] = "";
            }
            Session["status"] = dtlogin.Rows[0].Field<int>("status").ToString();

                if (dtlogin.Rows[0] != null && dtlogin.Rows.Count > 0)
                Response.Redirect("~/catalog.aspx");
               
        }
        catch(Exception error)
        {
            string msg = error.ToString();
        }
    }

}