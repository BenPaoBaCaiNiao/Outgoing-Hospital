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
    public partial class Frmpaxingzhi : Form
    {
        SqlConnection sqlconnection=new SqlConnection();
        public SqlConnection opensql()
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
        private DataTable showcmb(String sql)
        {
            sqlconnection = opensql();
            SqlCommand cmbcom = sqlconnection.CreateCommand();
            cmbcom.CommandText = sql;
            SqlDataAdapter cmbad = new SqlDataAdapter();
            cmbad.SelectCommand = cmbcom;
            DataTable cmbda = new DataTable();
            sqlconnection.Open();
            cmbad.Fill(cmbda);
            sqlconnection.Close();
            return cmbda;
            ;
        }

        public Frmpaxingzhi(String a)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txb_workorno.Text = a;
            txb_workorno.Enabled = false;
            DataTable cmbfenlei = new DataTable();
            cmbfenlei = showcmb("select * from tb_pafenlei;");
            cmb_fenlei.Name = "tb_pafenlei";
            cmb_fenlei.DataSource = cmbfenlei;
            cmb_fenlei.DisplayMember = "name";
            cmb_fenlei.ValueMember = "No";
            cmb_fenlei.SelectedIndex = 0;
            DataTable cmbshangcan = new DataTable();
            cmbshangcan = showcmb("select * from tb_shangcan;");
            cmb_shangcan.Name = "tb_shangcan";
            cmb_shangcan.DataSource = cmbshangcan;
            cmb_shangcan.DisplayMember = "name";
            cmb_shangcan.ValueMember = "No";
            cmb_shangcan.SelectedIndex = 9;
            DataTable cmbspecial = new DataTable();
            cmbspecial = showcmb("select * from tb_special;");
            cmb_biaozhi.Name = "tb_special";
            cmb_biaozhi.DataSource = cmbspecial;
            cmb_biaozhi.DisplayMember = "name";
            cmb_biaozhi.ValueMember = "No";
            cmb_biaozhi.SelectedIndex = 1;
        }


        private void Frmpaxingzhi_Load(object sender, EventArgs e)
        {

        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Frmruyuandengji ruyuandengji = ((Frmruyuandengji)this.Owner);
            ruyuandengji.pafenlei = cmb_fenlei.Text.Trim();
            ruyuandengji.special = cmb_biaozhi.Text.Trim();
            ruyuandengji.shangcan = cmb_shangcan.Text.Trim();
            this.Close();
            
         
           
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
