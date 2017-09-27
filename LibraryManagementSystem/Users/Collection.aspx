<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="LibraryManagementSystem.Collection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    #div1{
        margin:auto;
        
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="div1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BorderColor="Aqua" BorderStyle="Solid" Font-Size="Large">
    <Columns>
        <asp:BoundField DataField="Book_Title" HeaderText="Book_Title" SortExpression="Book_Title" />
        <asp:BoundField DataField="Book_Author" HeaderText="Book_Author" SortExpression="Book_Author" />
        <asp:BoundField DataField="Book_Edition" HeaderText="Book_Edition" SortExpression="Book_Edition" />
        <asp:BoundField DataField="Book_ISBN" HeaderText="Book_ISBN" SortExpression="Book_ISBN" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_ManagementConnectionString6 %>" SelectCommand="SELECT [Book_Title], [Book_Author], [Book_Edition], [Book_ISBN] FROM [Book_Details]"></asp:SqlDataSource>
<p>
</p>
        </div>
</asp:Content>
