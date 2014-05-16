<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="frmManageUsers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Users </title>
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
        <p style="text-align: center">
            Manage Users</p>
        <p id="lblUserName" style="text-align: center">
            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
        
        <id="lblPassword" style="text-align: center">
&nbsp;<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <id="lblSecurityLevel" style="text-align: center">
&nbsp;<asp:Label ID="lblSecurityLevel" runat="server" Text="Security Level"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="drpdwnSecurityLevel" runat="server">
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>U</asp:ListItem>
            </asp:DropDownList>
        <br />
        <p style="text-align: center">
            <asp:Button ID="btnAddUser" runat="server" Text="Add User" 
                onclick="btnAddUser_Click" />
        </p>
        <p style="text-align: center">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
        <p style="text-align: center">
            <asp:GridView ID="grdAddUser" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="UserID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" 
                        ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" 
                        SortExpression="UserName" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" 
                        SortExpression="UserPassword" />
                    <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" 
                        SortExpression="SecurityLevel" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </p>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString4 %>" 
        DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" 
        InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" 
        ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString4.ProviderName %>" 
        SelectCommand="SELECT * FROM [tblUserLogin]" 
        UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="UserID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="UserID" Type="Int32" />
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
            <asp:Parameter Name="SecurityLevel" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
            <asp:Parameter Name="SecurityLevel" Type="String" />
            <asp:Parameter Name="UserID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
