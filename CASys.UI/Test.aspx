<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="CASys.UI.Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" width="600">
                <tr>
                    <td colspan="2" align="center">用户注册</td>
                </tr>
                <tr>
                    <td>用户名</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                            ErrorMessage="用户名必须填写" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>密码</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                            ErrorMessage="必须填写密码" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>用户头像</td>
                    <td>
                        <asp:TextBox ID="txtHeadImage" runat="server" onfocus="blur();" ValidationGroup="shangchuan"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtHeadImage"
                            ErrorMessage="必须上传头像" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:FileUpload ID="fileUpload" runat="server" />
                        <asp:Button ID="btnUpload" runat="server" Text="上传" ValidationGroup="shangchuan" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="fileUpload"
                            Display="Dynamic" ErrorMessage="必须选择文件"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="提交" />
                    </td>
                    <td>
                        <input id="Reset3" type="reset" value="重置" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
