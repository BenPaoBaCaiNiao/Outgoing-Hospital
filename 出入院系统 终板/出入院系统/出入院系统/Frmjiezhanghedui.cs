using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 出入院系统
{
    public partial class Frmjiezhanghedui : Form
    {
        public Frmjiezhanghedui(String[] s)
        {
            InitializeComponent();
            this.txb_total.Text = s[0];
            this.txt_bencijiezhang.Text=s[1];
            this.txt_baoxiaoxiaoji.Text=s[2];
            this.txt_weijiefeiyong.Text=s[3];
            this.txt_yishouxianjin.Text=s[4];
            this.txt_shoutuizhipiao.Text=s[5];
            this.txt_yishouzhipiao.Text=s[6];
            this.txt_shoutuixianjin.Text=s[7];
            this.txb_days.Text = s[8]; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void but_ok_Click_1(object sender, EventArgs e)
        {
            Frmruyuandengji ruyuan = ((Frmruyuandengji)this.Owner);
            ruyuan.bl = true;
            this.Close();
        }
    }
}
