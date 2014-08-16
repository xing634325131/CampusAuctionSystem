<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCheck.aspx.cs" Inherits="CASys.UI.Control.LoginCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 600px; margin: 0px auto; text-align: center; margin-top: 200px;">
            <span>登录名或密码错误，如果您忘记了密码，请<a href="../FindPassword.aspx">找回密码</a><br />
            </span>
            &nbsp;<br />
            我记得密码，要<a id="go_back" runat="server" >重新登录</a>
        </div>
    </form>
</body>
</html>
