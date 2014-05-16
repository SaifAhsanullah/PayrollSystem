<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="frmViewPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Personnel</title>
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
        </p>
    
    </div>
    <asp:GridView ID="grdViewPersonnel" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
