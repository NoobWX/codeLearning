using Lesson1._1_HW.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Lesson1._1_HW
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int y = DateTime.Now.Year;
        private int m = 1;
        private int d = 1;
        private string sex = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Years_ddl.Items.Clear();
            Mounth_ddl.Items.Clear();
            Date_ddl.Items.Clear();
            for (int i = 0; i < 50; ++i)
            {
                if (i < 12)
                {
                    Mounth_ddl.Items.Add(m++.ToString());
                }
                if (i < 31)
                {
                    Date_ddl.Items.Add(d++.ToString());
                }
                Years_ddl.Items.Add(y--.ToString());
            }
            UserId_tbx.Text = RestStatus.RecoverUserStatus();
            Pwd1_tbx.Text = RestStatus.RecoverPwdStatus();
            Pwd1_tbx.TextMode = TextBoxMode.Password;
            Pwd2_tbx.TextMode = TextBoxMode.Password;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestStatus restStatus = new RestStatus();
            if (Pwd1_tbx.Text != "")
            {
                restStatus.SavePwdStatus(Pwd1_tbx.Text);
            }
            if(UserId_tbx.Text != "")
            {
                restStatus.SaveUserStatus(UserId_tbx.Text);
            }
            switch (DropDownList1.SelectedValue)
            {
                case "0":
                    Image1.ImageUrl = "~/Image/image0.jpg";
                    break;
                case "1":
                    Image1.ImageUrl = "~/Image/image1.jpg";
                    break;
                case "2":
                    Image1.ImageUrl = "~/Image/image2.jpg";
                    break;
                case "3":
                    Image1.ImageUrl = "~/Image/image3.jpg";
                    break;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox1.Checked == true)
            {
                sex = "男";
                CheckBox2.Checked = false;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox2.Checked == true)
            {
                sex = "女";
                CheckBox1.Checked = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "头像：" + DropDownList1.Text + '\n' + "用户名：" + UserId_tbx.Text + '\n' + "姓名：" + Name_tbx.Text + '\n' + "性别:" + sex + '\n';
        }
    }
}