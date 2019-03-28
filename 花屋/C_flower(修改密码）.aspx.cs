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
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label9.Text = Session["name"].ToString();
        Button3.Enabled = false;
        Button3.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
        int a = 0;
        OleDbConnection aconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
        OleDbCommand dcmd = new OleDbCommand("select * from [user] where Number='" +Label9.Text + "' and Password='"+TextBox1.Text+"'", aconn);
        aconn.Open();
        dcmd.Connection = aconn;
        OleDbDataReader dr = dcmd.ExecuteReader();
        if (dr.Read())
        {
            a = 1;
            

        }

        aconn.Close();
        if (a == 1)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
            conn.Open();
            OleDbCommand hcmd = new OleDbCommand();

            string Sql = "Update [user] Set [Password]='" + TextBox3.Text + "' where Number='" + Label9.Text + "'";
            hcmd.CommandText = Sql;
            hcmd.Connection = conn;




            int dd = (int)hcmd.ExecuteNonQuery();



            if (dd == 1)
            {
                Label8.Text = "修改成功 ，请登录 ";
                
            }
            else
            {
                Label8.Text = "修改失败，请重试 ";
            }
            conn.Close();
        }
        else
        {
            Label8.Text = "原密码错误,修改失败";

        }
        Button3.Enabled = true;
        Button3.Visible = true;
       
       
        


       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("User（用户登录）.aspx");
    }
}
