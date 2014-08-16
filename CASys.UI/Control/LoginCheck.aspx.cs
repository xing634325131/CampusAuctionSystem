using CASys.BLL;
using CASys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CASys.UI.Control
{
    public partial class LoginCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Role role = new Role();
            UserInfo user = new UserInfo();
            role.password = Request.QueryString["password"];
            user.nickName = Request.QueryString["userName"];
            if (new LoginBll().Login(role, user))//验证登录信息
            {
                Session["UserName"] = user.nickName;//登录成功，用户名写入session
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                go_back.HRef = Request.UrlReferrer.ToString();
            }
        }
    }
}