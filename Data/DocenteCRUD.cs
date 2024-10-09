using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

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
    }
}
