<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="CASys.UI.Control.Header" %>

<link href="../Styles/Header.css" rel="stylesheet" type="text/css" />

<script>
    function mouseOver(obj) {
        obj.style.background = "#FF4400";
    }
    function mouseOut(obj) {
        obj.style.background = "#FF6600";
    }
    function logout() {
        window.location = "../Control/Logout.aspx";
    }
</script>

<div class="headDiv">
    <div class="bannerDiv">
		<div class="logoImg"><img src="../Images/logo.gif"></div>
		<div class="searchDiv">
			<input type="text"/>
			<a href="#" class="search">搜索</a>
		</div>
		<div class="loginSpan" runat="server" id="divlogin">
			<ul>
				<li class="redLogo">亲，请登陆&nbsp;>&nbsp;</li>
				<li><a id="loginbtn">登录|</a></li>
				<li><a href="../Register.aspx" id="go_register">免费注册</a></li>
			</ul>
		</div>
	</div>
	<div class="menuDiv" id="menuDiv">
		<ul>
			<li class="menuLi" onmouseover="mouseOver(this)" onmouseout="mouseOut(this)"><a href="../Default.aspx">主页</a></li>
			<li class="menuLi" id="mypage" runat="server" onmouseover="mouseOver(this)" onmouseout="mouseOut(this)">个人空间</li>
			<li class="menuLi" onmouseover="mouseOver(this)" onmouseout="mouseOut(this)"><a href="../AuctionPredict.aspx">拍卖预告</a></li>
			<li class="menuLi" id="paiLiu" onmouseover="mouseOver(this)" onmouseout="mouseOut(this)"><a href="../Help.aspx">拍卖流程</a></li>
            <li class="menuLi" runat="server" onclick="logout()" id="logout"  onmouseover="mouseOver(this)" onmouseout="mouseOut(this)">注销</li>
		</ul>
	</div>
</div>