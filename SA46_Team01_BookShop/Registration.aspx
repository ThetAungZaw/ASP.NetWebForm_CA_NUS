<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SA46_Team01_BookShop.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <h2  style="color:blue;"> Registration</h2>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        <table>
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="txtName" runat="server" style="margin-left: 150px" Height="29px"></asp:TextBox>
                </td>
                <td>
                     <asp:RequiredFieldValidator ID="lbl" runat="server" ErrorMessage="Name is Required" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                      <asp:TextBox ID="txtPass" runat="server" style="margin-left: 150px" Height="31px"></asp:TextBox>
                </td>
                <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password is Required" ControlToValidate="txtPass" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label3" runat="server" Text="Comfirm Password"></asp:Label>
                </td>
                <td>
                      <asp:TextBox ID="txtComfirmPass" runat="server" style="margin-left: 150px" Height="38px"></asp:TextBox>
                </td>
                <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Comfirm Password is Required" ControlToValidate="txtComfirmPass" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password and Comfirm Password not same" ControlToCompare="txtPass" ControlToValidate="txtComfirmPass"  ForeColor="Red"></asp:CompareValidator>
                
                </td>
            
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="txtAddress" runat="server" Height="29px" style="margin-left: 150px; margin-top: 0px"></asp:TextBox>
                </td>
                <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Address is Required" ControlToValidate="txtAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnRigister" runat="server" OnClick="btnRigister_Click" Text="Rigister" />
                </td>
            </tr>

        </table>
            </div>
       </form>
</body>
</html>
