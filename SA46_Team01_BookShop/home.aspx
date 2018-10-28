<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="SA46_Team01_BookShop.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 913px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <table><tr><td>
                <asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" />
                <asp:Button ID="MemberListbtn" runat="server" Text="Member List" OnClick="MemberListbtn_Click" />
                <asp:Button ID="Discountbtn" runat="server" Text="Discount" OnClick="Discountbtn_Click" />
                <asp:Button ID="AddBook" runat="server" Text="Add Book" OnClick="AddBook_Click" />
                <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" align="Right" AppendDataBoundItems="true" AutoPostBack="True" Height="21px">
             
                            <asp:ListItem>Choose Category</asp:ListItem>
                        </asp:DropDownList>
                </td></tr></table>             
                                                                              
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="919px"
                            OnRowDeleting="OnRowDeleting"
                            OnRowEditing="OnRowEditing"
                            OnRowCancelingEdit=" OnRowCancelingEdit"
                            OnRowUpdating="OnRowUpdating"
                            OnRowDataBound="GridView1_RowDataBound"
                            DataKeyNames="BookId" BackColor="#CCFFCC" HorizontalAlign="Center">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <image src="images/<%# Eval("ISBN") %>.jpg" width="90" height="120"></image>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="BookId" SortExpression="ISBN">
                                    <ItemTemplate>
                                        <asp:Label ID="Labe6" runat="server" ItemStyle-Vertical="Center" Text='<%# Bind("BookId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Title" SortExpression="Title">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Title") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Author" SortExpression="Author">
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Author") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Author") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ISBN" SortExpression="ISBN">
                                    <ItemTemplate>
                                        <asp:Label ID="Labe3" runat="server" Text='<%# Bind("ISBN") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("ISBN") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Price" SortExpression="Price">
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                            </Columns>                          
                        </asp:GridView>
                     </div>
    </form>
</body>
</html>
