<%@ Page Title="" Language="C#" MasterPageFile="~/M1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebApplication2.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="wwwroot/CSS/StyleForPageFrame.css" />
    <style>
        .fadeIn {
            display: -webkit-flex;
            display: flex;
            -webkit-align-items: center;
            justify-items: center;
            width: 320px;
            height: 300px;
            background-color: gainsboro;
            border: darkgray;
            border-style: inset;
            border-radius: 20px;
        }

        .TextBox1 {
            width: 320px;
            height: 45px;
            display: -webkit-flex;
            display: flex;
            -webkit-align-items: center;
            justify-items: center;
        }

        .Box1 {
            width: 320px;
            height: 300px;
            margin: auto;
            display: -webkit-flex;
            display: flex;
            -webkit-flex-direction: column;
            flex-direction: column;
            width: 400px;
            height: 250px;
        }

        .Text {
            margin: auto;
        }
        .auto-style4 {
            margin-left: 23px;
        }
        .auto-style5 {
            margin-left: 13px;
        }
        .Psw2 {
            margin-left: 17px;
        }
        .Btn {
            margin-top: 20px;
        }
        .BackBtn {
            margin-left: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fadeIn">
        <div class="Box1" style="">
            <div style="width: 320px; height: 20px;">
                <asp:ImageButton ID="Back_btn" Height="20px" Width="30px" ImageUrl="wwwroot/RegisteredUI/Back0.png" OnMouseOver="src='wwwroot/RegisteredUI/Back1.png'" OnMouseOut="src='wwwroot/RegisteredUI/Back0.png'" runat="server" OnClick="Back_btn_Click" CssClass="BackBtn" title="返回登录"/>
            </div>
            <div style="width: 320px; height: 50px; position: center">
                <div style="text-align: center; top: 15px;">
                    <img src="wwwroot/RegisteredUI/head.png" height="30px" width="30px" />
                </div>
            </div>
            <div class="TextBox1" style="">
                <div class="Text">
                    <label style="margin-left:-10px">用户名</label>&nbsp;
                    <asp:TextBox runat="server" ID="Idname" Height="20px" CssClass="auto-style5"></asp:TextBox>
                </div>
            </div>
            <div class="TextBox1" style="">
                <div class="Text">
                    <label style="margin-left:15px">&nbsp;密码</label><asp:TextBox runat="server" ID="Psw1" Height="20px" CssClass="auto-style4" OnTextChanged="Psw1_TextChanged" TextMode="Password"></asp:TextBox>
                    <asp:Image runat="server" ID="Pw1" Width="10px" Height="10px"/>
                </div>
            </div>
            <div class="TextBox1" style="">
                <div class="Text">
                    <label style="margin-left: -11px">确认密码</label>
                    <asp:TextBox runat="server" ID="Psw2" Height="20px" CssClass="Psw2" OnTextChanged="Psw2_TextChanged" TextMode="Password"></asp:TextBox>
                    <asp:Image runat="server" ID="Pw2" Width="10px" Height="10px"/>
                </div>
            </div>
            <div class="TextBox1" style="height: 100px; width: 320px; text-align: center">
                <div class="Text">
                    <asp:ImageButton ID="ResignBtn" runat="server" Width="60px" Height="60px" CssClass="Btn" ImageUrl="wwwroot/RegisteredUI/Btn0.png" OnMouseOver="src='wwwroot/RegisteredUI/Btn1.png'" OnMouseOut="src='wwwroot/RegisteredUI/Btn0.png'" OnClick="ResignBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
