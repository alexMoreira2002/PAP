using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funcoes_Aplicacao;
using System.Data;

namespace FinalTeste
{
    public partial class Inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*int aux = int.Parse(Request.QueryString["REF"]);
            DataTable Quant = BaseDados.Instance.devolveconsulta("Select Quantidade FROM Products WHERE REF = " + aux);
            if (int.Parse(Quant.Rows[0][0].ToString()) == 0)
            {

            } */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistarProduto.aspx");
        }
    }
}