<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="LibraryManagementSystem.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
          #d5{
            margin:auto;
            width:1000px;
            color:blue;
          }
          </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="d5">
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
    <Columns>
        <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" visible="false"/>
         <asp:BoundField DataField="Book_Title" HeaderText="BookTitle" SortExpression="BookTitle" />
         <asp:BoundField DataField="Book_Author" HeaderText="BookAuthor" SortExpression="BookAuthor" />
         <asp:BoundField DataField="Book_Edition" HeaderText="BookEdition" SortExpression="BookEdition" />
         <asp:BoundField DataField="Book_ISBN" HeaderText="BookISBN" SortExpression="BookISBN" />


    </Columns>
</asp:GridView>
     
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_ManagementConnectionString5 %>" SelectCommand="SELECT User_Details.UserName,Book_Details.Book_Title, Book_Details.Book_Author, Book_Details.Book_Edition, Book_Details.Book_ISBN
FROM            Book_Details INNER JOIN
                         Order_Details ON Book_Details.BookId = Order_Details.BookId INNER JOIN
                         User_Details ON Order_Details.UserId = User_Details.UserId and (User_Details.UserName = @UserName)">
         <SelectParameters>
             <asp:SessionParameter Name="UserName" SessionField="Name" Type="String" />
         </SelectParameters>
     </asp:SqlDataSource>
           <a  style="color:black;resize:both;" href="User.aspx" ><h3>Do you wish to book more ???</h3></a>
     </div>
    </asp:Content>

