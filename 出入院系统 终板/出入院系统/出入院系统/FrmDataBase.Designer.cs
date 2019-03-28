namespace 出入院系统
{
    partial class FrmDataBase
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
            this.gb_database = new System.Windows.Forms.GroupBox();
            this.rab_school = new System.Windows.Forms.RadioButton();
            this.rab_personal = new System.Windows.Forms.RadioButton();
            this.but_ok = new System.Windows.Forms.Button();
            this.gb_database.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_database
            // 
            this.gb_database.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gb_database.Controls.Add(this.rab_school);
            this.gb_database.Controls.Add(this.rab_personal);
            this.gb_database.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_database.Location = new System.Drawing.Point(41, 28);
            this.gb_database.Name = "gb_database";
            this.gb_database.Size = new System.Drawing.Size(376, 119);
            this.gb_database.TabIndex = 0;
            this.gb_database.TabStop = false;
            this.gb_database.Text = "连接数据库";
            // 
            // rab_school
            // 
            this.rab_school.AutoSize = true;
            this.rab_school.Location = new System.Drawing.Point(65, 51);
            this.rab_school.Name = "rab_school";
            this.rab_school.Size = new System.Drawing.Size(65, 23);
            this.rab_school.TabIndex = 1;
            this.rab_school.TabStop = true;
            this.rab_school.Text = "学校";
            this.rab_school.UseVisualStyleBackColor = true;
            this.rab_school.CheckedChanged += new System.EventHandler(this.rab_school_CheckedChanged);
            // 
            // rab_personal
            // 
            this.rab_personal.AutoSize = true;
            this.rab_personal.Location = new System.Drawing.Point(234, 51);
            this.rab_personal.Name = "rab_personal";
            this.rab_personal.Size = new System.Drawing.Size(65, 23);
            this.rab_personal.TabIndex = 0;
            this.rab_personal.TabStop = true;
            this.rab_personal.Text = "个人";
            this.rab_personal.UseVisualStyleBackColor = true;
            this.rab_personal.CheckedChanged += new System.EventHandler(this.rab_personal_CheckedChanged);
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(164, 173);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(102, 49);
            this.but_ok.TabIndex = 1;
            this.but_ok.Text = "确定";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // FrmDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 262);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.gb_database);
            this.Name = "FrmDataBase";
            this.Text = "数据库连接";
            this.gb_database.ResumeLayout(false);
            this.gb_database.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_database;
        private System.Windows.Forms.RadioButton rab_school;
        private System.Windows.Forms.RadioButton rab_personal;
        private System.Windows.Forms.Button but_ok;
    }
}