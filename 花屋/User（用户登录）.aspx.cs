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
        Random rn = new Random();
        int a = rn.Next(1000, 10000);
        Label10.Text = a.ToString();
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
        OleDbCommand cmd = new OleDbCommand("select * from [user] where Number='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "'", conn);
        conn.Open();
        cmd.Connection = conn;
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["name"] = TextBox4.Text;
            Session["secret"] = TextBox5.Text;
            Session.Timeout = 90;
            Response.Redirect("M_user(用户主页 ） .aspx");


        }

        else
        {
            Label11.Text = "账号或密码错误,请重新登录";

        }

      conn.Close();
        
       
        
    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Random rn = new Random();        
        int a = rn.Next(1000, 10000);
        Label10.Text = a.ToString();
        
    }
}
