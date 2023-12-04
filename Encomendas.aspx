 <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Encomendas.aspx.cs" Inherits="PAP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Preco" runat="server" Text="teste" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Carrinho" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id_Carrinho" HeaderText="Id_Carrinho" InsertVisible="False" ReadOnly="True" SortExpression="Id_Carrinho" />
            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" SortExpression="Quantidade" />
            <asp:BoundField DataField="Preco" HeaderText="Preco" SortExpression="Preco" />
            <asp:BoundField DataField="Data_carrinho" HeaderText="Data_carrinho" SortExpression="Data_carrinho" />
            <asp:BoundField DataField="NIF" HeaderText="NIF" SortExpression="NIF" />
            <asp:CheckBoxField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Cod_Postal" HeaderText="Cod_Postal" SortExpression="Cod_Postal" />
            <asp:BoundField DataField="EAN" HeaderText="EAN" SortExpression="EAN" />
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Entrega Feita" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Carrinho] WHERE [Estado] = 1"></asp:SqlDataSource>
    </asp:Content>