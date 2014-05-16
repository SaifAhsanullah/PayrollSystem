using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //creates new datasource user object
        dsUser dsUserLogin;

        //security level string variable
        string SecurityLevel;

        //will take entries from login table
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"), Login1.UserName, Login1.Password);

        //if credential not found, will leave authentication as false 
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;

            //comment
            if (clsBusinessLayer.SendEmail("saif51483@gmail.com", "saif514@sbcglobal.net", "", "", "Login Incorrect",
                "The login failed for UserName: " + Login1.UserName + " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText +
                    " Your incorrect login information was sent to saif514@sbcglobal.net";
            }
            return;
        }

        //security level will be brought back as string from depending on login credentials
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        //switch statement to choose the type of session based on security level
        switch (SecurityLevel)
        {
            case "A":
                //if security level is brought back as "A", the session will be matched to security level A
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                //if security level is brought back as "U", the session will be matched to security level U
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}