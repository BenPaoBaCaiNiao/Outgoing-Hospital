namespace 出入院系统
{
    partial class Frmpaxingzhi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_biaoti = new System.Windows.Forms.Label();
            this.lb_fenlei = new System.Windows.Forms.Label();
            this.lb_biaozhi = new System.Windows.Forms.Label();
            this.lb_shanchan = new System.Windows.Forms.Label();
            this.lb_workorno = new System.Windows.Forms.Label();
            this.txb_workorno = new System.Windows.Forms.TextBox();
            this.cmb_shangcan = new System.Windows.Forms.ComboBox();
            this.cmb_fenlei = new System.Windows.Forms.ComboBox();
            this.cmb_biaozhi = new System.Windows.Forms.ComboBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_biaoti
            // 
            this.lb_biaoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_biaoti.AutoSize = true;
            this.lb_biaoti.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_biaoti.ForeColor = System.Drawing.Color.Red;
            this.lb_biaoti.Location = new System.Drawing.Point(123, 19);
            this.lb_biaoti.Name = "lb_biaoti";
            this.lb_biaoti.Size = new System.Drawing.Size(216, 29);
            this.lb_biaoti.TabIndex = 0;
            this.lb_biaoti.Text = "病人性质一览表";
            // 
            // lb_fenlei
            // 
            this.lb_fenlei.AutoSize = true;
            this.lb_fenlei.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_fenlei.Location = new System.Drawing.Point(23, 76);
            this.lb_fenlei.Name = "lb_fenlei";
            this.lb_fenlei.Size = new System.Drawing.Size(89, 20);
            this.lb_fenlei.TabIndex = 1;
            this.lb_fenlei.Text = "病人分类";
            // 
            // lb_biaozhi
            // 
            this.lb_biaozhi.AutoSize = true;
            this.lb_biaozhi.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_biaozhi.Location = new System.Drawing.Point(23, 140);
            this.lb_biaozhi.Name = "lb_biaozhi";
            this.lb_biaozhi.Size = new System.Drawing.Size(89, 20);
            this.lb_biaozhi.TabIndex = 2;
            this.lb_biaozhi.Text = "大病标志";
            // 
            // lb_shanchan
            // 
            this.lb_shanchan.AutoSize = true;
            this.lb_shanchan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_shanchan.Location = new System.Drawing.Point(240, 76);
            this.lb_shanchan.Name = "lb_shanchan";
            this.lb_shanchan.Size = new System.Drawing.Size(89, 20);
            this.lb_shanchan.TabIndex = 3;
            this.lb_shanchan.Text = "伤残情况";
            // 
            // lb_workorno
            // 
            this.lb_workorno.AutoSize = true;
            this.lb_workorno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_workorno.Location = new System.Drawing.Point(240, 141);
            this.lb_workorno.Name = "lb_workorno";
            this.lb_workorno.Size = new System.Drawing.Size(89, 20);
            this.lb_workorno.TabIndex = 4;
            this.lb_workorno.Text = "职退情况";
            // 
            // txb_workorno
            // 
            this.txb_workorno.Location = new System.Drawing.Point(335, 139);
            this.txb_workorno.Name = "txb_workorno";
            this.txb_workorno.Size = new System.Drawing.Size(132, 21);
            this.txb_workorno.TabIndex = 8;
            // 
            // cmb_shangcan
            // 
            this.cmb_shangcan.FormattingEnabled = true;
            this.cmb_shangcan.Location = new System.Drawing.Point(335, 76);
            this.cmb_shangcan.Name = "cmb_shangcan";
            this.cmb_shangcan.Size = new System.Drawing.Size(132, 20);
            this.cmb_shangcan.TabIndex = 9;
            // 
            // cmb_fenlei
            // 
            this.cmb_fenlei.FormattingEnabled = true;
            this.cmb_fenlei.Location = new System.Drawing.Point(113, 80);
            this.cmb_fenlei.Name = "cmb_fenlei";
            this.cmb_fenlei.Size = new System.Drawing.Size(121, 20);
            this.cmb_fenlei.TabIndex = 10;
            // 
            // cmb_biaozhi
            // 
            this.cmb_biaozhi.FormattingEnabled = true;
            this.cmb_biaozhi.Location = new System.Drawing.Point(113, 141);
            this.cmb_biaozhi.Name = "cmb_biaozhi";
            this.cmb_biaozhi.Size = new System.Drawing.Size(121, 20);
            this.cmb_biaozhi.TabIndex = 11;
            // 
            // but_ok
            // 
            this.but_ok.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_ok.Location = new System.Drawing.Point(128, 186);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 28);
            this.but_ok.TabIndex = 12;
            this.but_ok.Text = "确定";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_cancel.Location = new System.Drawing.Point(255, 187);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(74, 27);
            this.but_cancel.TabIndex = 13;
            this.but_cancel.Text = "取消";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // Frmpaxingzhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 226);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.cmb_biaozhi);
            this.Controls.Add(this.cmb_fenlei);
            this.Controls.Add(this.cmb_shangcan);
            this.Controls.Add(this.txb_workorno);
            this.Controls.Add(this.lb_workorno);
            this.Controls.Add(this.lb_shanchan);
            this.Controls.Add(this.lb_biaozhi);
            this.Controls.Add(this.lb_fenlei);
            this.Controls.Add(this.lb_biaoti);
            this.Name = "Frmpaxingzhi";
            this.Text = "出入院系统";
            this.Load += new System.EventHandler(this.Frmpaxingzhi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_biaoti;
        private System.Windows.Forms.Label lb_fenlei;
        private System.Windows.Forms.Label lb_biaozhi;
        private System.Windows.Forms.Label lb_shanchan;
        private System.Windows.Forms.Label lb_workorno;
        private System.Windows.Forms.TextBox txb_workorno;
        private System.Windows.Forms.ComboBox cmb_shangcan;
        private System.Windows.Forms.ComboBox cmb_fenlei;
        private System.Windows.Forms.ComboBox cmb_biaozhi;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_cancel;
    }
}