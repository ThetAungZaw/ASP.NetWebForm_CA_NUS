<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="SA46_Team01_BookShop.BookDetails" MasterPageFile="~/Site2.Master"%>

<asp:Content ID="CataloguePage" ContentPlaceHolderID="MainContent" runat="server">
            <asp:Image ID="Image1" runat="server" Width="300px" />
    <br />
             <asp:Label ID="lblTitle" runat="server" Font-Bold="False" Font-Overline="False" Font-Size="Medium" Text="Title:"></asp:Label>
    <asp:Label ID="txtTitle" runat="server" Height="25px" Width="260px"></asp:Label>
    <br />
    <asp:Label ID="lblISBN" runat="server" Font-Bold="False" Font-Overline="False" Font-Size="Medium" Text="ISBN:"></asp:Label>
    <asp:Label ID="txtISBN" runat="server" Height="25px" Width="260px"></asp:Label>
    <br />
    <asp:Label ID="lblAuthor" runat="server" Font-Bold="False" Font-Overline="False" Font-Size="Medium" Text="Author:"></asp:Label>
    <asp:Label ID="txtAuthor" runat="server" Height="25px" Width="260px"></asp:Label>
    <br />
    <asp:Label ID="lblCat" runat="server" Font-Bold="False" Font-Overline="False" Font-Size="Medium" Text="Category:"></asp:Label>
    <asp:Label ID="txtCat" runat="server" Height="25px" Width="260px"></asp:Label>
    <br />
    <asp:Label ID="lblQuantity" runat="server" Font-Bold="False" Font-Overline="False" Font-Size="Medium" Text="Quantity:"></asp:Label>
    <asp:TextBox ID="txtQuantity" runat="server" Height="25px" Width="260px" ViewStateMode="Enabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtQuantity" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblPrice" runat="server" Font-Bold="False" Font-Overline="False" Font-Size="Medium" Text="Price"></asp:Label>
    <asp:Label ID="txtPrice" runat="server" Height="25px" Width="260px"></asp:Label>
<br />
<br />
<br />
<asp:Button ID="btnAddToCart" runat="server" Height="38px" Text="Add to Cart" Width="225px" OnClick="btnAddToCart_Click"  />
</asp:Content>