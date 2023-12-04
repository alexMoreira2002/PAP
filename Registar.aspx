<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registar.aspx.cs" Inherits="FinalTeste.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 86px;
        }

        .auto-style2 {
            height: 85px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <table class="auto-style6" style="margin-left: 280px; font-size: x-large;">
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Nif</td>
            <td class="auto-style2" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtNif" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Nome</td>
            <td class="auto-style2" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Preencha o Nome!" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Email</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RegularExpressionValidator ID="valEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Incorreto!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Genero</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:DropDownList ID="cmbGender" runat="server">
                </asp:DropDownList>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Codigo Postal</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtCod_Postal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Telemovel</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtTelemovel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Password</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;"">Confirmar Password</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtPassConfirm" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="valPass0" runat="server" ControlToCompare="txtPass" ControlToValidate="txtPassConfirm" ErrorMessage="Password não coincide!" ForeColor="Red">*</asp:CompareValidator>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="aux" runat="server" Visible="false" Text="" />
    <asp:Button ID="Registar" class="btn btn-primary" style="font-size: x-large" runat="server" Text="Registar" OnClick="Registar_Click" />
    <br />
</asp:Content>
