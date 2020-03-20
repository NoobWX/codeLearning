<%@ Page Title="" Language="C#" MasterPageFile="~/M1.Master" AutoEventWireup="true" CodeBehind="CtrlForm.aspx.cs" Inherits="WebApplication2.CtrlForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="wwwroot/CSS/StyleForPageFrame.css" />
    <style>
        .TbPlace {
            display: -webkit-flex;
            display: flex;
            justify-content: center;
            -webkit-align-content: center;
        }

        .Box {
            border-radius: 10px;
            background-color: rgba(251,255,242,0.6);
            margin: auto;
            width: 800px;
            height: 400px;
        }

        .auto-style4 {
            overflow-y: scroll;
        }

        .HeadTextBox {
            text-align: center;
            display: table-cell;
            vertical-align: middle;
            border-width: 2px;
            width: 800px;
            height: 50px;
            border-style: ridge;
            border-top-left-radius: 10px;
            border-top-right-radius: 10px;
        }

        .HeadText {
            font-size: 25px;
            font-weight: 600;
            color: cadetblue;
            animation: myfirst 5s linear 2s infinite alternate;
            -webkit-animation: myfirst 5s linear 2s infinite alternate;
        }

        @keyframes myfirst {
            0% {
                color: cadetblue;
            }

            25% {
                color: blueviolet;
            }

            50% {
                color: antiquewhite;
            }

            75% {
                color: darkmagenta;
            }

            100% {
                color: cadetblue;
            }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fadeIn">
        <div class="Tbplace">
            <div class="Box">
                <div class="HeadTextBox">
                    <h2 class="HeadText">管理员操作页面</h2>
                </div>
                <div class="context">
                    <div class="left bar" style="width: 150px; height: 318px; display: inline-block; padding: 0;">
                        <div style="width: 150px; height: 25px; border-style: ridge; border-left-width: 2px; border-right-width: 2px; border-bottom: hidden; border-top: hidden;">
                            <asp:SiteMapPath ID="SitMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
                                <CurrentNodeStyle ForeColor="#333333" />
                                <NodeStyle Font-Bold="True" ForeColor="#7C6F57" />
                                <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
                                <RootNodeStyle Font-Bold="True" ForeColor="#5D7B9D" />
                            </asp:SiteMapPath>
                        </div>
                        <div style="overflow: hidden; width: 150px; border-style: ridge; height: 293px; border-width: 2px; border-bottom-left-radius: 10px;">
                            <asp:TreeView ID="NvaTree" runat="server" Height="295px" Font-Bold="True" ForeColor="#FFFFCC" NodeIndent="15" Width="150px" CssClass="auto-style4">
                                <Nodes>
                                    <asp:TreeNode Text="用户管理" Value="用户管理">
                                        <asp:TreeNode Text="用户添加" Value="添加用户"></asp:TreeNode>
                                        <asp:TreeNode Text="用户删除" Value="删除用户"></asp:TreeNode>
                                        <asp:TreeNode Text="用户查询" Value="查询用户"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="相册管理" Value="相册管理">
                                        <asp:TreeNode Text="相册添加" Value="相册添加"></asp:TreeNode>
                                        <asp:TreeNode Text="相册删除" Value="相册查询"></asp:TreeNode>
                                        <asp:TreeNode Text="相册查询" Value="相册删除"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="文章管理" Value="文章管理">
                                        <asp:TreeNode Text="文章添加" Value="文章添加"></asp:TreeNode>
                                        <asp:TreeNode Text="文章删除" Value="文章删除"></asp:TreeNode>
                                        <asp:TreeNode Text="文章查询" Value="文章查询"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="音乐管理" Value="音乐管理">
                                        <asp:TreeNode Text="音乐添加" Value="音乐添加"></asp:TreeNode>
                                        <asp:TreeNode Text="音乐删除" Value="音乐删除"></asp:TreeNode>
                                        <asp:TreeNode Text="音乐查询" Value="音乐插寻"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="订单管理" Value="订单管理">
                                        <asp:TreeNode Text="订单查询" Value="订单查询"></asp:TreeNode>
                                    </asp:TreeNode>
                                </Nodes>
                            </asp:TreeView>
                        </div>
                    </div>
                    <div class="gridview" style="width: 643px; height: 320px; border-style: ridge; border-right-width: 2px; border-left: hidden; border-top: hidden; display: inline-block; border-bottom-right-radius: 10px; padding: 0;">
                        
                        <asp:GridView ID="GridView1" runat="server" Height="135px" Width="641px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AllowPaging="True" PageSize="9" >
                            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                            <HeaderStyle BackColor="#4A3C8C" BorderStyle="Solid" Font-Bold="True" ForeColor="#E7E7FF" Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <PagerSettings Mode="NumericFirstLast" />
                            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle VerticalAlign="Middle" BackColor="#DEDFDE" BorderStyle="Solid" ForeColor="Black" Height="20px" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#594B9C" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#33276A" />
                        </asp:GridView>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
