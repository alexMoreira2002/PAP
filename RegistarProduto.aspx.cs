using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;
using Funcoes_Aplicacao;

namespace FinalTeste
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
        }

        protected void RegistarProduto_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("/Fotos/ " + txtEAN.Text + ".jpg"));

            bd.inserirProduto( txtEAN.Text, txtNome.Text, txtDescricao.Text, double.Parse(txtPreco.Text), txtEsado.Text, txtTipo.Text);
            Response.Redirect("Inicial.aspx");
        }
    }
}