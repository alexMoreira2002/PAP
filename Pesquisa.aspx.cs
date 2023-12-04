using Funcoes_Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalTeste
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        BaseDados bd; 
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
        }

        protected void Pesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}