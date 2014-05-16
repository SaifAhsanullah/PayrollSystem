using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmEditPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SecurityLevel"] != "A" || Session["SecurityLevel"] == null) //checks when the page loads if the security level is correct
        {
            Response.Redirect("frmLogin.aspx");
        }
    }
}