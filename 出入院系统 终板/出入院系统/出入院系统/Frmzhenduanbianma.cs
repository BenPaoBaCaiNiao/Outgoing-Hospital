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
    public partial class Frmzhenduanbianma : Form
    {
       private DataTable zhenduanbianma;
       SqlConnection sqlconnection = new SqlConnection();
       private String s1, s2;
       Frmruyuandengji ruyuandengji = new Frmruyuandengji();
       private SqlConnection opensql()
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
                   "Server=(local);Database=EduBaseHos;uid=jsj;pwd=2wsx@WSX";
           }
           return sqlconnection;
       }
       private void Full(String sql)
       {
           sqlconnection = opensql();
           SqlCommand command = sqlconnection.CreateCommand();
           command.CommandText =sql;
           SqlDataAdapter adfull = new SqlDataAdapter();
           adfull.SelectCommand = command;
           this.zhenduanbianma = new DataTable();
           sqlconnection.Open();
           adfull.Fill(this.zhenduanbianma);
           sqlconnection.Close();
           this.dgv_zhenduanbianma.Columns.Clear();
           this.dgv_zhenduanbianma.DataSource = this.zhenduanbianma;
           this.dgv_zhenduanbianma.Columns["No"].HeaderText = "代码";
           this.dgv_zhenduanbianma.Columns["illname"].HeaderText = "疾病名称";
           this.dgv_zhenduanbianma.Columns["style"].HeaderText = "类别";
           this.dgv_zhenduanbianma.Columns["yibaoNo"].HeaderText = "医保编码";
           this.dgv_zhenduanbianma.Columns["sdmoney"].HeaderText = "标准金额";
           this.dgv_zhenduanbianma.Columns["yibaomoney"].HeaderText = "医保金额";
           this.dgv_zhenduanbianma.Columns["jijin"].HeaderText = "基金金额";
           this.dgv_zhenduanbianma.Columns["shouping"].HeaderText = "首字拼音";
           this.dgv_zhenduanbianma.Columns[this.dgv_zhenduanbianma.Columns.Count - 1].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;

       }

        public Frmzhenduanbianma()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            
         
        }  
      



        private void Frmzhenduanbianma_Load(object sender, EventArgs e)
        {
            this.txb_daima.Focus(); 
            this.dgv_zhenduanbianma.ReadOnly = true;
            this.rb_daima.Checked = true;
            this.dgv_zhenduanbianma.RowHeadersVisible = false;

        }

        private void tsbut_tuihui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_daima_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void tsbut_baocun_Click(object sender, EventArgs e)
        {
            sqlconnection = opensql();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText =
                "update tb_ruyuanbianma set jijin=@jijin,style=@style,yibaomoney=@yibaomoney,sdmoney=@sdmoney,yibaoNo=@yibaoNo where No=@No";    
            command.Parameters.AddWithValue("@jijin", this.txb_jijin.Text.Trim());
            command.Parameters.AddWithValue("@style", this.txb_leibie.Text.Trim());
            command.Parameters.AddWithValue("@yibaomoney", this.txb_yibao.Text.Trim()); 
            command.Parameters.AddWithValue("@sdmoney", this.txb_biaozhun.Text.Trim());
            command.Parameters.AddWithValue("@yibaoNo", this.txb_yibaobianma.Text.Trim());
            command.Parameters.AddWithValue("@No",this.txb_daima.Text.Trim());       
            sqlconnection.Open();
            int affect = command.ExecuteNonQuery();
            sqlconnection.Close();
            if (rb_daima.Checked)
            {
                Full("select * from tb_ruyuanbianma order by No  asc;");
            }
            else
            {
                Full("select * from tb_ruyuanbianma order by illname  asc;");
            }
            MessageBox.Show("更新" + affect.ToString() + "行");          

           
        }

        private void rb_daima_CheckedChanged(object sender, EventArgs e)
        {
            Full("select * from tb_ruyuanbianma order by No  asc;");
           
        }

        private void rb_name_CheckedChanged(object sender, EventArgs e)
        {
            Full("select * from tb_ruyuanbianma order by illname  asc;");
        }

        private void txb_shoupindingwei_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void tsbut_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定删除该项?", "注意事项", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
           sqlconnection = opensql();
           SqlCommand command = sqlconnection.CreateCommand();
           command.CommandText =
               "delete tb_ruyuanbianma where No=@No;";
           command.Parameters.AddWithValue("@No",this.dgv_zhenduanbianma.CurrentRow.Cells["No"].Value.ToString());
            sqlconnection.Open();
            int affect = command.ExecuteNonQuery();
            sqlconnection.Close();
            this.dgv_zhenduanbianma.Rows.Remove(this.dgv_zhenduanbianma.CurrentRow);
            MessageBox.Show("成功删除" + affect.ToString() + "行");

        }

        private void tsbut_add_Click(object sender, EventArgs e)
        {
            //int a;
            //a = ruyuandengji.check("select * from tb_ruyuanbiama where No=@canshu", this.txb_daima.Text.Trim());
            //if (a == 1)
            //{
            //    MessageBox.Show("该项已存在，添加失败");
            //    return;
            //}
            DataRow addrow = this.zhenduanbianma.NewRow();
            addrow["No"] = this.txb_daima.Text.Trim();
            addrow["illname"] = this.txb_jibingname.Text.Trim();
            addrow["style"] = this.txb_leibie.Text.Trim();
            addrow["yibaoNo"] = this.txb_yibaobianma.Text.Trim();
            addrow["sdmoney"] = this.txb_biaozhun.Text.Trim();
            addrow["yibaomoney"] = this.txb_yibao.Text.Trim();
            addrow["jijin"] = this.txb_jijin.Text.Trim();
            addrow["shouping"] = this.txb_shoupindingwei.Text.Trim();
            this.zhenduanbianma.Rows.Add(addrow);
            sqlconnection = opensql();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText =
                "insert tb_ruyuanbianma(No,illname,style,yibaoNo,sdmoney,yibaomoney,jijin,shouping) values(@No,@illname,@style,@yibaoNo,@sdmoney,@yibaomoney,@jijin,@shouping);";
            command.Parameters.Add("@No", SqlDbType.Char, 10, "No");
            command.Parameters.Add("@illname", SqlDbType.VarChar, 0, "illname");
            command.Parameters.Add("@style", SqlDbType.VarChar, 0, "style");
            command.Parameters.Add("@yibaoNo", SqlDbType.Char, 10, "yibaoNo");
            command.Parameters.Add("@sdmoney", SqlDbType.VarChar, 0, "sdmoney");
            command.Parameters.Add("@yibaomoney", SqlDbType.VarChar, 0, "yibaomoney");
            command.Parameters.Add("@jijin", SqlDbType.VarChar, 0, "jijin");
            command.Parameters.Add("@shouping", SqlDbType.VarChar, 0, "shouping");
            SqlDataAdapter adinsert = new SqlDataAdapter();
            adinsert.InsertCommand = command;
            sqlconnection.Open();
            int affect = adinsert.Update(this.zhenduanbianma);
            sqlconnection.Close();
            MessageBox.Show("成功添加" + affect.ToString() + "行");
        }

        private void tsbut_choose_Click(object sender, EventArgs e)
        {
                       
            s1 = this.txb_daima.Text.Trim();
            s2 = this.txb_jibingname.Text.Trim();
            Frmruyuandengji ruyuandengji = ((Frmruyuandengji)this.Owner);
            ruyuandengji.txb_zhenduanma.Text = s1;
            ruyuandengji.txb_zhenduanname.Text = s2;
            this.Close();
            //值传递：用showdialog打开窗体，将值传回窗体,例如：原创题（From1),新窗体（From2)；原窗体中:
            //From2 f=new From2;
            //f.Owner=this;f.ShowDialog();
            //this.close();
            //新窗体:
            //From1 f=((From1)this.Owner)
            //f.txb_文本名.Text=内容;
            //Form1中的TextBox1的Modifiers属性需要是Public才可以引用，变量也是一样的
            
        }
        
        private void dgv_zhenduanbianma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            this.txb_daima.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["No"].Value.ToString();
            this.txb_biaozhun.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["sdmoney"].Value.ToString();
            this.txb_jibingname.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["illname"].Value.ToString();
            this.txb_jijin.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["jijin"].Value.ToString();
            this.txb_leibie.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["style"].Value.ToString();
            this.txb_shoupindingwei.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["shouping"].Value.ToString();
            this.txb_yibao.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["yibaomoney"].Value.ToString();
            this.txb_yibaobianma.Text = this.dgv_zhenduanbianma.CurrentRow.Cells["yibaoNo"].Value.ToString();
            
        }

        private void tsbut_look_Click_1(object sender, EventArgs e)
        {
            //if (this.txb_daima.Text.Trim() == "" && this.txb_shoupindingwei.Text.Trim() == "")
            //{
            //    MessageBox.Show("代码或首拼不为空", "注意事项",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            //    return;
            //}
            //else if (this.txb_daima.Text.Trim() != "")
            //{
            //    for (int i = 0; i < this.dgv_zhenduanbianma.RowCount - 1;i++)
            //    {
            //        if (this.dgv_zhenduanbianma.Rows[i].Cells["No"].Value.ToString() == this.txb_daima.Text.Trim())
            //        {
            //            this.txb_jibingname.Text = this.dgv_zhenduanbianma.Rows[i].Cells["illname"].Value.ToString();
            //            this.txb_jijin.Text = this.dgv_zhenduanbianma.Rows[i].Cells["jijin"].Value.ToString();
            //            this.txb_leibie.Text = this.dgv_zhenduanbianma.Rows[i].Cells["style"].Value.ToString();
            //            this.txb_shoupindingwei.Text = this.dgv_zhenduanbianma.Rows[i].Cells["shouping"].Value.ToString();
            //            this.txb_yibao.Text = this.dgv_zhenduanbianma.Rows[i].Cells["yibaomoney"].Value.ToString();
            //            this.txb_yibaobianma.Text = this.dgv_zhenduanbianma.Rows[i].Cells["yibaoNo"].Value.ToString();
            //            this.txb_biaozhun.Text = this.dgv_zhenduanbianma.Rows[i].Cells["sdmoney"].Value.ToString();
            //            return;
            //        }                                  

            //    }
            //}
            //else if (this.txb_shoupindingwei.Text.Trim() != "")
            //{
            //    for (int i = 0; i < this.dgv_zhenduanbianma.RowCount - 1; i++)
            //    {
            //        if (this.dgv_zhenduanbianma.Rows[i].Cells["shouping"].Value.ToString() == this.txb_shoupindingwei.Text.Trim())
            //        {
            //            this.dgv_zhenduanbianma.CurrentCell = this.dgv_zhenduanbianma.Rows[i].Cells["shouping"];
            //            this.txb_daima.Text = this.dgv_zhenduanbianma.Rows[i].Cells["No"].Value.ToString();
            //            this.txb_jibingname.Text = this.dgv_zhenduanbianma.Rows[i].Cells["illname"].Value.ToString();
            //            this.txb_jijin.Text = this.dgv_zhenduanbianma.Rows[i].Cells["jijin"].Value.ToString();
            //            this.txb_leibie.Text = this.dgv_zhenduanbianma.Rows[i].Cells["style"].Value.ToString();
            //            this.txb_yibao.Text = this.dgv_zhenduanbianma.Rows[i].Cells["yibaomoney"].Value.ToString();
            //            this.txb_yibaobianma.Text = this.dgv_zhenduanbianma.Rows[i].Cells["yibaoNo"].Value.ToString();
            //            this.txb_biaozhun.Text = this.dgv_zhenduanbianma.Rows[i].Cells["sdmoney"].Value.ToString();
            //            return;
            //        }
            //    }
               
            //}
           
        }

        private void ts1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
