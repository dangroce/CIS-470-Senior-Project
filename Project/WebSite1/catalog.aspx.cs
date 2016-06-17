using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebSite1_catalog : System.Web.UI.Page
{
   clsBusinessLayer myBusinessLayer = new clsBusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }

   public void btnProduct_click(object sender, EventArgs e)
    {

        if(Session["userid"]!=null)
        {
            Button btnName = (Button)sender;
            int cntPrd = 0;

            string btnNameID = btnName.ID;
            int btnID = Convert.ToInt32(btnNameID.Substring((btnNameID.Length - 1), 1));
            int prdID = Convert.ToInt32(btnNameID.Substring((btnNameID.Length - 3), 1));

            cntPrd = myBusinessLayer.AddOrder(Convert.ToInt32(Session["userid"].ToString()), prdID);

            this.lblCartCount.Text = cntPrd.ToString();

        }
        else
        {
            this.lblCartCount.Text = "Please Login! To Order your Products.";
        }

    }
}