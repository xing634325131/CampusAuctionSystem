<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="CASys.UI.Control.Login" %>

<link href="../Styles/Login.css" type="text/css" rel="stylesheet" />

<script src="../Control/CJL.0.1.min.js"></script>
<script src="../Control/AlertBox.js"></script>
<script src="../Scripts/Login.js"></script>

<div class="login_lgbox" id="loginbox">
    <div class="none">
        <div class="login_lgtitle">
            登录
        </div>
        <div id="login_lgclose">
            <asp:ImageButton ID="ImageClose" ToolTip="关闭窗口" CssClass="imgclose" ImageUrl="~/Images/close.gif" runat="server" />
        </div>
    </div>
    <div class="login_lgdivhr">
        <hr class="login_lghr" />
    </div>
    <div class="login_lgdiv">
        <div class="login_lgt">
            登录账号：
        </div>
        <div class="login_lgnp">
            <input id="loginId" onfocus="loginunuse()" maxlength="18" type="text" />
        </div>
    </div>
    <div class="login_lgdiv">
        <div class="login_lgt">
            登录密码：
        </div>
        <div class="login_lgnp">
            <input id="loginpassword" type="password" maxlength="16" />
        </div>
        <div class="login_lgforgetpwd">
            <a href="../FindPassword.aspx">忘记密码？</a>
        </div>
    </div>
    <div class="login_lgdiv">
        <div class="login_lgt">
            验证码：
        </div>
        <div class="login_lgnp">
            <input id="loginvalicode" onblur="checkCode()" type="text" maxlength="4" />
        </div>
        <div class="login_lgcode">
            <img src="../ValidateCode.aspx?ValidateCodeType=2&0.011150883024061309"
                onclick="this.src='../ValidateCode.aspx?ValidateCodeType=2&'+Math.random();"
                id="imgValidateCode" alt="点击刷新验证码" title="点击刷新验证码"
                style="cursor: pointer;" />
        </div>
        <div class="login_lgreset">
            <a onclick="codeRefresh()" href="javascript:;">看不清楚，换一张</a>
        </div>
    </div>
    <span id="message" class="msg"></span>
    <div class="login_lgdiv">
        <div class="login_lgpwd">
            <asp:CheckBox ID="CBRememberPwd" runat="server" Text="记住密码" />
        </div>
        <div class="login_lgautologin">
            <asp:CheckBox ID="CBAutoLogin" runat="server" Text="自动登录" />
        </div>
    </div>
    <div class="login_lgdiv">
        <div class="login_lgbtn">
            <asp:Button ID="BtnLogin" runat="server" Text="登录" OnClientClick="checkLogin()" CssClass="loginBtn" />
        </div>
        <div class="login_lgcancelbtn">
            <asp:Button ID="BtnCancelLogin" runat="server" Text="取消登录" CssClass="cancelLoginBtn" />
        </div>
        <div class="login_lgrt">
            还没账号？<a href="../Register.aspx">赶快去注册吧</a>
        </div>
    </div>
</div>


<script type="text/javascript">
    (function () {
        var ab = new AlertBox("loginbox"), lock = true;
        ab.center = true;
        ab.fixed = true;
        ab.onShow = function () {
            $$("loginId").select();
            $$("loginpassword").value = "";
            $$("loginvalicode").value = "";
            OverLay.show();
        }
        ab.onClose = function () {
            OverLay.close();
        }
        $$("loginbtn").onclick = function () { ab.show(); }
        $$("<%=ImageClose.ClientID%>").onclick = function () { ab.close(); }
        $$("<%=BtnCancelLogin.ClientID%>").onclick = function () { ab.close(); }
    })();
    function loginunuse() {
        document.getElementById("<%=BtnLogin.ClientID%>").disabled = true;
    }
    document.onkeydown = function () {
        var cookies = document.cookie;
        var valicode;
        if (cookies.length > 0) {
            c_start = cookies.indexOf("CheckCode=")
            if (c_start != -1) {
                valicode = cookies.substring(c_start + 10, c_start + 14).toLowerCase();
            }
        }
        if (event.keyCode == 13 && document.getElementById("<%=BtnLogin.ClientID%>").disabled == false) {
        checkLogin();
    }
    if (event.keyCode == 8) {
        document.getElementById("<%=BtnLogin.ClientID%>").disabled = true;
            document.getElementById("message").innerText = error;
        }
    var valicodelen = document.getElementById("loginvalicode").value.length;
    if (valicodelen == 3) {
        if (event.keyCode == hashcode[valicode.substring(3, 4)]) {
            var inputcode = document.getElementById("loginvalicode").value.toLowerCase();
            if (inputcode.substring(0, 3) != valicode.substring(0, 3)) {
                document.getElementById("<%=BtnLogin.ClientID%>").disabled = true;
                    document.getElementById("message").innerText = error;
                }
                else {
                    document.getElementById("<%=BtnLogin.ClientID%>").disabled = false;
                    document.getElementById("message").innerText = "";
                }
            }
            else {
                document.getElementById("<%=BtnLogin.ClientID%>").disabled = true;
                document.getElementById("message").innerText = error;
            }
        }
}
    function codeRefresh() {
        var img = document.getElementById("imgValidateCode");
        img.click();
    }
    function checkLogin() {
        window.location = "../Control/LoginCheck.aspx?userName=" + loginId.value + "&password=" + loginpassword.value;
    }
    function checkCode() {
        var cookies = document.cookie;
        if (cookies.length > 0) {
            c_start = cookies.indexOf("CheckCode=")
            if (c_start != -1) {
                var valicode = cookies.substring(c_start + 10, c_start + 14).toLowerCase();
                var inputcode = document.getElementById("loginvalicode").value.toLowerCase();
                if (inputcode != valicode) {
                    document.getElementById("<%=BtnLogin.ClientID%>").disabled = true;
                    document.getElementById("message").innerText = error;
                }
                else {
                    document.getElementById("<%=BtnLogin.ClientID%>").disabled = false;
                    document.getElementById("message").innerText = "";
                }
            }
        }
    }
</script>
