using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funcoes_Aplicacao;

namespace PAP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
        } 

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.devolveconsulta("DELETE FROM T_Carrinho WHERE Id_Carrinho = " + int.Parse(GridView1.SelectedRow.Cells[0].Text) + "");
            Response.Redirect("Encomendas.aspx");
        }
    }
}