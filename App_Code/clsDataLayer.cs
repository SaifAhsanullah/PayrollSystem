using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//adding namespace to modify databases, .net applications, and modify data from different sources
using System.Data.OleDb;
using System.Net;
using System.Data;



public class clsDataLayer
{

    //adduser function similar to SavePersonnel function (thank God!)
    public static bool AddUser(string Database, string userName, string password, string securityLevel)
    {
        bool userAdded;
        OleDbTransaction myTransaction = null;

        try
        {
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            strSQL = "Insert into tblUserLogin " +
                    "(UserName, UserPassword, SecurityLevel) values ('" + userName +
                    "', '" + password + "', '" + securityLevel + "')";

            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            command.ExecuteNonQuery();

            myTransaction.Commit();
            conn.Close();
            userAdded = true;
        }
        catch (Exception ex)
        {
            userAdded = false;
            myTransaction.Rollback();
        }
        return userAdded;
    }
    //this function verifies that a user is in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        //declare objects for database use
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //create connection to database 
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Database);

        //comment
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
                                    "where UserName like '" + UserName + "' " +
                                    "and UserPassword like '" + UserPassword + "'", sqlConn);

        //creates new datasource user
        DS = new dsUser();

        //comment
        sqlDA.Fill(DS.tblUserLogin);

        //will return the value of datasource inquiry
        return DS;
    }


    //gets user activity from the tblUserActivity database 
    public static dsUserActivity GetUserActivity(string Database)
    {
        //objects created from the following three classes used to connect to database
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //creates object of OleDbConnection instance in sqlConn.  Creates connection to data
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source= " + Database);

        //creates object of olddbdataadapter instance in sqlDA.  can fill and update data source
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

        //creates database user activity in DS  
        DS = new dsUserActivity();

        //will user activity table  
        sqlDA.Fill(DS.tblUserActivity);

        //function will return DS object 
        return DS;
    }

    //function to save user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        //comment 
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source= " + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" + GetIP4Address() + "', '" + FormAccessed + "')";

        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    //function to get IP address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;

        foreach (IPAddress IPA in
            Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }

	public clsDataLayer()
	{
		
	}
    //this function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName, string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;
        OleDbTransaction myTransaction = null;

        try
        {
            //creates database object connection 
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source= " + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            //sql string
            strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";

            //will interpret the return type as a text 
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            //returns rows that are affected
            command.ExecuteNonQuery();

            //will update pay, start, and end dates only 
            strSQL = "Update tblPersonnel " +
                "Set PayRate=" + PayRate + ", " +
                "StartDate='" + StartDate + "', " +
                "EndDate='" + EndDate + "' " +
                "Where ID=(Select Max(ID) From tblPersonnel)";

            //will interpret the return type as a text
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            command.ExecuteNonQuery();
            myTransaction.Commit();

            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            //will run if an exception is throwin 
            myTransaction.Rollback();   //rolls back when exception thrown
            recordSaved = false;
        }
        return recordSaved;
    }

    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        //objects created from the following three classes used to connect to database
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //creates object of OleDbConnection instance in sqlConn.  Creates connection to data
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
             //query statement

        if (strSearch == null || strSearch == "") //will return all if search is blank
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName ='" +strSearch+"'", sqlConn); //will search string
        }


        //create the dataset
        DS = new dsPersonnel();

        //fill the data set
        sqlDA.Fill(DS.tblPersonnel);

        //return the dataset
        return DS;
    }
}

