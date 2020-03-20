<%@ Page Title="" Language="C#" MasterPageFile="~/M1.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication2.FrontPage" StylesheetTheme="InPutSk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="wwwroot/CSS/StyleForPageFrame.css" />
    <style type="text/css">
        .auto-style4 {
            height: 40px;
        }

        .auto-style5 {
            width: 100%;
            height: 197px;
        }

        .auto-style6 {
            margin-top: 0;
        }

        .Box0 {
            display: -webkit-flex;
            display: flex;
            -webkit-flex-direction: column;
            flex-direction: column;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="fadeIn" style="width: 320px; height: 300px; background-color: gainsboro; border-radius: 20px; border-style: initial;">
        <div style="width: 320px; padding-left: 5px;">
            <asp:SiteMapPath ID="SitMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
                <CurrentNodeStyle ForeColor="#333333" />
                <NodeStyle Font-Bold="True" ForeColor="#7C6F57" />
                <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
                <RootNodeStyle Font-Bold="True" ForeColor="#5D7B9D" />
            </asp:SiteMapPath>
        </div>
        <div class="Box0">
            <div style="margin: auto;">
                <table class="auto-style5" style="padding-top: 20px">
                    <tr>
                        <td class="auto-style4" style="text-align: center;">
                            <asp:Image ID="Image3" runat="server" Height="40px" Width="40px" ImageUrl="wwwroot\LoginUI\用户头像.png" />
                            <br />
                            登录</td>
                    </tr>
                    <tr style="margin-top: 10px">
                        <td class="auto-style4" style="text-align: center;">
                            <asp:Image ID="Image1" runat="server" Height="35px" Width="40px" ImageUrl="wwwroot\LoginUI\用户名.png" ImageAlign="Top" />
                            &nbsp;
                    <asp:TextBox ID="UserID" runat="server" CssClass="auto-style6" Height="30px" Wrap="False" SkinID="new"></asp:TextBox>
                        </td>
                    </tr>
                    <tr style="margin-top: 10px">
                        <td style="text-align: center">
                            <asp:Image ID="Image2" runat="server" Height="35px" Width="40px" ImageUrl="wwwroot\LoginUI\密码.png" ImageAlign="Top" />
                            &nbsp;
                    <asp:TextBox ID="Password" runat="server" CssClass="auto-style6" Height="30px" TextMode="Password" SkinID="new"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="Box0" style="height: 100px; width: 320px;">
            <div style="  width: 320px; height: 30px; text-align: center">
                <asp:ImageButton ID="ImgBtn_btn" ImageUrl="wwwroot\LoginBtn\Login0.png" runat="server" OnClick="ImgBtn_Click" OnMouseOver="this.src='wwwroot/LoginBtn/Login1.png'" OnMouseOut="this.src='wwwroot/LoginBtn/Login0.png'" OnMouseClick="this.src='wwwroot/LoginBtn/Login2.png'" />
            </div>
            <div style="height: 30px; width: 320px; text-align: center; margin-top:10px">
                <asp:ImageButton ID="Resign_btn" Width="25px" Height="25px"  runat="server" ImageUrl="wwwroot/LoginBtn/Resign0.png" OnMouseOver="this.src='wwwroot/LoginBtn/Resign1.png'" OnMouseOut="this.src='wwwroot/LoginBtn/Resign0.png'" title="加入我们" OnClick="Resign_btn_Click"/>
            </div>

        </div>
    </div>

</asp:Content>


