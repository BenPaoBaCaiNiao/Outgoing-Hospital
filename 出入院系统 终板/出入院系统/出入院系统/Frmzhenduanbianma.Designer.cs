namespace 出入院系统
{
    partial class Frmzhenduanbianma
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
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.tsbut_look = new System.Windows.Forms.ToolStripButton();
            this.tsbut_add = new System.Windows.Forms.ToolStripButton();
            this.tsbut_delete = new System.Windows.Forms.ToolStripButton();
            this.tsbut_baocun = new System.Windows.Forms.ToolStripButton();
            this.tsbut_choose = new System.Windows.Forms.ToolStripButton();
            this.spc = new System.Windows.Forms.SplitContainer();
            this.gb_paixu = new System.Windows.Forms.GroupBox();
            this.rb_daima = new System.Windows.Forms.RadioButton();
            this.lb_shoupindingwei = new System.Windows.Forms.Label();
            this.lb_yibao = new System.Windows.Forms.Label();
            this.lb_biaozhun = new System.Windows.Forms.Label();
            this.txb_shoupindingwei = new System.Windows.Forms.TextBox();
            this.lb_jijin = new System.Windows.Forms.Label();
            this.txb_yibaobianma = new System.Windows.Forms.TextBox();
            this.lb_jibingname = new System.Windows.Forms.Label();
            this.txb_biaozhun = new System.Windows.Forms.TextBox();
            this.lb_yibaobianma = new System.Windows.Forms.Label();
            this.lb_leibie = new System.Windows.Forms.Label();
            this.txb_yibao = new System.Windows.Forms.TextBox();
            this.txb_jibingname = new System.Windows.Forms.TextBox();
            this.txb_daima = new System.Windows.Forms.TextBox();
            this.txb_leibie = new System.Windows.Forms.TextBox();
            this.txb_jijin = new System.Windows.Forms.TextBox();
            this.lb_daima = new System.Windows.Forms.Label();
            this.dgv_zhenduanbianma = new System.Windows.Forms.DataGridView();
            this.ts1.SuspendLayout();
            this.spc.Panel1.SuspendLayout();
            this.spc.Panel2.SuspendLayout();
            this.spc.SuspendLayout();
            this.gb_paixu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zhenduanbianma)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Location = new System.Drawing.Point(20, 66);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(106, 20);
            this.rb_name.TabIndex = 64;
            this.rb_name.TabStop = true;
            this.rb_name.Text = "按名称排序";
            this.rb_name.UseVisualStyleBackColor = true;
            this.rb_name.CheckedChanged += new System.EventHandler(this.rb_name_CheckedChanged);
            // 
            // ts1
            // 
            this.ts1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbut_look,
            this.tsbut_add,
            this.tsbut_delete,
            this.tsbut_baocun,
            this.tsbut_choose});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Size = new System.Drawing.Size(897, 28);
            this.ts1.TabIndex = 65;
            this.ts1.Text = "toolStrip1";
            this.ts1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts1_ItemClicked);
            // 
            // tsbut_look
            // 
            this.tsbut_look.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_look.Image = global::出入院系统.Properties.Resources.查询;
            this.tsbut_look.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_look.Name = "tsbut_look";
            this.tsbut_look.Size = new System.Drawing.Size(62, 25);
            this.tsbut_look.Text = "查找";
            this.tsbut_look.Click += new System.EventHandler(this.tsbut_look_Click_1);
            // 
            // tsbut_add
            // 
            this.tsbut_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_add.Image = global::出入院系统.Properties.Resources.添加２;
            this.tsbut_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_add.Name = "tsbut_add";
            this.tsbut_add.Size = new System.Drawing.Size(62, 25);
            this.tsbut_add.Text = "添加";
            this.tsbut_add.Click += new System.EventHandler(this.tsbut_add_Click);
            // 
            // tsbut_delete
            // 
            this.tsbut_delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_delete.Image = global::出入院系统.Properties.Resources.删除;
            this.tsbut_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_delete.Name = "tsbut_delete";
            this.tsbut_delete.Size = new System.Drawing.Size(62, 25);
            this.tsbut_delete.Text = "删除";
            this.tsbut_delete.Click += new System.EventHandler(this.tsbut_delete_Click);
            // 
            // tsbut_baocun
            // 
            this.tsbut_baocun.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_baocun.Image = global::出入院系统.Properties.Resources.保存;
            this.tsbut_baocun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_baocun.Name = "tsbut_baocun";
            this.tsbut_baocun.Size = new System.Drawing.Size(94, 25);
            this.tsbut_baocun.Text = "保存修改";
            this.tsbut_baocun.Click += new System.EventHandler(this.tsbut_baocun_Click);
            // 
            // tsbut_choose
            // 
            this.tsbut_choose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbut_choose.Image = global::出入院系统.Properties.Resources.选择;
            this.tsbut_choose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_choose.Name = "tsbut_choose";
            this.tsbut_choose.Size = new System.Drawing.Size(62, 25);
            this.tsbut_choose.Text = "选择";
            this.tsbut_choose.Click += new System.EventHandler(this.tsbut_choose_Click);
            // 
            // spc
            // 
            this.spc.Location = new System.Drawing.Point(28, 31);
            this.spc.Name = "spc";
            // 
            // spc.Panel1
            // 
            this.spc.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.spc.Panel1.Controls.Add(this.gb_paixu);
            this.spc.Panel1.Controls.Add(this.lb_shoupindingwei);
            this.spc.Panel1.Controls.Add(this.lb_yibao);
            this.spc.Panel1.Controls.Add(this.lb_biaozhun);
            this.spc.Panel1.Controls.Add(this.txb_shoupindingwei);
            this.spc.Panel1.Controls.Add(this.lb_jijin);
            this.spc.Panel1.Controls.Add(this.txb_yibaobianma);
            this.spc.Panel1.Controls.Add(this.lb_jibingname);
            this.spc.Panel1.Controls.Add(this.txb_biaozhun);
            this.spc.Panel1.Controls.Add(this.lb_yibaobianma);
            this.spc.Panel1.Controls.Add(this.lb_leibie);
            this.spc.Panel1.Controls.Add(this.txb_yibao);
            this.spc.Panel1.Controls.Add(this.txb_jibingname);
            this.spc.Panel1.Controls.Add(this.txb_daima);
            this.spc.Panel1.Controls.Add(this.txb_leibie);
            this.spc.Panel1.Controls.Add(this.txb_jijin);
            this.spc.Panel1.Controls.Add(this.lb_daima);
            // 
            // spc.Panel2
            // 
            this.spc.Panel2.Controls.Add(this.dgv_zhenduanbianma);
            this.spc.Size = new System.Drawing.Size(841, 529);
            this.spc.SplitterDistance = 280;
            this.spc.TabIndex = 66;
            // 
            // gb_paixu
            // 
            this.gb_paixu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gb_paixu.Controls.Add(this.rb_name);
            this.gb_paixu.Controls.Add(this.rb_daima);
            this.gb_paixu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_paixu.Location = new System.Drawing.Point(15, 387);
            this.gb_paixu.Name = "gb_paixu";
            this.gb_paixu.Size = new System.Drawing.Size(200, 100);
            this.gb_paixu.TabIndex = 81;
            this.gb_paixu.TabStop = false;
            this.gb_paixu.Text = "排序方式";
            // 
            // rb_daima
            // 
            this.rb_daima.AutoSize = true;
            this.rb_daima.Location = new System.Drawing.Point(20, 29);
            this.rb_daima.Name = "rb_daima";
            this.rb_daima.Size = new System.Drawing.Size(106, 20);
            this.rb_daima.TabIndex = 80;
            this.rb_daima.TabStop = true;
            this.rb_daima.Text = "按代码排序";
            this.rb_daima.UseVisualStyleBackColor = true;
            this.rb_daima.CheckedChanged += new System.EventHandler(this.rb_daima_CheckedChanged);
            // 
            // lb_shoupindingwei
            // 
            this.lb_shoupindingwei.AutoSize = true;
            this.lb_shoupindingwei.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_shoupindingwei.Location = new System.Drawing.Point(12, 316);
            this.lb_shoupindingwei.Name = "lb_shoupindingwei";
            this.lb_shoupindingwei.Size = new System.Drawing.Size(88, 16);
            this.lb_shoupindingwei.TabIndex = 78;
            this.lb_shoupindingwei.Text = "首拼定位：";
            // 
            // lb_yibao
            // 
            this.lb_yibao.AutoSize = true;
            this.lb_yibao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_yibao.Location = new System.Drawing.Point(12, 165);
            this.lb_yibao.Name = "lb_yibao";
            this.lb_yibao.Size = new System.Drawing.Size(88, 16);
            this.lb_yibao.TabIndex = 71;
            this.lb_yibao.Text = "医保金额：";
            // 
            // lb_biaozhun
            // 
            this.lb_biaozhun.AutoSize = true;
            this.lb_biaozhun.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_biaozhun.Location = new System.Drawing.Point(12, 126);
            this.lb_biaozhun.Name = "lb_biaozhun";
            this.lb_biaozhun.Size = new System.Drawing.Size(88, 16);
            this.lb_biaozhun.TabIndex = 70;
            this.lb_biaozhun.Text = "标准金额：";
            // 
            // txb_shoupindingwei
            // 
            this.txb_shoupindingwei.Location = new System.Drawing.Point(106, 339);
            this.txb_shoupindingwei.Name = "txb_shoupindingwei";
            this.txb_shoupindingwei.Size = new System.Drawing.Size(139, 21);
            this.txb_shoupindingwei.TabIndex = 8;
            this.txb_shoupindingwei.TextChanged += new System.EventHandler(this.txb_shoupindingwei_TextChanged);
            // 
            // lb_jijin
            // 
            this.lb_jijin.AutoSize = true;
            this.lb_jijin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_jijin.Location = new System.Drawing.Point(12, 205);
            this.lb_jijin.Name = "lb_jijin";
            this.lb_jijin.Size = new System.Drawing.Size(88, 16);
            this.lb_jijin.TabIndex = 72;
            this.lb_jijin.Text = "基金金额：";
            // 
            // txb_yibaobianma
            // 
            this.txb_yibaobianma.Location = new System.Drawing.Point(106, 85);
            this.txb_yibaobianma.Name = "txb_yibaobianma";
            this.txb_yibaobianma.Size = new System.Drawing.Size(100, 21);
            this.txb_yibaobianma.TabIndex = 3;
            // 
            // lb_jibingname
            // 
            this.lb_jibingname.AutoSize = true;
            this.lb_jibingname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_jibingname.Location = new System.Drawing.Point(12, 249);
            this.lb_jibingname.Name = "lb_jibingname";
            this.lb_jibingname.Size = new System.Drawing.Size(88, 16);
            this.lb_jibingname.TabIndex = 76;
            this.lb_jibingname.Text = "疾病名称：";
            // 
            // txb_biaozhun
            // 
            this.txb_biaozhun.Location = new System.Drawing.Point(106, 121);
            this.txb_biaozhun.Name = "txb_biaozhun";
            this.txb_biaozhun.Size = new System.Drawing.Size(100, 21);
            this.txb_biaozhun.TabIndex = 4;
            // 
            // lb_yibaobianma
            // 
            this.lb_yibaobianma.AutoSize = true;
            this.lb_yibaobianma.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_yibaobianma.Location = new System.Drawing.Point(12, 90);
            this.lb_yibaobianma.Name = "lb_yibaobianma";
            this.lb_yibaobianma.Size = new System.Drawing.Size(88, 16);
            this.lb_yibaobianma.TabIndex = 68;
            this.lb_yibaobianma.Text = "医保编码：";
            // 
            // lb_leibie
            // 
            this.lb_leibie.AutoSize = true;
            this.lb_leibie.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_leibie.Location = new System.Drawing.Point(12, 52);
            this.lb_leibie.Name = "lb_leibie";
            this.lb_leibie.Size = new System.Drawing.Size(88, 16);
            this.lb_leibie.TabIndex = 64;
            this.lb_leibie.Text = "类    别：";
            // 
            // txb_yibao
            // 
            this.txb_yibao.Location = new System.Drawing.Point(106, 160);
            this.txb_yibao.Name = "txb_yibao";
            this.txb_yibao.Size = new System.Drawing.Size(100, 21);
            this.txb_yibao.TabIndex = 5;
            // 
            // txb_jibingname
            // 
            this.txb_jibingname.Location = new System.Drawing.Point(106, 279);
            this.txb_jibingname.Name = "txb_jibingname";
            this.txb_jibingname.Size = new System.Drawing.Size(139, 21);
            this.txb_jibingname.TabIndex = 7;
            // 
            // txb_daima
            // 
            this.txb_daima.Location = new System.Drawing.Point(106, 9);
            this.txb_daima.Name = "txb_daima";
            this.txb_daima.Size = new System.Drawing.Size(100, 21);
            this.txb_daima.TabIndex = 1;
            this.txb_daima.TextChanged += new System.EventHandler(this.txb_daima_TextChanged);
            // 
            // txb_leibie
            // 
            this.txb_leibie.Location = new System.Drawing.Point(106, 47);
            this.txb_leibie.Name = "txb_leibie";
            this.txb_leibie.Size = new System.Drawing.Size(100, 21);
            this.txb_leibie.TabIndex = 2;
            // 
            // txb_jijin
            // 
            this.txb_jijin.Location = new System.Drawing.Point(106, 200);
            this.txb_jijin.Name = "txb_jijin";
            this.txb_jijin.Size = new System.Drawing.Size(100, 21);
            this.txb_jijin.TabIndex = 6;
            // 
            // lb_daima
            // 
            this.lb_daima.AutoSize = true;
            this.lb_daima.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_daima.Location = new System.Drawing.Point(12, 14);
            this.lb_daima.Name = "lb_daima";
            this.lb_daima.Size = new System.Drawing.Size(88, 16);
            this.lb_daima.TabIndex = 66;
            this.lb_daima.Text = "代    码：";
            // 
            // dgv_zhenduanbianma
            // 
            this.dgv_zhenduanbianma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_zhenduanbianma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zhenduanbianma.Location = new System.Drawing.Point(3, 3);
            this.dgv_zhenduanbianma.Name = "dgv_zhenduanbianma";
            this.dgv_zhenduanbianma.RowTemplate.Height = 23;
            this.dgv_zhenduanbianma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_zhenduanbianma.Size = new System.Drawing.Size(551, 521);
            this.dgv_zhenduanbianma.TabIndex = 0;
            this.dgv_zhenduanbianma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zhenduanbianma_CellContentClick);
            // 
            // Frmzhenduanbianma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(897, 558);
            this.Controls.Add(this.spc);
            this.Controls.Add(this.ts1);
            this.Name = "Frmzhenduanbianma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入院诊断编码 ";
            this.Load += new System.EventHandler(this.Frmzhenduanbianma_Load);
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.spc.Panel1.ResumeLayout(false);
            this.spc.Panel1.PerformLayout();
            this.spc.Panel2.ResumeLayout(false);
            this.spc.ResumeLayout(false);
            this.gb_paixu.ResumeLayout(false);
            this.gb_paixu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zhenduanbianma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripButton tsbut_add;
        private System.Windows.Forms.ToolStripButton tsbut_delete;
        private System.Windows.Forms.SplitContainer spc;
        private System.Windows.Forms.Label lb_shoupindingwei;
        private System.Windows.Forms.RadioButton rb_daima;
        private System.Windows.Forms.Label lb_yibao;
        private System.Windows.Forms.Label lb_biaozhun;
        private System.Windows.Forms.TextBox txb_shoupindingwei;
        private System.Windows.Forms.Label lb_jijin;
        private System.Windows.Forms.TextBox txb_yibaobianma;
        private System.Windows.Forms.Label lb_jibingname;
        private System.Windows.Forms.TextBox txb_biaozhun;
        private System.Windows.Forms.Label lb_yibaobianma;
        private System.Windows.Forms.Label lb_leibie;
        private System.Windows.Forms.TextBox txb_yibao;
        private System.Windows.Forms.TextBox txb_jibingname;
        private System.Windows.Forms.TextBox txb_daima;
        private System.Windows.Forms.TextBox txb_leibie;
        private System.Windows.Forms.TextBox txb_jijin;
        private System.Windows.Forms.Label lb_daima;
        private System.Windows.Forms.GroupBox gb_paixu;
        private System.Windows.Forms.DataGridView dgv_zhenduanbianma;
        private System.Windows.Forms.ToolStripButton tsbut_baocun;
        private System.Windows.Forms.ToolStripButton tsbut_choose;
        private System.Windows.Forms.ToolStripButton tsbut_look;
    }
}