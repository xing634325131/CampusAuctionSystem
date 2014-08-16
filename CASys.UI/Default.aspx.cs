using CASys.DAL;
using CASys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CASys.UI
{
    public partial class Default : System.Web.UI.Page,IPostBackEventHandler
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string userName = Session["UserName"] as string;
            //if (userName != null)
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), this.GetHashCode().ToString(),
            //       "window.onload=function () {alert(\"欢迎您，" + userName + "\");} ", true);
            //}
        }

        public void RaisePostBackEvent(string eventArgument)
        {
            if (eventArgument == "mypage")
            {
                if (Session["UserName"] != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), this.GetHashCode().ToString(),
                    "window.location=\"PerInfo.aspx\"", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), this.GetHashCode().ToString(),
                    "document.getElementById(\"loginbtn\").click();", true);
                }
            }
        }
    }
}