<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToolBox.aspx.cs" Inherits="CASys.UI.ToolBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div><a href="https://passport.baidu.com/v2/?login&tpl=mn&u=http%3A%2F%2Fwww.baidu.com%2F"  id="lb" onclick="return false;">登录</a></div>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <img alt="" src="Images/search.gif" /></p>
    </form>
    </body>
</html>
