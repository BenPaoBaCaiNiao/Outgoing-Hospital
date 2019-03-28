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
    public partial class Frmzhuce : Form
    {
        public Frmzhuce()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void but_zhuce_Click(object sender, EventArgs e)
        {
            if (this.txb_yonghu.Text.Trim() == "")
            {
                MessageBox.Show("用户名不可为空","注意事项",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.txb_yonghu.Focus();
            }
            else if (this.txb_mima.Text.Trim() == "")
            {
                MessageBox.Show("密码不可为空","注意事项",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.txb_mima.Focus();
            }
            else
            {
                SqlConnection sqlconnection = new SqlConnection();
                sqlconnection.ConnectionString =
                        "Server=(local);Database=EduBaseHos;Integrated Security=sspi";
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlcommand.CommandText =
                    "select count(1) from tb_user where No=@No;";
                sqlcommand.Parameters.AddWithValue("@No", this.txb_yonghu.Text.Trim());
                sqlconnection.Open();
                int row = (int)sqlcommand.ExecuteScalar();
                sqlconnection.Close();
                if (row == 1)
                {
                    MessageBox.Show("该用户已经存在，请重试 ", "注意事项", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txb_yonghu.Text = "";
                    this.txb_mima.Text = "";
                    this.txb_yonghu.Focus();
                }
                else
                {
                    SqlConnection sqlconnection1 = new SqlConnection();
                    sqlconnection1.ConnectionString =
                            "Server=(local);Database=EduBaseHos;Integrated Security=sspi";
                    SqlCommand sqlcommand1 = sqlconnection1.CreateCommand();
                    sqlcommand1.CommandText =
                        "insert tb_user (No,passwd) values(@No,@password);";
                    sqlcommand1.Parameters.AddWithValue("@No", this.txb_yonghu.Text.Trim());
                    sqlcommand1.Parameters.AddWithValue("@password", this.txb_mima.Text.Trim());
                    sqlconnection1.Open();
                    int rowaffect = (int)sqlcommand1.ExecuteNonQuery();
                    sqlconnection1.Close();
                    if (rowaffect == 1)
                    {
                        DialogResult dr = MessageBox.Show("注册成功，去登录", "标题", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            Frmdenglu denglu = new Frmdenglu();
                            this.Close();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("注册失败，是否重试", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            this.Show();
                        }
                        else
                        {
                            Frmdenglu denglu = new Frmdenglu();
                            denglu.Show();
                        }
                    }
                }
            }
        }


        private void but_quxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





                    








