using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funcoes_Aplicacao;

namespace FinalTeste
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();

            Label1.Text = Request.QueryString["EAN"];
            Label2.Text = Session["NIF"].ToString();
            Label3.Text = Session["Cod_Postal"].ToString();
        }

        protected void Finalizar_click(object sender, EventArgs e)
        {
            bd.devolveconsulta("Insert INTO T_Carrinho (Quantidade,Preco,NIF, Data_carrinho, Cod_Postal, EAN) values("+int.Parse(txtQuantidade.Text)+",(SELECT Preco FROM T_Produto WHERE EAN='" + Label1.Text + "'), " + Label2.Text + " , GETDATE(), '" + Label3.Text + "', " + Label1.Text + ")");
            Response.Redirect("Inicial.aspx");
        }
    }
}