<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="CASys.UI.Help" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>拍卖流程</title>
    <script src="../Scripts/jquery-1.9.1.js"></script>
    <script src="../Scripts/jquery.ui.core.js"></script>
    <script src="../Scripts/jquery.ui.widget.js"></script>
    <script src="../Scripts/jquery.ui.tabs.js"></script>
    <link href="Styles/Help.css" type="text/css" rel="stylesheet" />
    <script>
        $(function () {
            $("#tabs").tabs().addClass("ui-tabs-vertical ui-helper-clearfix");
            $("#tabs li").removeClass("ui-corner-top").addClass("ui-corner-left");
        });
	</script>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <uc1:header ID="header" runat="server" />
            <div id="tabs" class="center">
                <ul class="help_ul">
                    <li><img class="titlelogo" alt="标题图片" src="../Images/titlelogo.gif" /><a href="#tabs-1">交易流程</a></li>
                    <li><img class="titlelogo" alt="标题图片" src="../Images/titlelogo.gif" /><a href="#tabs-2">术语解释</a></li>
                    <li><img class="titlelogo" alt="标题图片" src="../Images/titlelogo.gif" /><a href="#tabs-3">拍卖规则</a></li>
                </ul>
                <hr class="helphr"/>
                <div id="tabs-1">
                    <div class="title">
                        <img class="titlelogo" alt="标题图片" src="../Images/titlelogo.gif" />交易流程
                    </div>
					<div class="txt_1">
                        送拍流程----为买家和卖家提供最及时的信息，最可靠的保障。基本业务流程如下：
                    </div>
                    <div class="txt_2">
                        一、送拍
                    </div>
                    <div class="txt_3">
                       注册成为会员之后，可以申请进行拍卖。申请成功后，将尽快进行回复，申请通过与否都会通知到您的个人空间。
                    </div>
                    <div class="txt_2">
                        二、拍卖
                    </div>
                    <div class="txt_3">
                        系统根据您的拍卖底价进行拍卖发布，并且在规定时间内由竞拍者出的最高价格，达成此项拍卖物品的交易记录。
                    </div>
                    <div class="txt_2">
                          三、竞拍
                    </div>
                    <div class="txt_3">
                         注册成为会员后，即可选择物品进行竞拍，我们会及时通知您的喊价竞拍成功的情况。有几档加价原则，在您选择某个物品竞拍后即可在页面上看到。
                    </div>
                </div>
                <div id="tabs-2">
                    <div class="title">
                        <img class="titlelogo" alt="标题图片" src="../Images/titlelogo.gif" />术语解释
                    </div>
					<div class="txt_1">
                        物品：
					</div>
                    <div class="txt_2">
                        此专业术语仅限于具体物质形态的实际存在的且具有使用价值的事物
                    </div>
                    <div class="txt_1">
                        挂拍物品：
					</div>
                    <div class="txt_2">
                       申请发布同意后，可在该系统上进行拍卖且正在处于拍卖状态的物品。
                    </div>
                    <div class="txt_1">
                        物品下架：
					</div>
                    <div class="txt_2">
                          过了一定期限后，将此物品下架，即该物品信息不再能够在本系统显示且不可进行任何活动。
                    </div>
                    <div class="txt_1">
                         物品挂拍时间：
                    </div>
					<div class="txt_2">
                         用户期望在该系统上保持拍卖状态且已经管理员同意的时间。
                    </div>
                    <div class="txt_1">
                         物品起拍价：
                    </div>
					<div class="txt_2">
                          用户期望的物品的最低被拍走价格
                    </div>
                </div>
                <div id="tabs-3">
                    <div class="title">
                        <img class="titlelogo" alt="标题图片" src="../Images/titlelogo.gif" />拍卖规则
                    </div>
                    <div class="txt_1">
                        买家参与拍卖需交纳保证金
                    </div>
                    <div class="txt_2">
                        保证金收取规则为:
                    </div>
                    <div class="txt_3">
                        1）每次出价金额的N%/笔，小数部分按四舍五入取整。
                    </div>
                    <div class="txt_3">
                        2）收取固定保证金。
                    </div>
                    <div class="txt_1">
                        参加拍卖的用户需先向自己的账户充值，参与拍卖后对应金额的保证金将被冻结在账户中。
                    </div>
                    <div class="txt_2">
                        1.有出价高者竞拍后，此次出价的买家保证金系统立即给予解冻。
                    </div>
                    <div class="txt_2">
                        2.成功竞拍后如果卖家主动关闭交易，则系统立即解冻买家的保证金。
                    </div>
                    <div class="txt_2">
                        3.竞拍成功的买家在3天交易期内履行该交易（付款）后，系统会立即解冻保证金；否则在3天交易期满后系统将自动关闭交易，并且保证金不予解冻。
                    </div>
                </div>
            </div>
            <uc2:footer ID="Footer1" runat="server" />
            <uc3:login ID="Login1" runat="server" />
        </div>
    </form>
</body>
</html>
