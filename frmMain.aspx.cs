using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //collects user activity
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");

        //if-statement that will make links invisible if not admin
        if (Session["SecurityLevel"] != "A")
        {
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;
            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;
            linkbtnManageUsers.Visible = false;
            imgbtnManageUsers.Visible = false;
        }
    }
}