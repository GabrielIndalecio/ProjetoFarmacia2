using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProdutoCRUD
    {
        private readonly string _conexao;

        public ProdutoCRUD(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluiProduto(Produtos produtos)
        {
            const string query = @"INSERT INTO entrada_medicamento (nome_medicamento, setor_medicamento, unidade_medicamento, estoque_medicamento, datavalidade_medicamento, lote_medicamento)
                                    Values(@nome, @setor, @unidade, @estoque, @datavalidade, @lote)";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaobd))
                {
                    comandoSql.Parameters.AddWithValue("@nome", produtos.nome_medicamento);
                    comandoSql.Parameters.AddWithValue("@setor", produtos.setor_medicamento);
                    comandoSql.Parameters.AddWithValue("@unidade", produtos.unidade_medicamento);
                    comandoSql.Parameters.AddWithValue("@estoque", produtos.estoque_medicamento);
                    comandoSql.Parameters.AddWithValue("@datavalidade", produtos.datavalidade_medicamento);
                    comandoSql.Parameters.AddWithValue("@lote", produtos.lote_medicamento);

                    conexaobd.Open();

                    comandoSql.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro", ex);
            }
        }
    }
}
