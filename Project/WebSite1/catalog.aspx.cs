using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebSite1_catalog : System.Web.UI.Page
{
    int cartCounter;
    List<int> cartItems = new List<int>();
    clsBusinessLayer myBusinessLayer = new clsBusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cartCounter = 0;
        }
    }

   public void btnProduct_click(object sender, EventArgs e)
    {
        Button clickedButton = (((Button)sender).Attributes).Keys.OfType<"value">.ToString();

        if (clickedButton == null)
            return;

        string btnNum = clickedButton.Attributes.Keys..ToString();
        switch (Convert.ToInt32(btnNum.Substring((btnNum.Length-1), btnNum.Length)))
        {
            case 1:
                cartCounter++;
                cartItems.Add(1);
                break;

            case 2:
                cartCounter++;
                cartItems.Add(2);
                break;
        }

        this.lblCartCount.Text = cartCounter.ToString();
    }


}