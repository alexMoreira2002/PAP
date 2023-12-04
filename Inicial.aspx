<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="FinalTeste.Inicial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />

    <%if (Session["user"] != null && Session["Perfil"].ToString() == "2")
        { %>
    <asp:Button ID="btnAdd" runat="server" Text="Adicionar produto" type="button" class="btn btn-primary" OnClick="btnAdd_Click" />
    <% } %>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="EAN" DataSourceID="SqlDataSource1" ForeColor="Black" RepeatColumns="3" CellPadding="75" ShowHeader="False">
        <ItemTemplate>
            NOME:
            <asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' />
            <br />
            <asp:Image ID="Image1" runat="server" Height="246px" ImageUrl='<%# Eval("EAN", "Fotos/{0}.jpg") %>' Width="234px" />
            <br />
            <br />
            Descricao:
            <asp:Label ID="DescricaoLabel" runat="server" Text='<%# Eval("Descricao") %>' />
            <br />1
            Preco:
            <asp:Label ID="PrecoLabel" runat="server" Text='<%# Eval("Preco") %>' />$
            <br />
            Ean:
            <asp:Label ID="EANLabel1" runat="server" Text='<%# Eval("EAN") %>' />
            <br />
            <%if (Session["user"] != null)
            { %>
                <br />
                <a href="addCarrinho.aspx?EAN=<%# Eval("EAN")%>">Adicionar ao carrinho</a>
                <%
                    if (Session["Perfil"].ToString() == "2")
                    { %>
                    <br />
                    <a href="AtualizarProduct.aspx?EAN=<%# Eval("EAN") %>">Atualizar produto</a>
                    <br />
                    <a href="RemoverProduct.aspx?EAN=<%# Eval("EAN") %>">Remover produto</a>
                <%} %>
          <%} %>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [T_Produto]"></asp:SqlDataSource>
</asp:Content>
