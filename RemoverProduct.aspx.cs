using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funcoes_Aplicacao;
using System.IO;

namespace FinalTeste
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
            string EAN = Request.QueryString["EAN"];
            File.Delete(Server.MapPath("/Fotos/ " + EAN));
            bd.devolveconsulta("DELETE FROM T_Produto WHERE EAN = '" + EAN + "'");

            Response.Redirect("Inicial.aspx");
        }
    }
}