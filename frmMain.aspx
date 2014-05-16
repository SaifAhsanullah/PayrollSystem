<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
        <style type="text/css">
    body{background-color:Silver;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p style="text-align: center">
    <font color="black" size="2"><strong><font color="blue" face="Comic Sans MS" size="4">Cool</font>
    <font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> 
    <font color="#993366">Productions</font>, Inc.</font></strong></font></p>
    
    </div>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnCalculator" runat="server" 
            PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnCalculator" runat="server" 
            ImageUrl="~/images/calculator.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" 
            Width="54px" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnNewEmployee" runat="server" 
            PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnNewEmployee" runat="server" 
            ImageUrl="~/images/employee.jpg" PostBackUrl="~/frmPersonnel.aspx" 
            Width="81px" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" 
            PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="64px" 
            ImageUrl="~/images/activity.jpg" PostBackUrl="~/frmUserActivity.aspx" 
            Width="91px" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" 
            PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="72px" 
            ImageUrl="~/images/staff.png" PostBackUrl="~/frmViewPersonnel.aspx" 
            Width="130px" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnSearch" runat="server" 
            PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnSearch" runat="server" Height="36px" 
            ImageUrl="~/images/search.jpg" PostBackUrl="~/frmSearchPersonnel.aspx" 
            Width="132px" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnEditEmployees" runat="server" 
            PostBackUrl="~/frmEditPersonnel.aspx">Edit Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="61px" 
            ImageUrl="~/images/eraser.png" PostBackUrl="~/frmEditPersonnel.aspx" 
            Width="120px" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="linkbtnManageUsers" runat="server" 
            PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="67px" 
            ImageUrl="~/images/toolbox.jpg" PostBackUrl="~/frmManageUsers.aspx" 
            Width="102px" />
    </p>
    </form>
</body>
</html>
