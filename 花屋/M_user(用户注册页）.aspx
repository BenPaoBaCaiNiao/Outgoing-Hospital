<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="M_user(用户注册页）.aspx.cs" Inherits="Default2" Title="无标题页" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 800px;
            height: 50px;
        }
        .style5
        {
            height: 29px;
        }
        .style6
        {
        }
        .style8
        {
            width: 419px;
        }
        .style9
        {
            height: 168px;
        }
        .style10
        {
            width: 419px;
            height: 104px;
        }
        .style11
        {
            height: 104px;
        }
        .style12
        {
            width: 419px;
            height: 94px;
        }
        .style13
        {
            height: 94px;
        }
        .style14
        {
            width: 419px;
            height: 83px;
        }
        .style15
        {
            height: 83px;
        }
        .style16
        {
            width: 419px;
            height: 101px;
        }
        .style17
        {
            height: 101px;
        }
        .style18
        {
            width: 419px;
            height: 84px;
        }
        .style19
        {
            height: 84px;
        }
        .style20
        {
            height: 33px;
        }
        .style21
        {
            height: 46px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4" 
        style="font-family: 黑体; font-size: x-large; line-height: 50px; text-align: center; background-color: #FFFFFF; background-image: none;">
        <tr>
            <td class="style9" colspan="2">
                <asp:Label ID="Label23" runat="server" BackColor="Black" BorderColor="Black" 
                    Font-Size="XX-Large" ForeColor="White" Text="注册用户" Width="800px" 
                    Height="50px"></asp:Label>
                <br />
                <asp:Label ID="Label24" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="账号： "></asp:Label>
            </td>
            <td align="left" class="style11">
                <asp:TextBox ID="TextBox12" runat="server" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox12" ErrorMessage="RequiredFieldValidator" 
                    Font-Size="Small">请填写账号，可包含字母、数字、符号</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style12">
                <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="昵称："></asp:Label>
            </td>
            <td align="left" class="style13">
                <asp:TextBox ID="TextBox13" runat="server" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox13" ErrorMessage="RequiredFieldValidator" 
                    Font-Size="Small">请填写昵称，可包含字母等符号</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style14">
                <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="密码： "></asp:Label>
            </td>
            <td align="left" class="style15">
                <asp:TextBox ID="TextBox14" runat="server" Height="30px" Width="300px" TextMode="Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox14" ErrorMessage="请输入密码" Font-Size="Small"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style16">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="确认密码： "></asp:Label>
            </td>
            <td align="left" class="style17">
                <asp:TextBox ID="TextBox15" runat="server" Height="30px" Width="300px" TextMode="Password" ></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox14" ControlToValidate="TextBox15" 
                    ErrorMessage="CompareValidator" Font-Size="Small">请再次填写密码！</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="center" class="style8">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="性别： "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style5">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="287px">
                    <asp:ListItem>女</asp:ListItem>
                    <asp:ListItem>男 
                    </asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="style18">
                <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="日期： "></asp:Label>
            </td>
            <td align="left" class="style19">
                <asp:TextBox ID="TextBox21" runat="server" Width="89px"></asp:TextBox>
                <asp:Label ID="Label25" runat="server" Text="年"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="52px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label26" runat="server" Text="月"></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="61px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label27" runat="server" Text="日"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style16">
                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="喜欢的花卉： "></asp:Label>
            </td>
            <td align="left" class="style17">
                <asp:TextBox ID="TextBox20" runat="server" Height="30px" 
                    ontextchanged="TextBox20_TextChanged" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style20" colspan="2">
                <asp:Button ID="Button1" runat="server" BackColor="#FFCCFF" 
                    Font-Size="XX-Large" Height="50px" Text="注册 " Width="150px" 
                    onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="style19" colspan="2">
            </td>
        </tr>
        <tr>
            <td class="style6" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

