using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session ["SecurityLevel"] != "A" || Session["SecurityLevel"] == null) //checks when the page loads if the security level is correct
        {
            Response.Redirect("frmLogin.aspx");
        }
    }
    protected void btnAddUser_Click(object sender, EventArgs e)
    {
        //validate like in previous lab
        if (txtUserName.Text == "")
        {
            txtUserName.BackColor = System.Drawing.Color.Red;
            lblMessage.Text = "Must enter User Name";
        }
        else if (txtPassword.Text == "")
        {
            txtPassword.BackColor = System.Drawing.Color.Red;
            lblMessage.Text = "Must enter Password";
        }
        else
        {
            clsDataLayer.AddUser(Server.MapPath("PayrollSystem_DB.mdb"), txtUserName.Text, txtPassword.Text, drpdwnSecurityLevel.Text);
            Response.Redirect("frmManageUsers.aspx");
            grdAddUser.DataBind();
            lblMessage.Text = "User Added to System";
        }
    }
}