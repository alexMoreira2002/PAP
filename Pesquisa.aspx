<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="FinalTeste.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" BackColor="Silver" Text="Pesquisar Nome  " Height="30px"></asp:Label>
    <asp:TextBox ID="Pesquisa" runat="server" Width="240px" OnTextChanged="Pesquisa_TextChanged"></asp:TextBox>
    <br />
    <asp:DataList ID="DataList1" runat="server" DataKeyField="EAN" DataSourceID="SqlDataSource1" ForeColor="Black" RepeatColumns="3" CellPadding="75" BorderColor="Gray" BorderStyle="Solid" ShowHeader="False" BorderWidth="2px">
        <itemtemplate>
            Nome:
            <asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' />
            <br />
            <asp:Image ID="Image1" runat="server" Height="246px" ImageUrl='<%# Eval("EAN", "Fotos/{0}.jpg") %>' Width="234px" />
            <br />
            EAN:
            <asp:Label ID="EANLabel" runat="server" Text='<%# Eval("EAN") %>' />
            <br />
            Preco:
            <asp:Label ID="PrecoLabel" runat="server" Text='<%# Eval("Preco") %>' />$
            <br />
            Descricao:
            <asp:Label ID="DescricaoLabel" runat="server" Text='<%# Eval("Descricao") %>' />
            <br />
            <br />
                        <%if (Session["user"] != null)
                            { %>
            <br />
            <a href="addCarrinho.aspx?EAN=<%# Eval("EAN") %>">Adicionar ao carrinho(Work In Progress)</a>
            <%
                if (Session["Perfil"].ToString() == "1")
                { %>
            <br />
            <a href="RemoverProduct.aspx?EAN=<%# Eval("EAN") %>">Remover produto(Work In Progress)</a>
            <br />
            <a href="AtualizarProduct.aspx?EAN=<%# Eval("EAN") %>">Atualizar produto(Work In Progress)</a>
            <%}
                } %>
        </itemtemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [EAN], [Nome], [Preco], [Descricao] FROM [T_Produto] WHERE ([Nome] LIKE '%' + @Nome + '%')">
        <selectparameters>
            <asp:ControlParameter ControlID="Pesquisa" Name="Nome" PropertyName="Text" Type="String" />
        </selectparameters>
    </asp:SqlDataSource>
</asp:Content>

