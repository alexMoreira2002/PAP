<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalTeste.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1188px;
        margin-left: 240px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-6"></div>
    <div class="col-sm-6">
        <div class="auto-style1">
            <asp:Label ID="lbl_email" runat="server" BackColor="#CCCCCC" Text="Email"></asp:Label>
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_pass" runat="server" BackColor="#CCCCCC" Text="Password"></asp:Label>
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="Login" />
        </div>
    </div>
</asp:Content>
