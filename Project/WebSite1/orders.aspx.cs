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
        DataTable dtOrders = new DataTable();

        dtOrders = myBusiness.GetOrders(Session["userid"].ToString());
    }
}