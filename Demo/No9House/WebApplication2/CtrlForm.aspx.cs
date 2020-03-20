using BLL;
using System;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class CtrlForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MidWareManage midWare = new MidWareManage("UserInfo");
            GridView1.DataSource = midWare.gettable(midWare);
            DataBind();
        }


    }
}