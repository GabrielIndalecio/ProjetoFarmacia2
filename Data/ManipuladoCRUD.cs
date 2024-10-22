using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ManipuladoCRUD
    {
        private readonly string _conexao;

        public ManipuladoCRUD (string conexao)
        {
            _conexao = conexao;
        }
        public void IncluiProdutoManipulacao (Manipulados manipulados)
        {
            const string query = @"INSERT INTO medicamento_manipulado (nome_manipulado, unidade_manipulado, estoque_manipulado, datavalidade_manipulado, lote_manipulado, datafabricacao_manipulado, responsavel_manipulado, local_manipulado, temperatura_manipulado)
                                    Values(@nome, @unidade, @estoque, @datavalidade, @lote, @datafabricacao, @responsavel_manipulado, @local_med, @temp_med)";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaobd))
                {
                    comandoSql.Parameters.AddWithValue("@nome", manipulados.nome_manipulado);

                    comandoSql.Parameters.AddWithValue("@unidade", manipulados.unidade_manipulado);
                    comandoSql.Parameters.AddWithValue("@estoque", manipulados.estoque_manipulado);
                    comandoSql.Parameters.AddWithValue("@datavalidade", manipulados.datavalidade_manipulado);
                    comandoSql.Parameters.AddWithValue("@lote", manipulados.lote_manipulado);
                    comandoSql.Parameters.AddWithValue("@datafabricacao", manipulados.datafabricacao_manipulado);

                    comandoSql.Parameters.AddWithValue("@responsavel_manipulado", manipulados.responsavel_manipulado);
                    comandoSql.Parameters.AddWithValue("@local_med", manipulados.local_manipulado);
                    comandoSql.Parameters.AddWithValue("@temp_med", manipulados.temperatura_manipulado);

                    conexaobd.Open();

                    comandoSql.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro", ex);
            }
        }

        public void ExcluirProdutoManipulacao(int codigo)
        {
            const string query = "DELETE FROM medicamento_manipulado WHERE id_manipulado = @cod";

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

        public DataSet BuscaUnicaProdutoManipulacao (string pesquisar = "")
        {
            const string query = @"SELECT * FROM medicamento_manipulado WHERE nome_manipulado Like @pesquisar";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                using (var adaptador = new SqlDataAdapter(comandosql))
                {
                    string paramentroPesquisa = $"%{pesquisar}%";
                    comandosql.Parameters.AddWithValue("@pesquisar", paramentroPesquisa);
                    conexaobd.Open();
                    var dsProdutosManipulacao = new DataSet();
                    adaptador.Fill(dsProdutosManipulacao, "medicamento_manipulado");
                    return dsProdutosManipulacao;
                }
            }
            catch (Exception ex) { throw new Exception($"Erro ao Buscar Produto {ex.Message}", ex); }
        }

        public Manipulados ObtemProdutoManipulacao(string codigoProduto)
        {
            const string query = "Select * from medicamento_manipulado where nome_manipulado = @cod";

            Manipulados manipulados = null;
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
                            manipulados = new Manipulados
                            {
                                id_manipulado = Convert.ToInt32(reader["id_manipulado"]),
                                nome_manipulado = reader["nome_manipulado"].ToString(),

                                unidade_manipulado = reader["unidade_manipulado"].ToString(),
                                estoque_manipulado = Convert.ToInt32(reader["estoque_manipulado"]),
                                datavalidade_manipulado = reader["datavalidade_manipulado"].ToString(),
                                lote_manipulado = Convert.ToInt32(reader["lote_manipulado"]),
                                datafabricacao_manipulado = reader["datafabricacao_manipulado"].ToString(),

                                responsavel_manipulado = reader["responsavel_manipulado"].ToString(),
                                local_manipulado = reader["local_manipulado"].ToString(),
                                temperatura_manipulado = reader["temperatura_manipulado"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return manipulados;
        }

        public void DarBaixaManipulacao( Manipulados manipulados)
        {
            const string query = @"update medicamento_manipulado set estoque_manipulado = @quantidade where id_manipulado = @id";

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comandosql = new SqlCommand(query, conexaobd))
                {
                    comandosql.Parameters.AddWithValue("@quantidade", manipulados.estoque_manipulado);
                    comandosql.Parameters.AddWithValue("@id", manipulados.id_manipulado);

                    conexaobd.Open();

                    comandosql.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw new Exception("Erro" + ex); }
        }

    }
}
