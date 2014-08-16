using CASys.BLL;
using CASys.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CASys.UI.Images
{
    public partial class Register : System.Web.UI.Page, IPostBackEventHandler, ICallbackEventHandler
    {
        string result = "";
        private RegisterBll registerBll = new RegisterBll();


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
                result = eventArgument + "该用户名已存在!";
            }
            else
            {
                result = eventArgument + "可以注册!";
            }
        }

        public string GetCallbackResult()
        {
            return result;
        }

        /// <summary>
        /// 注册验证及页面跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            if (genderMale.Checked == false && genderFemale.Checked == false)//验证性别
            {
                CMGender.Text = "请选择性别!";
                return;
            }
            if (CheckBox1.Checked == false)//验证同意协议
            {
                CMAgree.Text = "必须同意此协议!";
            }

            //验证验证码
            string userCode = this.txtValidate.Value; //获取用户输入的验证码
            if (String.IsNullOrEmpty(userCode))
            {
                ErrorTips.Text = "请输入验证码！";
                return;
            }
            string validCode = this.Session["CheckCode"] as String;  //获取系统生成的验证码
            if (!string.IsNullOrEmpty(validCode))
            {
                if (userCode.ToLower() == validCode.ToLower())
                {
                    ErrorTips.Text = "验证成功!";
                }
                else
                {
                    ErrorTips.Text = "请输入正确的验证码!";
                    return;
                }
            }
            Session["UserName"] = textInputName.Value;
            if (PostRegister())
            {
                Response.Redirect("Default.aspx");//页面跳转
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), this.GetHashCode().ToString(),
                    "alert(注册失败，请稍后再试！);", true);
            }
        }

        /// <summary>
        /// 实现注册
        /// </summary>
        /// <returns></returns>
        private bool PostRegister()
        {
            Role role = new Role();
            UserInfo user = new UserInfo();
            user.nickName = textInputName.Value;
            user.realName = realname.Value;
            user.gender = genderMale.Checked == true ? "男" : "女";
            role.password = textInputPassword.Value;
            user.email = textEmail.Value + emailSelect.Value;
            user.tel = textContact.Value;
            return registerBll.Register(role, user);
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