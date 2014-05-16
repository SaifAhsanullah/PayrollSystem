using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmUserActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SecurityLevel"] != "A" || Session["SecurityLevel"] == null) //checks when the page loads if the security level is correct
        {
            Response.Redirect("frmLogin.aspx");
        }

        if (!Page.IsPostBack)
        {
            //Declares the DataSet
            dsUserActivity myDataSet = new dsUserActivity();

            //fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.mdb"));

            //sets the DataGrid to the DataSource based on the table
            grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];

            //binds the DataGrid
            grdUserActivity.DataBind();
        }
    }
}