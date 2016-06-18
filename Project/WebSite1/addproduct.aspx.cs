using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class addproduct : System.Web.UI.Page

{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProductAdd_Click(object sender, EventArgs e)
    {
      
    }

    protected void UploadButton_Click(object sender, EventArgs e)
    {
        if ((upProdImage.PostedFile != null) && (upProdImage.PostedFile.ContentLength > 0))
        {
            string fn = System.IO.Path.GetFileName(upProdImage.PostedFile.FileName);
            string SaveLocation = Server.MapPath("~/images/") + "\\" + fn;
            try
            {
                upProdImage.PostedFile.SaveAs(SaveLocation);
                StatusLabel.Text = ("The file has been uploaded.");
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ("Error: " + ex.Message);
                //Note: Exception.Message returns a detailed message that describes the current exception. 
                //For security reasons, we do not recommend that you return Exception.Message to end users in 
                //production environments. It would be better to put a generic error message. 
            }
        }
        else
        {
            Response.Write("Please select a file to upload.");
        }
    }
}