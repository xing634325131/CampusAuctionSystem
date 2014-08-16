<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuctionPredict.aspx.cs" Inherits="CASys.UI.AuctionPredict" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>拍卖预告</title>
    <link href="../Styles/AuctionPredict.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="predict" align="center">
            <uc1:header ID="header" runat="server" />
            <div class="divbox">
                <div class="predicthead">
                    等待拍卖中......
                </div>
                <hr class="predicthr" />
                <div class="predictbox1">
                    <img src="Images/goods1.gif" class="boximg" />
                    <div class="boxright">
                        <div class="divtxt">名称：</div>
                        <div class="divcontent">布娃娃</div>
                        <div class="divtxt">拍卖时间：</div>
                        <div class="divcontent">2013年11月2日-2013年11月7日</div>
                        <div class="divtxt">底价：</div>
                        <div class="divcontent">5￥</div>
                        <div class="divtxt">加价幅度：</div>
                        <div class="divcontent">1￥</div>
                    </div>
                </div>
                <div class="predictbox1">
                    <img src="Images/goods2.gif" class="boximg"  />
                    <div class="boxright">
                        <div class="divtxt">名称：</div>
                        <div class="divcontent">布娃娃</div>
                        <div class="divtxt">拍卖时间：</div>
                        <div class="divcontent">2013年11月2日-2013年11月7日</div>
                        <div class="divtxt">底价：</div>
                        <div class="divcontent">5￥</div>
                        <div class="divtxt">加价幅度：</div>
                        <div class="divcontent">1￥</div>
                    </div>
                </div>
                <div class="predictbox1">
                    <img src="Images/goods3.gif" class="boximg"  />
                    <div class="boxright">
                        <div class="divtxt">名称：</div>
                        <div class="divcontent">布娃娃</div>
                        <div class="divtxt">拍卖时间：</div>
                        <div class="divcontent">2013年11月2日-2013年11月7日</div>
                        <div class="divtxt">底价：</div>
                        <div class="divcontent">5￥</div>
                        <div class="divtxt">加价幅度：</div>
                        <div class="divcontent">1￥</div>
                    </div>
                </div>
            </div>
            <uc2:footer ID="Footer1" runat="server" />
            <uc3:login ID="Login1" runat="server" />
        </div>
    </form>
</body>
</html>
