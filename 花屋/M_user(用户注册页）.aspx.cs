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
    protected void TextBox20_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string str1=TextBox21.Text+"年"+DropDownList2.SelectedValue +"月"+DropDownList3.SelectedValue +"日";
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/1.mdb"));
         conn.Open();
        OleDbCommand hcmd = new OleDbCommand(); 
       
        string Sql = "Insert Into [user] ([Number],[Name],[Password],[Sex],[Date],[Flower]) Values ('" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox15.Text + "','" + RadioButtonList1.SelectedValue + "','" + str1 + "','" + TextBox20.Text + "')";
        hcmd.CommandText = Sql;
        hcmd.Connection = conn;

     

        
       int dd=(int)hcmd.ExecuteNonQuery ();



       if (dd == 1)
       {
           Label24.Text = "注册成功 ，请登录 ";
           Response.Redirect("M_user(用户主页 ） .aspx");
       }
       else
       {
           Label24.Text = "注册失败 ，请重新登录 ";
       }
       conn.Close();
        
        
      
       

       
    }
}
