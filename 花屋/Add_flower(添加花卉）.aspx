<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Add_flower(添加花卉）.aspx.cs" Inherits="Default2" Title="无标题页" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style16
        {
            width: 800px;
        }
        .style18
        {
            height: 10px;
        }
        .style19
        {
            height: 89px;
        }
        .style20
        {
            height: 88px;
        }
        .style21
        {
            height: 80px;
        }
        .style22
        {
            height: 82px;
        }
        .style23
        {
            height: 91px;
        }
        .style24
        {
            height: 110px;
        }
        .style25
        {
            height: 10px;
            width: 360px;
        }
        .style26
        {
            height: 89px;
            width: 360px;
        }
        .style27
        {
            height: 88px;
            width: 360px;
        }
        .style28
        {
            height: 80px;
            width: 360px;
        }
        .style29
        {
            height: 82px;
            width: 360px;
        }
        .style30
        {
            height: 91px;
            width: 360px;
        }
        .style31
        {
            height: 110px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="background-image: url('image/32.jpg')">
    </p>
    <table class="style16" style="background-image: url('image/54210446b5445.jpg')">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="添加花卉" 
                    ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style25">
            </td>
            <td class="style18">
            </td>
        </tr>
        <tr>
            <td class="style26">
                <asp:Label ID="Label4" runat="server" Text="所属科属：" Font-Size="X-Large" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style19">
                <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style27">
                <asp:Label ID="Label5" runat="server" Text="花名： " Font-Size="X-Large" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style20">
                <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style28">
                <asp:Label ID="Label6" runat="server" Text="习性： " Font-Size="X-Large" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style21">
                <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style29">
                <asp:Label ID="Label7" runat="server" Text="产地： " Font-Size="X-Large" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style22">
                <asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style30">
                <asp:Label ID="Label8" runat="server" Text="花语： " Font-Size="X-Large" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style23">
                <asp:TextBox ID="TextBox6" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style31">
                <asp:Label ID="Label9" runat="server" Text="养护小知识： " Font-Size="X-Large" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style24">
                <asp:TextBox ID="TextBox7" runat="server" Height="30px" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style31" colspan="2">
                <asp:Label ID="Label10" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style31">
                <asp:Button ID="Button4" runat="server" Height="37px" Text="确认添加" 
                    Width="102px" onclick="Button4_Click" />
            </td>
            <td class="style31">
                <asp:Button ID="Button5" runat="server" Height="37px" Text="修改 " 
                    Width="102px" />
            </td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

