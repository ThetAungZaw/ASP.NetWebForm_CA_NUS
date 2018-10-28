<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="SA46_Team01_BookShop.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <style>
     table {
    width: 80%;
}
 </style>
    <title></title>
     <h2 style="color:blue;">Admin : Add Book</h2> 
</head>
<body>
    <form id="form1" runat="server">
         <table><tr><td>
                <asp:Button ID="Homebtn1" runat="server" OnClick="Homebtn1_Click" Text="Home" CausesValidation="false" />
                <asp:Button ID="MemberListbtn1" runat="server" Text="Member List" CausesValidation="false" OnClick="MemberListbtn1_Click" />
                <asp:Button ID="Discountbtn1" runat="server" Text="Discount" CausesValidation="false" OnClick="Discountbtn1_Click" />
                <asp:Button ID="AddBook1" runat="server" Text="Add Book" CausesValidation="false" OnClick="AddBook1_Click" />
              
                <asp:Button ID="Logout1" runat="server" Text="Logout" OnClick="Logout_Click" CausesValidation="false"/>
              
                </td></tr></table>  
        <table border="0" id="book">
        <tr>
            <td>    
            <asp:Label ID="lblTitle" runat="server" Text="Book Title"></asp:Label>
            </td>  
            <td>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitle" runat="server" ErrorMessage="Title is Required" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
         </td>
        </tr>

        <tr>
            <td>
                 <asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAuthor" runat="server" ErrorMessage="Author Name is Required" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblISBN" runat="server" Text="ISBN"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidatorISBN" runat="server" ErrorMessage="ISBN is Required" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
            <tr>
                <td><asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label></td>
                <td><asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 51px" Width="264px">
            </asp:DropDownList></td>
                <td></td>
            </tr>

            <tr>
                <td><asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label></td>
                <td> <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox></td>
                <td> <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrice" runat="server" ErrorMessage="Price is Required" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Stock"></asp:Label></td>
                <td><asp:TextBox ID="TextBox5" runat="server" style="margin-left: 51px" Width="264px"></asp:TextBox></td>
                <td> <asp:RequiredFieldValidator ID="RequiredFieldValidatorStock" runat="server" ErrorMessage="Stock is Required" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr><td><asp:FileUpload ID="FileUpload1" runat="server" /></td></tr>
            <tr>
                <td colspan="3">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="AddBook"  />
                </td>
            </tr>
            
        </table>
        

<asp:Label ID="StatusLabel" runat="server" Text="Label"></asp:Label>

    </form>
</body>

</html>

