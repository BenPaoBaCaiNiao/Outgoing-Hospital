<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="M_Admin(管理员首页）.aspx.cs" Inherits="Default2" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 983px;
    }
    .style7
    {
        height: 35px;
    }
    .style8
    {
        height: 15px;
    }
    .style9
    {
        height: 393px;
        width: 289px;
    }
    .style13
    {
        height: 393px;
    }
    .style14
    {
        height: 35px;
        width: 292px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style5">
    <tr bgcolor="#FFCCFF">
        <td class="style9">
            <br />
            <br />
            <asp:Image ID="Image4" runat="server" Height="327px" 
                ImageUrl="~/image/meigui.jpg" Width="364px" />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td class="style13">
            <asp:Label ID="Label4" runat="server" Font-Size="X-Large" 
                Text="玫瑰在植物分类学上是一种蔷薇科蔷薇属灌木(Rosa rugosa)，在日常生活中是蔷薇属一系列花大艳丽的栽培品种的统称，这些栽培品种亦可称做月季或蔷薇。" 
                Width="613px"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style8" colspan="2">
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
</table>
</asp:Content>

