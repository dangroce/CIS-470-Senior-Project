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
    public DataTable CataCart;

    protected void Page_Load(object sender, EventArgs e)
    {
        dlCatalogs.DataSource = myBusinessLayer.CatagoryList();
        dlCatalogs.DataBind();

        if (Session["CatalogCart"] == null)
        {
            CataCart = new DataTable("CataCart");
            CataCart.Columns.Add(new DataColumn("itemid", typeof(string)));
            CataCart.Columns.Add(new DataColumn("productid", typeof(string)));
            CataCart.Columns.Add(new DataColumn("userid", typeof(string)));

            Session["CatalogCart"] = CataCart;

            for(int i=1; i<=9; i++)
            {
                DataRow cc = CataCart.NewRow();
                cc[0] = 1;
                cc[1] = 1;
                cc[2] = 1;
                CataCart.Rows.Add(cc);
            }
        }
        else
            CataCart = (DataTable)Session["CatalogCart"];

        if (!IsPostBack)
        {
        }
    }

    public void btnProduct_click(object sender, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Selected")
        {
            // String dlSelectedCat = dlCatalogs.DataKeys[dlCatalogs.SelectedIndex].ToString();
            // DataListItem dliSelectedCat = dlCatalogs.SelectedItem;
            // string itemid = ((Label)dliSelectedCat.FindControl("hdnID")).Text;
        }

    }

    protected void dlCatalogs_SelectedIndexChanged(object sender, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Selected")
        {
           // String dlSelectedCat = dlCatalogs.DataKeys[dlCatalogs.SelectedIndex].ToString();
           // DataListItem dliSelectedCat = dlCatalogs.SelectedItem;
           // string itemid = ((Label)dliSelectedCat.FindControl("hdnID")).Text;

        }


    }
}