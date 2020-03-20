using System;
using System.Windows.Forms;
using BLL;

namespace WebApplication2
{
    public partial class SignIn : System.Web.UI.Page
    {
        private bool _keys;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Psw1_TextChanged(object sender, EventArgs e)
        {
            if (Psw1 != null && Psw1.Text.Length < 6)
            {
                Pw1.ImageUrl = "wwwroot/RegisteredUI/Error.png";
            }
            else
            {
                Pw1.ImageUrl = "wwwroot/RegisteredUI/Pass.png";
            }
        }

        protected void Psw2_TextChanged(object sender, EventArgs e)
        {
            if (Psw2.Text != null && Psw2.Text != Psw1.Text )
            {
                Pw2.ImageUrl = "wwwroot/RegisteredUI/Error.png";
                _keys = false;
            }
            else
            {
                Pw2.ImageUrl = "wwwroot/RegisteredUI/Pass.png";
                _keys = true;
            }
        }

        protected void ResignBtn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            MidWareManage midWare = new MidWareManage("UserInfo",Idname.Text,Psw2.Text);
            if (Psw1 != null && _keys)
            {
                if (midWare.checkrepectuser(midWare))
                {
                    if (midWare.addfield(midWare))
                    {
                        MessageBox.Show("注册成功!即将转至登录界面....");
                        Response.Redirect("~/LoginPage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('注册失败.');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('用户名已被占用.');</script>");
                }
            }
        }

        protected void Back_btn_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}