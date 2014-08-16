using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CASys.UI
{
    public partial class Details : System.Web.UI.Page,IPostBackEventHandler
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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