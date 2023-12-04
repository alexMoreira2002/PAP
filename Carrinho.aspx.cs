using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funcoes_Aplicacao;

namespace FinalTeste
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
            Label1.Text = Session["NIF"].ToString();
            double total = 0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                total += double.Parse(GridView1.Rows[i].Cells[2].Text) * double.Parse(GridView1.Rows[i].Cells[1].Text);
            }
            Preco.Text = total.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            bd.devolveconsulta("UPDATE T_Carrinho SET Estado=1 WHERE NIF='" + Session["NIF"] + "'");
            Response.Redirect("Inicial.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}