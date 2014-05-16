using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonalVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //will take information within text box in Personnel to text box in personal verified page
        txtVerifiedInfo.Text = Session["txtFirstName"].ToString() +
            "\n" + Session["txtLastName"].ToString() +
            "\n" + Session["txtPayRate"].ToString() +
            "\n" + Session["txtStartDate"].ToString() +
            "\n" + Session["txtEndDate"].ToString();

        //if statement that makes sure that correct information is transferred.   
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"), Session["txtFirstName"].ToString(), Session["txtLastName"].ToString(),
            Session["txtPayRate"].ToString(), Session["txtStartDate"].ToString(), Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was successsfully saved!"; //will show statement if statement was sent correctly
        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was NOT saved."; //will show if information is not saved successfully
        }
    }
}