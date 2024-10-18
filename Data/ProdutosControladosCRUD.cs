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
            const string query = @"INSERT INTO medicamento_controlado (nome_medicamento_controlado, setor_medicamento_controlado, unidade_medicamento_controlado, estoque_medicamento_controlado, datavalidade_medicamento_controlado, lote_medicamento_controlado, data_fabricacao_controlado, data_entrada_controlado, responsavel_medicamento_controlado, local_medicamento_controlado, temperatura_medicamento_controlado)
                                   Values (@nome, @setor, @unidade, @estoque, @datavalidade, @lote, @data_fabricacao, @data_entrada, @responsavel, @local, @temp)";


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
                    comandoSql.Parameters.AddWithValue("@local", produtoscontrolados.local_medicamento_controlado);
                    comandoSql.Parameters.AddWithValue("@temp", produtoscontrolados.temperatura_medicamento_controlado);

                    conexaobd.Open();
                    // O codigo ta um lixo!
                    comandoSql.ExecuteNonQuery();
                } // O codigo mais porco!
            }
            catch (Exception ex)
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

        public ProdutosControlados ObtemProdutoControlado(string codigoProduto)
        {
            const string query = "Select * from medicamento_controlado where nome_medicamento_controlado = @cod";
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
                                id_produto_controlado = Convert.ToInt32(reader["id_produto_controlado"]),
                                nome_medicamento_controlado = reader["nome_medicamento_controlado"].ToString(),
                                setor_medicamento_controlado = reader["setor_medicamento_controlado"].ToString(),
                                unidade_medicamento_controlado = reader["unidade_medicamento_controlado"].ToString(),
                                estoque_medicamento_controlado = Convert.ToInt32(reader["estoque_medicamento_controlado"]),
                                datavalidade_medicamento_controlado = reader["datavalidade_medicamento_controlado"].ToString(),
                                lote_medicamento_controlado = Convert.ToInt32(reader["lote_medicamento_controlado"]),
                                data_fabricacao_controlado = reader["data_fabricacao_controlado"].ToString(),
                                data_entrada_controlado = reader["data_entrada_controlado"].ToString(),
                                responsavel_medicamento_controlado = reader["responsavel_medicamento_controlado"].ToString(),
                                local_medicamento_controlado = reader["local_medicamento_controlado"].ToString(),
                                temperatura_medicamento_controlado = reader["temperatura_medicamento_controlado"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("erro", ex); }
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
        public void AlterarProdutoControlado(ProdutosControlados prodcontrol)
        {
            const string query = @"update medicamento_controlado set 
                                    nome_medicamento_controlado = @nome,
                                    setor_medicamento_controlado = @setor,
                                    unidade_medicamento_controlado = @unidade,
                                    estoque_medicamento_controlado = @quantidade,
                                    datavalidade_medicamento_controlado = @datavalidade,
                                    lote_medicamento_controlado = @lote,
                                    data_fabricacao_controlado = @fabricacao,
                                    data_entrada_controlado = @entrada,
                                    responsavel_medicamento_controlado = @responsavel
                                    local_medicamento_controlado = @local
                                    temperatura_medicamento_controlado = @temp
                                    where id_produto_controlado = @id";
            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                {
                    comandosql.Parameters.AddWithValue("@setor", prodcontrol.setor_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@unidade", prodcontrol.unidade_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@quantidade", prodcontrol.estoque_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@datavalidade", prodcontrol.datavalidade_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@lote", prodcontrol.lote_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@fabricacao", prodcontrol.data_fabricacao_controlado);
                    comandosql.Parameters.AddWithValue("@entrada", prodcontrol.data_entrada_controlado);
                    comandosql.Parameters.AddWithValue("@responsavel", prodcontrol.responsavel_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@local", prodcontrol.local_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@temp", prodcontrol.temperatura_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@nome", prodcontrol.nome_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@id", prodcontrol.id_produto_controlado);

                    conexaobd.Open();

                    comandosql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro" + ex);
            }
        }
        public void DarBaixaControlado(ProdutosControlados produtoscontrolados)
        {
            const string query = @"update medicamento_controlado set estoque_medicamento_controlado = @quantidade where id_produto_controlado = @id";

            try
            {
                using(var conexaobd = new SqlConnection(_conexao))
                using(var comandosql = new SqlCommand(query, conexaobd))
                {
                    comandosql.Parameters.AddWithValue("@quantidade", produtoscontrolados.estoque_medicamento_controlado);
                    comandosql.Parameters.AddWithValue("@id", produtoscontrolados.id_produto_controlado);

                    conexaobd.Open();

                    comandosql.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro" + ex);
            }
        }
    }
}
