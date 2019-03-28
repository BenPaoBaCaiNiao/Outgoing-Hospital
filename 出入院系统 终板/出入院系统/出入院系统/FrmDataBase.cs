using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 出入院系统
{
    public partial class FrmDataBase : Form
    {
        public int database;
        public static int data;
        public FrmDataBase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void but_ok_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        private void rab_school_CheckedChanged(object sender, EventArgs e)
        {
            data = 1;
        }

        private void rab_personal_CheckedChanged(object sender, EventArgs e)
        {
            data = 0;
        }
        public int Data()
        {
            database = data;
            return database;
        }

    }
}
