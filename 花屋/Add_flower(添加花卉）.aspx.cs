using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
       
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
        conn.Open();
        OleDbCommand acmd = new OleDbCommand();
        string sql ="Insert Into [flower] ([kind],[Name],[LifeStyle],[From],[Flolang]) Values ('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
        acmd.CommandText = sql;
        acmd.Connection = conn;


        int dd =(int) acmd.ExecuteNonQuery();


        if (dd == 1)
        {
            Label10.Text = "添加成功！";
            Response.Redirect("Add_flower(添加花卉）.aspx");

        }
        else
        {
            Label10.Text = "添加失败失败，请重试 ";
        }
        conn.Close();



    }
}
