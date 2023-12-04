<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrinho.aspx.cs" Inherits="FinalTeste.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" visible="false" Text='' />
    <asp:Label ID="Label2" runat="server" visible="false" Text='' />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Carrinho" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id_Carrinho" HeaderText="Id_Item" InsertVisible="False" ReadOnly="True" SortExpression="Id_Item" />
            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" SortExpression="Quantidade" />
            <asp:BoundField DataField="Preco" HeaderText="Preco" SortExpression="Preco" />
            <asp:BoundField DataField="Data_carrinho" HeaderText="Data_carrinho" SortExpression="Data_carrinho" />
            <asp:BoundField DataField="NIF" HeaderText="NIF" SortExpression="NIF" />
            <asp:CheckBoxField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Cod_Postal" HeaderText="Cod_Postal" SortExpression="Cod_Postal" />
            <asp:BoundField DataField="EAN" HeaderText="EAN" SortExpression="EAN" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Carrinho] WHERE [Estado] = 0">
    </asp:SqlDataSource>
    </br>

    <asp:Label ID="Total" runat="server" Text="Preço final:   " />
    <asp:Label ID="Preco" runat="server" Text="" />
    <br />
    <br />
    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar Compra" type="button" class="btn btn-primary" OnClick="btnAdd_Click" />

</asp:Content>
