<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lesson1._1_HW.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-top: 0px;
            background-color:wheat;
        }
        .auto-style2 {
            width: 685px;
        }
        .auto-style3 {
            width: 685px;
            height: 40px;
        }
        .auto-style4 {
            width: 695px;
        }
        .auto-style5 {
            width: 695px;
            height: 40px;
        }
        .auto-style6 {
            width: 685px;
            height: 122px;
        }
        .auto-style7 {
            width: 695px;
            height: 122px;
        }
        .auto-style8 {
            width: 685px;
            height: 29px;
        }
        .auto-style9 {
            width: 695px;
            height: 29px;
        }
        .auto-style10 {
            height: 38px;
        }
        .auto-style11 {
            width: 685px;
            height: 26px;
        }
        .auto-style12 {
            width: 695px;
            height: 26px;
        }
    </style>
    </head>
<body style="height: 834px">
    <form id="form1" runat="server">
    <table border="1" class="auto-style1">
        <caption>
            用户注册</caption>
        <tr>
            <td class="auto-style6" rowspan="2">头像</td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="0">头像0</asp:ListItem>
                    <asp:ListItem Value="1">头像1</asp:ListItem>
                    <asp:ListItem Value="2">头像2</asp:ListItem>
                    <asp:ListItem Value="3">头像3</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Image ID="Image1" runat="server" Height="128px" ImageUrl="~/Image/image0.jpg" Width="128px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">用户名</td>
            <td class="auto-style4">
                <asp:TextBox ID="UserId_tbx" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserId_tbx" ErrorMessage="用户名不可以为空" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">密码</td>
            <td class="auto-style9">
                <asp:TextBox ID="Pwd1_tbx" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pwd1_tbx" ErrorMessage="密码不可为空" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">确认密码</td>
            <td class="auto-style4">
                <asp:TextBox ID="Pwd2_tbx" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Pwd1_tbx" ControlToValidate="Pwd2_tbx" ErrorMessage="密码不一致" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">姓名</td>
            <td class="auto-style4">
                <asp:TextBox ID="Name_tbx" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">性别</td>
            <td class="auto-style4">
                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="男" />
&nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="女" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">身高</td>
            <td class="auto-style4">
                <asp:TextBox ID="BodyL_tbx" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">出生日期</td>
            <td class="auto-style5">
                <asp:DropDownList ID="Years_ddl" runat="server" Height="25px" Width="123px">
                </asp:DropDownList>
                年<asp:DropDownList ID="Mounth_ddl" runat="server" Height="26px" Width="77px">
                </asp:DropDownList>
                月<asp:DropDownList ID="Date_ddl" runat="server" Height="24px" Width="77px">
                </asp:DropDownList>
                日</td>
        </tr>
        <tr>
            <td class="auto-style3">电话</td>
            <td class="auto-style5">
                <asp:TextBox ID="Phone_tbx" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">邮箱</td>
            <td class="auto-style5">
                <asp:TextBox ID="Mail_tbx" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">爱好</td>
            <td class="auto-style12">
                <asp:CheckBox ID="CheckBox3" runat="server" Text="音乐" />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="看书" />
                <asp:CheckBox ID="CheckBox5" runat="server" Text="电影" />
                <asp:CheckBox ID="CheckBox6" runat="server" Text="逛街" />
                <asp:CheckBox ID="CheckBox7" runat="server" Text="编码" />
            </td>
        </tr>
        <tr>
            <td class="auto-style10" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="注册" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="取消" />
&nbsp;&nbsp; </td>
        </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
