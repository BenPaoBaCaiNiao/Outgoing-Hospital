<%@ Page Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="M_user(用户主页 ） .aspx.cs" Inherits="_Default" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 827px;
            height: 582px;
        }
        .style6
        {
            height: 125px;
        }
        .style7
        {
            height: 18px;
        }
        .style8
        {
            height: 116px;
        }
        .style9
        {
            height: 125px;
            width: 380px;
        }
        .style10
        {
            height: 18px;
            width: 380px;
        }
        .style11
        {
            height: 116px;
            width: 380px;
        }
        .style12
        {
            width: 380px;
        }
        .style16
    {
        height: 80px;
        width: 380px;
    }
    .style18
    {
        height: 80px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style5" bgcolor="#CCCCFF">
        <tr bgcolor="#CCCCFF">
            <td align="left" class="style16">
                </td>
            <td class="style18" bgcolor="#FFCC66">
                </td>
            <td class="style18" align="right">
                </td>
        </tr>
        <tr>
            <td align="center" class="style9">
                <asp:Image ID="Image4" runat="server" Height="171px" 
                    ImageUrl="~/image/8694a4c27d1ed21b2a22b7abae6eddc450da3f90.jpg" 
                    Width="206px" />
                <br />
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="X-Large" 
                    onclick="LinkButton3_Click"><a href="猴面小龙兰.aspx">猴面小龙兰</a></asp:LinkButton>
            </td>
            <td class="style6" bgcolor="#FFCC66">
                <br />
                <br />
            </td>
            <td class="style6" align="center">
                <asp:Image ID="Image5" runat="server" Height="161px" 
                    ImageUrl="~/image/t01ec8563fb00f5078d.jpg" Width="220px" />
                <br />
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Size="X-Large">郁金香</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="left" class="style10" bgcolor="#FFCC66">
                </td>
            <td class="style7" bgcolor="#FFCC66">
                </td>
            <td class="style7" bgcolor="#FFCC66">
                </td>
        </tr>
        <tr>
            <td align="center" class="style11">
                <asp:Image ID="Image6" runat="server" Height="212px" 
                    ImageUrl="~/image/6536197.jpg" Width="218px" />
                <br />
                <asp:LinkButton ID="LinkButton5" runat="server" Font-Size="X-Large" 
                    onclick="LinkButton5_Click">白蔷薇</asp:LinkButton>
            </td>
            <td class="style8" bgcolor="#FFCC66">
                &nbsp;</td>
            <td class="style8" align="center">
                <asp:Image ID="Image7" runat="server" Height="182px" 
                    ImageUrl="~/image/22480380.jpg" Width="221px" />
                <br />
                <asp:LinkButton ID="LinkButton6" runat="server" Font-Size="X-Large"><a href="白芍药 .aspx" >白芍药</a> 
                </asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

