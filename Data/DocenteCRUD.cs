using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Data
{
    public class DocenteCRUD
    {
        private readonly string _conexao;

        public DocenteCRUD(string conexao)
        {
            _conexao = conexao;
        }
        public void IncluiDocente(Docentes docentes)
        {
            const string query = @"INSERT INTO Docentes(nome_docente, email_docente, senha_docente) Values (@nome, @email, @senha)";

            try
            {
                using(var conexaobd = new SqlConnection(_conexao))

                using(var comandosql = new SqlCommand(query, conexaobd))
                {
                    comandosql.Parameters.AddWithValue("@nome", docentes.nome_docente);
                    comandosql.Parameters.AddWithValue("@email", docentes.email_docente);
                    comandosql.Parameters.AddWithValue("@senha", docentes.senha_docente);

                    conexaobd.Open();

                    comandosql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO", ex);
            }
        }
        public bool LoginDocente(string email, string senha)
        {
            bool LoginSucesso = false;
            const string query = @"SELECT * FROM Docentes WHERE email_docente = @email AND senha_docente = @senha";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@email", email);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    conexaoBd.Open();

                    using (var reader = comandoSql.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoginSucesso = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO", ex);
            }

            return LoginSucesso;
        }
        public string NomeLogin(string email, string senha)
        {
            string nomeUsuario = null;
            const string query = @"SELECT nome_docente FROM Docentes WHERE email_docente = @email AND senha_docente = @senha";
            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaobd))
                {
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);

                    conexaobd.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomeUsuario = reader["nome_docente"].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro {ex.Message}", ex);
            }
            return nomeUsuario;
        }
    }
}
