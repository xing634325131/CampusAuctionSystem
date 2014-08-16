<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CASys.UI.About" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>关于校园拍拍</title>
    <link rel="stylesheet" type="text/css" href="../Styles/About.css"/>
</head>
<body >
    <form id="form1" runat="server">
    <div class="about_at" align="center">
        <uc1:header ID="header" runat="server" />
        <uc2:footer runat="server" />
        <uc3:login ID="Login1" runat="server" />
    </div>
    </form>
</body>
</html>
