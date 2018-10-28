<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserOrderDetail.aspx.cs" Inherits="SA46_Team01_BookShop.UserOrderDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
             <table><tr><td>
                <asp:Button ID="Homebtn5" runat="server" OnClick="Homebtn5_Click" Text="Home" />
                <asp:Button ID="MemberListbtn5" runat="server" Text="Member List" OnClick="MemberListbtn5_Click" />
                <asp:Button ID="Discountbtn5" runat="server" Text="Discount" OnClick="Discountbtn5_Click" />
                <asp:Button ID="AddBook5" runat="server" Text="Add Book" OnClick="AddBook5_Click" />
                 l</td></tr></table>  
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
             <Columns>
                <asp:BoundField DataField="OrderId" HeaderText="OrderId" SortExpression="OrderId" />
                <asp:BoundField DataField="OrderLine" HeaderText="OrderLine" SortExpression="OrderLine" />
                <asp:BoundField DataField="BookID" HeaderText="BookId" SortExpression="BookId" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                 <asp:BoundField DataField="LineAmount" HeaderText="LineAmount" SortExpression="LineAmount" />
             </Columns>
        </asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="<<Back" OnClick="Button1_Click" />

   </div>
    </form>
</body>
</html>
