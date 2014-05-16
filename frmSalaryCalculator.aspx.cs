using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalcSal_Click(object sender, EventArgs e)
    {
        double hours;
        double taxRate;
        double salary;

        hours = Convert.ToDouble(txtAnnualHours.Text); //stores converted hours input 
        taxRate = Convert.ToDouble(txtRate.Text); //stores converted tax rate input

        salary = (hours * taxRate); //calculates salary

        lblSalary.Text = "$ "+salary.ToString(); //catenates dollar sign and converted salary variable to salary text box
    }
}