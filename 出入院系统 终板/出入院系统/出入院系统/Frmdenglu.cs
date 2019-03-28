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
    public partial class Frmdenglu : Form
    {

       
        SqlConnection sqlconnection = new SqlConnection();
        SqlCommand sqlcommand = new SqlCommand();
        public Frmdenglu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_mima.UseSystemPasswordChar = true;
            this.lkb_xianshi.Text = "显示密码";

        }
        private SqlCommand opensql()
        {
            FrmDataBase frmdatabase = new FrmDataBase();
            if (frmdatabase.Data() == 0)
            {
                sqlconnection.ConnectionString =
                    "Server=(local);DataBase=EduBaseHos;Integrated Security=sspi";
            }
            else
            {
                sqlconnection.ConnectionString =
                    "Server=(local);DataBase=EduBaseHos;uid=jsj;pwd=2wsx@WSX";
            }

            SqlCommand sqlcommand = sqlconnection.CreateCommand();
            return sqlcommand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_yonghu.Text.Trim() == "" || txt_mima.Text.Trim() == "")
            {
                MessageBox.Show("用户或密码不可为空","注意事项",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (txt_yonghu.Text.Trim() == "")
                {
                    this.txt_yonghu.Focus();
                }
                else
                {
                    this.txt_mima.Focus();
                }
                return;
            }

            sqlcommand = opensql();
            sqlcommand.CommandText =
                    "SELECT COUNT(1) FROM tb_gonghao WHERE gonghaoNo=@No and passwd=@passwd";
            sqlcommand.Parameters.AddWithValue("@No", this.txt_yonghu.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@passwd", this.txt_mima.Text.Trim());
            sqlcommand.Parameters["@passwd"].SqlDbType = SqlDbType.VarChar;
            sqlconnection.Open();
            int row = (int)sqlcommand.ExecuteScalar();
            sqlconnection.Close();            
            if (row == 1)
            {
                
                Frmruyuandengji ruyuandengji = new Frmruyuandengji();
                ruyuandengji.Show();
                ruyuandengji.tstxb_chuyuangonghaoNo.Text = this.txt_yonghu.Text.Trim();
                ruyuandengji.tstxb_jiaokuangonghaoNo.Text = this.txt_yonghu.Text.Trim();
                this.Visible = false;
                
            }
            else
            {
                MessageBox.Show("用户号或密码错误，请重新输入","注意事项",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.txt_mima.Focus();
                this.txt_mima.SelectAll();
                return;
            }
            
          
            
            

        

        }

        private void but_quxiao_Click(object sender, EventArgs e)
        {
            
        }

        private void but_quxiao_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_zhuce_Click(object sender, EventArgs e)
        {
            Frmzhuce zhuce = new Frmzhuce();
            zhuce.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            Frmzhuce frmzhuce = new Frmzhuce();
            this.Visible = false;
            frmzhuce.ShowDialog();
            this.Visible = true;

        }

        private void lkb_xianshi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lkb_xianshi.Text == "显示密码")
            {
                txt_mima.UseSystemPasswordChar = false;
                this.lkb_xianshi.Text = "隐藏密码";
            }
            else
            {
                txt_mima.UseSystemPasswordChar = true;
                this.lkb_xianshi.Text = "显示密码";
            }
        }

        private void lkl_DataBase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDataBase frmdatabase = new FrmDataBase();
            frmdatabase.ShowDialog();
            this.Show();
            
        }
    }
}
