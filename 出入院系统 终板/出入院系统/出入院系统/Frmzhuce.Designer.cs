namespace 出入院系统
{
    partial class Frmzhuce
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
            this.lb_yonghu = new System.Windows.Forms.Label();
            this.lb_mima = new System.Windows.Forms.Label();
            this.txb_mima = new System.Windows.Forms.TextBox();
            this.txb_yonghu = new System.Windows.Forms.TextBox();
            this.but_zhuce = new System.Windows.Forms.Button();
            this.but_quxiao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_yonghu
            // 
            this.lb_yonghu.AutoSize = true;
            this.lb_yonghu.BackColor = System.Drawing.Color.Transparent;
            this.lb_yonghu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_yonghu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_yonghu.Location = new System.Drawing.Point(127, 113);
            this.lb_yonghu.Name = "lb_yonghu";
            this.lb_yonghu.Size = new System.Drawing.Size(69, 19);
            this.lb_yonghu.TabIndex = 0;
            this.lb_yonghu.Text = "用户名";
            // 
            // lb_mima
            // 
            this.lb_mima.AutoSize = true;
            this.lb_mima.BackColor = System.Drawing.Color.Transparent;
            this.lb_mima.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_mima.ForeColor = System.Drawing.Color.Transparent;
            this.lb_mima.Location = new System.Drawing.Point(127, 168);
            this.lb_mima.Name = "lb_mima";
            this.lb_mima.Size = new System.Drawing.Size(49, 19);
            this.lb_mima.TabIndex = 1;
            this.lb_mima.Text = "密码";
            // 
            // txb_mima
            // 
            this.txb_mima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_mima.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_mima.Location = new System.Drawing.Point(241, 165);
            this.txb_mima.Name = "txb_mima";
            this.txb_mima.Size = new System.Drawing.Size(180, 22);
            this.txb_mima.TabIndex = 2;
            // 
            // txb_yonghu
            // 
            this.txb_yonghu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_yonghu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_yonghu.Location = new System.Drawing.Point(241, 110);
            this.txb_yonghu.Name = "txb_yonghu";
            this.txb_yonghu.Size = new System.Drawing.Size(180, 22);
            this.txb_yonghu.TabIndex = 3;
            // 
            // but_zhuce
            // 
            this.but_zhuce.BackColor = System.Drawing.Color.White;
            this.but_zhuce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_zhuce.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_zhuce.Location = new System.Drawing.Point(131, 254);
            this.but_zhuce.Name = "but_zhuce";
            this.but_zhuce.Size = new System.Drawing.Size(107, 41);
            this.but_zhuce.TabIndex = 4;
            this.but_zhuce.Text = "注册";
            this.but_zhuce.UseVisualStyleBackColor = false;
            this.but_zhuce.Click += new System.EventHandler(this.but_zhuce_Click);
            // 
            // but_quxiao
            // 
            this.but_quxiao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_quxiao.Location = new System.Drawing.Point(318, 253);
            this.but_quxiao.Name = "but_quxiao";
            this.but_quxiao.Size = new System.Drawing.Size(103, 42);
            this.but_quxiao.TabIndex = 5;
            this.but_quxiao.Text = "取消";
            this.but_quxiao.UseVisualStyleBackColor = true;
            this.but_quxiao.Click += new System.EventHandler(this.but_quxiao_Click);
            // 
            // Frmzhuce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::出入院系统.Properties.Resources.timg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 399);
            this.Controls.Add(this.but_quxiao);
            this.Controls.Add(this.but_zhuce);
            this.Controls.Add(this.txb_yonghu);
            this.Controls.Add(this.txb_mima);
            this.Controls.Add(this.lb_mima);
            this.Controls.Add(this.lb_yonghu);
            this.Name = "Frmzhuce";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_yonghu;
        private System.Windows.Forms.Label lb_mima;
        private System.Windows.Forms.TextBox txb_mima;
        private System.Windows.Forms.TextBox txb_yonghu;
        private System.Windows.Forms.Button but_zhuce;
        private System.Windows.Forms.Button but_quxiao;
    }
}