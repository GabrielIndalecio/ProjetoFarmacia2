using System;
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
    }
}
