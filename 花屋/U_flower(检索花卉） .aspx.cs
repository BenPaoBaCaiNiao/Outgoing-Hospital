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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "白芍药")
        {
            Response.Redirect("白芍药 .aspx");
        }
        else if (TextBox1.Text == "猴面小龙兰")
        {

            Response.Redirect("猴面小龙兰.aspx");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked || CheckBox5.Checked || RadioButtonList1.SelectedIndex==0)
        {
            Response.Redirect("白芍药 .aspx");
        }
        else if (CheckBox1.Checked || CheckBox2.Checked || CheckBox3.Checked || CheckBox4.Checked || CheckBox8.Checked || RadioButtonList1.SelectedIndex==2)
        {
            Response.Redirect("猴面小龙兰.aspx");
        }
        else
        {
            Label8.Text = "暂无花卉信息！！";
        }


    }
}
