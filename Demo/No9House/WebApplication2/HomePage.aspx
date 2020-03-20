<%@ Page Title="" Language="C#" MasterPageFile="~/M1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication2.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Visible="false"></asp:SiteMapPath>
    </div>
    <div style="display: -webkit-flex; display: flex; -webkit-align-content: center; justify-content: center;">
        <div>
            <asp:ImageButton ID="GoNext" runat="server" Width="80px" Height="80px" OnMouseOver="this.src='wwwroot/NextImg/Next1.png'" OnMouseOut="this.src='wwwroot/NextImg/Next0.png'" OnClick="NextBtn_Click" ImageUrl="~/wwwroot/NextImg/Next0.png"/>
        </div>
    </div>
</asp:Content>
