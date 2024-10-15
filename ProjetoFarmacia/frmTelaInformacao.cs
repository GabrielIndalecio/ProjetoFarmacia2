using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFarmacia
{
    public partial class frmTelaInformacao : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;
        public frmTelaInformacao(string codigo)
        {
            InitializeComponent();
            if (codigo != null)
            {
                Produtos produtos = new Produtos();
                ProdutosControlados produtoscontrol = new ProdutosControlados();
                ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
                ProdutosControladosCRUD prodcrudcontrol = new ProdutosControladosCRUD(_conexao);

                produtos = produtocrud.ObtemProduto(codigo);
                produtoscontrol = prodcrudcontrol.ObtemProdutoControlado(codigo);
                
                if(produtos == null)
                {
                    txbCodigo.Text = produtoscontrol.id_produto_controlado.ToString();
                    txbNomeProdutoInf.Text = produtoscontrol.nome_medicamento_controlado;
                    txbQuantidadeInf.Text = produtoscontrol.estoque_medicamento_controlado.ToString();
                    txbUnidadeOutrosInf.Text = produtoscontrol.unidade_medicamento_controlado;
                    txbDataEntradaProdInf.Text = produtoscontrol.data_entrada_controlado;
                    mtbDataValidadeInf.Text = produtoscontrol.datavalidade_medicamento_controlado;
                    mtbFabricacaoInf.Text = produtoscontrol.data_fabricacao_controlado;
                    txtNomeRespInf.Text = produtoscontrol.responsavel_medicamento_controlado;
                    if (produtoscontrol.setor_medicamento_controlado == "Utensílios")
                    {
                        rbUtensilioInf.Checked = true;
                    }
                    if (produtoscontrol.setor_medicamento_controlado == "Matéria Prima")
                    {
                        rbMateriaInf.Checked = true;
                    }
                    if (produtoscontrol.setor_medicamento_controlado == "Material de Consumo")
                    {
                        rbMaterialConsumoInf.Checked = true;
                    }
                    cbProdutoControlado.Checked = true;
                }
                else
                {
                    txbCodigo.Text = produtos.id_produto.ToString();
                    txbNomeProdutoInf.Text = produtos.nome_medicamento;
                    txbQuantidadeInf.Text = produtos.estoque_medicamento.ToString();
                    txbUnidadeOutrosInf.Text = produtos.unidade_medicamento;
                    txbDataEntradaProdInf.Text = produtos.data_entrada;
                    mtbDataValidadeInf.Text = produtos.datavalidade_medicamento;
                    mtbFabricacaoInf.Text = produtos.data_fabricacao;
                    txbLoteCadInf.Text = produtos.lote_medicamento.ToString();
                    txtNomeRespInf.Text = produtos.responsavel_medicamento;
                    if (produtos.setor_medicamento == "Utensílios")
                    {
                        rbUtensilioInf.Checked = true;
                    }
                    if (produtos.setor_medicamento == "Matéria Prima")
                    {
                        rbMateriaInf.Checked = true;
                    }
                    if (produtos.setor_medicamento == "Material de Consumo")
                    {
                        rbMaterialConsumoInf.Checked = true;
                    }
                }
                
            }
        }

        private void btnSalvarCadInf_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cbProdutoControlado.Checked == true)
            {
                int codigo = Convert.ToInt32(txbCodigo.Text);
                if(MessageBox.Show("Tem Certeza que desejas Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProdutosControladosCRUD prodcrudcontrol = new ProdutosControladosCRUD(_conexao);
                    prodcrudcontrol.ExcluirProduto(codigo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro", "Erro");
                }
            }
            else
            {
                int codigo = Convert.ToInt32(txbCodigo.Text);
                if (MessageBox.Show("Tem Certeza que desejas Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
                    produtocrud.ExcluirProduto(codigo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro", "Erro");
                }
            }
            
        }

        private void cbAlteracao_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAlteracao.Checked)
            {
                btnSalvarCadInf.Enabled = cbAlteracao.Checked;
                txbNomeProdutoInf.ReadOnly = false;
                txbQuantidadeInf.ReadOnly = false;
                txbUnidadeOutrosInf.ReadOnly = false;
                txbLoteCadInf.ReadOnly = false;
                txbDataEntradaProdInf.ReadOnly = false;
                txtNomeRespInf.ReadOnly = false;
                mtbDataValidadeInf.ReadOnly = false;
                mtbFabricacaoInf.ReadOnly = false;
            }
            else
            {
                btnSalvarCadInf.Enabled = false;
                txbNomeProdutoInf.ReadOnly = true;
                txbQuantidadeInf.ReadOnly = true;
                txbUnidadeOutrosInf.ReadOnly = true;
                txbLoteCadInf.ReadOnly = true;
                txbDataEntradaProdInf.ReadOnly = true;
                txtNomeRespInf.ReadOnly = true;
                mtbDataValidadeInf.ReadOnly = true;
                mtbFabricacaoInf.ReadOnly = true;
            }
        }
    }
}
