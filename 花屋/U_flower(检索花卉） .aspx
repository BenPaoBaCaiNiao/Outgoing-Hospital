<%@ Page Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="U_flower(检索花卉） .aspx.cs" Inherits="_Default" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 833px;
        height: 122px;
    }
    .style7
    {
        height: 91px;
    }
    .style9
    {
        width: 100px;
        height: 72px;
    }
    .style10
    {
        height: 72px;
    }
    .style11
    {
        width: 100px;
        height: 75px;
    }
    .style12
    {
        height: 75px;
    }
    .style13
    {
        width: 100px;
        height: 28px;
    }
    .style14
    {
        height: 28px;
    }
    .style15
    {
        width: 100px;
        height: 31px;
    }
    .style16
    {
        height: 31px;
    }
    .style17
    {
        height: 91px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <table align="center" class="style5" 
        style="border-style: none; background-image: url('image/21(1).jpg'); table-layout: auto;">
        <tr>
            <td class="style9">
                <asp:Label ID="Label7" runat="server" Text="花名查找："></asp:Label>
            </td>
            <td class="style10" colspan="4">
                <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="439px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="GO " Width="84px" 
                    onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="style11">
                辅助查找： 
            </td>
            <td class="style12" colspan="4" style="border-style: none">
            </td>
        </tr>
        <tr>
            <td class="style13">
                <asp:Label ID="Label4" runat="server" Text="花期： "></asp:Label>
            </td>
            <td class="style14">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="春季 " />
            </td>
            <td class="style14">
                <asp:CheckBox ID="CheckBox2" runat="server" Text="夏季" />
            </td>
            <td class="style14">
                <asp:CheckBox ID="CheckBox3" runat="server" Text="秋季" />
            </td>
            <td class="style14">
                <asp:CheckBox ID="CheckBox4" runat="server" Text="冬季" />
            </td>
        </tr>
        <tr>
            <td class="style15">
                <asp:Label ID="Label5" runat="server" Text="颜色："></asp:Label>
            </td>
            <td class="style16">
                <asp:CheckBox ID="CheckBox5" runat="server" Text="白色" />
            </td>
            <td class="style16">
                <asp:CheckBox ID="CheckBox6" runat="server" Text="红色" />
            </td>
            <td class="style16">
                <asp:CheckBox ID="CheckBox7" runat="server" Text="蓝色" />
            </td>
            <td class="style16">
                <asp:CheckBox ID="CheckBox8" runat="server" Text="橙色 " />
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="Label6" runat="server" Text="养活难易 ： "></asp:Label>
            </td>
            <td class="style17">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>容易养殖</asp:ListItem>
                    <asp:ListItem>留心养殖</asp:ListItem>
                    <asp:ListItem>精心养殖 
                    </asp:ListItem>
                    <asp:ListItem>专业养殖 
                    </asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style17">
                &nbsp;</td>
            <td class="style17">
                &nbsp;</td>
            <td class="style17">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7" colspan="4">
                <asp:Label ID="Label8" runat="server" Font-Size="XX-Large" 
                    Font-Underline="True" ForeColor="#FF3300"></asp:Label>
            </td>
            <td align="center" class="style17">
                <asp:Button ID="Button2" runat="server" BackColor="Black" Font-Size="X-Large" 
                    ForeColor="White" Height="50px" Text="查找 " Width="100px" 
                    onclick="Button2_Click" />
            </td>
        </tr>
    </table>
    <br />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

