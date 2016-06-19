using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebSite1_orders : System.Web.UI.Page
{
    clsBusinessLayer myBusiness = new clsBusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/login.aspx");
        }
        DataTable dtOrders = new DataTable();

        dtOrders = myBusiness.GetOrders(Session["userid"].ToString());

        gvOrders.DataSource = dtOrders;
        gvOrders.DataBind();

        DataTable dtPurchases = new DataTable();
        dtPurchases = myBusiness.GetPurchases(Session["userid"].ToString());
        gvPurchases.DataSource = dtPurchases;
        gvPurchases.DataBind();
    }
    protected void btnComplete_Click(object sender, EventArgs e)
    {

    }
}