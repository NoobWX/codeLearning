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

        private void OK_btn_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(Price_tbx.Text)*Convert.ToDouble(Counts_tbx.Text);
            item_lbx.Items.Add("单价："+Price_tbx.Text+"元;  数量："+Counts_tbx.Text+"件");
            result_lbl.Text = total.ToString()+"元";
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Price_tbx.Text = "";
            Counts_tbx.Text = "";
            result_lbl.Text = ""+"元";
            item_lbx.Items.Clear();

        }
    }
}
