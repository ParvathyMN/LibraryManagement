<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibraryManagementSystem.Home" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        height: 199px;
    }
        .auto-style2 {
            width: 141px;
    }
        #d1{
            margin-left:400px;
            width:400px;
            height:400px;

           }
        .auto-style3 {
            width: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="d1" class="auto-style3">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="UserName" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="UserName is required!" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is required!" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" BackColor="#669999" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#669999" />
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        </table>
    

     <a style="color:black;resize:both;" href="Register.aspx" ><h3>New user ? Register here !!!</a>
            </div>
</asp:Content>
