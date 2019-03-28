namespace 出入院系统
{
    partial class Frmbedcheck
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
            this.dgv_keshi = new System.Windows.Forms.DataGridView();
            this.lb_detail = new System.Windows.Forms.Label();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.tsl_keshiname = new System.Windows.Forms.ToolStripLabel();
            this.tscmb_keshiname = new System.Windows.Forms.ToolStripComboBox();
            this.txb_shuaxin = new System.Windows.Forms.ToolStripButton();
            this.tsbut_chaxun = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keshi)).BeginInit();
            this.ts1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_keshi
            // 
            this.dgv_keshi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_keshi.Location = new System.Drawing.Point(31, 36);
            this.dgv_keshi.Name = "dgv_keshi";
            this.dgv_keshi.RowTemplate.Height = 23;
            this.dgv_keshi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_keshi.Size = new System.Drawing.Size(948, 420);
            this.dgv_keshi.TabIndex = 0;
            this.dgv_keshi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_keshi_CellContentClick_1);
            // 
            // lb_detail
            // 
            this.lb_detail.AutoSize = true;
            this.lb_detail.ForeColor = System.Drawing.Color.Red;
            this.lb_detail.Location = new System.Drawing.Point(16, 250);
            this.lb_detail.Name = "lb_detail";
            this.lb_detail.Size = new System.Drawing.Size(0, 14);
            this.lb_detail.TabIndex = 4;
            // 
            // ts1
            // 
            this.ts1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_keshiname,
            this.tscmb_keshiname,
            this.txb_shuaxin,
            this.tsbut_chaxun});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Size = new System.Drawing.Size(1028, 33);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 6;
            this.ts1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts1_ItemClicked);
            // 
            // tsl_keshiname
            // 
            this.tsl_keshiname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsl_keshiname.Name = "tsl_keshiname";
            this.tsl_keshiname.Size = new System.Drawing.Size(107, 30);
            this.tsl_keshiname.Text = "科室名称：";
            // 
            // tscmb_keshiname
            // 
            this.tscmb_keshiname.BackColor = System.Drawing.Color.White;
            this.tscmb_keshiname.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscmb_keshiname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tscmb_keshiname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tscmb_keshiname.Name = "tscmb_keshiname";
            this.tscmb_keshiname.Size = new System.Drawing.Size(121, 33);
            // 
            // txb_shuaxin
            // 
            this.txb_shuaxin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_shuaxin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txb_shuaxin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_shuaxin.Image = global::出入院系统.Properties.Resources.刷新;
            this.txb_shuaxin.ImageTransparentColor = System.Drawing.Color.Blue;
            this.txb_shuaxin.Name = "txb_shuaxin";
            this.txb_shuaxin.Size = new System.Drawing.Size(70, 30);
            this.txb_shuaxin.Text = "刷新";
            this.txb_shuaxin.Click += new System.EventHandler(this.txb_shuaxin_Click);
            // 
            // tsbut_chaxun
            // 
            this.tsbut_chaxun.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbut_chaxun.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbut_chaxun.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_chaxun.ForeColor = System.Drawing.Color.Blue;
            this.tsbut_chaxun.Image = global::出入院系统.Properties.Resources.查询2;
            this.tsbut_chaxun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_chaxun.Name = "tsbut_chaxun";
            this.tsbut_chaxun.Size = new System.Drawing.Size(70, 30);
            this.tsbut_chaxun.Text = "查询";
            this.tsbut_chaxun.Click += new System.EventHandler(this.tsbut_chaxun_Click);
            // 
            // Frmbedcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 457);
            this.Controls.Add(this.ts1);
            this.Controls.Add(this.lb_detail);
            this.Controls.Add(this.dgv_keshi);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Frmbedcheck";
            this.Text = "床位查询";
            this.Load += new System.EventHandler(this.Frmbedcheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keshi)).EndInit();
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_keshi;
        private System.Windows.Forms.Label lb_detail;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripLabel tsl_keshiname;
        private System.Windows.Forms.ToolStripComboBox tscmb_keshiname;
        private System.Windows.Forms.ToolStripButton tsbut_chaxun;
        private System.Windows.Forms.ToolStripButton txb_shuaxin;
    }
}