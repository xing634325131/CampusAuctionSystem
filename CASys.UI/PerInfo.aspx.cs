using CASys.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CASys.UI
{
    public partial class PerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Session["UserName"] as string;
            if (userName == null)
            {
                Response.Redirect("Default.aspx");
            }
            //InstituteList.DataSource = new ModifyInfo().GetAllInstitute();
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