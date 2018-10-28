<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewDiscountPage.aspx.cs" Inherits="SA46_Team01_BookShop.NewDiscountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>  
              <table><tr><td>
                <asp:Button ID="Homebtn4" runat="server" OnClick="Homebtn4_Click" Text="Home" />
                <asp:Button ID="MemberListbtn4" runat="server" Text="Member List" OnClick="MemberListbtn4_Click" />
                <asp:Button ID="Discountbtn4" runat="server" Text="Discount" OnClick="Discountbtn4_Click" />
                <asp:Button ID="AddBook4" runat="server" Text="Add Book" OnClick="AddBook4_Click" />
                 <asp:Button ID="Logout4" runat="server" Text="Logout" OnClick="Logout_Click" />
                </td></tr></table>  
          <table border="0" id="Discount">
        <tr>
            <td>    
            <asp:Label ID="Promo" runat="server" Text="Promo Name"></asp:Label>
            </td>  
            <td>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox>
            </td>
            
        </tr>

        <tr>
            <td>
                 <asp:Label ID="DiscountRate" runat="server" Text="DiscountRate"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox>
            </td>
            
        </tr>     
              
        <tr>
            <td>
                 <asp:Label ID="StartDate" runat="server" Text="StartDate"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox>
            </td>
           
        </tr>        
              
        <tr>
            <td>
                 <asp:Label ID="EndDate" runat="server" Text="EndDate"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox>
            </td>
          
        </tr>        
        </table>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  />
              </div>  
    </form>
</body>
</html>
