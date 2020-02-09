using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashManager
{
    public partial class Form1 : Form
    {
        double total = 0.0d;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Promotion_cbx.Items.AddRange (new object[] { "正常收费", "八折优惠","满300减100" });
            Promotion_cbx.SelectedIndex = 0;
        }
        private void OK_btn_Click(object sender, EventArgs e)
        {
            CreateCashFactory ccf = new CreateCashFactory(Counts_tbx.Text, Price_tbx.Text);
            CashFun cf = ccf.CreateCashFun(Promotion_cbx.SelectedIndex);
            item_lbx.Items.Add("单价：" + Price_tbx.Text + "元;  数量：" + Counts_tbx.Text + "件;   " + Promotion_cbx.Text);
            total += cf.GetResult();
            result_lbl.Text = total.ToString()+"元";

            //switch(Promotion_cbx.SelectedIndex)
            //{
            //    case 0: 
            //        total += Convert.ToDouble(Price_tbx.Text) * Convert.ToDouble(Counts_tbx.Text);

            //        break;
            //    case 1:
            //        total += Convert.ToDouble(Price_tbx.Text) * Convert.ToDouble(Counts_tbx.Text) * 0.8;
            //        break;
            //}
            //item_lbx.Items.Add("单价："+Price_tbx.Text+"元;  数量："+Counts_tbx.Text+"件;   "+Promotion_cbx.Text);
            //result_lbl.Text = total.ToString()+"元";
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Price_tbx.Text = "";
            Price_tbx.Text = "";
            Counts_tbx.Text = "";
            result_lbl.Text = "0.0";
            item_lbx.Items.Clear(); 
        }


    }
}
