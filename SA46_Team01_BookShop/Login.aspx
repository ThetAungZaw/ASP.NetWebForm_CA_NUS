<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SA46_Team01_BookShop.Login" MasterPageFile="~/Site2.Master"%>

<asp:Content ID="CataloguePage" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passowrd" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Login1" runat="server" Text="LogIn" OnClick="Login1_Click" />
    
<asp:Button ID="regBtn" runat="server" OnClick="regBtn_Click" Text="Register" />
    
</asp:Content>