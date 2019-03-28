<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User（用户登录）.aspx.cs" Inherits="Default2" Title="无标题页" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
            height: 949px;
        }
        .style5
        {
            height: 71px;
        }
        .style6
        {
            height: 71px;
            width: 427px;
        }
        .style7
        {
            height: 165px;
    }
        .style10
        {
            width: 427px;
            height: 86px;
        }
        .style11
        {
            height: 86px;
        }
        .style15
    {
        height: 76px;
    }
    .style16
    {
        height: 60px;
        width: 427px;
    }
    .style17
    {
        height: 60px;
    }
    .style18
    {
        height: 74px;
    }
    .style19
    {
        height: 55px;
    }
    .style21
    {
        height: 70px;
        width: 427px;
    }
    .style22
    {
        height: 70px;
    }
    .style23
    {
        height: 93px;
    }
        .style24
        {
            height: 76px;
            width: 427px;
        }
        .style25
        {
            height: 74px;
            width: 427px;
        }
        .style26
        {
            height: 55px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 1px; width: 17px">
        &nbsp;</p>
    <table class="style4" bgcolor="White">
        <tr>
            <td class="style23" colspan="2" bgcolor="White">
                <asp:Label ID="Label5" runat="server" BackColor="Black" Font-Size="X-Large" 
                    ForeColor="White" Height="44px" Text="用户登录" Width="800px"></asp:Label>
            </td>
        </tr>
        <tr align="right">
            <td class="style6" align="center">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="用户账号： " Width="131px" ForeColor="Black"></asp:Label>
            </td>
            <td class="style5" align="left">
                <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style16">
            </td>
            <td class="style17">
            </td>
        </tr>
        <tr>
            <td class="style24" align="center">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="密码： " Width="150px" BackColor="White"></asp:Label>
            </td>
            <td class="style15">
                <asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="400px" TextMode="Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox5" ErrorMessage="请输入密码" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style21">
            </td>
            <td class="style22">
            </td>
        </tr>
        <tr>
            <td class="style10" align="right">
                </td>
            <td align="left" class="style11">
                <asp:Label ID="Label10" runat="server" Height="47px" Width="150px" 
                    BorderStyle="Groove" BackColor="White" Font-Size="XX-Large"></asp:Label>
                <asp:Button ID="Button2" runat="server" BackColor="White" BorderStyle="None" 
                    Font-Size="Medium" Font-Underline="True" ForeColor="#66FF66" 
                    onclick="Button2_Click" Text="看不清楚，换一个" />
            </td>
        </tr>
        <tr>
            <td class="style25" align="center">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="验证码：" Width="106px" BackColor="White"></asp:Label>
            </td>
            <td align="left" class="style18">
                <asp:TextBox ID="TextBox6" runat="server" Height="30px" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox6" ErrorMessage="请输入验证码 " Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style26" colspan="2">
                <asp:Label ID="Label11" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style15" colspan="2">
        <asp:Button ID="Button1" runat="server" BackColor="#FFCCFF" BorderColor="White" 
            EnableTheming="True" Height="50px" Text="登录" Width="100px" Font-Size="X-Large" 
                    ForeColor="Black" onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="style7" colspan="2">
            </td>
        </tr>
    </table>
    <p align="center">
    </p>
<p align="center">
    </p>
<p align="center">
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
<p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

