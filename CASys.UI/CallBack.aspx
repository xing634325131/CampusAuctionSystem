<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallBack.aspx.cs" Inherits="CASys.UI.CallBack" %>

<%@ Implements Interface="System.Web.UI.ICallbackEventHandler" %>
<%@ Import Namespace="System.Text" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>�û�ע��</title>
    <script type="text/javascript">
        function Success(args, context) {
            message.innerText = args;
        }
        function Error(args, context) {
            message.innerText = '�������쳣';
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            �û���<input type="text" id="txtUserName" onblur="CallServerMethod(txtUserName.value,null)" /><span id="message"></span><br />
            ����<input type="password" id="txtPwd" /><br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="javascript:return confirm('ȷ���ύ?')"  Text="Button" />
    </form>
</body>
</html>
