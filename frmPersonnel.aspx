<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personnel</title>
    <style type="text/css">
        body{background-color:Silver;}
        .style2
        {
            text-align: center;
            width: 482px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="position: relative">
    <div>
        <p style="text-align: center">
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/frmMain.aspx"><font color="black" size="2"><strong><font color="blue" face="Comic Sans MS" size="4">Cool</font>
    <font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> 
    <font color="#993366">Productions</font>, Inc.<br />
        </font></strong></font></asp:LinkButton>
        &nbsp;<br />
        </p>
    </div>
    <asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" 
        Width="300px" style="margin-left:271px">
        <p class="style2">
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="74px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtFirstName" ErrorMessage="Can't be left blank"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="74px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtLastName" ErrorMessage="Can't be left blank"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate:" width="74px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="txtPayRate" ErrorMessage="Can't be left blank"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date:" width="74px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtStartDate" ErrorMessage="must be in mm/dd/yyyy" 
                ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lblEndDate" runat="server" Text="End Date:" width="74px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtEndDate" ErrorMessage="must be in mm/dd/yyyy" 
                ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"></asp:RegularExpressionValidator>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="btnSubmit_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="style2">
            <asp:Label ID="lblError" runat="server" Text=" "></asp:Label>
        </p>
    </asp:Panel>
    </form>
</body>
</html>
