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
            const string query = @"INSERT INTO entrada_medicamento (nome_medicamento, setor_medicamento, unidade_medicamento, estoque_medicamento, datavalidade_medicamento, lote_medicamento, data_fabricacao, data_entrada, responsavel_medicamento, local_medicamento, temperatura_medicamento)
                                    Values(@nome, @setor, @unidade, @estoque, @datavalidade, @lote, @datafabricacao, @data_entrada, @responsavel_medicamento, @local_med, @temp_med)";

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
                    comandoSql.Parameters.AddWithValue("@local_med", produtos.local_medicamento);
                    comandoSql.Parameters.AddWithValue("@temp_med", produtos.temperatura_medicamento);

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
            const string query = @"SELECT id_produto, nome_medicamento, setor_medicamento, unidade_medicamento, estoque_medicamento, datavalidade_medicamento, lote_medicamento, data_fabricacao, data_entrada, responsavel_medicamento, local_medicamento, temperatura_medicamento
                                    FROM entrada_medicamento WHERE nome_medicamento LIKE @pesquisa
                                    UNION ALL
                                    SELECT id_produto_controlado, nome_medicamento_controlado, setor_medicamento_controlado, unidade_medicamento_controlado, estoque_medicamento_controlado, datavalidade_medicamento_controlado, lote_medicamento_controlado, data_fabricacao_controlado, data_entrada_controlado, responsavel_medicamento_controlado, local_medicamento_controlado, temperatura_medicamento_controlado
                                    FROM medicamento_controlado WHERE nome_medicamento_controlado LIKE @pesquisa";

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
            const string query = @"SELECT id_produto, nome_medicamento, setor_medicamento, unidade_medicamento, estoque_medicamento, datavalidade_medicamento, lote_medicamento, data_fabricacao, data_entrada, responsavel_medicamento, local_medicamento, temperatura_medicamento
                                    FROM entrada_medicamento WHERE setor_medicamento LIKE @Pesquisar
                                    UNION ALL
                                    SELECT id_produto_controlado, nome_medicamento_controlado, setor_medicamento_controlado, unidade_medicamento_controlado, estoque_medicamento_controlado, datavalidade_medicamento_controlado, lote_medicamento_controlado, data_fabricacao_controlado, data_entrada_controlado, responsavel_medicamento_controlado, local_medicamento_controlado, temperatura_medicamento_controlado
                                    FROM medicamento_controlado WHERE setor_medicamento_controlado LIKE @Pesquisar";

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
       
        public Produtos ObtemProduto(string codigoProduto)
        {
            const string query = "Select * from entrada_medicamento where nome_medicamento = @cod";
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
                                responsavel_medicamento = reader["responsavel_medicamento"].ToString(),
                                local_medicamento = reader["local_medicamento"].ToString(),
                                temperatura_medicamento = reader["temperatura_medicamento"].ToString()
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
        public DataTable Puxardadosvalidade()
        {
            DataTable datatable = new DataTable();

            const string query = @"SELECT nome_medicamento AS Nome, datavalidade_medicamento AS Validade FROM entrada_medicamento UNION ALL SELECT nome_medicamento_controlado AS Nome, datavalidade_medicamento_controlado AS Validade FROM medicamento_controlado";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using(var comandosql = new SqlCommand(query, conexaobd))
                using(SqlDataAdapter adapter = new SqlDataAdapter(comandosql))
                {
                    adapter.Fill(datatable);
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro {ex.Message}", ex);
            }
            return datatable;
        }
        public DataSet BuscaUnicaProduto(string pesquisar="")
        {
            const string query = @"SELECT * FROM entrada_medicamento WHERE nome_medicamento Like @pesquisar";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                using (var adaptador = new SqlDataAdapter(comandosql))
                {
                    string paramentroPesquisa = $"%{pesquisar}%";
                    comandosql.Parameters.AddWithValue("@pesquisar", paramentroPesquisa);
                    conexaobd.Open();
                    var dsProdutos = new DataSet();
                    adaptador.Fill(dsProdutos, "entrada_medicamento");
                    return dsProdutos;
                }
            }
            catch (Exception ex) { throw new Exception($"Erro ao Buscar Produto {ex.Message}", ex); }
        }
        public void AlterarProduto(Produtos produtos)
        {
            const string query = @"update entrada_medicamento set 
                                    nome_medicamento = @nome,
                                    setor_medicamento = @setor1,
                                    unidade_medicamento = @unidade,
                                    estoque_medicamento = @quantidade,
                                    datavalidade_medicamento = @datavalidade,
                                    lote_medicamento = @lote,
                                    data_fabricacao = @fabricacao,
                                    data_entrada = @entrada,
                                    responsavel_medicamento = @responsavel,
                                    local_medicamento = @local,
                                    temperatura_medicamento = @temperatura
                                    where id_produto = @id";
            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using(var comandosql = new SqlCommand( query, conexaobd))
                {
                    comandosql.Parameters.AddWithValue("@setor1", produtos.setor_medicamento);
                    comandosql.Parameters.AddWithValue("@unidade", produtos.unidade_medicamento);
                    comandosql.Parameters.AddWithValue("@quantidade", produtos.estoque_medicamento);
                    comandosql.Parameters.AddWithValue("@datavalidade", produtos.datavalidade_medicamento);
                    comandosql.Parameters.AddWithValue("@lote", produtos.lote_medicamento);
                    comandosql.Parameters.AddWithValue("@fabricacao", produtos.data_fabricacao);
                    comandosql.Parameters.AddWithValue("@entrada", produtos.data_entrada);
                    comandosql.Parameters.AddWithValue("@responsavel", produtos.responsavel_medicamento);
                    comandosql.Parameters.AddWithValue("@local", produtos.local_medicamento);
                    comandosql.Parameters.AddWithValue("@temperatura", produtos.temperatura_medicamento);
                    comandosql.Parameters.AddWithValue("@nome", produtos.nome_medicamento);
                    comandosql.Parameters.AddWithValue("@id", produtos.id_produto);

                    conexaobd.Open();

                    comandosql.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro" + ex);
            }

        }
        public void DarBaixa(Produtos produtos)
        {
            const string query = @"update entrada_medicamento set estoque_medicamento = @quantidade where id_produto = @id";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                {
                    comandosql.Parameters.AddWithValue("@quantidade", produtos.estoque_medicamento);
                    comandosql.Parameters.AddWithValue("@id", produtos.id_produto);

                    conexaobd.Open();

                    comandosql.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw new Exception("Erro" + ex); }
        }
        public DataTable VerificarEstoque() 
        {
            DataTable dataset = new DataTable();

            const string query = @"SELECT nome_medicamento AS Nome, estoque_medicamento AS Quantidade FROM entrada_medicamento UNION ALL SELECT nome_medicamento_controlado AS Nome, estoque_medicamento_controlado AS Quantidade FROM medicamento_controlado";
            try
            {
                using(var conexaoBD  = new SqlConnection(_conexao))
                using(var comandosql = new SqlCommand( query, conexaoBD))
                using(SqlDataAdapter adapter = new SqlDataAdapter(comandosql))
                {
                    adapter.Fill(dataset);
                }
            }
            catch(Exception ex) { throw new Exception($"Erro {ex.Message}", ex); }
            return dataset;
        }
    }
}
