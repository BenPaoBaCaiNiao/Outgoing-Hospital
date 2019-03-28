using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("A_user(管理用户信息）.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("A_flower(管理花卉信息).aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("A_messa(管理留言).aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Index(首页）.aspx");
    }
}
