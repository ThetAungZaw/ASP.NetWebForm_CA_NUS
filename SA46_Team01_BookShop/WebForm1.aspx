<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SA46_Team01_BookShop.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><asp:Label ID="labelBookSummaries" runat="server" Text="Book Summaries" Font-Bold="True" Font-Size="16pt" ForeColor="#660033"></asp:Label></center>
            
            <asp:GridView ID="GridView1" runat="server" StyleSheet="table" 
                DataKeyNames ="BookId"
                AutoGenerateColumns="False" 
                OnRowDeleting="GridView1_RowDeleting" 
                
               
                
                OnRowDataBound="GridView1_RowDataBound" BackColor="#99CC00" ForeColor="#990000">
                <Columns>
                   <asp:BoundField DataField="UserId" ReadOnly="true" HeaderText="a" SortExpression="BookID" />
                     

                    <asp:TemplateField HeaderText="b" SortExpression="Author">
                        <EditItemTemplate>
                            <asp:Textbox ID="tbxAuthor" runat="server"></asp:Textbox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAuthor" runat="server" Text='<%# Bind("LineNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="c" SortExpression="ISBN">
                        <EditItemTemplate>
                            <asp:Textbox ID="tbxISBN" runat="server"></asp:Textbox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblISBN" runat="server" Text='<%# Bind("BookId") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="d" SortExpression="Stock">
                        <EditItemTemplate>
                            <asp:Textbox ID="tbxStock" runat="server"></asp:Textbox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblIStock" runat="server" Text='<%# Bind("LineAmount") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                  
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ItemStyle-Width="5%"/>
                </Columns>
            </asp:GridView>

            <br />

        </div>
    </form>
</body>
</html>
