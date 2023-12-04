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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            DataTable Tipo = bd.devolveconsulta("Select Distinct Tipo FROM T_Produto");
            if (ddl_tipo.Items.Count < Tipo.Rows.Count)
            {
                for (int i = 0; i < Tipo.Rows.Count; i++)
                {
                    ddl_tipo.Items.Add(Tipo.Rows[i][0].ToString());
                }
            }
        }
    }
}