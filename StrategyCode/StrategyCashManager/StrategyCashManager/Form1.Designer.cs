namespace StrategyCashManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Count_tbx = new System.Windows.Forms.TextBox();
            this.Price_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscountType_cbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Goods_lbx = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Result_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Count_tbx
            // 
            this.Count_tbx.Location = new System.Drawing.Point(209, 36);
            this.Count_tbx.Name = "Count_tbx";
            this.Count_tbx.Size = new System.Drawing.Size(191, 28);
            this.Count_tbx.TabIndex = 2;
            // 
            // Price_tbx
            // 
            this.Price_tbx.Location = new System.Drawing.Point(209, 88);
            this.Price_tbx.Name = "Price_tbx";
            this.Price_tbx.Size = new System.Drawing.Size(191, 28);
            this.Price_tbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "个数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "单价：";
            // 
            // DiscountType_cbx
            // 
            this.DiscountType_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscountType_cbx.FormattingEnabled = true;
            this.DiscountType_cbx.Location = new System.Drawing.Point(209, 138);
            this.DiscountType_cbx.Name = "DiscountType_cbx";
            this.DiscountType_cbx.Size = new System.Drawing.Size(191, 26);
            this.DiscountType_cbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "优惠活动：";
            // 
            // Goods_lbx
            // 
            this.Goods_lbx.FormattingEnabled = true;
            this.Goods_lbx.ItemHeight = 18;
            this.Goods_lbx.Location = new System.Drawing.Point(82, 189);
            this.Goods_lbx.Name = "Goods_lbx";
            this.Goods_lbx.Size = new System.Drawing.Size(468, 238);
            this.Goods_lbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "总价：";
            // 
            // Result_lbl
            // 
            this.Result_lbl.AutoSize = true;
            this.Result_lbl.Font = new System.Drawing.Font("宋体", 28F);
            this.Result_lbl.Location = new System.Drawing.Point(255, 488);
            this.Result_lbl.Name = "Result_lbl";
            this.Result_lbl.Size = new System.Drawing.Size(108, 56);
            this.Result_lbl.TabIndex = 10;
            this.Result_lbl.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 586);
            this.Controls.Add(this.Result_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Goods_lbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiscountType_cbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_tbx);
            this.Controls.Add(this.Count_tbx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Count_tbx;
        private System.Windows.Forms.TextBox Price_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DiscountType_cbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Goods_lbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Result_lbl;
    }
}

