<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallBack.aspx.cs" Inherits="CASys.UI.CallBack" %>

<%@ Implements Interface="System.Web.UI.ICallbackEventHandler" %>
<%@ Import Namespace="System.Text" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>用户注册</title>
    <script type="text/javascript">
        function Success(args, context) {
            message.innerText = args;
        }
        function Error(args, context) {
            message.innerText = '发生了异常';
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名<input type="text" id="txtUserName" onblur="CallServerMethod(txtUserName.value,null)" /><span id="message"></span><br />
            密码<input type="password" id="txtPwd" /><br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="javascript:return confirm('确认提交?')"  Text="Button" />
    </form>
</body>
</html>
