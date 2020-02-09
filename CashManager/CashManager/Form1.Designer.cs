namespace CashManager
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_tbx = new System.Windows.Forms.TextBox();
            this.Counts_tbx = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.item_lbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Promotion_cbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量：";
            // 
            // Price_tbx
            // 
            this.Price_tbx.Location = new System.Drawing.Point(200, 30);
            this.Price_tbx.Name = "Price_tbx";
            this.Price_tbx.Size = new System.Drawing.Size(169, 28);
            this.Price_tbx.TabIndex = 2;
            // 
            // Counts_tbx
            // 
            this.Counts_tbx.Location = new System.Drawing.Point(200, 86);
            this.Counts_tbx.Name = "Counts_tbx";
            this.Counts_tbx.Size = new System.Drawing.Size(169, 28);
            this.Counts_tbx.TabIndex = 3;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(426, 23);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 39);
            this.OK_btn.TabIndex = 4;
            this.OK_btn.Text = "确认";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(426, 81);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(75, 35);
            this.Reset_btn.TabIndex = 5;
            this.Reset_btn.Text = "重置";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // item_lbx
            // 
            this.item_lbx.FormattingEnabled = true;
            this.item_lbx.ItemHeight = 18;
            this.item_lbx.Location = new System.Drawing.Point(82, 191);
            this.item_lbx.Name = "item_lbx";
            this.item_lbx.Size = new System.Drawing.Size(408, 202);
            this.item_lbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "合计：";
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("宋体", 36F);
            this.result_lbl.Location = new System.Drawing.Point(184, 424);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(174, 72);
            this.result_lbl.TabIndex = 8;
            this.result_lbl.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "优惠策略：";
            // 
            // Promotion_cbx
            // 
            this.Promotion_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Promotion_cbx.FormattingEnabled = true;
            this.Promotion_cbx.Location = new System.Drawing.Point(200, 141);
            this.Promotion_cbx.Name = "Promotion_cbx";
            this.Promotion_cbx.Size = new System.Drawing.Size(169, 26);
            this.Promotion_cbx.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 517);
            this.Controls.Add(this.Promotion_cbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item_lbx);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Counts_tbx);
            this.Controls.Add(this.Price_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "商场收银系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Price_tbx;
        private System.Windows.Forms.TextBox Counts_tbx;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.ListBox item_lbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Promotion_cbx;
    }
}

