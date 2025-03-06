using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Bcpg;

namespace AppLocalCSharp
{
    public class Empregado
    {
        private string stringConexao = "SERVER=localhost;PORT=3306;DATABASE=meu_banco_de_dados;UID=root;";

        public int Matricula { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public DataTable Pesquisar()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                string sql = "SELECT matricula, cpf, nome, endereco FROM empregado WHERE 1";

                if (Matricula != 0)
                    sql += " AND Matricula = @Matricula";
                if (!string.IsNullOrEmpty(Cpf))
                    sql += " AND cpf = @Cpf";
                if (!string.IsNullOrEmpty(Nome))
                    sql += " AND nome LIKE @Nome";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Matricula", Matricula);
                    comando.Parameters.AddWithValue("@Cpf", Cpf);
                    comando.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable dados = new DataTable();

                    adaptador.Fill(dados);

                    return dados;
                }
            }
        }

        public void Incluir()
        {
            string sql = "INSERT INTO empregado (cpf, nome, endereco) VALUES (@Cpf, @Nome, @Endereco)";
            ExecutarComando(sql);
        }

        public void Alterar()
        {
            string sql = "UPDATE empregado SET cpf = @Cpf, nome = @Nome, endereco = @Endereco WHERE Matricula = @Matricula";
            ExecutarComando(sql);
        }

        public void Excluir()
        {
            string sql = "DELETE FROM empregado WHERE matricula = @Matricula";
            ExecutarComando(sql);
        }
        private void ExecutarComando(string sql)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@Matricula", Matricula);
                        comando.Parameters.AddWithValue("@Cpf", Cpf);
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Endereco", Endereco);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }

}

