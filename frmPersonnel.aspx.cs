using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SecurityLevel"] != "A" || Session["SecurityLevel"] == null) //checks when the page loads if the security level is correct
        {
            Response.Redirect("frmLogin.aspx");
        }

        //based on session security level, certain things will be visible
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
        }
        //will make buttons invisible for all other session types
        else
        {
            btnSubmit.Visible = false;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Boolean errors = false; //must be kept false to send form

        try //makes sure date format is correct
        {
            if (txtFirstName.Text == null || txtFirstName.Text == "") //if left blank
            {
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Must enter a first name <br/>";
                errors = true;
            }

            if (txtLastName.Text == null || txtLastName.Text == "")
            {
                txtLastName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Must enter a last name <br/>";
                errors = true;
            }

            if (txtPayRate.Text == null || txtPayRate.Text == "")
            {
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Must enter a pay rate <br />";
                errors = true;
            }

            if (txtStartDate.Text == null || txtStartDate.Text == "")
            {
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Must enter a start date <br />";
                errors = true;
            }

            if (txtEndDate.Text == null || txtEndDate.Text == "")
            {
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Must enter an end date <br />";
                errors = true;
            }


            DateTime dt1 = DateTime.Parse(txtStartDate.Text); //dateTime object
            DateTime dt2 = DateTime.Parse(txtEndDate.Text); //dateTime object

            if (DateTime.Compare(dt1, dt2) >= 0) //will test that start date is before end date
            {

                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "start date can not be before end date <br />";
                errors = true;

            }

            if (!errors) //will send as long as none of above conditions made errors set to true
            {
                Session["txtFirstName"] = txtFirstName.Text;
                Session["txtLastName"] = txtLastName.Text;
                Session["txtPayRate"] = txtPayRate.Text;
                Session["txtStartDate"] = txtStartDate.Text;
                Session["txtEndDate"] = txtEndDate.Text;
                Response.Redirect("frmPersonalVerified.aspx");
            }
        }
        catch (Exception ex) //if format exception thrown, it will display this message in error box
        {
            lblError.Text += "Please enter date in mm/dd/yyyy format <br/>";
        }
      }
}