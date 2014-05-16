<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salary Calculator</title>
        <style type="text/css">
    body{background-color:Silver;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p style="text-align: center">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/frmMain.aspx"><font color="black" size="2"><strong><font color="blue" face="Comic Sans MS" size="4">Cool</font>
    <font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> 
    <font color="#993366">Productions</font>, Inc.<br />
        </font></strong></font></asp:LinkButton>
        <br /><br />
        <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours"></asp:Label>&nbsp;
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox><br />

        <asp:Label ID="lblRate" runat="server" Text="Rate"></asp:Label>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox><br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCalcSal" runat="server" Text="Calculate Salary" onclick="btnCalcSal_Click" /><br />
        &nbsp;&nbsp;
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
        
        </p>
        
     </div>
    </form>
</body>
</html>
