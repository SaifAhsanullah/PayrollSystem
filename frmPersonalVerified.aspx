<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonalVerified.aspx.cs" Inherits="frmPersonalVerified" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verified Personnel</title>
    <style type="text/css">
        body{background-color:Silver;}
        .style1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p style="text-align: center">
    
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/frmMain.aspx">    <font color="black" size="2"><strong><font color="blue" face="Comic Sans MS" size="4">Cool</font>
    <font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> 
    <font color="#993366">Productions</font>, Inc.</font></strong></font></asp:LinkButton>
    
        </p>
    
    </div>
    <p class="style1">
    <asp:Label ID="Label1" runat="server" Text="Information to Submit"></asp:Label>
    <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" 
        TextMode="MultiLine" Width="400px" ></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Button ID="btnViewPersonnel" runat="server" 
            PostBackUrl="~/frmViewPersonnel.aspx" Text="View Personnel" />
    </p>
    </form>
</body>
</html>
