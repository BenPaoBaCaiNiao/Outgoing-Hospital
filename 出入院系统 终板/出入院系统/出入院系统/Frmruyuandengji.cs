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
    public partial class Frmruyuandengji : Form
    {
        
        public SqlConnection sqlconnection = new SqlConnection();
        public SqlCommand sqlcommand = new SqlCommand();        
        public SqlDataReader sqldatareader;
        public string pafenlei, special, shangcan;
        private string workorno;
        
        private String keshi;//area;
        ////打开连接
        public SqlCommand opensql()
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

        ////下拉框的查找
        private DataTable showcmb(String sql)
        {
            SqlCommand cmbcom = opensql();
            cmbcom.CommandText = sql;
            SqlDataAdapter cmbad = new SqlDataAdapter();
            cmbad.SelectCommand = cmbcom;
            DataTable cmbda = new DataTable();
            sqlconnection.Open();
            cmbad.Fill(cmbda);
            sqlconnection.Close();
            return cmbda;
        }
        ////判断一行是否存在
        public int look(String sql, String canshu)
        {
            sqlcommand = opensql();
            sqlcommand.CommandText = sql;
            sqlcommand.Parameters.AddWithValue("@canshu", canshu);
            sqlconnection.Open();
            int affect = (int)sqlcommand.ExecuteScalar();
            sqlconnection.Close();
            return affect;
        }
        public float look1(String sql, String canshu)
        {
            sqlcommand = opensql();
            sqlcommand.CommandText = sql;
            sqlcommand.Parameters.AddWithValue("@canshu", canshu);
            sqlconnection.Open();
            float affect = (float)sqlcommand.ExecuteScalar();
            sqlconnection.Close();
            return affect;
        }
        ////查找一行
        
        private void check(String sql, String canshu,int i)
        {
            sqlcommand = opensql();
            sqlcommand.CommandText = sql;
            sqlcommand.Parameters.AddWithValue("@canshu", canshu);
            sqlconnection.Open();
            if (i == 0)
            {
                sqldatareader = sqlcommand.ExecuteReader();
            }
            else
            {
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
             }
            
        }
        //////删除
        public void delete(String sql,String canshu1,String canshu2,DataGridView dgv)
        {
            if (MessageBox.Show("确定删除该项?", "注意事项", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }           
            sqlcommand = sqlconnection.CreateCommand();
            sqlcommand.CommandText =sql;
            sqlcommand.Parameters.AddWithValue("@canshu1",canshu1);
            sqlcommand.Parameters.AddWithValue("@canshu2", canshu2);
            sqlconnection.Open();
            int affect = sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            dgv.Rows.Remove(dgv.CurrentRow);
            MessageBox.Show("成功删除" + affect.ToString() + "行");
        }



        ////入院登记初始化
        public void ruyuanstart()
        {

            this.txb_menzhenNo.Focus();
            txb_menzhenNo.Focus();
            but_bag.Enabled = false;
            but_bedcard.Enabled = false;
            but_bedcheck.Enabled = false;
            but_zenduanbianma.Enabled = false;
            but_ruyuan.Enabled = false;
            but_paxingzhi.Enabled = false;
            DataTable dadoctor = showcmb("select * from tb_gonghao;");
            cmb_doctor.Name = "tb_gonghao";
            cmb_doctor.DataSource = dadoctor;
            cmb_doctor.DisplayMember = "name";
            cmb_doctor.ValueMember = "gonghaoNo";
            DataTable daarea = showcmb("select * from tb_area;");
            cmb_area.Name = "tb_area";
            cmb_area.DataSource = daarea;
            cmb_area.DisplayMember = "name";
            cmb_area.ValueMember = "No";
            DataTable daminzhu = showcmb("select * from tb_minzhu;");
            cmb_minzhu.Name = "tb_minzhu";
            cmb_minzhu.DataSource = daminzhu;
            cmb_minzhu.DisplayMember = "name";
            cmb_minzhu.ValueMember = "No";
            DataTable dakeshi = showcmb("select * from tb_keshi;");
            cmb_keshi.Name = "tb_keshi";
            cmb_keshi.DataSource = dakeshi;
            cmb_keshi.DisplayMember = "keshiname";
            cmb_keshi.ValueMember = "keshiNo";
            DataTable dajistyle = showcmb("select * from tb_jistyle;");
            cmb_jistyle.Name = "tb_jistyle";
            cmb_jistyle.DataSource = dajistyle;
            cmb_jistyle.DisplayMember = "name";
            cmb_jistyle.ValueMember = "No";

        }

        ////出院处理初始化
        public void chuyuanstart()
        {
            this.tstxb_chuyuangonghaoNo.Enabled = false;
            this.tsp_chuyuan.Visible = true;
            DateTime dt = System.DateTime.Now;
            this.txb_enddate.Text = dt.ToShortDateString();
            this.txb_rudate.Enabled = false;
            this.txb_startdate.Enabled = false;
            this.txb_jistyle.Enabled = false;
            this.txb_area.Enabled = false;
            this.txb_chuyuanname.Enabled = false;
            this.txb_sex.Enabled = false;
            this.rb_zhuyuan.Checked = true;
            this.txb_chuyuanbedNo.Enabled = false;
            
        }
        ////入院交款处理初始化
        public void jiaokuanstart()
        {
            this.tsp_ruyuanjiaokuan.Visible = true;
            this.tstxb_jiaokuangonghaoNo.Enabled = false;
            this.txb_jiaokuanmenNo.Enabled = false;
            this.txb_jiaokuanarea.Enabled = false;
            this.txb_jiaokuankeshi.Enabled = false;
            this.txb_jiaokuanname.Enabled = false;
            this.txb_jiaokuanpastyle.Enabled = false;
            DateTime dt = DateTime.Now;
            this.tsl_jiaokuantime.Text = dt.ToShortDateString();
            DataTable dapayway = showcmb("select * from tb_payway;");
            this.cmb_jiaokuanway.Name = "tb_payway";
            this.cmb_jiaokuanway.DataSource = dapayway;
            this.cmb_jiaokuanway.DisplayMember = "paywayname";
            this.cmb_jiaokuanway.ValueMember = "paywayNo";
            this.cmb_jiaokuanway.SelectedValue = 2;
            DataTable dapaystyle = showcmb("select * from tb_paystyle;");
            this.cmb_jiaokuanpaystyle.Name = "tb_paystyle";
            this.cmb_jiaokuanpaystyle.DataSource = dapaystyle;
            this.cmb_jiaokuanpaystyle.DisplayMember = "paystylename";
            this.cmb_jiaokuanpaystyle.ValueMember = "paystyleNo";
            this.cmb_jiaokuanpaystyle.SelectedValue = 2;
            this.dgv_jiaokuan.ReadOnly = true;
            this.dgv_jiaokuan.RowHeadersVisible = false;
            this.dgv_jiaokuan.AllowUserToResizeColumns = false;

        }
        ////初始化代码
        public Frmruyuandengji()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ruyuanstart();
            chuyuanstart();
            jiaokuanstart();
            chuyuanstart();
            detailstart();
            

        }





        ////入院登记代码
        private void but_painformation_Click(object sender, EventArgs e)
        {
            if (this.txb_menzhenNo.Text.Trim() == "")
            {
                MessageBox.Show("请输门诊号");
                this.txb_menzhenNo.Focus();
                return;
            }
            if (look("select count(1) from tb_base b join tb_zhenduan z on z.menNo=b.menNo where b.menNo=@canshu", this.txb_menzhenNo.Text.Trim()) != 1)
            {
                MessageBox.Show("该门诊号不存在");
                return;
            }
            sqlcommand = opensql();
            sqlcommand.CommandText =
                "select * from tb_base b join tb_zhenduan z on z.menNo=b.menNo where b.menNo=@menzhenNo";
            sqlcommand.Parameters.AddWithValue("@menzhenNo", this.txb_menzhenNo.Text.Trim());
            sqlconnection.Open();
            SqlDataReader datareader = sqlcommand.ExecuteReader();
            if (datareader.Read())
            {
                txb_name.Text = datareader["paname"].ToString();
                txb_idNo.Text = datareader["idNo"].ToString();
                txb_address.Text = datareader["homead"].ToString();
                dt_birthday.Text = ((DateTime)datareader["birthdate"]).ToShortDateString();
                txb_country.Text = datareader["guoji"].ToString();
                txb_email.Text = datareader["email"].ToString();
                txb_job.Text = datareader["profession"].ToString();
                txb_email.Text = datareader["email"].ToString();
                this.txb_menzhenday.Text = ((DateTime)datareader["zhenduanday"]).ToShortDateString();
                if (datareader["marryorno"].ToString() == "1")
                {
                    txb_marry.Text = "是";
                }
                else
                {
                    txb_marry.Text = "否";
                }

                rb_male.Checked = (Boolean)datareader["sex"];
                rb_female.Checked = !(Boolean)datareader["sex"];
                this.cmb_minzhu.Text = datareader["minzhu"].ToString();
                txb_phone.Text = datareader["telephone"].ToString();
                txb_relation.Text = datareader["relation"].ToString();
                txb_relationname.Text = datareader["familyname"].ToString();
                txb_zhenduandetail.Text = datareader["shuoming"].ToString();
                workorno = datareader["workorno"].ToString();
            }
            sqlconnection.Close();

            but_bag.Enabled = true;
            but_bedcard.Enabled = true;
            but_bedcheck.Enabled = true;
            but_zenduanbianma.Enabled = true;
            but_ruyuan.Enabled = true;
            but_paxingzhi.Enabled = true;
            DateTime dt = System.DateTime.Now;
            this.txb_ruyuantime.Text = dt.TimeOfDay.ToString();

        }

        private void but_zenduanbianma_Click(object sender, EventArgs e)
        {
            Frmzhenduanbianma zhenduanbianma = new Frmzhenduanbianma();
            zhenduanbianma.Owner = this;
            this.Visible = false;
            zhenduanbianma.ShowDialog();
            this.Show();
        }
        private void but_paxingzhi_Click_1(object sender, EventArgs e)
        {
            Frmpaxingzhi paxingzhi = new Frmpaxingzhi(workorno);
            paxingzhi.Owner = this;
            paxingzhi.ShowDialog();
        }

        private void but_bedcheck_Click_1(object sender, EventArgs e)
        {
            //area = cmb_area.SelectedValue.ToString();
            keshi = this.cmb_keshi.Text.Trim();
            Frmbedcheck bedcheck = new Frmbedcheck(keshi);//,area
            bedcheck.Owner = this;
            this.Visible = false;
            bedcheck.ShowDialog();
            this.Show();

        }

        private void but_bedcard_Click(object sender, EventArgs e)
        {
            Frmbedcard f = new Frmbedcard();
            this.Visible = false;
            f.ShowDialog();
            this.Show();
        }




        private void but_ruyuan_Click_1(object sender, EventArgs e)
        {
            if (this.pafenlei == "" || this.special == "")
            {
                MessageBox.Show("请设置病人的性质");
                return;
            }
            sqlcommand = opensql();
            sqlcommand.CommandText =
                "insert tb_hosbase(zuNo,menNo,rudate,rutime,jistyle,pastyle,illest,shangcan,areaNo,keshiNo,roomNo,bedNo,gonghaoNo) values(@zuNo,@menNo,@rudate,@rutime,@jistyle,@pastyle,@illest,@shangcan,@areaNo,@keshiNo,@roomNo,@bedNo,@gonghaoNo);";
            sqlcommand.Parameters.AddWithValue("@zuNo", this.txb_zuyuanNo.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@menNo", this.txb_menzhenNo.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@rudate", this.dt_ruyuanday.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@rutime", this.txb_ruyuantime.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@jistyle", this.cmb_jistyle.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@pastyle", this.pafenlei);
            sqlcommand.Parameters.AddWithValue("@illest", this.special);
            sqlcommand.Parameters.AddWithValue("@shangcan", this.shangcan);
            sqlcommand.Parameters.AddWithValue("@areaNo", this.cmb_area.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@keshiNo", this.cmb_keshi.SelectedValue.ToString());
            sqlcommand.Parameters.AddWithValue("@roomNo", this.txb_houseNo.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@bedNo", this.txb_bedNo.Text.Trim());

            sqlcommand.Parameters.AddWithValue("@gonghaoNo", this.cmb_doctor.SelectedValue.ToString());
            sqlconnection.Open();
            int affect = sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            if (affect == 1)
            {
                MessageBox.Show("入院登记成功");
                tb_all.SelectedIndex = 1;
                this.txb_jiaokuanzuNo.Text = this.txb_chuyuanzuNo.Text.Trim();
                this.txb_jiaokuanmenNo.Text = this.txb_menNo.Text.Trim();
                this.txb_jiaokuanname.Text = this.txb_name.Text.Trim();
                this.txb_jiaokuanarea.Text = this.cmb_area.Text.Trim();
                this.txb_jiaokuankeshi.Text = this.cmb_keshi.Text.Trim();
                this.txb_jiaokuanpastyle.Text = this.pafenlei;
                return;
            }
            else
            {
                MessageBox.Show("入院登记失败");
                return;
            }
        }






        ////入院交款处理代码
        
        private DataTable dashouju = new DataTable();
        private float xiaoji1;
        private void showdgv(String canshu, DataGridView dgv)
        {
            DataTable dashouju = new DataTable();
            sqlcommand = opensql();
            sqlconnection.Open();
            sqlcommand.CommandText =
                "select shoujuNo,zuNo,wherework,Convert(decimal(10,2),shoujumoney) as shoujumoney,paystyle,payway,paytime,menNo,gonghaoNo,bshoujumoney from tb_shouju where zuNo=@zuNo;";
            sqlcommand.Parameters.AddWithValue("@zuNo", canshu);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlcommand;
            dataAdapter.Fill(dashouju);
            sqlconnection.Close();
            this.dashouju = dashouju;
            dgvstart(dgv);
            dgv.Columns.Clear();
            dgv.DataSource = dashouju;
            dgv.Columns["shoujuNo"].HeaderText = "收据编号";
            dgv.Columns["wherework"].HeaderText = "单位";
            dgv.Columns["shoujumoney"].HeaderText = "交款金额";
            dgv.Columns["paystyle"].HeaderText = "交款类型";
            dgv.Columns["payway"].HeaderText = "交款方式";
            dgv.Columns["paytime"].HeaderText = "交款时间";
            dgv.Columns["gonghaoNo"].HeaderText = "工号";
            dgv.Columns["bshoujumoney"].HeaderText = "大写数额";
            dgv.Columns["menNo"].Visible = false;
            dgv.Columns["zuNo"].Visible = false;  
            xiaoji1=Convert.ToInt16(dashouju.Compute("SUM(shoujumoney)", ""));
            this.txb_chuyuanxiaoji1.Text = xiaoji1.ToString() ;
        }


        //    public String moneyb(String money)
        //    {
        //        int a;
        //        String str1,str2,str3;
        //        str1=null;
        //        str2=null;
        //        str3=null;
        //        a = money.IndexOf(".");
        //        for(int i=1;i<=Math.Ceiling((double)a/4);i++)
        //        {
        //            for(;a>0;a--)
        //                str1=str1.Insert(1,money.Substring(a-1,a));
        //        }                   


                //private String shuzi(String shuzi)
                //{
                //    String str;
                //    Double shuzi1=Convert.ToDouble(shuzi);
                //    if(shuzi1>Double.MaxValue || shuzi1<=0)
                //    {
                //        MessageBox.Show("金额格式不正确","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                //        return "0";
                //    }
                //    String c, s = null;  
                //    String[] big=new String[]{"零","壹","贰","叁","肆","伍","陆","柒","捌","玖"};
                //    String[] jine=shuzi.Split('.');
                //    if(jine[0].Length==1)
                //    {                        
                        
                    
                //    }
                //    return str;
        
                //}





       
        public static int shoujuNo = 1006;
        public static int fapiaoNo = 1006;
        public int a = shoujuNo;
        public int b = fapiaoNo;
        private void showshouju(int i)
        {
            if(i==1)
            {               
                a = a + 1;
                this.txb_jiaokuanshoujuNo.Text = "S0"+a.ToString();
            }
            else if (i == 0)
            {               
                b = b + 1;
                this.txb_fapiaoNo.Text = "F0" + b.ToString();
            }
            
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            showshouju(1);
            txb_jiaokuanmoney.Text = "";
            this.txb_jiaokuanmoneyb.Text = "";

        }
        private void tsbut_check_Click_1(object sender, EventArgs e)
        {
            if (txb_jiaokuanzuNo.Text.Trim() == "")
            {

                MessageBox.Show("请输入住院号？");
                return;
            }
            int i = look("select count(1) from tb_base b join tb_hosbase h on b.menNo=h.menNo join tb_keshi k on h.keshiNo=k.keshiNo join tb_area a on h.areaNo=a.No where h.zuNo=@canshu;", this.txb_jiaokuanzuNo.Text.Trim());
            if (i !=1)
            {
                MessageBox.Show("该住院号不存在或者该住院号不存在");
                return;
            }
            pa_jiaokuan.Enabled = true;
            sqlcommand = opensql();
            sqlcommand.CommandText =
                "select * from tb_base b join tb_hosbase h on b.menNo=h.menNo join tb_keshi k on h.keshiNo=k.keshiNo join tb_area a on h.areaNo=a.No where h.zuNo=@zuNo;";
            sqlcommand.Parameters.AddWithValue("@zuNo", this.txb_jiaokuanzuNo.Text.Trim());
            sqlconnection.Open();
            SqlDataReader datareader = sqlcommand.ExecuteReader();
            if (datareader.Read())
            {
                this.txb_jiaokuanmenNo.Text = datareader["menNo"].ToString();
                this.txb_jiaokuanarea.Text = datareader["name"].ToString();
                this.txb_jiaokuankeshi.Text = datareader["keshiname"].ToString();
                this.txb_jiaokuanname.Text = datareader["paname"].ToString();
                this.txb_jiaokuanpastyle.Text = datareader["pastyle"].ToString();                            

            }
            sqlconnection.Close();
            showdgv(this.txb_jiaokuanzuNo.Text.Trim(), this.dgv_jiaokuan);        
            showshouju(1);


        }
        private void cmb_jiaokuanway_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.cmb_jiaokuanway.SelectedValue.Equals(1))
            {

                lb_startdanwei.Visible = true;
            }
            else
            {
                lb_startdanwei.Visible = false;
            }
        }
        private void but_jiaokuanok_Click_1(object sender, EventArgs e)
        {
            DataRow addrow = this.dashouju.NewRow();
            addrow["shoujuNo"] = this.txb_jiaokuanshoujuNo.Text.Trim();
            addrow["zuNo"] = this.txb_jiaokuanzuNo.Text.Trim();
            addrow["wherework"] = this.txb_jiaokuandanwei.Text.Trim();
            addrow["shoujumoney"] = this.txb_jiaokuanmoney.Text.Trim();  
            addrow["paystyle"] = this.cmb_jiaokuanpaystyle.Text.Trim();
            addrow["payway"] = this.cmb_jiaokuanway.Text.Trim();
            addrow["paytime"] = this.tsl_jiaokuantime.Text.Trim();
            addrow["gonghaoNo"] = this.tstxb_jiaokuangonghaoNo.Text.Trim();
            addrow["bshoujumoney"] = this.txb_jiaokuanmoneyb.Text.Trim();
            this.dashouju.Rows.Add(addrow);
        }


        private void tsbut_jiaokuanbaocun_Click_1(object sender, EventArgs e)
        {
            sqlcommand = opensql();
            sqlcommand.CommandText =
                "insert tb_shouju(shoujuNo,zuNo,wherework,shoujumoney,paystyle,payway,paytime,gonghaoNo,bshoujumoney) values (@shoujuNo,@zuNo,@wherework,@shoujumoney,@paystyle,@payway,@paytime,@gonghaoNo,@bshoujumoney);";
            sqlcommand.Parameters.Add("@shoujuNo", SqlDbType.Char, 30, "shoujuNo");
            sqlcommand.Parameters.Add("@zuNo", SqlDbType.Char, 30, "zuNo");
            sqlcommand.Parameters.Add("@wherework", SqlDbType.VarChar, 0, "wherework");
            sqlcommand.Parameters.Add("@shoujumoney", SqlDbType.Char, 10, "shoujumoney");            
            sqlcommand.Parameters.Add("@paystyle", SqlDbType.VarChar, 0, "paystyle");
            sqlcommand.Parameters.Add("@payway", SqlDbType.VarChar, 0, "payway");
            sqlcommand.Parameters.Add("@paytime", SqlDbType.VarChar, 0, "paytime");
            sqlcommand.Parameters.Add("@gonghaoNo", SqlDbType.Char, 10, "gonghaoNo");
            sqlcommand.Parameters.Add("bshoujumoney", SqlDbType.VarChar, 0, "bshoujumoney");
            SqlDataAdapter adinsert = new SqlDataAdapter();
            sqlconnection.Open();
            adinsert.InsertCommand = sqlcommand;
            int affect = adinsert.Update(this.dashouju);
            sqlconnection.Close();
            if (affect != 1)
            {
                MessageBox.Show("保存失败，请核对数据");
                return;
            }
            else
            {
                MessageBox.Show("保存成功");
                shoujuNo = a;
                return;
            }

        }

        private void but_jiaokuandelete_Click_1(object sender, EventArgs e)
        {
            if (this.dgv_jiaokuan.RowCount > 0)
            {
                DataRow selectedcurrent = ((DataRowView)this.dgv_jiaokuan.CurrentRow.DataBoundItem).Row;
                if (selectedcurrent.RowState == DataRowState.Unchanged)
                {
                    MessageBox.Show("该行不允许删除操作，删除失败");
                    return;
                }
                else
                {
                    this.dashouju.Rows.Remove(selectedcurrent);
                    return;
                }
            }
            else
            {
                MessageBox.Show("此操作无效");
                return;
            }

        }
        private void tsbut_clear_Click_1(object sender, EventArgs e)
        {
            this.txb_jiaokuanarea.Text = "";
            this.txb_jiaokuandanwei.Text = "";
            this.txb_jiaokuankeshi.Text = "";
            this.txb_jiaokuanmenNo.Text = "";
            this.txb_jiaokuanmoney.Text = "";
            this.txb_jiaokuanmoneyb.Text = "";
            this.txb_jiaokuanname.Text = "";
            this.txb_jiaokuanpastyle.Text = "";
            this.txb_jiaokuanshoujuNo.Text = "";
            this.txb_jiaokuanzuNo.Text = "";
            this.cmb_jiaokuanpaystyle.SelectedValue = 2;
            this.cmb_jiaokuanway.SelectedValue = 2;
        }




        ////出院处理
        ////视图showdgv(1,2,3)
        float total;
        private void showdgv(String sql, String canshu, DataGridView dgv,int i)
        {
            DataTable shuju = new DataTable();//采用内部变量，当多次查询时，仍可以查询不同的数值，但当采用全局变量时，反复查询会有错误
            sqlcommand = opensql();
            sqlconnection.Open();
            sqlcommand.CommandText = sql;
            sqlcommand.Parameters.AddWithValue("@canshu", canshu);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlcommand;
            dataAdapter.Fill(shuju);
            sqlconnection.Close();
            dgv.Columns.Clear();
            dgv.DataSource = shuju;
            if (i == 1)
            {
                total = Convert.ToInt16(shuju.Compute("SUM(xiaoji)", ""));
                
            }            

        }
        private void dgvstart(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;


        }
        

        private void tsbut_chuyuancheck_Click_1(object sender, EventArgs e)
        {
            
            if (this.txb_menNo.Text == "" && this.txb_chuyuanzuNo.Text == "")
            {
                MessageBox.Show("请输入住院号或门诊号");
                return;
            }
            sqlcommand = opensql();
            if (this.txb_menNo.Text != "")
            {
                if (look("select count(1) from tb_hosbase h join tb_base b on b.menNo=h.menNo join tb_keshi k on h.keshiNo=k.keshiNo join tb_area a on a.No=h.areaNo where h.menNo=@canshu;", this.txb_menNo.Text.Trim()) != 1)
                {
                    MessageBox.Show("该门诊号不存在");
                    return;
                }
                sqlcommand.CommandText =
                    "select * from tb_hosbase h join tb_base b on b.menNo=h.menNo join tb_keshi k on h.keshiNo=k.keshiNo join tb_area a on a.No=h.areaNo where h.menNo=@menNo;";
                sqlcommand.Parameters.AddWithValue("@menNo", this.txb_menNo.Text.Trim());
            }
            if (this.txb_chuyuanzuNo.Text != "")
            {
                if (look("select count(1) from tb_hosbase h join tb_base b on b.menNo=h.menNo join tb_keshi k on h.keshiNo=k.keshiNo join tb_area a on a.No=h.areaNo where h.zuNo=@canshu;", this.txb_chuyuanzuNo.Text.Trim()) != 1)
                {
                    MessageBox.Show("该住院号不存在");
                    return;
                }
                sqlcommand.CommandText =
                    "select * from tb_hosbase h join tb_base b on b.menNo=h.menNo join tb_keshi k on h.keshiNo=k.keshiNo join tb_area a on a.No=h.areaNo where h.zuNo=@zuNo;";
                sqlcommand.Parameters.AddWithValue("@zuNo", this.txb_chuyuanzuNo.Text.Trim());
            }
            
            sqlconnection.Open();
            SqlDataReader datareader = sqlcommand.ExecuteReader();
            if (datareader.Read())
            {
                this.txb_chuyuanzuNo.Text = datareader["zuNo"].ToString();
                this.txb_menNo.Text = datareader["menNo"].ToString();
                this.txb_chuyuanname.Text = datareader["paname"].ToString();
                if (datareader["sex"].ToString() == " 1")
                {
                    this.txb_sex.Text = "男";
                }
                else
                {
                    this.txb_sex.Text = "女";
                }
                if (datareader["zhustate"].ToString() == "住院")
                {
                    this.rb_zhuyuan.Checked = true;
                }
                else
                {
                    this.rb_zhuanyuan.Checked = true;
                }
                this.txb_rudate.Text = datareader["rudate"].ToString();
                this.txb_startdate.Text = datareader["rudate"].ToString();
                this.txb_jistyle.Text = datareader["jistyle"].ToString();
                this.txb_area.Text = datareader["name"].ToString();
                this.txb_chuyuanbedNo.Text = datareader["keshiname"].ToString() + datareader["bedNo"].ToString();                              

            }
            sqlconnection.Close();
            showdgv(this.txb_chuyuanzuNo.Text.Trim(), this.dgv_finished);
            showdgv("select zuNo,a.shouNo,shouname,a.shuoliang,s.danjia,a.shuoliang*s.danjia as xiaoji,payorno from (select zuNo,shouNo,SUM(shuliang) shuoliang,payorno from tb_feiyong where zuNo=@canshu group by zuNo,shouNo,payorno) as a join tb_standart s on a.shouNo=s.shouNo;", this.txb_chuyuanzuNo.Text.Trim(), this.dgv_detail,1);
            this.dgv_detail.Columns["shouname"].HeaderText = "医疗项目";
            this.dgv_detail.Columns["shuoliang"].HeaderText = "数量";
            this.dgv_detail.Columns["danjia"].HeaderText = "单价";
            this.dgv_detail.Columns["xiaoji"].HeaderText = "金额(元)";
            this.dgv_detail.Columns["zuNo"].Visible = false;
            this.dgv_detail.Columns["shouNo"].Visible = false;
            this.dgv_detail.Columns["payorno"].Visible = true;
            dgvstart(this.dgv_detail);
            this.txb_chuyuanxiaoji.Text = total.ToString();
            showshouju(0);
            float yipay = 0;
            float weipay = 0;            
            foreach (DataGridViewRow r in this.dgv_detail.Rows)
            {

                if (r.Cells["payorno"].Value != null && r.Cells["payorno"].Value.ToString() !="1")
                {
                    r.DefaultCellStyle.BackColor = Color.DarkOrange;
                    weipay += Convert.ToInt16(r.Cells["xiaoji"].Value);
                }
            }
           
            yipay = total - weipay;
            this.txb_yipay.Text = yipay.ToString();
            this.txb_nopay.Text = weipay.ToString();
            this.txb_yue.Text = (xiaoji1 - yipay).ToString();
            this.txb_total.Text = this.txb_chuyuanxiaoji.Text.Trim();
            this.txb_zipay.Text = this.txb_chuyuanxiaoji1.Text.Trim();
            this.txb_zipay.Text = this.txb_yipay.Text.Trim();
            this.txb_day.Text = (Convert.ToDateTime(this.txb_enddate.Text.Trim()) - Convert.ToDateTime(this.txb_startdate.Text.Trim())).ToString();
            

        }
        private void tsbut_chuyuandetail_Click(object sender, EventArgs e)
        {
            this.tstxb_detailzuNo.Text = this.txb_chuyuanzuNo.Text.Trim();
            tb_all.SelectedIndex = 3;           

   
        } 

        private void tsbut_chuyuanjisuan_Click(object sender, EventArgs e)
        {
            double yue,shoucrash=0,shouzhipiao=0,thispay,total;
           
            if (this.txb_nopay.Text.Trim() != "")
            {
                if (this.txb_baoxiao.Text.Trim() == "" && this.txb_jimoney.Text.Trim() == "")
                {
                    this.txb_thispay.Text = Convert.ToDouble(this.txb_nopay.Text.Trim()).ToString();
                }
                else if (this.txb_baoxiao.Text.Trim() != "")
                {
                    this.txb_thispay.Text = (Convert.ToDouble(this.txb_nopay.Text.Trim()) - Convert.ToDouble(this.txb_baoxiao.Text.Trim())).ToString();
                }
                else if (this.txb_jimoney.Text.Trim() != "")
                {
                    this.txb_thispay.Text = (Convert.ToDouble(this.txb_nopay.Text.Trim()) - Convert.ToDouble(this.txb_jimoney.Text.Trim())).ToString();
                }
                else if (this.txb_baoxiao.Text.Trim() != "" && this.txb_jistyle.Text.Trim() != "")
                {
                    this.txb_thispay.Text = (Convert.ToDouble(this.txb_nopay.Text.Trim()) - (Convert.ToDouble(this.txb_baoxiao.Text.Trim()) + Convert.ToDouble(this.txb_jimoney.Text.Trim()))).ToString();
                }
            }//用Convert时，要对转换的值进行非空值的排除 ，如果是空值无法装换。

            yue=Convert.ToDouble(this.txb_yue.Text.Trim()); 
            thispay=Convert.ToDouble(this.txb_thispay.Text.Trim());
            if(this.txb_shoucrash.Text.Trim()!="")
                shoucrash=Convert.ToDouble(this.txb_shoucrash.Text.Trim());
            if(this.txb_shouzhipiao.Text.Trim()!="")
                shouzhipiao=Convert.ToDouble(this.txb_shouzhipiao.Text .Trim());
            if (yue < thispay)
            {
                if (shoucrash <= 0 && shouzhipiao <= 0)
                {
                    MessageBox.Show("该账户余额不足");
                    return;
                }
                else
                {
                    if ((total = yue + shoucrash + shouzhipiao) >= thispay)
                    {
                        this.txb_tuixianjin.Text = (total - thispay).ToString();
                    }
                    else
                    {
                        MessageBox.Show("该账户余额 不足");
                        return;
                    }
                }
            }
            else
            {
                this.txb_tuixianjin.Text = ((yue - thispay) + shoucrash).ToString();
                this.txb_tuizhipiao.Text = shouzhipiao.ToString();
            }


                    
                    
            
            
                    

        }
        private void tsbut_chuyuanshuaxin_Click(object sender, EventArgs e)
        {
            showdgv(this.txb_chuyuanzuNo.Text.Trim(), this.dgv_finished);
            showdgv("select zuNo,a.shouNo,shouname,a.shuoliang,s.danjia,a.shuoliang*s.danjia as xiaoji from (select zuNo,shouNo,SUM(shuliang) shuoliang from tb_feiyong where zuNo=@canshu group by zuNo,shouNo) as a join tb_standart s on a.shouNo=s.shouNo;", this.txb_chuyuanzuNo.Text.Trim(), this.dgv_detail, 1);
            this.dgv_detail.Columns["shouname"].HeaderText = "医疗项目";
            this.dgv_detail.Columns["shuoliang"].HeaderText = "数量";
            this.dgv_detail.Columns["danjia"].HeaderText = "单价";
            this.dgv_detail.Columns["xiaoji"].HeaderText = "金额(元)";
            this.dgv_detail.Columns["zuNo"].Visible = false;
            this.dgv_detail.Columns["shouNo"].Visible = false;
            dgvstart(this.dgv_detail);
            this.txb_chuyuanxiaoji.Text = total.ToString() + "  元";
            showshouju(0);
            foreach (DataGridViewRow r in this.dgv_detail.Rows)
            {

                if (r.Cells["payorno"].Value != null && r.Cells["payorno"].Value.ToString() != "1")
                {
                    r.DefaultCellStyle.BackColor = Color.DarkOrange;                 
                }
            }
        }
        private void cb_chuyuan_CheckedChanged(object sender, EventArgs e)
        {            
                if (this.cb_jiezhang.Checked != true)
                {
                    
                    MessageBox.Show("该患者尚未结帐，请先结帐");
                    this.cb_chuyuan.Checked=false;
                    return;
                }
                else
                {
                    this.cb_chuyuan.Checked = true;
                    outorno = 1;
                }

        }
        
        int outorno=0, jiorno=0, tuiorno=0;
        public Boolean bl = false;
        private void tsbut_chuyuanbaocun_Click(object sender, EventArgs e)
        {
            String[] a = {this.txb_total.Text.Trim(), this.txb_zipay.Text.Trim(),this.txb_baoxiao.Text.Trim(),this.txb_jimoney.Text.Trim(),this.txb_shouzhipiao.Text.Trim(),this.txb_tuizhipiao.Text.Trim(),this.txb_shoucrash.Text.Trim(),this.txb_tuixianjin.Text.Trim(),this.txb_day.Text.Trim()};
            DialogResult result=MessageBox.Show("请核对结帐费用","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Frmjiezhanghedui hedui = new Frmjiezhanghedui(a);
                hedui.Owner = this;
                this.Visible = false;
                hedui.ShowDialog();
                this.Show();

            }
            else
            {
                bl = true;
            }
            if (!bl)
            {
                return;
            }
            if (look("select count(1) from tb_pay where zuNo=@canshu;", this.txb_chuyuanzuNo.Text.Trim()) == 1)
            {
                MessageBox.Show("该病人已出院，详情请查阅出院病人信息");
                return;
            }
                check("update tb_feiyong set payorno=1 where zuNo=@canshu;", this.txb_chuyuanzuNo.Text.Trim(), 1);
                sqlcommand = opensql();
                if (this.txb_chuyuanzuNo.Text.Trim() == "" || this.txb_menNo.Text.Trim() == "")
                {
                    MessageBox.Show("住院号与门诊号不可为空");
                    return;
                }
                sqlcommand.CommandText =
                    " insert tb_pay(zuNo,menNo,paydate,totalmoney,nopaymoney,baoxiaomoney,jizhangmoney,personpay,finallypay,shouzhipiao,tuizhipiao,shuocrash,tuicrash,outorno,fapiaoNo,gonghaoNo,fdanwei,jiorno,tuiorno) values(@zuNo,@menNo,@paydate,@totalmoney,@nopaymoney,@baoxiaomoney,@jizhangmoney,@personpay,@finallypay,@shouzhipiao,@tuizhipiao,@shuocrash,@tuicrash,@outorno,@fapiaoNo,@gonghaoNo,@fdanwei,@jiorno,@tuiorno); ";
                sqlcommand.Parameters.AddWithValue("@zuNo", this.txb_chuyuanzuNo.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@menNo", this.txb_menNo.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@paydate", this.txb_enddate.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@totalmoney", this.txb_total.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@nopaymoney", this.txb_nopay.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@baoxiaomoney", this.txb_baoxiao.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@jizhangmoney", this.txb_jimoney.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@personpay", this.txb_zipay.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@finallypay", this.txb_thispay.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@shouzhipiao", this.txb_shouzhipiao.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@tuizhipiao", this.txb_tuizhipiao.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@shuocrash", this.txb_shoucrash.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@tuicrash", this.txb_tuizhipiao.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@outorno", outorno);
                sqlcommand.Parameters.AddWithValue("@fapiaoNo", this.txb_fapiaoNo.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@gonghaoNo", this.tstxb_chuyuangonghaoNo.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@fdanwei", this.txb_fdanwei.Text.Trim());
                sqlcommand.Parameters.AddWithValue("@jiorno", jiorno);
                sqlcommand.Parameters.AddWithValue("@tuiorno", tuiorno);
                sqlconnection.Open();
                int affect = sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                if (affect != 0)
                {
                    MessageBox.Show("出院成功");
                    fapiaoNo = b;
                    return;
                }
                else
                {
                    MessageBox.Show("出院失败");
                    return;
                }
        }
        private void cb_jiezhang_CheckedChanged(object sender, EventArgs e)
        {          
            
                MessageBox.Show("结帐成功，请输入单位，以便发票打印");
                jiorno = 1;
                return;     

        }
        private void cb_tuikuan_CheckedChanged(object sender, EventArgs e)
        {
            tuiorno = 1;
            MessageBox.Show("请输入单位，以便发票打印");
            return;
        }



        ////费用明细查询 
        ////初始化
        public void detailstart()
        {
            this.gb_detail.Enabled = false;
            tsp_detail.Enabled = true;
            tsbut_detaildelete.Enabled = true;
         }
        private void tsbut_detailcheck_Click(object sender, EventArgs e)
        {
            if (this.tstxb_detailzuNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入住院号查询");
                return;
            }
            if (look("select COUNT(1) from tb_hosbase where zuNo=@canshu;", this.tstxb_detailzuNo.Text.Trim()) != 1)
            {
                MessageBox.Show("该住院号不存在，请重新输入");
                this.tstxb_detailzuNo.Text = "";
                this.tstxb_detailzuNo.Focus();
                return;
            }

            check("select paname,case sex when 0 then '女' else '男' end as sex,DATEDIFF(YEAR,birthdate,GETDATE()) as age from tb_base b join tb_hosbase h on b.menNo=h.menNo where h.zuNo=@canshu;", this.tstxb_detailzuNo.Text.Trim(),0);
            if (sqldatareader.Read())
            {
                this.txb_detailage.Text = sqldatareader["age"].ToString();
                this.txb_detailname.Text = sqldatareader["paname"].ToString();
                this.txb_detailsex.Text = sqldatareader["sex"].ToString();
                sqlconnection.Close();
                showdgv("select f.zuNo,f.No,f.shouNo,shouname,f.shuliang,danwei,danjia,shuliang*danjia as xiaoji,f.payorno  from tb_feiyong f join tb_standart s on f.shouNo=s.shouNo where f.zuNo=@canshu;", this.tstxb_detailzuNo.Text.Trim(), this.dgv_moredetail,1);
                dgvstart(this.dgv_moredetail);
                this.dgv_moredetail.Columns["shouNo"].HeaderText = "医疗项目编码";
                this.dgv_moredetail.Columns["shouname"].HeaderText = "医疗费用类型";
                this.dgv_moredetail.Columns["shuliang"].HeaderText = "数量";
                this.dgv_moredetail.Columns["danwei"].HeaderText = "单位";
                this.dgv_moredetail.Columns["danjia"].HeaderText = "单价";
                this.dgv_moredetail.Columns["xiaoji"].HeaderText = "小计";
                this.dgv_moredetail.Columns["No"].Visible = false;
                this.dgv_moredetail.Columns["zuNo"].Visible = false;
                this.dgv_moredetail.Columns["payorno"].HeaderText = "是否已付款";
                this.lb_xiaoji.Text = total.ToString();
            }
            this.tsbut_detaildelete.Enabled = true;
        }

        private void tsbut_chuyuandelete_Click(object sender, EventArgs e)
        {
           
            delete("delete from tb_feiyong where No=@canshu1 and zuNo=@canshu2;", this.dgv_moredetail.CurrentRow.Cells["No"].Value.ToString(), this.dgv_moredetail.CurrentRow.Cells["zuNo"].Value.ToString(),this.dgv_moredetail);
           
        }

        private void txb_nopay_TextChanged(object sender, EventArgs e)
        {

        }
        //查看出院病人消息
        private void but_check_Click(object sender, EventArgs e)
        {
            sqlcommand = opensql();
            sqlcommand.CommandText =
                "select * from tb_pay;";
            SqlDataAdapter sqlad = new SqlDataAdapter();
            sqlad.SelectCommand = sqlcommand;
            DataTable da = new DataTable();
            sqlconnection.Open();
            sqlad.Fill(da);
            sqlconnection.Close();
            this.dgv_chupa.DataSource = da;
            this.dgv_chupa.ReadOnly = true;
            this.dgv_chupa.Columns["zuNo"].HeaderText = "住院号";
            this.dgv_chupa.Columns["menNo"].HeaderText = "门诊号";
            this.dgv_chupa.Columns["paydate"].HeaderText = "结帐日期";
            this.dgv_chupa.Columns["totalmoney"].HeaderText = "总费用";
            this.dgv_chupa.Columns["nopaymoney"].HeaderText = "结帐前未付费用";
            this.dgv_chupa.Columns["baoxiaomoney"].HeaderText = "报销费用";
            this.dgv_chupa.Columns["jizhangmoney"].HeaderText = "记帐费用";
            this.dgv_chupa.Columns["personpay"].HeaderText = "自付费用";
            this.dgv_chupa.Columns["finallypay"].HeaderText = "本次结帐";
            this.dgv_chupa.Columns["shouzhipiao"].HeaderText = "实收支票";
            this.dgv_chupa.Columns["tuizhipiao"].HeaderText = "实退支票";
            this.dgv_chupa.Columns["shuocrash"].HeaderText = "已收现金";
            this.dgv_chupa.Columns["tuicrash"].HeaderText = "已退现金";
            this.dgv_chupa.Columns["outorno"].HeaderText = "是否出院";
            this.dgv_chupa.Columns["fapiaoNo"].HeaderText = "发票编码";
            this.dgv_chupa.Columns["gonghaoNo"].HeaderText = "结帐工号";
            this.dgv_chupa.Columns["fdanwei"].HeaderText = "发票单位";
            this.dgv_chupa.Columns["jiorno"].HeaderText = "是否结帐";
            this.dgv_chupa.Columns["tuiorno"].HeaderText = "是否退款";
        }

        private void tsbut_chuyuanprint_Click(object sender, EventArgs e)
        {
            String[] s = { this.txb_chuyuanname.Text.Trim(), this.txb_chuyuanbedNo.Text.Trim(), this.txb_chuyuanzuNo.Text.Trim(), this.txb_startdate.Text.Trim(), this.txb_enddate.Text.Trim(),this.txb_day.Text.Trim() };
            Frmjiezhangfapiao fapiao = new Frmjiezhangfapiao(s);
            this.Visible = false;
            fapiao.ShowDialog();
            this.Show();
        }

        private void but_chakan_Click(object sender, EventArgs e)
        {
            sqlcommand = opensql();
            sqlcommand.CommandText =
                "select * from tb_standart;";
            SqlDataAdapter sqlad = new SqlDataAdapter();
            sqlad.SelectCommand = sqlcommand;
            DataTable da = new DataTable();
            sqlconnection.Open();
            sqlad.Fill(da);
            sqlconnection.Close();
            this.dgv_standart.DataSource = da;
            this.dgv_standart.Columns["shouNo"].HeaderText="项目编码";
            this.dgv_standart.Columns["shouname"].HeaderText="项目名称";
            this.dgv_standart.Columns["danwei"].HeaderText="计价单位";
            this.dgv_standart.Columns["standart"].HeaderText="收费标准";
            this.dgv_standart.Columns["danjia"].HeaderText="单价";
         

        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            SqlCommand insert = opensql();
            insert.CommandText =
                "insert tb_standart(shouNo,shouname,danwei,standart,danjia) values(@shouNo,@shouname,@danwei,@standart,@danjia);";
            insert.Parameters.Add("@shouNo", SqlDbType.Char, 10, "shouNo");
            insert.Parameters.Add("@shouname", SqlDbType.VarChar, 0, "shouname");
            insert.Parameters.Add("@danwei", SqlDbType.VarChar, 0, "danwei");
            insert.Parameters.Add("@standart", SqlDbType.VarChar, 0, "standart");
            insert.Parameters.Add("@danjia", SqlDbType.Int, 10, "danjia");
            SqlCommand update = opensql();
            update.CommandText =
                "update tb_standart set shouNo=@shouNo,shouname=@shouname,danwei=@danwei,standart=@standart,danjia=@danjia where shouNo=@oldNo;";
            update.Parameters.Add("@shouNo", SqlDbType.Char, 10, "shouNo");
            update.Parameters.Add("@shouname", SqlDbType.VarChar, 0, "shouname");
            update.Parameters.Add("@danwei", SqlDbType.VarChar, 0, "danwei");
            update.Parameters.Add("@standart", SqlDbType.VarChar, 0, "standart");
            update.Parameters.Add("@danjia", SqlDbType.Int, 10, "danjia");
            update.Parameters.Add("@oldNo", SqlDbType.Char,10, "shouNo");
            update.Parameters["@oldNo"].SourceVersion = DataRowVersion.Original;
            SqlCommand delete = opensql();
            delete.CommandText =
                "delete from tb_standart where shouNo=@shouNo;";
            delete.Parameters.Add("@shouNo", SqlDbType.Char, 10, "shouNo");
            SqlDataAdapter sqlad = new SqlDataAdapter();
            DataTable da = (DataTable)this.dgv_standart.DataSource;            
            sqlad.InsertCommand = insert;
            sqlad.UpdateCommand = update;
            sqlad.DeleteCommand = delete;
            sqlconnection.Open();
            int row = sqlad.Update(da);
            MessageBox.Show("更新" + row + "行");

           
        }



     

    
    





  
    }
}
