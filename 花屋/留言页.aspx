<%@ Page Language="C#" AutoEventWireup="true" CodeFile="留言页.aspx.cs" Inherits="留言页" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style2
        {
            width: 840px;
            height: 678px;
        }
        .style4
        {
            width: 544px;
        }
        .style5
        {
            height: 278px;
        }
        .style6
        {
            height: 113px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table align="center" class="style2">
        <tr>
            <td class="style3" colspan="2">
                <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="~/image/33.jpg" 
                    Width="250px" />
            </td>
            <td align="center" bgcolor="#FFFFCC" class="style4" colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="依旧 "></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="依旧 "></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="静待花开 "></asp:Label>
            </td>
            <td>
                <asp:Image ID="Image3" runat="server" Height="200px" ImageUrl="~/image/34.jpg" 
                    Width="250px" />
            </td>
        </tr>
        <tr bgcolor="Black">
            <td align="center" class="style3">
                &nbsp;</td>
            <td class="style3" colspan="2">
                &nbsp;</td>
            <td class="style3" colspan="2">
                &nbsp;</td>
        </tr>
        <tr bgcolor="White">
            <td align="center" class="style3">
                &nbsp;</td>
            <td class="style3" colspan="2" align="center" 
                style="font-family: 华文中宋; font-size: xx-large">
                留言
            </td>
            <td class="style3" colspan="2">
                &nbsp;</td>
        </tr>
        <tr bgcolor="White">
            <td align="center" class="style3">
                请输入留言内容：</td>
            <td class="style3" colspan="2" align="center" 
                style="font-family: 华文中宋; font-size: xx-large">
                &nbsp;</td>
            <td class="style3" colspan="2">
                &nbsp;</td>
        </tr>
        <tr bgcolor="White">
            <td align="center" class="style5" colspan="5">
                <asp:TextBox ID="TextBox1" runat="server" Height="300px" Width="831px"></asp:TextBox>
            </td>
        </tr>
        <tr bgcolor="White">
            <td align="center" class="style6" colspan="5">
                <asp:Button ID="Button1" runat="server" Text="确认留言 " Width="130px" 
                    onclick="Button1_Click" />
                <asp:Label ID="Label4" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr bgcolor="White">
            <td align="right" class="style6" colspan="5">
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="X-Large" 
                    onclick="LinkButton1_Click">回主页 </asp:LinkButton>
            </td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
