<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="A_flower(管理花卉信息).aspx.cs" Inherits="Default2" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: 微软雅黑; font-size: xx-large">
        &nbsp;花卉信息</p>
    <p style="height: 134px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="Name" DataSourceID="AccessDataSource1" 
            ForeColor="#333333" GridLines="None" Height="235px" Width="728px">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowSelectButton="True" />
                <asp:BoundField DataField="kind" HeaderText="kind" SortExpression="kind" />
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" 
                    SortExpression="Name" />
                <asp:BoundField DataField="LifeStyle" HeaderText="LifeStyle" 
                    SortExpression="LifeStyle" />
                <asp:BoundField DataField="From" HeaderText="From" SortExpression="From" />
                <asp:BoundField DataField="Flolang" HeaderText="Flolang" 
                    SortExpression="Flolang" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" DataFile="~/App_Data/1.mdb" 
            DeleteCommand="DELETE FROM [flower] WHERE [Name] = ? AND [kind] = ? AND (([LifeStyle] = ?) OR ([LifeStyle] IS NULL AND ? IS NULL)) AND (([From] = ?) OR ([From] IS NULL AND ? IS NULL)) AND (([Flolang] = ?) OR ([Flolang] IS NULL AND ? IS NULL))" 
            InsertCommand="INSERT INTO [flower] ([kind], [Name], [LifeStyle], [From], [Flolang]) VALUES (?, ?, ?, ?, ?)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [flower]" 
            
            
            UpdateCommand="UPDATE [flower] SET [kind] = ?, [LifeStyle] = ?, [From] = ?, [Flolang] = ? WHERE [Name] = ? AND [kind] = ? AND (([LifeStyle] = ?) OR ([LifeStyle] IS NULL AND ? IS NULL)) AND (([From] = ?) OR ([From] IS NULL AND ? IS NULL)) AND (([Flolang] = ?) OR ([Flolang] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_kind" Type="String" />
                <asp:Parameter Name="original_LifeStyle" Type="String" />
                <asp:Parameter Name="original_From" Type="String" />
                <asp:Parameter Name="original_Flolang" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="kind" Type="String" />
                <asp:Parameter Name="LifeStyle" Type="String" />
                <asp:Parameter Name="From" Type="String" />
                <asp:Parameter Name="Flolang" Type="String" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_kind" Type="String" />
                <asp:Parameter Name="original_LifeStyle" Type="String" />
                <asp:Parameter Name="original_From" Type="String" />
                <asp:Parameter Name="original_Flolang" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="kind" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="LifeStyle" Type="String" />
                <asp:Parameter Name="From" Type="String" />
                <asp:Parameter Name="Flolang" Type="String" />
            </InsertParameters>
        </asp:AccessDataSource>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        <asp:Button ID="Button4" runat="server" BackColor="#FF6600" Font-Size="X-Large" 
            Font-Underline="True" Text="添加花卉" Width="174px" onclick="Button4_Click" />
    </p>
    <p align="center">
        &nbsp;</p>
</asp:Content>

