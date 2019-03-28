<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="A_user(管理用户信息）.aspx.cs" Inherits="Default2" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: 微软雅黑; font-size: xx-large">
        用户信息<br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" DataFile="~/App_Data/1.mdb" 
            DeleteCommand="DELETE FROM [user] WHERE [Number] = ? AND [Name] = ? AND (([Sex] = ?) OR ([Sex] IS NULL AND ? IS NULL)) AND (([Date] = ?) OR ([Date] IS NULL AND ? IS NULL)) AND (([Work] = ?) OR ([Work] IS NULL AND ? IS NULL)) AND (([Flower] = ?) OR ([Flower] IS NULL AND ? IS NULL))" 
            InsertCommand="INSERT INTO [user] ([Number], [Name], [Sex], [Date], [Work], [Flower]) VALUES (?, ?, ?, ?, ?, ?)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT [Number], [Name], [Sex], [Date], [Work], [Flower] FROM [user]" 
            
            
            
            UpdateCommand="UPDATE [user] SET [Name] = ?, [Sex] = ?, [Date] = ?, [Work] = ?, [Flower] = ? WHERE [Number] = ? AND [Name] = ? AND (([Sex] = ?) OR ([Sex] IS NULL AND ? IS NULL)) AND (([Date] = ?) OR ([Date] IS NULL AND ? IS NULL)) AND (([Work] = ?) OR ([Work] IS NULL AND ? IS NULL)) AND (([Flower] = ?) OR ([Flower] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_Number" Type="String" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Sex" Type="String" />
                <asp:Parameter Name="original_Date" Type="DateTime" />
                <asp:Parameter Name="original_Work" Type="String" />
                <asp:Parameter Name="original_Flower" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Sex" Type="String" />
                <asp:Parameter Name="Date" Type="DateTime" />
                <asp:Parameter Name="Work" Type="String" />
                <asp:Parameter Name="Flower" Type="String" />
                <asp:Parameter Name="original_Number" Type="String" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Sex" Type="String" />
                <asp:Parameter Name="original_Date" Type="DateTime" />
                <asp:Parameter Name="original_Work" Type="String" />
                <asp:Parameter Name="original_Flower" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="Number" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Sex" Type="String" />
                <asp:Parameter Name="Date" Type="DateTime" />
                <asp:Parameter Name="Work" Type="String" />
                <asp:Parameter Name="Flower" Type="String" />
            </InsertParameters>
        </asp:AccessDataSource>
    </p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="Number" DataSourceID="AccessDataSource1" 
        Height="647px" Width="755px" BorderStyle="None" CellSpacing="2">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <Columns>
            <asp:BoundField DataField="Number" HeaderText="Number" 
                ReadOnly="True" SortExpression="Number" />
            <asp:BoundField DataField="Name" HeaderText="Name" 
                SortExpression="Name" />
            <asp:BoundField DataField="Sex" HeaderText="Sex" SortExpression="Sex" />
            <asp:BoundField DataField="Date" HeaderText="Date" 
                SortExpression="Date" />
            <asp:BoundField DataField="Work" HeaderText="Work" SortExpression="Work" />
            <asp:BoundField DataField="Flower" HeaderText="Flower" 
                SortExpression="Flower" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <p>
    </p>
</asp:Content>

