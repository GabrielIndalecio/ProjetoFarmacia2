using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProdutosControladosCRUD
    {
        private readonly string _conexao;

        public ProdutosControladosCRUD(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluiProdutoControlado(ProdutosControlados produtoscontrolados)
        {
            const string query = @"INSERT INTO medicamento_controlado (nome_medicamento_controlado, setor_medicamento_controlado, unidade_medicamento_controlado, estoque_medicamento_controlado, datavalidade_medicamento_controlado, lote_medicamento_controlado, data_fabricacao_controlado, data_entrada_controlado, responsavel_medicamento_controlado)
                                   Values (@nome, @setor, @unidade, @estoque, @datavalidade, @lote, @data_fabricacao, @data_entrada, @responsavel)";


            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaobd))
                {   // Quem foi o viado que fez os codigos do banco de dados assim?
                    comandoSql.Parameters.AddWithValue("@nome", produtoscontrolados.nome_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@setor", produtoscontrolados.setor_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@unidade", produtoscontrolados.unidade_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@estoque", produtoscontrolados.estoque_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@datavalidade", produtoscontrolados.datavalidade_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@lote", produtoscontrolados.lote_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@data_fabricacao", produtoscontrolados.data_fabricacao_controlado);
                    comandoSql.Parameters.AddWithValue("@data_entrada", produtoscontrolados.data_entrada_controlado);
                    comandoSql.Parameters.AddWithValue("@responsavel", produtoscontrolados.responsavel_medicamento_controlado);

                    conexaobd.Open();
                    // O codigo ta um lixo!
                    comandoSql.ExecuteNonQuery();
                } // O codigo mais porco!
            }
            catch(Exception ex)
            {
                throw new Exception("Erro", ex);
            } // Baiano safado
        }
        
        public DataSet BuscarProdutoControlado(string pesquisa = "")
        {
            const string query = "Select * From medicamento_controlado Where nome_medicamento_controlado Like @pesquisa";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                using (var adaptador = new SqlDataAdapter(comandosql))
                {
                    string paramentroPesquisa = $"%{pesquisa}%";
                    comandosql.Parameters.AddWithValue("@pesquisa", paramentroPesquisa);
                    conexaobd.Open();
                    var dsProdutos_Controlados = new DataSet();
                    adaptador.Fill(dsProdutos_Controlados, "medicamento_controlado");
                    return dsProdutos_Controlados;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro {ex.Message}", ex);
            }
        }

        public DataSet BuscarSetorControlado(string Pesquisar = "")
        {
            const string query = "Select * from medicamento_controlado Where setor_medicamento_controlado Like @Pesquisar";

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
                    adaptador.Fill(dsProdutosSetor, "medicamento_controlado");
                    return dsProdutosSetor;
                }
            }
            catch (Exception ex) { throw new Exception($"Erro ao Buscar Produto Controlado {ex.Message}", ex); }
        }

        public ProdutosControlados ObtemProdutoControlado(int codigoProduto)
        {
            const string query = "Select * from medicamento_controlado where id_produto = @cod";
            ProdutosControlados produtos = null;
            try
            {
                using (var conexaobD = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobD))
                {
                    comandosql.Parameters.AddWithValue("@cod", codigoProduto);
                    conexaobD.Open();
                    using (var reader = comandosql.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            produtos = new ProdutosControlados
                            {
                                id_produto_controlado = Convert.ToInt32(reader["id_produto"]),
                                nome_medicamento_controlado = reader["nome_medicamento"].ToString(),
                                setor_medicamento_controlado = reader["setor_medicamento"].ToString(),
                                unidade_medicamento_controlado = reader["unidade_medicamento"].ToString(),
                                estoque_medicamento_controlado = Convert.ToInt32(reader["estoque_medicamento"]),
                                datavalidade_medicamento_controlado = reader["datavalidade_medicamento"].ToString(),
                                lote_medicamento_controlado = Convert.ToInt32(reader["lote_medicamento"]),
                                data_fabricacao_controlado = reader["data_fabricacao"].ToString(),
                                data_entrada_controlado = reader["data_entrada"].ToString(),
                                responsavel_medicamento_controlado = reader["responsavel_medicamento"].ToString()
                            };
                        }
                    }
                }
            }catch(Exception ex) { throw new Exception("erro", ex); }
            return produtos;
        }
        public void ExcluirProduto(int codigo)
        {
            const string query = "DELETE FROM medicamento_controlado WHERE id_produto_controlado = @cod";

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comandoSQL = new SqlCommand(query, conexaoBD))
                {
                    comandoSQL.Parameters.AddWithValue("@cod", codigo);

                    conexaoBD.Open();

                    comandoSQL.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro {ex.Message}", ex);
            }
        }
    }
}
