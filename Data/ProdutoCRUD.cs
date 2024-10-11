using System;
using System.Collections.Generic;
using System.Data;
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
            const string query = @"INSERT INTO entrada_medicamento (nome_medicamento, setor_medicamento, unidade_medicamento, estoque_medicamento, datavalidade_medicamento, lote_medicamento, data_fabricacao, data_entrada)
                                    Values(@nome, @setor, @unidade, @estoque, @datavalidade, @lote, @datafabricacao, @data_entrada)";

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
                    comandoSql.Parameters.AddWithValue("@datafabricacao", produtos.data_fabricacao);
                    comandoSql.Parameters.AddWithValue("@data_entrada", produtos.data_entrada);

                    conexaobd.Open();

                    comandoSql.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro", ex);
            }
        }

        public DataSet BuscarProduto(string pesquisa = "")
        {
            const string query = "Select * from entrada_medicamento Where nome_medicamento Like @pesquisa";

            try
            {
                using(var conexaobd = new SqlConnection(_conexao))
                using(var comandosql = new SqlCommand(query, conexaobd))
                using(var adaptador = new SqlDataAdapter(comandosql))
                {
                    string paramentroPesquisa = $"%{pesquisa}%";
                    comandosql.Parameters.AddWithValue("@pesquisa", paramentroPesquisa);
                    conexaobd.Open();
                    var dsProdutos = new DataSet();
                    adaptador.Fill(dsProdutos, "entrada_medicamento");
                    return dsProdutos;
                }
            }
            catch(Exception ex) { throw new Exception($"Erro ao Buscar Produto {ex.Message}", ex); }
        }

        public DataSet BuscarSetor(string Pesquisar = "")
        {
            const string query = "Select * from entrada_medicamento Where setor_medicamento Like @Pesquisar";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                using (var adaptador = new SqlDataAdapter(comandosql))
                {
                    string paramentroPesquisa = $"%{Pesquisar}%";
                    comandosql.Parameters.AddWithValue("@Pesquisar", paramentroPesquisa);
                    conexaobd.Open();
                    var dsProdutosSetor = new DataSet();
                    adaptador.Fill(dsProdutosSetor, "entrada_medicamento");
                    return dsProdutosSetor;
                }
            }
            catch (Exception ex) { throw new Exception($"Erro ao Buscar Produto {ex.Message}", ex); }
        }
    }
}
