<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CASys.UI.Images.Register" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%--<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>  注册界面不能登录--%>

<%@ Implements Interface="System.Web.UI.ICallbackEventHandler" %>
<%@ Import Namespace="System.Text" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>注册账号</title>
    <script type="text/javascript" src="Scripts/jquery-1.8.2.js"></script>
    <script type="text/javascript">
        function Success(args, context) {
            message.innerText = args;
        }
        function Error(args, context) {
            message.innerText = '发生了异常';
        }
        function codeRefresh() {
            var img = document.getElementById("imgValidateCode");
            img.click();
        }
    </script>
    <link href="Styles/Header.css" rel="Stylesheet" type="text/css" />
    <link href="Styles/Registe.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <div align="center">
            <uc1:header runat="server" ID="header1" />
            <div class="registeDiv">
                <label class="registeDivLabel">会员注册</label>
                <hr class="registerhr" />
                <div class="registerbottom">
                    <label class="registeLabel">
                        用户基本信息：
                    </label>
                    <div class="formcontent">
                        <ul class="registeUl">
                            <li>&nbsp;&nbsp;用户名：
                                <input class="textInput" runat="server" id="textInputName" type="text" maxlength="18" onblur="CallServerMethod(textInputName.value,null)" />
                                <label class="labeltext">6~18个字符，需以字母开头</label>
                                <span id="message" class="msgclass"></span>
                                <asp:RequiredFieldValidator ID="RFVUser" Display="Dynamic" ControlToValidate="textInputName" runat="server" ForeColor="Red" ErrorMessage="用户名不能为空!"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="REVUser" Display="Dynamic" ControlToValidate="textInputName" ForeColor="Red" ValidationExpression="^[a-zA-z][a-zA-Z0-9_]{2,18}$" runat="server" ErrorMessage="用户名不合规范!"></asp:RegularExpressionValidator>
                            </li>
                            <li>真实姓名：
                                <input class="textInput" id="realname" runat="server" type="text" />
                            </li>
                            <li>&nbsp;&nbsp;&nbsp;&nbsp;性别:&nbsp;&nbsp;
                                    <asp:RadioButton CssClass="genderMale" ID="genderMale" GroupName="gender" Text="男" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:RadioButton ID="genderFemale" GroupName="gender" Text="女" runat="server" />
                                <asp:Label ID="CMGender" runat="server" ForeColor="Red"></asp:Label>
                            </li>
                        </ul>
                    </div>
                    <label class="registeLabel">
                        用户安全信息：
                    </label>
                    <div class="formcontent">
                        <ul class="registeUl">
                            <li>&nbsp;&nbsp;&nbsp;&nbsp;密码：
                                <input class="textInput" id="textInputPassword" runat="server" type="password" maxlength="16" />
                                <label class="labeltext">由6~16位字符，区分大小写</label>
                                <asp:RequiredFieldValidator ID="RFVPwd" runat="server" ErrorMessage="密码不能为空!" ForeColor="Red" ControlToValidate="textInputPassword" Display="Dynamic"></asp:RequiredFieldValidator>
                            </li>
                            <li>确认密码：
                                <input class="textInput" id="textInputPasswordSure" runat="server" type="password" maxlength="16" />
                                <asp:CompareValidator ID="CVPwd" runat="server" ForeColor="Red" ControlToValidate="textInputPasswordSure" ControlToCompare="textInputPassword" ErrorMessage="两次输入的密码不同!"></asp:CompareValidator>
                            </li>
                            <li>&nbsp;&nbsp;&nbsp;&nbsp;邮箱：
                                <input class="textInput" runat="server" id="textEmail" type="text" />
                                <select name="mail" id="emailSelect" runat="server">
                                    <option value="@qq.com">@qq.com</option>
                                    <option value="@sina.com">@sian.com</option>
                                    <option value="@163.com">@163.com</option>
                                    <option value="@souhu.com">@souhu.com</option>
                                </select>
                                <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ErrorMessage="邮箱号码不能为空!" ForeColor="Red" ControlToValidate="textEmail" Display="Dynamic"></asp:RequiredFieldValidator>
                            </li>
                            <li>联系方式：
                                <input class="textInput" type="text" runat="server" id="textContact" />
                                <asp:RequiredFieldValidator ID="RFVContact" runat="server" ForeColor="Red" ErrorMessage="联系方式不能为空!" ControlToValidate="textContact" Display="Dynamic"></asp:RequiredFieldValidator>
                            </li>
                            <li>&nbsp;&nbsp;验证码：
                                <input runat="server" id="txtValidate" />
                                <img src="ValidateCode.aspx?ValidateCodeType=2&0.011150883024061309" onclick="this.src='ValidateCode.aspx?ValidateCodeType=2&'+Math.random();" id="imgValidateCode" alt="点击刷新验证码" title="点击刷新验证码" style="cursor: pointer;" />
                                <a onclick="codeRefresh()" class="diva" href="javascript:;">看不清楚，换一张</a>
                                <asp:Label ID="ErrorTips" runat="server" Text="" ForeColor="Red"></asp:Label>
                            </li>
                        </ul>
                    </div>
                    <label class="checkLabel">
                        <input type="checkbox" runat="server" id="CheckBox1" class="checkInput" />
                        <a href="../Agreement.aspx" class="agreement">我已阅读此网站协议</a>
                        <asp:Label ID="CMAgree" ForeColor="Red" runat="server"></asp:Label>
                    </label>
                    <br />
                    <%-- <input type="submit" class="registeButton" value="立即注册" />--%>
                    <asp:Button ID="BtnRegister" runat="server" Text="立即注册" CssClass="registeButton" OnClick="BtnRegister_Click" />
                </div>
            </div>
            <uc2:footer runat="server" ID="footer1" />
            <%-- <uc3:login ID="Login1" runat="server" />--%>
        </div>
    </form>
</body>
</html>
