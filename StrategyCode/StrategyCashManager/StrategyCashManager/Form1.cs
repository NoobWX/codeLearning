using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyCashManager
{
    public partial class Form1 : Form
    {
        double Total = 0.0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscountType_cbx.Items.AddRange(new object[] { "原价", "八折", "满300减100" });
            DiscountType_cbx.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextCash contextCash = null;
            switch(DiscountType_cbx.SelectedIndex)
            {
                case 0:
                    contextCash = new ContextCash(new OriginalCost());
                    break;
                case 1:
                    contextCash = new ContextCash(new Discount(0.8d));
                    break;
                case 2:
                    contextCash = new ContextCash(new Reduction(300, 100));
                    break;
            }
            double TotalPrice = contextCash.ContextCashInterface(Convert.ToDouble(Count_tbx.Text) * Convert.ToDouble(Price_tbx.Text));
            Total += TotalPrice;
            Goods_lbx.Items.Add("价格：" + Price_tbx.Text + "   个数：" + Count_tbx.Text + "   优惠活动：" + DiscountType_cbx.SelectedItem.ToString());
            Result_lbl.Text = Total.ToString() + "元";
        }
    }
}
