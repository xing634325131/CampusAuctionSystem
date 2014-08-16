<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CASys.UI.Default" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>欢迎来到校园拍拍</title>

</head>

<body>
    <form id="form1" runat="server">
        <div class="about_at" align="center">
            <uc1:header ID="header" runat="server" />
            <!-- JiaThis Button BEGIN -->
            <div class="jiathis_style">
                <span class="jiathis_txt">分享到：</span>
                <a class="jiathis_button_tools_1"></a>
                <a class="jiathis_button_tools_2"></a>
                <a class="jiathis_button_tools_3"></a>
                <a class="jiathis_button_tools_4"></a>
                <a href="http://www.jiathis.com/share" class="jiathis jiathis_txt jiathis_separator jtico jtico_jiathis" target="_blank">更多</a>
                <a class="jiathis_counter_style"></a>
            </div>
            <script type="text/javascript" src="http://v3.jiathis.com/code/jia.js" charset="utf-8"></script>
            <!-- JiaThis Button END -->
            <uc2:footer ID="Footer1" runat="server" />
            <uc3:login ID="Login1" runat="server" />
        </div>
    </form>
</body>
</html>
