<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CASys.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" src="Scripts/jquery-1.8.2.js"></script>
    <script type="text/javascript" >
        $(document).ready(function () {
            //将二级菜单设置为不可见 
            $(".FAQlist").css("display", "none");
            //单击一级菜单触发的事件 
            $(".bartitleFAQ").click(function () {
                $(".FAQlist").css("display", "none");//将二级菜单全部设置为不可见 
                $(this).next(".FAQlist").css("display", "block");//当前一级菜单的二级菜单设置为可见 
            })
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="mainleftFAQ">
                <div class="category">
                    <img src="images/admin.gif" width="215" height="66" />
                </div>
                <div id="disp">
                </div>
                <div class="bartitleFAQ">
                    <img src="images/yuan.gif" /><span class="admintext11">服务管理</span>
                </div>
                <div class="FAQlist">
                    <ul>
                        <li><a href='#'>等待提交</a></li>
                        <li><a href='#' title=''>等待发布</a></li>
                        <li><a href='#' title=''>正式项目</a></li>
                        <li><a href='#' title=''>点此新增</a></li>
                    </ul>
                </div>
                <div class="bartitleFAQ">
                    <img src="images/yuan.gif" /><span class="admintext11">更新流程</span>
                </div>
                <div class="FAQlist">
                    <ul>
                        <li><a href='#'>后台搜索</a></li>
                        <li><a href='#' title=''>更新流程</a></li>
                    </ul>
                </div>
                <div class="bartitleFAQ">
                    <img src="images/yuan.gif" /><span class="admintext11">FAQ管理</span>
                </div>
                <div class="FAQlist">
                    <ul>
                        <li><a href='#'>等待提交</a></li>
                        <li><a href='#' title=''>等待发布</a></li>
                        <li><a href='#' title=''>正式项目</a></li>
                        <li><a href='#' title=''>点此新增</a></li>
                    </ul>
                </div>
                <div class="bartitleFAQ">
                    <img src="images/yuan.gif" /><span class="admintext11">下载管理</span>
                </div>
                <div class="FAQlist">
                    <ul>
                        <li><a href='#'>等待提交</a></li>
                        <li><a href='#' title=''>等待发布</a></li>
                        <li><a href='#' title=''>正式项目</a></li>
                        <li><a href='#' title=''>点此新增</a></li>
                    </ul>
                </div>
                <div class="bartitleFAQ">
                    <img src="images/yuan.gif" /><span class="admintext11">返回首页</span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
