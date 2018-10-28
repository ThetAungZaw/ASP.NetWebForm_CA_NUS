<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Discountpage.aspx.cs" Inherits="SA46_Team01_BookShop.Discountpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <table><tr><td>
                <asp:Button ID="Homebtn2" runat="server" OnClick="Homebtn2_Click" Text="Home" />
                <asp:Button ID="MemberListbtn2" runat="server" Text="Member List" OnClick="MemberListbtn2_Click" />
                <asp:Button ID="Discountbtn2" runat="server" Text="Discount" OnClick="Discountbtn2_Click" />
                <asp:Button ID="AddBook2" runat="server" Text="Add Book" OnClick="AddBook2_Click" />
                 <asp:Button ID="Logout2" runat="server" Text="Logout" OnClick="Logout_Click" />
                
                </td></tr></table>  
            <asp:Button ID="New" runat="server" Text="New" OnClick="New_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="919px"
                OnRowDeleting="OnRowDeleting"
                OnRowEditing="OnRowEditing"
                OnRowCancelingEdit=" OnRowCancelingEdit"
                OnRowUpdating="OnRowUpdating"
                OnRowDataBound="GridView1_RowDataBound"
                DataKeyNames="DiscountId" EnableViewState="true">
                <Columns>
                    <asp:TemplateField HeaderText="DiscountId" SortExpression="DiscountId">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("DiscountId") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="PromoName" SortExpression="PromoName">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("PromoName") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("PromoName") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="StartDate" ItemStyle-Width="120px">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("StartDate", "{0:dd, MMM yyyy}") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="EndDate" ItemStyle-Width="120px">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("EndDate", "{0:dd, MMM yyyy}") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DiscountRate" SortExpression="DiscountRate">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("DiscountRate") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DiscountRate") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True"  ShowEditButton="true" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
