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
public partial class 白芍药_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["flower"] = Label2.Text;
        Session.Timeout = 90;
        string messa="";
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data/db1.mdb"));
        OleDbCommand cmd = new OleDbCommand("select Number,Content from [tb_message(1)]", conn);
        conn.Open();
        cmd.Connection = conn;
        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            messa += dr["Number"] + "<br/>";
            messa += dr["Content"]+"<br/>";
        }
        Label1.Text = messa;

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
}
