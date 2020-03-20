using BLL;
using System;
using System.Collections.Generic;
using System.Web.UI;
namespace WebApplication2
{
    public partial class FrontPage : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void ImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            MidWareManage midWare = new MidWareManage("UserInfo", new List<string> { "user_id", "user_pwd" }, new List<string> { UserID.Text.Trim(), Password.Text.Trim() },1);
            if (UserID.Text != "" && Password.Text != "" && midWare.checkdele(midWare))
            {
                if (midWare.getType(midWare))
                {
                    Response.Redirect("~/CtrlForm.aspx");
                }
                else
                    Response.Write("<script>alert('当前用户权限不足!');</script>");
            }
            else
                Response.Write("<script>alert('用户名或密码错误!');</script>");
        }

        protected void Resign_btn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}