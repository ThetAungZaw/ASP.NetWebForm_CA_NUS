<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CataloguePage.aspx.cs" Inherits="SA46Team01WNET.CataloguePage" MasterPageFile="~/Site2.Master" %>

<asp:Content ID="CataloguePage" ContentPlaceHolderID="MainContent" runat="server">

            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" colspan="3" Style="width: 900px; height: 80px;">
                    </asp:TableCell>
                </asp:TableRow>



                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Style="width: 300px; height: 240px;">
                        <asp:Table ID="Table2" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 160px;">
                                    <asp:ImageButton ID="Image1" runat="server" OnClick="Image1_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLName1" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLPrice1" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>

                    <asp:TableCell runat="server" Style="width: 300px; height: 240px;">
                        <asp:Table ID="Table3" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 160px;">
                                    <asp:ImageButton ID="Image2" runat="server" OnClick="Image2_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLName2" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLPrice2" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>

                    <asp:TableCell runat="server" Style="width: 300px; height: 240px;">
                        <asp:Table ID="Table4" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 160px;">
                                    <asp:ImageButton ID="Image3" runat="server" OnClick="Image3_Click"/>     
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLName3" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLPrice3" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>


                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Style="width: 300px; height: 240px;">
                        <asp:Table ID="Table5" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 160px;">
                                    <asp:ImageButton ID="Image4" runat="server" OnClick="Image4_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLName4" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLPrice4" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>

                    <asp:TableCell runat="server" Style="width: 300px; height: 240px;">
                        <asp:Table ID="Table6" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 160px;">
                                    <asp:ImageButton ID="Image5" runat="server" OnClick="Image5_Click"/>        
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLName5" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLPrice5" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>

                    <asp:TableCell runat="server" Style="width: 300px; height: 240px;">
                        <asp:Table ID="Table7" runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 160px;">
                                    <asp:ImageButton ID="Image6" runat="server" OnClick="Image6_Click"/>     
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLName6" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" Style="width: 300px; height: 40px;">
                                    <asp:Label ID="LBLPrice6" runat="server" Text="Label"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>


                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" colspan="3" Style="width: 900px; height: 40px;">
                        <asp:LinkButton ID="LinkButtonPrev" runat="server" Width="150px" OnClick="LinkButtonPrevious_Click">Previous</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton1" runat="server" Width="150px" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" Width="150px" OnClick="LinkButton2_Click">LinkButton</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" Width="150px" OnClick="LinkButton3_Click">LinkButton</asp:LinkButton>
                        <asp:LinkButton ID="LinkButtonNext" runat="server" Width="150px" OnClick="LinkButtonNext_Click">Next</asp:LinkButton>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>



</asp:Content>
