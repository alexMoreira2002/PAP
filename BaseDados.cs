using System;
using System.Collections.Generic;
using System.Configuration; // Livraria para aceder às configuração da Aplicação
using System.Data; // Livraria para trabalhar com BD
using System.Data.SqlClient; // Livraria para trabalhar com o SQLServer

namespace Funcoes_Aplicacao
{
    class BaseDados
    {

        private static BaseDados instance;
        public static BaseDados Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseDados();
                    return instance;
                }
                else
                {
                    return null;
                }
            }
        }

        #region Funções_Manipulacao_Dados

        string strLigacao;
        SqlConnection LigacaoBD;

        public BaseDados()
        {
            strLigacao = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            LigacaoBD = new SqlConnection(strLigacao);
            LigacaoBD.Open();
        }
        ~BaseDados()
        {
            try
            {
                LigacaoBD.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        // Método executar um script de SQL para Manipular/alterar Dados
        public void executa_SQL(string sql)
        {
            SqlCommand comando = new SqlCommand(); // Classe para executar um comando de SQL
            comando.CommandText = sql;
            comando.Connection = LigacaoBD; // Ligar o comando à Base de dados onde se vai executar o Script de SQL
            comando.ExecuteNonQuery(); // Executar o comando de SQL para alteração de dados.
            comando.Dispose(); // Libertar a variavel
                               // comando = null; -> APAGAR CONTEUDO DA VARIÁVEL
        }

        // Método executar um script de SQL com utilização de parmetros
        public void executa_SQL(string sql, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD); // Vincular o comando à Base de Dados
            comando.Parameters.AddRange(parametros.ToArray()); // Associar os parametros ao comando
            comando.ExecuteNonQuery(); // Executar o comando
            comando.Dispose();
        }

        // Iniciar a transação
        public SqlTransaction iniciar_transacao()
        {
            return LigacaoBD.BeginTransaction();
        }

        // Método executar um script de SQL com utilização de transação
        public void executa_SQL(string sql, List<SqlParameter> parametros, SqlTransaction transacao)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD); // Vincular o comando à Base de Dados
            comando.Parameters.AddRange(parametros.ToArray()); // Associar os parametros ao comando
            comando.Transaction = transacao;

            if (comando.ExecuteNonQuery() > 0)
            {
                transacao.Commit();
            }
            else
            {
                transacao.Rollback();
            }

            comando.Dispose();
        }

        // Método para executar uma consulta de SQL
        public DataTable devolveconsulta(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD);
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            comando.Dispose();
            return registos;

        }

        // Método para executar uma consulta de SQL com parametros
        public DataTable devolveconsulta(string sql, List<SqlParameter> param)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD);
            comando.Parameters.AddRange(param.ToArray());
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            comando.Dispose();
            return registos;
        }

        public void inserirUtilizador(string Nif, string Nome, string Email, string Sexo, string Cod_Postal, string Telemovel, string Pass, string Perfil)
        {
            string sql = "Insert INTO T_Pessoa(Nif,Nome,Email,Sexo,Cod_Postal,Telemovel,Pass,Perfil) " +
                "values(@Nif,@Nome,@Email,@Sexo,@Cod_Postal,@Telemovel,@Pass,@Perfil)";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@Nif",SqlDbType=SqlDbType.NVarChar,Value=Nif},
                new SqlParameter(){ParameterName="@Nome",SqlDbType=SqlDbType.NVarChar,Value=Nome},
                new SqlParameter(){ParameterName="@Email",SqlDbType=SqlDbType.NVarChar,Value=Email},
                new SqlParameter(){ParameterName="@Sexo",SqlDbType=SqlDbType.NVarChar,Value=Sexo},
                new SqlParameter(){ParameterName="@Cod_Postal",SqlDbType=SqlDbType.NVarChar,Value=Cod_Postal},
                new SqlParameter(){ParameterName="@Telemovel",SqlDbType=SqlDbType.NVarChar,Value=Telemovel},
                new SqlParameter(){ParameterName="@Pass",SqlDbType=SqlDbType.NVarChar,Value=Pass},
                new SqlParameter(){ParameterName="@Perfil",SqlDbType=SqlDbType.NVarChar,Value=Perfil},
            };

            executa_SQL(sql, parametros);
        }
        public void inserirProduto(string EAN, string Nome, string Descricao, double Preco, string Estado, string Tipo)
        {
            string sql = "Insert INTO T_Produto(EAN,Nome,Descricao,Preco,Estado,Tipo) " +
                "values(@EAN,@Nome,@Descricao,@Preco,@Estado,@Tipo)";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@EAN",SqlDbType = SqlDbType.NVarChar,Value = EAN},
                new SqlParameter(){ParameterName="@Nome",SqlDbType = SqlDbType.NVarChar,Value = Nome},
                new SqlParameter(){ParameterName="@Descricao",SqlDbType = SqlDbType.NVarChar,Value = Descricao},
                new SqlParameter(){ParameterName="@Preco",SqlDbType=SqlDbType.Money,Value= Preco},
                new SqlParameter(){ParameterName="@Estado",SqlDbType=SqlDbType.NVarChar,Value= Estado},
                new SqlParameter(){ParameterName="@Tipo",SqlDbType=SqlDbType.NVarChar,Value= Tipo},
            };
            executa_SQL(sql, parametros);
        }

        public void inserirCompra(int Preco, string NIF, string Cod_Postal, string EAN)
        {
            string sql = "Insert INTO T_Carrinho (Quantidade,Preco,NIF, Data_carrinho, Cod_Postal, EAN) " +
                "values(@Quantidade,@Preco,@NIF, @Data_carrinho, @Cod_Postal, @EAN)";


            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@Quantidade",SqlDbType=SqlDbType.Int,Value = 1},
                new SqlParameter(){ParameterName="@Preco",SqlDbType=SqlDbType.Money,Value = Preco},
                new SqlParameter(){ParameterName="@NIF",SqlDbType=SqlDbType.VarChar,Value = NIF},
                new SqlParameter(){ParameterName="@Data_carrinho",SqlDbType=SqlDbType.Date,Value = DateTime.Now},
                new SqlParameter(){ParameterName="@Cod_Postal",SqlDbType=SqlDbType.VarChar,Value = Cod_Postal},
                new SqlParameter(){ParameterName="@EAN",SqlDbType=SqlDbType.VarChar,Value = EAN},
            };
            executa_SQL(sql, parametros);
        }

        public DataTable verificarlogin(string email, string pass)
        {
            string SQL = "SELECT * FROM T_Pessoa WHERE Email='" + email + "' AND Pass ='" + pass + "'";

            DataTable utilizador = devolveconsulta(SQL);
            if (utilizador == null || utilizador.Rows.Count == 0)
                return null;

            return utilizador;
        }

        #endregion

        #region Funções_EMail

        public static void enviarMail(string nomeDe, string passwordDe,
                   string paraQuem, string assunto, string texto, string anexo = null)
        {
            //objetos email
            System.Net.Mail.MailMessage mensagem = new System.Net.Mail.MailMessage();
            System.Net.NetworkCredential credenciais = new System.Net.NetworkCredential(nomeDe, passwordDe);
            System.Net.Mail.MailAddress deQuem = new System.Net.Mail.MailAddress(nomeDe);
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

            //mensagem
            mensagem.To.Add(paraQuem);
            mensagem.From = deQuem;
            mensagem.Subject = assunto;
            mensagem.Body = texto;
            mensagem.IsBodyHtml = true;
            //servidor
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credenciais;
            //anexo
            if (anexo != null && anexo != "")
            {
                if (System.IO.File.Exists(anexo) == true)
                {
                    System.Net.Mail.Attachment ficheiroAnexo = new System.Net.Mail.Attachment(anexo);
                    mensagem.Attachments.Add(ficheiroAnexo);
                }
            }
            //enviar
            smtp.Send(mensagem);
        }
        #endregion
    }
}



