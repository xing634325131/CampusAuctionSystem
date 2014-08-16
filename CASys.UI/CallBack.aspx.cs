using CASys.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CASys.UI
{
    public partial class CallBack : System.Web.UI.Page,ICallbackEventHandler
    {
        string result = "";
        
        public void Page_Load(Object sender, EventArgs e)
        {
            ClientScriptManager csm = Page.ClientScript;
            String reference = csm.GetCallbackEventReference(this, "args", "Success", "", "Error", false);
            String callbackScript = "function CallServerMethod(args, context) {\n" +
             reference + ";\n }";
            csm.RegisterClientScriptBlock(this.GetType(), "CallServerMethod",
             callbackScript, true);
        }

        public void RaiseCallbackEvent(String eventArgument)
        {
            if (!new RegisterBll().CheckUser(eventArgument.Trim()))
            {
                result = eventArgument + "不能作为用户名注册。";
            }
            else
            {
                result = eventArgument + "可以注册。";
            }
        }

        public string GetCallbackResult()
        {
            return result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!ClientScript.IsClientScriptBlockRegistered(this.GetType(), "haha"))
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "haha", "<script language='javascript'>alert('ClientScriptBlock')</script>");
            }
        }
    }
}