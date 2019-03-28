namespace 出入院系统
{
    partial class Frmbedcard
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbut_fanhui = new System.Windows.Forms.ToolStripButton();
            this.tsbut_dayin = new System.Windows.Forms.ToolStripButton();
            this.tslb_biaoti = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_hulijibie = new System.Windows.Forms.GroupBox();
            this.lb_14 = new System.Windows.Forms.Label();
            this.lb_13 = new System.Windows.Forms.Label();
            this.lb_12 = new System.Windows.Forms.Label();
            this.lb_11 = new System.Windows.Forms.Label();
            this.gb_food = new System.Windows.Forms.GroupBox();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.gb_detail = new System.Windows.Forms.GroupBox();
            this.lb_yizhu = new System.Windows.Forms.Label();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.gb_information = new System.Windows.Forms.GroupBox();
            this.lb_xkeshi = new System.Windows.Forms.Label();
            this.lb_ruyuanzhengduan = new System.Windows.Forms.Label();
            this.lb_zuyuanNo = new System.Windows.Forms.Label();
            this.lb_ruyuandate = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_keshi = new System.Windows.Forms.Label();
            this.lb_bedcard = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_hulijibie.SuspendLayout();
            this.gb_food.SuspendLayout();
            this.gb_detail.SuspendLayout();
            this.gb_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbut_fanhui,
            this.tsbut_dayin,
            this.tslb_biaoti});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbut_fanhui
            // 
            this.tsbut_fanhui.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbut_fanhui.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbut_fanhui.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_fanhui.Image = global::出入院系统.Properties.Resources.退回;
            this.tsbut_fanhui.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_fanhui.Name = "tsbut_fanhui";
            this.tsbut_fanhui.Size = new System.Drawing.Size(72, 31);
            this.tsbut_fanhui.Text = "返回";
            this.tsbut_fanhui.Click += new System.EventHandler(this.tsbut_fanhui_Click);
            // 
            // tsbut_dayin
            // 
            this.tsbut_dayin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbut_dayin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbut_dayin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_dayin.Image = global::出入院系统.Properties.Resources.打印;
            this.tsbut_dayin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_dayin.Name = "tsbut_dayin";
            this.tsbut_dayin.Size = new System.Drawing.Size(70, 31);
            this.tsbut_dayin.Text = "打印";
            // 
            // tslb_biaoti
            // 
            this.tslb_biaoti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslb_biaoti.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tslb_biaoti.ForeColor = System.Drawing.Color.Blue;
            this.tslb_biaoti.Name = "tslb_biaoti";
            this.tslb_biaoti.Size = new System.Drawing.Size(76, 31);
            this.tslb_biaoti.Text = "床头卡";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.gb_hulijibie);
            this.panel1.Controls.Add(this.gb_food);
            this.panel1.Controls.Add(this.gb_detail);
            this.panel1.Controls.Add(this.gb_information);
            this.panel1.Controls.Add(this.lb_bedcard);
            this.panel1.Location = new System.Drawing.Point(125, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 541);
            this.panel1.TabIndex = 3;
            // 
            // gb_hulijibie
            // 
            this.gb_hulijibie.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_hulijibie.Controls.Add(this.lb_14);
            this.gb_hulijibie.Controls.Add(this.lb_13);
            this.gb_hulijibie.Controls.Add(this.lb_12);
            this.gb_hulijibie.Controls.Add(this.lb_11);
            this.gb_hulijibie.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_hulijibie.Location = new System.Drawing.Point(267, 318);
            this.gb_hulijibie.Name = "gb_hulijibie";
            this.gb_hulijibie.Size = new System.Drawing.Size(137, 189);
            this.gb_hulijibie.TabIndex = 6;
            this.gb_hulijibie.TabStop = false;
            this.gb_hulijibie.Text = "护理级别";
            // 
            // lb_14
            // 
            this.lb_14.AutoSize = true;
            this.lb_14.Location = new System.Drawing.Point(6, 150);
            this.lb_14.Name = "lb_14";
            this.lb_14.Size = new System.Drawing.Size(98, 21);
            this.lb_14.TabIndex = 3;
            this.lb_14.Text = "三级护理";
            // 
            // lb_13
            // 
            this.lb_13.AutoSize = true;
            this.lb_13.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_13.Location = new System.Drawing.Point(6, 110);
            this.lb_13.Name = "lb_13";
            this.lb_13.Size = new System.Drawing.Size(98, 21);
            this.lb_13.TabIndex = 2;
            this.lb_13.Text = "二级护理";
            // 
            // lb_12
            // 
            this.lb_12.AutoSize = true;
            this.lb_12.ForeColor = System.Drawing.Color.Blue;
            this.lb_12.Location = new System.Drawing.Point(6, 74);
            this.lb_12.Name = "lb_12";
            this.lb_12.Size = new System.Drawing.Size(98, 21);
            this.lb_12.TabIndex = 1;
            this.lb_12.Text = "一级护理";
            // 
            // lb_11
            // 
            this.lb_11.AutoSize = true;
            this.lb_11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_11.Location = new System.Drawing.Point(6, 37);
            this.lb_11.Name = "lb_11";
            this.lb_11.Size = new System.Drawing.Size(98, 21);
            this.lb_11.TabIndex = 0;
            this.lb_11.Text = "特级护理";
            // 
            // gb_food
            // 
            this.gb_food.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_food.Controls.Add(this.lb_3);
            this.gb_food.Controls.Add(this.lb_2);
            this.gb_food.Controls.Add(this.lb_1);
            this.gb_food.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_food.Location = new System.Drawing.Point(29, 318);
            this.gb_food.Name = "gb_food";
            this.gb_food.Size = new System.Drawing.Size(138, 189);
            this.gb_food.TabIndex = 5;
            this.gb_food.TabStop = false;
            this.gb_food.Text = "饮食级别";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_3.Location = new System.Drawing.Point(6, 110);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(98, 21);
            this.lb_3.TabIndex = 2;
            this.lb_3.Text = "普通饮食";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.ForeColor = System.Drawing.Color.Red;
            this.lb_2.Location = new System.Drawing.Point(6, 74);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(120, 21);
            this.lb_2.TabIndex = 1;
            this.lb_2.Text = "半流质饮食";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.ForeColor = System.Drawing.Color.Purple;
            this.lb_1.Location = new System.Drawing.Point(6, 37);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(98, 21);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "流质饮食";
            // 
            // gb_detail
            // 
            this.gb_detail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_detail.Controls.Add(this.lb_yizhu);
            this.gb_detail.Controls.Add(this.lb_doctor);
            this.gb_detail.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_detail.Location = new System.Drawing.Point(480, 78);
            this.gb_detail.Name = "gb_detail";
            this.gb_detail.Size = new System.Drawing.Size(312, 429);
            this.gb_detail.TabIndex = 4;
            this.gb_detail.TabStop = false;
            this.gb_detail.Text = "详情 ";
            // 
            // lb_yizhu
            // 
            this.lb_yizhu.AutoSize = true;
            this.lb_yizhu.Location = new System.Drawing.Point(28, 123);
            this.lb_yizhu.Name = "lb_yizhu";
            this.lb_yizhu.Size = new System.Drawing.Size(120, 21);
            this.lb_yizhu.TabIndex = 1;
            this.lb_yizhu.Text = "特殊交待：";
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Location = new System.Drawing.Point(28, 50);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(120, 21);
            this.lb_doctor.TabIndex = 0;
            this.lb_doctor.Text = "责任医生：";
            // 
            // gb_information
            // 
            this.gb_information.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_information.Controls.Add(this.lb_xkeshi);
            this.gb_information.Controls.Add(this.lb_ruyuanzhengduan);
            this.gb_information.Controls.Add(this.lb_zuyuanNo);
            this.gb_information.Controls.Add(this.lb_ruyuandate);
            this.gb_information.Controls.Add(this.lb_age);
            this.gb_information.Controls.Add(this.lb_sex);
            this.gb_information.Controls.Add(this.lb_name);
            this.gb_information.Controls.Add(this.lb_keshi);
            this.gb_information.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_information.Location = new System.Drawing.Point(29, 78);
            this.gb_information.Name = "gb_information";
            this.gb_information.Size = new System.Drawing.Size(375, 221);
            this.gb_information.TabIndex = 3;
            this.gb_information.TabStop = false;
            this.gb_information.Text = "个人信息";
            // 
            // lb_xkeshi
            // 
            this.lb_xkeshi.AutoSize = true;
            this.lb_xkeshi.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_xkeshi.Location = new System.Drawing.Point(79, 35);
            this.lb_xkeshi.Name = "lb_xkeshi";
            this.lb_xkeshi.Size = new System.Drawing.Size(0, 21);
            this.lb_xkeshi.TabIndex = 8;
            // 
            // lb_ruyuanzhengduan
            // 
            this.lb_ruyuanzhengduan.AutoSize = true;
            this.lb_ruyuanzhengduan.Location = new System.Drawing.Point(17, 171);
            this.lb_ruyuanzhengduan.Name = "lb_ruyuanzhengduan";
            this.lb_ruyuanzhengduan.Size = new System.Drawing.Size(120, 21);
            this.lb_ruyuanzhengduan.TabIndex = 7;
            this.lb_ruyuanzhengduan.Text = "入院诊断：";
            // 
            // lb_zuyuanNo
            // 
            this.lb_zuyuanNo.AutoSize = true;
            this.lb_zuyuanNo.Location = new System.Drawing.Point(181, 123);
            this.lb_zuyuanNo.Name = "lb_zuyuanNo";
            this.lb_zuyuanNo.Size = new System.Drawing.Size(98, 21);
            this.lb_zuyuanNo.TabIndex = 5;
            this.lb_zuyuanNo.Text = "住院号：";
            // 
            // lb_ruyuandate
            // 
            this.lb_ruyuandate.AutoSize = true;
            this.lb_ruyuandate.Location = new System.Drawing.Point(17, 123);
            this.lb_ruyuandate.Name = "lb_ruyuandate";
            this.lb_ruyuandate.Size = new System.Drawing.Size(120, 21);
            this.lb_ruyuandate.TabIndex = 4;
            this.lb_ruyuandate.Text = "入院日期：";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(181, 72);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(76, 21);
            this.lb_age.TabIndex = 3;
            this.lb_age.Text = "年龄：";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(17, 72);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(76, 21);
            this.lb_sex.TabIndex = 2;
            this.lb_sex.Text = "性别：";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_name.Location = new System.Drawing.Point(182, 35);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(76, 21);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "姓名：";
            // 
            // lb_keshi
            // 
            this.lb_keshi.AutoSize = true;
            this.lb_keshi.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_keshi.Location = new System.Drawing.Point(18, 35);
            this.lb_keshi.Name = "lb_keshi";
            this.lb_keshi.Size = new System.Drawing.Size(76, 21);
            this.lb_keshi.TabIndex = 0;
            this.lb_keshi.Text = "科室：";
            // 
            // lb_bedcard
            // 
            this.lb_bedcard.AutoSize = true;
            this.lb_bedcard.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_bedcard.Location = new System.Drawing.Point(359, 13);
            this.lb_bedcard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_bedcard.Name = "lb_bedcard";
            this.lb_bedcard.Size = new System.Drawing.Size(164, 48);
            this.lb_bedcard.TabIndex = 2;
            this.lb_bedcard.Text = "床头卡";
            // 
            // Frmbedcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frmbedcard";
            this.Text = "出入院系统";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_hulijibie.ResumeLayout(false);
            this.gb_hulijibie.PerformLayout();
            this.gb_food.ResumeLayout(false);
            this.gb_food.PerformLayout();
            this.gb_detail.ResumeLayout(false);
            this.gb_detail.PerformLayout();
            this.gb_information.ResumeLayout(false);
            this.gb_information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbut_dayin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_bedcard;
        private System.Windows.Forms.GroupBox gb_detail;
        private System.Windows.Forms.GroupBox gb_hulijibie;
        private System.Windows.Forms.GroupBox gb_food;
        private System.Windows.Forms.Label lb_yizhu;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_14;
        private System.Windows.Forms.Label lb_13;
        private System.Windows.Forms.Label lb_12;
        private System.Windows.Forms.Label lb_11;
        private System.Windows.Forms.GroupBox gb_information;
        private System.Windows.Forms.Label lb_xkeshi;
        private System.Windows.Forms.Label lb_ruyuanzhengduan;
        private System.Windows.Forms.Label lb_zuyuanNo;
        private System.Windows.Forms.Label lb_ruyuandate;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_keshi;
        private System.Windows.Forms.ToolStripButton tsbut_fanhui;
        private System.Windows.Forms.ToolStripLabel tslb_biaoti;


    }
}