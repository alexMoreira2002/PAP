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
    public partial class WebForm1 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            DataTable Login = bd.verificarlogin(txt_email.Text, txt_pass.Text);
            if (Login != null)
            {
                Session["NIF"] = Login.Rows[0][0].ToString();
                Session["user"] = Login.Rows[0][1].ToString();
                Session["Email"] = Login.Rows[0][2].ToString();
                Session["Cod_Postal"] = Login.Rows[0][4].ToString();
                Session["Perfil"] = Login.Rows[0][7].ToString();
                Response.Redirect("Inicial.aspx");
            }
        }
    }
}