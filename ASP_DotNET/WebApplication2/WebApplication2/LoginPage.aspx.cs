using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class FrontPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_btn.ImageUrl = "wwwroot/LoginBtn/Login2.png";
        }
    }
}