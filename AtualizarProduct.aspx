<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AtualizarProduct.aspx.cs" Inherits="FinalTeste.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6" style="margin-left: 280px; font-size: x-large;">
        <tr>
            <td class="auto-style4" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">EAN</td>
            <td class="auto-style5" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtEAN" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Nome</td>
            <td class="auto-style2" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style4" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Descricao</td>
            <td class="auto-style5" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" Height="90px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Preco</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtPreco" runat="server">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Estado</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Tipo</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="padding-left: 50px; padding-top: 50px; font-size: x-large;">Imagem</td>
            <td class="auto-style1" style="padding-right: 50px; padding-top: 50px">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
    </table>
        <br />
    <asp:Button ID="RegistarProduto" class="btn btn-light" runat="server" Text="Registar Produto" OnClick="RegistarProduto_Click" />
    <br />
</asp:Content>
