<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="SA46_Team01_BookShop.MemberList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 545px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
             <table><tr><td>
                <asp:Button ID="Homebtn3" runat="server" OnClick="Homebtn3_Click" Text="Home" />
                <asp:Button ID="MemberListbtn3" runat="server" Text="Member List" OnClick="MemberListbtn3_Click" />
                <asp:Button ID="Discountbtn3" runat="server" Text="Discount" OnClick="Discountbtn3_Click" />
                <asp:Button ID="AddBook3" runat="server" Text="Add Book" OnClick="AddBook3_Click" />
                 <asp:Button ID="Logout3" runat="server" Text="Logout" OnClick="Logout_Click" />
                </td></tr></table>  

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="919px"
                    OnRowDeleting="OnRowDeleting"                                
                     DataKeyNames="UserId" EnableViewState="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" >
                    <Columns>
                        <asp:TemplateField HeaderText="UserId" SortExpression="UserId">
                            <ItemTemplate>
                                <asp:Label ID="labe1" runat="server" Text='<%# Bind("UserId") %>'></asp:Label>
                            </ItemTemplate>
                             </asp:TemplateField>
                        <asp:TemplateField HeaderText="UserName" SortExpression="UserName">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                            </ItemTemplate>                            
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Address" SortExpression="Address">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                            </ItemTemplate>                          
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True"  />
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="OrderDetail"  />
                    </Columns> 
            </asp:GridView>

        </div>
    </form>
</body>
</html>
