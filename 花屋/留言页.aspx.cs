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

public partial class 留言页 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string str1=Session["name"].ToString();
        string str2=Session["flower"].ToString();
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
        conn.Open();
        OleDbCommand bcmd = new OleDbCommand();
        string sql = "Insert Into [message] ([Number],Content,[Name]) Values ('" + str1 + "','" + TextBox1.Text + "','"+ str2 +"')";
        bcmd.CommandText = sql;
        bcmd.Connection = conn;
        bool dd = true;
        try
        {
            bcmd.ExecuteNonQuery();
        }        
        catch
        {
            dd=false;
             Label4.Text = "留言失败，请重试 ";
            Response.Redirect(" 留言页.aspx");
        }
        finally
        {
            Label4.Text = "留言成功";
            Response.Redirect("留言页.aspx");
        }
        
           
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("M_user(用户主页 ） .aspx");
    }
}
