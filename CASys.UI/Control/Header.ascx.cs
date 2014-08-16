using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CASys.UI.Control
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                string username = Session["UserName"] as string;
                divlogin.Attributes["style "] = "display:none ";
                logout.Attributes["style "] = "display:block ";
            }
            else
            {
                divlogin.Attributes["style "] = "display:block ";
                logout.Attributes["style "] = "display:none ";
            }
            this.mypage.Attributes["onclick"] = this.Page.ClientScript.GetPostBackEventReference(this.Page, "mypage");//添加响应事件
        }
    }
}