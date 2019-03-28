<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin(管理员登录).aspx.cs" Inherits="Admin_管理员登录_" Title="无标题页" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 536px;
        }
        .style6
        {
            width: 248px;
            height: 65px;
        }
        .style7
        {
            height: 65px;
        }
        .style8
        {
            width: 248px;
            height: 20px;
        }
        .style9
        {
            height: 20px;
        }
        .style10
        {
            height: 81px;
        }
        .style11
        {
            width: 248px;
            height: 32px;
        }
        .style12
        {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <br />
        <asp:Label ID="Label5" runat="server" BackColor="Black" Font-Size="X-Large" 
            ForeColor="White" Height="50px" style="margin-top: 0px" Text="管理员登录" 
            Width="800px"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <p align="left">
        &nbsp;</p>
    <table class="style4">
        <tr>
            <td class="style6">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="False" 
                    Font-Size="X-Large" Text="管理员账号： "></asp:Label>
            </td>
            <td align="center" class="style10">
                <asp:TextBox ID="TextBox3" runat="server" Height="32px" Width="322px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
            </td>
            <td class="style9">
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="登录密码： "></asp:Label>
            </td>
            <td align="center" class="style10">
                <asp:TextBox ID="TextBox4" runat="server" Height="32px" Width="322px" TextMode="Password" ></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td align="center" class="style12">
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="验证码： "></asp:Label>
            </td>
            <td align="center" class="style10">
                <asp:TextBox ID="TextBox5" runat="server" BackColor="Black" ForeColor="White" 
                    ontextchanged="TextBox5_TextChanged" Width="58px"></asp:TextBox>
                +<asp:TextBox ID="TextBox6" runat="server" BackColor="Black" ForeColor="White" 
                    Width="62px"></asp:TextBox>
                =<asp:TextBox ID="TextBox7" runat="server" Width="92px"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" BackColor="White" BorderStyle="None" 
                    Font-Size="Medium" Font-Underline="True" ForeColor="#66CCFF" 
                    onclick="Button2_Click" Text="看不清楚，换一个" Width="158px" />
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="Label9" runat="server" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="51px" Text="登录" Width="119px" 
            onclick="Button1_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

