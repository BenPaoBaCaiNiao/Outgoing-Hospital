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
    public partial class Frmbedcheck : Form
    {
        SqlConnection sqlconnection = new SqlConnection();
        private String houseNo, bedNo, dengji;
        
        public void opensql()
        {
            FrmDataBase frmdatabase = new FrmDataBase();
            if (frmdatabase.Data()== 0)
            {
                sqlconnection.ConnectionString =
                    "Server=(local);DataBase=EduBaseHos;Integrated Security=sspi";
            }
            else
            {
                sqlconnection.ConnectionString =
                    "Server=(local);Database=EduBaseHos;uid=jsj;pwd=2wsx@WSX";
            }
            
         }
        public void select()
        {
            opensql();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText =
                "select b.keshiNo,keshiname,roomNo,bedNo,case nullorno when 1 then '非空床' when 0 then '空床' end as nullorno,dengji from tb_bed b join tb_keshi k on b.keshiNo=k.keshiNo where keshiname=@keshi;";
            SqlCommand command1 = sqlconnection.CreateCommand();
            command1.CommandText =
                "select count(*) from tb_bed b join tb_keshi k on b.keshiNo=b.keshiNo where keshiname=@keshi and nullorno=0;";
            command.Parameters.AddWithValue("@keshi", tscmb_keshiname.ComboBox.Text.Trim());
            command1.Parameters.AddWithValue("@keshi", tscmb_keshiname.ComboBox.Text.Trim());
            SqlDataAdapter keshiad = new SqlDataAdapter();
            keshiad.SelectCommand = command;
            DataTable keshida = new DataTable();
            sqlconnection.Open();
            keshiad.Fill(keshida);
            sqlconnection.Close();
            this.dgv_keshi.Columns.Clear();
            this.dgv_keshi.DataSource = keshida;
            this.dgv_keshi.Columns["keshiNo"].HeaderText = "科室编号";
            this.dgv_keshi.Columns["keshiname"].HeaderText = "科室名称";
            this.dgv_keshi.Columns["roomNo"].HeaderText = "房间号";
            this.dgv_keshi.Columns["bedNo"].HeaderText = "病床号";
            this.dgv_keshi.Columns["dengji"].HeaderText = "等级";
            this.dgv_keshi.Columns["nullorno"].HeaderText = "状态";
            this.dgv_keshi.Columns[this.dgv_keshi.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            dgv_keshi.ReadOnly = true;
            
        }
      

        
        public Frmbedcheck(String keshi)//,String area
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
            opensql();
            SqlCommand cmbcom = sqlconnection.CreateCommand();
            cmbcom.CommandText=
                "select * from tb_keshi;";
            SqlDataAdapter cmbad=new SqlDataAdapter();
            cmbad.SelectCommand=cmbcom;
            DataTable cmbda=new DataTable();
            sqlconnection.Open();
            cmbad.Fill(cmbda);
            sqlconnection.Close();
            tscmb_keshiname.Name="keshi";
            tscmb_keshiname.ComboBox.DataSource = cmbda;
            tscmb_keshiname.ComboBox.DisplayMember = "keshiname";
            tscmb_keshiname.ComboBox.ValueMember = "keshiNo";          
            this.tscmb_keshiname.Text= keshi;

        }

    
        private void tsbut_chaxun_Click(object sender, EventArgs e)
        {
            select();
        }

        private void txb_shuaxin_Click(object sender, EventArgs e)
        {
           select();
        }

        private void dgv_keshi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ts1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frmbedcheck_Load(object sender, EventArgs e)
        {

        }

        private void dgv_keshi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            houseNo = this.dgv_keshi.CurrentRow.Cells["roomNo"].Value.ToString();
            bedNo = this.dgv_keshi.CurrentRow.Cells["bedNo"].Value.ToString();
            dengji = this.dgv_keshi.CurrentRow.Cells["dengji"].Value.ToString();
            Frmruyuandengji ruyuandengji = ((Frmruyuandengji)this.Owner);
            ruyuandengji.txb_houseNo.Text = houseNo;
            ruyuandengji.txb_bedNo.Text = bedNo;
            ruyuandengji.txb_dengji.Text = dengji;
            //ruyuandengji.Show();
            this.Close();
        }
    }
}
