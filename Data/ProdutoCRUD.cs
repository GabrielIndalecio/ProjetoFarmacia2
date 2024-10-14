    using MySql.Data.MySqlClient;
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
            const string query = @"INSERT INTO entrada_medicamento (nome_medicamento, setor_medicamento, unidade_medicamento, estoque_medicamento, datavalidade_medicamento, lote_medicamento, data_fabricacao, data_entrada, responsavel_medicamento)
                                    Values(@nome, @setor, @unidade, @estoque, @datavalidade, @lote, @datafabricacao, @data_entrada, @responsavel_medicamento)";

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
                    comandoSql.Parameters.AddWithValue("@responsavel_medicamento", produtos.responsavel_medicamento);

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
       
        public Produtos ObtemProduto(int codigoProduto)
        {
            const string query = "Select * from entrada_medicamento where id_produto = @cod";
            Produtos produtos = null;
            try
            {
                using (var conexaobD = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand (query, conexaobD))
                {
                    comandosql.Parameters.AddWithValue("@cod", codigoProduto);
                    conexaobD.Open();
                    using(var reader = comandosql.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            produtos = new Produtos
                            {
                                id_produto = Convert.ToInt32(reader["id_produto"]),
                                nome_medicamento = reader["nome_medicamento"].ToString(),
                                setor_medicamento = reader["setor_medicamento"].ToString(),
                                unidade_medicamento = reader["unidade_medicamento"].ToString(),
                                estoque_medicamento = Convert.ToInt32(reader["estoque_medicamento"]),
                                datavalidade_medicamento = reader["datavalidade_medicamento"].ToString(),
                                lote_medicamento = Convert.ToInt32(reader["lote_medicamento"]),
                                data_fabricacao = reader["data_fabricacao"].ToString(),
                                data_entrada = reader["data_entrada"].ToString(),
                                responsavel_medicamento = reader["responsavel_medicamento"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return produtos;
        }

        public void ExcluirProduto(int codigo)
        {
            const string query = "DELETE FROM entrada_medicamento WHERE id_produto = @cod";

            try
            {
                using(var conexaoBD = new SqlConnection(_conexao))
                using(var comandoSQL = new SqlCommand(query, conexaoBD))
                {
                    comandoSQL.Parameters.AddWithValue("@cod", codigo);

                    conexaoBD.Open();

                    comandoSQL.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                throw new Exception ($"Erro {ex.Message}", ex);
            }
        }
        public List<string> DataValidadeProduto()
        {
            List<string> produtosvencidos = new List<string>();
            
            const string query = "SELECT nome_medicamento, datavalidade_medicamento FROM entrada_medicamento";

            try
            {
                using(var conexaobd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaobd))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string nomeProduto = reader.GetString(0);
                        DateTime datavalidade = reader.GetDateTime(1);

                        if(datavalidade < DateTime.Now)
                        {
                            produtosvencidos.Add(nomeProduto);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro {ex.Message}", ex);
            }
            return produtosvencidos;
        }
    }
}
