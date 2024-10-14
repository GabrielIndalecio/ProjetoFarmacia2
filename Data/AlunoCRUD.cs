using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AlunoCRUD
    {
        private readonly string _conexao;

        public AlunoCRUD(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluiAluno(Alunos alunos) 
        {
            const string query = @"INSERT INTO alunos (nome_aluno, email_aluno, senha_aluno) Values (@nome, @email, @senha)";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))

                using(var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@nome", alunos.nome_aluno);
                    comandoSql.Parameters.AddWithValue("@email", alunos.email_aluno);
                    comandoSql.Parameters.AddWithValue("@senha", alunos.senha_aluno);

                    conexaoBd.Open();

                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro" + ex);
            }
        }
        public bool LoginUsuario(string email, string senha)
        {
            bool LoginSucesso = false;
            
            const string query = @"SELECT * FROM alunos WHERE email_aluno = @email AND senha_aluno = @senha";

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
            const string query = @"SELECT nome_aluno FROM alunos WHERE email_aluno = @email AND senha_aluno = @senha";
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
                            nomeUsuario = reader["nome_aluno"].ToString();
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
