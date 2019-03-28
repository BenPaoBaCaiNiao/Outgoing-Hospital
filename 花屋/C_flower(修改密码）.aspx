<%@ Page Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="C_flower(修改密码）.aspx.cs" Inherits="_Default" Title="无标题页" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 840px;
        }
        .style7
        {
            height: 61px;
            width: 749px;
        }
        .style8
        {
            height: 81px;
            width: 749px;
        }
        .style9
        {
            height: 55px;
            width: 740px;
        }
        .style10
        {
            height: 61px;
            width: 740px;
        }
        .style11
        {
            height: 81px;
            width: 740px;
        }
        .style12
        {
            height: 101px;
        }
        .style13
        {
            height: 82px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style5" 
        style="background-image: url('image/10.jpg'); height: 529px;">
        <tr>
            <td align="center" class="style13" colspan="2">
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label4" runat="server" Font-Size="XX-Large" Text="修改密码 "></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style9">
                <asp:Label ID="Label5" runat="server" Text="旧密码 ："></asp:Label>
            </td>
            <td class="style7">
                <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style10">
                <asp:Label ID="Label6" runat="server" Text="新密码： "></asp:Label>
            </td>
            <td class="style7">
                <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style11">
                <asp:Label ID="Label7" runat="server" Font-Size="Large" Text="确认新密码："></asp:Label>
            </td>
            <td align="left" class="style8">
                <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="250px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" EnableTheming="False" 
                    ErrorMessage="请输入新密码 "></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="style11">
                &nbsp;</td>
            <td align="left" class="style8">
                <asp:Label ID="Label8" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" class="style12" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Font-Size="Large" Height="53px" 
                    Text="确定" Width="95px" onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Font-Size="Large" Height="50px" 
                    onclick="Button3_Click" Text="去登录" Width="100px" />
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>

