<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerInfo.aspx.cs" MaintainScrollPositionOnPostback="true"  Inherits="CASys.UI.PerInfo" %>

<%@ Register Src="Control/Footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/Control/Header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Login.ascx" TagName="login" TagPrefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Styles/person-login.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/personLogin.js" type="text/javascript">
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main-border" align="center">
            <uc1:header ID="header" runat="server" />
            <div class="divperson">
                <div id="left-border">
                    <div id="head-image"><a href="#">head-image</a></div>
                    <ul id="ul1">
                        <li>更改头像&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li>
                        <li>上传头像</li>
                    </ul>
                    <div id="left-horizon"></div>
                    <div id="infor">个人信息设置</div>
                    <ul id="ul2">
                        <li>基本信息设置</li>
                        <li></li>
                        <li><a href="#">安全信息设置</a></li>
                    </ul>
                    <div id="manage">我的物品管理</div>
                    <ul id="ul3">
                        <li>我的竞拍物品</li>
                        <li></li>
                        <li>我的挂牌物品</li>
                    </ul>
                    <div id="myReq">我的申请</div>
                    <ul id="ul4">
                        <li>我的申请表</li>
                    </ul>
                </div>
                <div id="right-border">
                    <div id="table1">
                        <table class="tableperson">
                            <tr>
                                <td colspan="2">
                                    <div class="title_Info">基本资料</div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">昵称：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="nickName" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">性别：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="radio" name="sex" value="boy" checked="checked" />男
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <input type="radio" name="sex" />女
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">生日：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <select name="year">
                                            <option value="1988">1988</option>
                                            <option value="1989">1989</option>
                                            <option value="1990">1990</option>
                                            <option value="1991">1991</option>
                                            <option value="1992">1992</option>
                                            <option value="1993">1993</option>
                                            <option value="1994">1994</option>
                                            <option value="1995">1995</option>
                                            <option value="1996">1996</option>
                                            <option value="1997">1997</option>
                                            <option value="1998">1998</option>
                                            <option value="1999" selected="selected">1999</option>
                                            <option value="2000">2000</option>
                                            <option value="2001">2001</option>
                                            <option value="2002">2002</option>
                                            <option value="2003">2003</option>
                                            <option value="2004">2004</option>
                                            <option value="2005">2005</option>
                                            <option value="2006">2006</option>
                                            <option value="2007">2007</option>
                                            <option value="2008">2008</option>
                                        </select>&nbsp;&nbsp;
                            <select name="mouth">
                                <option value="1" selected="selected">1</option>
                                <option value="2">2</option>
                                <option value="3">3</option>
                                <option value="4">4</option>
                                <option value="5">5</option>
                                <option value="6">6</option>
                                <option value="7">7</option>
                                <option value="8">8</option>
                                <option value="9">9</option>
                                <option value="10">10</option>
                                <option value="11">11</option>
                                <option value="12">12</option>
                            </select>
                                        &nbsp;&nbsp;
                            <select name="date">
                                <option value="1" selected="selected">1</option>
                                <option value="2">2</option>
                                <option value="3">3</option>
                                <option value="4">4</option>
                                <option value="5">5</option>
                                <option value="6">6</option>
                                <option value="7">7</option>
                                <option value="8">8</option>
                                <option value="9">9</option>
                                <option value="10">10</option>
                                <option value="11">11</option>
                                <option value="12">12</option>
                                <option value="3">13</option>
                                <option value="4">14</option>
                                <option value="5">15</option>
                                <option value="6">16</option>
                                <option value="7">17</option>
                                <option value="8">18</option>
                                <option value="9">19</option>
                                <option value="10">20</option>
                                <option value="11">21</option>
                                <option value="12">22</option>
                                <option value="3">23</option>
                                <option value="4">24</option>
                                <option value="5">25</option>
                                <option value="6">26</option>
                                <option value="7">27</option>
                                <option value="8">28</option>
                                <option value="9">29</option>
                                <option value="10">30</option>
                            </select>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">所在地：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="homeTown" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">联系方式：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="contact" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">QQ：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="contactQQ" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">邮箱：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="mailBox" size="30" />
                                        <select name="mailName">
                                            <option value="QQMail" selected="selected">@qq.com</option>
                                            <option value="sinaMail">@sina.com</option>
                                            <option value="163Mail">@163.com</option>
                                            <option value="souhu">@souhu.com</option>
                                        </select>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">个人简介：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <textarea name="intro" cols="44" rows="10"></textarea>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div class="title_Info">院系专业</div>
                                </td>
                            </tr>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <tr>
                                        <td>
                                            <div class="div">学院：</div>
                                        </td>
                                        <td>
                                            <div class="div">
                                                <%--<input type="text" name="academy" size="50" />--%>
                                                <asp:ObjectDataSource ID="InstituteData" runat="server" SelectMethod="GetAll" TypeName="CASys.Dal.GradeDal"></asp:ObjectDataSource>
                                                <asp:DropDownList ID="InstituteList" runat="server" DataSourceID="InstituteData" DataTextField="name" DataValueField="id" AutoPostBack="True"></asp:DropDownList>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="div">专业：</div>
                                        </td>
                                        <td>
                                            <div class="div">
                                                <%--<input type="text" name="major" size="50" />--%>
                                                <asp:ObjectDataSource ID="MajorData" runat="server" SelectMethod="GetAll" TypeName="CASys.Dal.GradeDal">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="InstituteList" DbType="Guid" Name="upperId" PropertyName="SelectedValue" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:DropDownList ID="MajorList" runat="server" DataSourceID="MajorData" DataTextField="name" DataValueField="id" AutoPostBack="True"></asp:DropDownList>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="div">
                                                年级：
                                            </div>
                                        </td>
                                        <td>
                                            <div class="div">
                                                <%--<input type="text" name="grade" size="50" />--%>
                                                <asp:ObjectDataSource ID="GradeData" runat="server" SelectMethod="GetAll" TypeName="CASys.Dal.GradeDal">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="MajorList" DbType="Guid" Name="upperId" PropertyName="SelectedValue" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:DropDownList ID="GeadeList" runat="server" DataSourceID="GradeData" DataTextField="name" DataValueField="id"></asp:DropDownList>
                                            </div>
                                        </td>
                                    </tr>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="GeadeList" />
                                </Triggers>
                            </asp:UpdatePanel>
                            <tr>
                                <td colspan="2">
                                    <div class="title_Info">其他信息（选填）</div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">个性签名：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="signature" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">影视信息：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="movie" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">书籍：</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="text" name="famouse" size="50" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="div">&nbsp;&nbsp;</div>
                                </td>
                                <td>
                                    <div class="div">
                                        <input type="submit" name="save" value="保存" class="personbtn" />
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <input type="reset" name="cancel" value="取消" class="personbtn" />
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <div id="request">我要挂拍</div>
                    </div>
                </div>
            </div>
            <uc2:footer ID="Footer1" runat="server" />
            <uc3:login ID="Login1" runat="server" />
        </div>
    </form>
</body>
</html>
