<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="A_messa(管理留言).aspx.cs" Inherits="Default2" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style16
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: 微软雅黑; font-size: xx-large">
        留言信息<br />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" DataKeyNames="Number" 
        DataSourceID="AccessDataSource1" Height="353px" Width="656px">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="Number" HeaderText="Number" 
                ReadOnly="True" SortExpression="Number" />
            <asp:BoundField DataField="Content" HeaderText="Content" 
                SortExpression="Content" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        ConflictDetection="CompareAllValues" DataFile="~/App_Data/1.mdb" 
        DeleteCommand="DELETE FROM [message] WHERE [Number] = ? AND [Name] = ? AND (([Content] = ?) OR ([Content] IS NULL AND ? IS NULL))" 
        InsertCommand="INSERT INTO [message] ([Name], [Content], [Number]) VALUES (?, ?, ?)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT [Name], [Content], [Number] FROM [message]" 
        
        
        UpdateCommand="UPDATE [message] SET [Name] = ?, [Content] = ? WHERE [Number] = ? AND [Name] = ? AND (([Content] = ?) OR ([Content] IS NULL AND ? IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_Number" Type="String" />
            <asp:Parameter Name="original_Name" Type="String" />
            <asp:Parameter Name="original_Content" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Content" Type="String" />
            <asp:Parameter Name="original_Number" Type="String" />
            <asp:Parameter Name="original_Name" Type="String" />
            <asp:Parameter Name="original_Content" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Content" Type="String" />
            <asp:Parameter Name="Number" Type="String" />
        </InsertParameters>
    </asp:AccessDataSource>
</p>
<table class="style16">
    <tr>
        <td align="center">
            <asp:Image ID="Image4" runat="server" Height="90px" 
                ImageUrl="~/image/t019dc989583d645690.jpg" Width="996px" />
        </td>
    </tr>
</table>
<p align="left">
    &nbsp;</p>
</asp:Content>

