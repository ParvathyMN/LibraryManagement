<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="LibraryManagementSystem.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="Book_Title" HeaderText="Book_Title" SortExpression="Book_Title" />
            <asp:BoundField DataField="Book_Author" HeaderText="Book_Author" SortExpression="Book_Author" />
            <asp:BoundField DataField="Book_Edition" HeaderText="Book_Edition" SortExpression="Book_Edition" />
            <asp:BoundField DataField="Book_ISBN" HeaderText="Book_ISBN" SortExpression="Book_ISBN" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Library_ManagementConnectionString10 %>" SelectCommand="SELECT User_Details.UserName,Book_Details.Book_Title, Book_Details.Book_Author, Book_Details.Book_Edition, Book_Details.Book_ISBN
FROM            Book_Details INNER JOIN
                         Order_Details ON Book_Details.BookId = Order_Details.BookId INNER JOIN
                         User_Details ON Order_Details.UserId = User_Details.UserId and (User_Details.UserName = @UserName) and (Order_Details.mode = 1)">
         <SelectParameters>
             <asp:SessionParameter Name="UserName" SessionField="Name" Type="String" />
         </SelectParameters>
    </asp:SqlDataSource>
<br />
<asp:Button ID="Button2" runat="server" Text="Confirm" OnClick="Button2_Click" />
</asp:Content>
