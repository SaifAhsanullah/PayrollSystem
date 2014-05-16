using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            String searchString = Request["txtSearchName"];
            //declares the dataset
            dsPersonnel myDataSet = new dsPersonnel();

            //fill the dataset with what is return from function
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), searchString);

            //set the datagrid to the datsource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

            //bind datagrid
            grdViewPersonnel.DataBind();
        }
    }
}