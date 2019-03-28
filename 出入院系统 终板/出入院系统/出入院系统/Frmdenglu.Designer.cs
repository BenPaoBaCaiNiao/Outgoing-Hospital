namespace 出入院系统
{
    partial class Frmdenglu
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
            this.lb_yonghu = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.txt_yonghu = new System.Windows.Forms.TextBox();
            this.txt_mima = new System.Windows.Forms.TextBox();
            this.but_denglu = new System.Windows.Forms.Button();
            this.but_quxiao = new System.Windows.Forms.Button();
            this.lkb_zhuce = new System.Windows.Forms.LinkLabel();
            this.lkb_xianshi = new System.Windows.Forms.LinkLabel();
            this.lkl_DataBase = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_mima = new System.Windows.Forms.PictureBox();
            this.pic_yonghu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yonghu)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_yonghu
            // 
            this.lb_yonghu.AutoSize = true;
            this.lb_yonghu.BackColor = System.Drawing.Color.Transparent;
            this.lb_yonghu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_yonghu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_yonghu.Image = global::出入院系统.Properties.Resources.用户名_1_;
            this.lb_yonghu.Location = new System.Drawing.Point(-4, 85);
            this.lb_yonghu.Name = "lb_yonghu";
            this.lb_yonghu.Size = new System.Drawing.Size(0, 19);
            this.lb_yonghu.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("仿宋", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_title.ForeColor = System.Drawing.Color.Black;
            this.lb_title.Location = new System.Drawing.Point(104, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(721, 97);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "出入院管理系统";
            // 
            // txt_yonghu
            // 
            this.txt_yonghu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yonghu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_yonghu.Location = new System.Drawing.Point(88, 87);
            this.txt_yonghu.Name = "txt_yonghu";
            this.txt_yonghu.Size = new System.Drawing.Size(143, 29);
            this.txt_yonghu.TabIndex = 2;
            // 
            // txt_mima
            // 
            this.txt_mima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mima.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_mima.Location = new System.Drawing.Point(88, 172);
            this.txt_mima.Name = "txt_mima";
            this.txt_mima.Size = new System.Drawing.Size(143, 29);
            this.txt_mima.TabIndex = 3;
            // 
            // but_denglu
            // 
            this.but_denglu.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_denglu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_denglu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_denglu.ForeColor = System.Drawing.Color.Black;
            this.but_denglu.Location = new System.Drawing.Point(31, 259);
            this.but_denglu.Name = "but_denglu";
            this.but_denglu.Size = new System.Drawing.Size(117, 37);
            this.but_denglu.TabIndex = 4;
            this.but_denglu.Text = "登录";
            this.but_denglu.UseVisualStyleBackColor = false;
            this.but_denglu.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_quxiao
            // 
            this.but_quxiao.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_quxiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_quxiao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_quxiao.Location = new System.Drawing.Point(168, 259);
            this.but_quxiao.Name = "but_quxiao";
            this.but_quxiao.Size = new System.Drawing.Size(118, 37);
            this.but_quxiao.TabIndex = 5;
            this.but_quxiao.Text = "取消";
            this.but_quxiao.UseVisualStyleBackColor = false;
            this.but_quxiao.Click += new System.EventHandler(this.but_quxiao_Click_1);
            // 
            // lkb_zhuce
            // 
            this.lkb_zhuce.AutoSize = true;
            this.lkb_zhuce.BackColor = System.Drawing.Color.Transparent;
            this.lkb_zhuce.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkb_zhuce.ForeColor = System.Drawing.Color.Black;
            this.lkb_zhuce.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lkb_zhuce.Location = new System.Drawing.Point(247, 91);
            this.lkb_zhuce.Name = "lkb_zhuce";
            this.lkb_zhuce.Size = new System.Drawing.Size(50, 25);
            this.lkb_zhuce.TabIndex = 7;
            this.lkb_zhuce.TabStop = true;
            this.lkb_zhuce.Text = "注册";
            this.lkb_zhuce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lkb_xianshi
            // 
            this.lkb_xianshi.AutoSize = true;
            this.lkb_xianshi.BackColor = System.Drawing.Color.Transparent;
            this.lkb_xianshi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkb_xianshi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lkb_xianshi.Location = new System.Drawing.Point(237, 181);
            this.lkb_xianshi.Name = "lkb_xianshi";
            this.lkb_xianshi.Size = new System.Drawing.Size(65, 20);
            this.lkb_xianshi.TabIndex = 8;
            this.lkb_xianshi.TabStop = true;
            this.lkb_xianshi.Text = "显示密码";
            this.lkb_xianshi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkb_xianshi_LinkClicked);
            // 
            // lkl_DataBase
            // 
            this.lkl_DataBase.AutoSize = true;
            this.lkl_DataBase.BackColor = System.Drawing.Color.Transparent;
            this.lkl_DataBase.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkl_DataBase.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lkl_DataBase.Location = new System.Drawing.Point(185, 311);
            this.lkl_DataBase.Name = "lkl_DataBase";
            this.lkl_DataBase.Size = new System.Drawing.Size(113, 25);
            this.lkl_DataBase.TabIndex = 9;
            this.lkl_DataBase.TabStop = true;
            this.lkl_DataBase.Text = "连接数据库 ";
            this.lkl_DataBase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_DataBase_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pic_mima);
            this.panel1.Controls.Add(this.pic_yonghu);
            this.panel1.Controls.Add(this.txt_yonghu);
            this.panel1.Controls.Add(this.but_denglu);
            this.panel1.Controls.Add(this.lb_yonghu);
            this.panel1.Controls.Add(this.but_quxiao);
            this.panel1.Controls.Add(this.lkb_zhuce);
            this.panel1.Controls.Add(this.lkl_DataBase);
            this.panel1.Controls.Add(this.txt_mima);
            this.panel1.Controls.Add(this.lkb_xianshi);
            this.panel1.Location = new System.Drawing.Point(607, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 355);
            this.panel1.TabIndex = 10;
            // 
            // pic_mima
            // 
            this.pic_mima.Image = global::出入院系统.Properties.Resources.用户名_1_;
            this.pic_mima.Location = new System.Drawing.Point(31, 87);
            this.pic_mima.Name = "pic_mima";
            this.pic_mima.Size = new System.Drawing.Size(31, 29);
            this.pic_mima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mima.TabIndex = 11;
            this.pic_mima.TabStop = false;
            // 
            // pic_yonghu
            // 
            this.pic_yonghu.Image = global::出入院系统.Properties.Resources.密码;
            this.pic_yonghu.InitialImage = global::出入院系统.Properties.Resources.密码;
            this.pic_yonghu.Location = new System.Drawing.Point(31, 172);
            this.pic_yonghu.Name = "pic_yonghu";
            this.pic_yonghu.Size = new System.Drawing.Size(31, 29);
            this.pic_yonghu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_yonghu.TabIndex = 10;
            this.pic_yonghu.TabStop = false;
            // 
            // Frmdenglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::出入院系统.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_title);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Frmdenglu";
            this.Text = "用户登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yonghu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_yonghu;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox txt_yonghu;
        private System.Windows.Forms.TextBox txt_mima;
        private System.Windows.Forms.Button but_denglu;
        private System.Windows.Forms.Button but_quxiao;
        private System.Windows.Forms.LinkLabel lkb_zhuce;
        private System.Windows.Forms.LinkLabel lkb_xianshi;
        private System.Windows.Forms.LinkLabel lkl_DataBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_mima;
        private System.Windows.Forms.PictureBox pic_yonghu;
    }
}

