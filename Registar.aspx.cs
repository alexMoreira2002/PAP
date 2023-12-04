using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funcoes_Aplicacao;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace FinalTeste
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] genero = { "Masculino", "Feminino", "Outro" };
            if (cmbGender.Items.Count < genero.Length)
            {
                for (int i = 0; i < genero.Length; i++)
                {
                    cmbGender.Items.Add(genero[i]);
                }
            }

            if (Session["Perfil"] != null)
            {
                if (Session["Perfil"].ToString() == "2")
                {
                    aux.Text = "1";
                }
            }
        }

        protected void Registar_Click(object sender, EventArgs e)
        {
            BaseDados.Instance.inserirUtilizador(txtNif.Text.ToString(),txtNome.Text.ToString(),txtEmail.Text.ToString(),cmbGender.SelectedValue.ToString(),txtCod_Postal.Text.ToString(),txtTelemovel.Text.ToString(),txtPass.ToString(),aux.Text.ToString());
            Response.Redirect("Login.aspx");
        }
    }
}