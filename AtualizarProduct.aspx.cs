using Funcoes_Aplicacao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalTeste
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        BaseDados bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd = new BaseDados();
            if (txtEAN.Text == "" && txtNome.Text == "")
            {
                DataTable product = bd.devolveconsulta("SELECT * FROM T_Produto WHERE EAN = '" + Request.QueryString["EAN"] + "'");

                txtEAN.Text = product.Rows[0][0].ToString();
                txtNome.Text = product.Rows[0][1].ToString();
                txtDescricao.Text = product.Rows[0][2].ToString();
                txtPreco.Text = product.Rows[0][3].ToString();
                txtEstado.Text = product.Rows[0][4].ToString();
                txtTipo.Text = product.Rows[0][5].ToString();
            }
        }

        protected void RegistarProduto_Click(object sender, EventArgs e)
        {
            atualizarProduto(txtEAN.Text.ToString(), txtNome.Text.ToString(), txtDescricao.Text.ToString(), double.Parse(txtPreco.Text.ToString()), txtEstado.Text.ToString(), txtTipo.Text.ToString());

            Response.Redirect("Inicial.aspx");
        }

        public void atualizarProduto(string EAN, string Nome, string Descricao, double Preco, string Estado, string Tipo)
        {
            string sql = "UPDATE T_Produto SET EAN = @EAN, Nome = @Nome, Descricao = @Descricao, Preco = @Preco, Estado = @Estado, Tipo = @Tipo WHERE EAN = '" + Request.QueryString["EAN"] + "'";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@EAN",SqlDbType = SqlDbType.NVarChar,Value = EAN},
                new SqlParameter(){ParameterName="@Nome",SqlDbType = SqlDbType.NVarChar,Value = Nome},
                new SqlParameter(){ParameterName="@Descricao",SqlDbType = SqlDbType.NVarChar,Value = Descricao},
                new SqlParameter(){ParameterName="@Preco",SqlDbType=SqlDbType.Money,Value= Preco},
                new SqlParameter(){ParameterName="@Estado",SqlDbType=SqlDbType.NVarChar,Value= Estado},
                new SqlParameter(){ParameterName="@Tipo",SqlDbType=SqlDbType.NVarChar,Value= Tipo},
            };
            BaseDados.Instance.executa_SQL(sql, parametros);
        }
    }
}