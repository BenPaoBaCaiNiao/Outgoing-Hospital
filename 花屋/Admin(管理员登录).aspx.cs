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

public partial class Admin_管理员登录_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
        Random rn = new Random();
        int b = rn.Next(0, 100);
        int a = rn.Next(0,100);
        TextBox5.Text = b.ToString();
        TextBox6.Text = a.ToString();
        TextBox7.Text = "";


            }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
        OleDbCommand cmd = new OleDbCommand("select * from [Admin] where 账号='"+TextBox3.Text+"' and 密码='"+TextBox4.Text+"'", conn);
        conn.Open();
        cmd.Connection = conn;
        OleDbDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
       {
           
               Response.Redirect("M_Admin(管理员首页）.aspx");
           
            
       }
            
            else 
            {
                Label9.Text = "账号或密码错误,请重新登录";
              
            }
                          

        
        conn.Close();
        
        
        
        


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Random rn = new Random();
        int b = rn.Next(0, 100);
        int a = rn.Next(0, 100);
        TextBox5.Text = b.ToString();
        TextBox6.Text = a.ToString();
        TextBox7.Text = "";
       

    }
}
