<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="CASys.UI.Details" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>物品详细信息</title>
    <link type="text/css" href="Styles/Details.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.8.2.js"></script>
    <script src="Scripts/WebForms/Details.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="detailes-div" align="center">
            <uc1:header ID="header" runat="server" />
            <div class="details">
                <div class="dt_titles">
                    物品详细信息
                </div>
                <hr class="dt_hr" />
                <div class="dt_content">
                    <div class="dt_left">
                        <div class="dt_bigimg">
                            <img class="bigimg" src="Images/bigimg.gif" />
                        </div>
                        <div class="dt_smallimg">
                            <img class="smallimg" src="Images/smallimg.gif" />
                            <img class="smallimg" src="Images/smallimg.gif" />
                            <img class="smallimg" src="Images/smallimg.gif" />
                        </div>
                    </div>
                    <div class="dt_div_right">
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">名称：</div>
                                <div class="div_right">联想笔记本M490</div>
                            </div>
                        </div>
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">底价：</div>
                                <div class="div_right" id="oldprice">￥1000</div>
                            </div>
                        </div>
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">加价幅度：</div>
                                <div class="div_right" id="price_range">￥50</div>
                            </div>
                        </div>
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">叫价次数：</div>
                                <div class="div_right" id="countprice">2次</div>
                            </div>
                        </div>
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">当前价：</div>
                                <div class="div_right" id="nowprice">￥1200</div>
                            </div>
                        </div>
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">拍卖时间：</div>
                                <div class="div_right">2013年11月4日-2013年11月15日</div>
                            </div>
                        </div>
                        <div class="dt_right">
                            <div class="div">
                                <div class="div_left">物品描述：</div>
                                <div class="div_right_desc">
                                        八成新，M490为2012年8月上市的商用多彩版产品，14寸的M490做工优秀是一款高性能的沉稳商务本。
                                </div>
                            </div>
                        </div>
                        <div class="dt_right_bottom">
                            <div class="div_top">
                                <div class="div_left">出价：</div>
                                <div class="div_center_price">
                                    <input class="div_price" />
                                </div>
                                <div class="div_right_btn">
                                    <img src="Images/add.gif" class="div_right_btn_add" />
                                    <img src="Images/sub.gif" class="div_right_btn_sub" />
                                </div>
                            </div>
                            <div class="div_bottom">
                                <input type="button" class="dt_btn" value="参与竞拍" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <uc2:footer ID="Footer1" runat="server" />
            <uc3:login ID="Login1" runat="server" />
        </div>
    </form>
</body>
</html>
