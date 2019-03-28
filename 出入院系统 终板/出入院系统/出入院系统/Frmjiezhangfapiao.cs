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
    public partial class Frmjiezhangfapiao : Form
    {
        public Frmjiezhangfapiao(String[] s)
        {
            InitializeComponent();
            this.txb_name.Text=s[0];
            this.txb_bedNo.Text=s[1];
            this.txb_zuNo.Text=s[2];
            this.txb_timeone.Text=s[3];
            this.txb_timetwo.Text=s[4];
            this.txb_day.Text = s[5];

        }


    }
}
