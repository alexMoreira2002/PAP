<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addCarrinho.aspx.cs" Inherits="FinalTeste.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Qunatidade" runat="server" Text='Quantidade do produto: ' />
    <asp:TextBox ID="txtQuantidade" runat="server" TextMode="Number"></asp:TextBox> 
    <asp:Label ID="Label1" runat="server" visible="false" Text='' />
    <asp:Label ID="Label2" runat="server" visible="false" Text='' />
    <asp:Label ID="Label3" runat="server" visible="false" Text='' />
    <br />
    <br />
    <asp:Button ID="Finalizar" class="btn btn-light" runat="server" Text="Inicio" OnClick="Finalizar_click" />
</asp:Content>
