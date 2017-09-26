﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="LibraryManagementSystem.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BookId" DataSourceID="SqlDataSource1" Width="805px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
    <Columns>

        <asp:BoundField DataField="Book_Title" HeaderText="Book_Title" SortExpression="Book_Title" />
        <asp:BoundField DataField="Book_Author" HeaderText="Book_Author" SortExpression="Book_Author" />
        <asp:BoundField DataField="Book_Edition" HeaderText="Book_Edition" SortExpression="Book_Edition" />
        <asp:BoundField DataField="Book_ISBN" HeaderText="Book_ISBN" SortExpression="Book_ISBN" />
        <asp:BoundField DataField="Book_AvailDate" HeaderText="Book_AvailDate" SortExpression="Book_AvailDate"  />
        <asp:BoundField DataField="Book_Amount" HeaderText="Book_Amount" SortExpression="Book_Amount" />
         <asp:TemplateField HeaderText="Rent">
                <ItemTemplate>
                    <asp:CheckBox ID="chkCtrl" runat="server" AutoPostBack="true"  />
                </ItemTemplate>
            </asp:TemplateField>
    </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_ManagementConnectionString3 %>" SelectCommand="SELECT * FROM [Book_Details]"></asp:SqlDataSource>
<p>
    <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
</p>
<asp:Label ID="Label2" runat="server"></asp:Label>
<p>
    &nbsp;</p>
</asp:Content>
