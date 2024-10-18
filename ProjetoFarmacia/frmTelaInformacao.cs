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
                    txbLoteCadInf.Text = produtoscontrol.lote_medicamento_controlado.ToString();
                    txtNomeRespInf.Text = produtoscontrol.responsavel_medicamento_controlado;
                    txbLocal.Text = produtoscontrol.local_medicamento_controlado;
                    cbTemperatura.Text = produtoscontrol.temperatura_medicamento_controlado;
                    if (produtoscontrol.setor_medicamento_controlado == rbUtensilioInf.Text)
                    {
                        rbUtensilioInf.Checked = true;
                    }
                    if (produtoscontrol.setor_medicamento_controlado == rbMateriaInf.Text)
                    {
                        rbMateriaInf.Checked = true;
                    }
                    if (produtoscontrol.setor_medicamento_controlado == rbMaterialConsumoInf.Text)
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
                    txbLocal.Text = produtos.local_medicamento;
                    cbTemperatura.Text = produtos.temperatura_medicamento;
                    if (produtos.setor_medicamento == rbUtensilioInf.Text)
                    {
                        rbUtensilioInf.Checked = true;
                    }
                    if (produtos.setor_medicamento == rbMateriaInf.Text)
                    {
                        rbMateriaInf.Checked = true;
                    }
                    if (produtos.setor_medicamento == rbMaterialConsumoInf.Text)
                    {
                        rbMaterialConsumoInf.Checked = true;
                    }
                }
                
            }
        }

        private void btnSalvarCadInf_Click(object sender, EventArgs e)
        {
            if (cbProdutoControlado.Checked)
            {
                ProdutosControlados produtoscontrolados = new ProdutosControlados();
                ProdutosControladosCRUD prodcontrolcrud = new ProdutosControladosCRUD(_conexao);
                try
                {
                    produtoscontrolados.id_produto_controlado = int.Parse(txbCodigo.Text);
                    produtoscontrolados.nome_medicamento_controlado = txbNomeProdutoInf.Text;
                    produtoscontrolados.estoque_medicamento_controlado = Convert.ToInt32(txbQuantidadeInf.Text);
                    produtoscontrolados.unidade_medicamento_controlado = txbUnidadeOutrosInf.Text;
                    produtoscontrolados.data_entrada_controlado = txbDataEntradaProdInf.Text;
                    produtoscontrolados.datavalidade_medicamento_controlado = mtbDataValidadeInf.Text;
                    produtoscontrolados.data_fabricacao_controlado = mtbFabricacaoInf.Text;
                    produtoscontrolados.lote_medicamento_controlado = Convert.ToInt32(txbLoteCadInf.Text);
                    produtoscontrolados.responsavel_medicamento_controlado = txtNomeRespInf.Text;
                    produtoscontrolados.local_medicamento_controlado = txbLocal.Text;
                    produtoscontrolados.temperatura_medicamento_controlado = cbTemperatura.Text;
                    if (rbMaterialConsumoInf.Checked == true)
                    {
                        produtoscontrolados.setor_medicamento_controlado = rbMaterialConsumoInf.Text;
                    }
                    if (rbMateriaInf.Checked == true)
                    {
                        produtoscontrolados.setor_medicamento_controlado = rbMateriaInf.Text;
                    }
                    if( rbUtensilioInf.Checked == true)
                    {
                        produtoscontrolados.setor_medicamento_controlado = rbUtensilioInf.Text;
                    }

                    prodcontrolcrud.AlterarProdutoControlado(produtoscontrolados);
                    MessageBox.Show("Alterado com Sucesso!");
                    this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:" + ex);
                }
            }
            else
            {
                Produtos produtos = new Produtos();
                ProdutoCRUD prodcrud = new ProdutoCRUD(_conexao);
                
                try
                {
                    produtos.id_produto = int.Parse(txbCodigo.Text);
                    produtos.nome_medicamento = txbNomeProdutoInf.Text;
                    produtos.estoque_medicamento = Convert.ToInt32(txbQuantidadeInf.Text);
                    produtos.unidade_medicamento = txbUnidadeOutrosInf.Text;
                    produtos.data_entrada = txbDataEntradaProdInf.Text;
                    produtos.datavalidade_medicamento = mtbDataValidadeInf.Text;
                    produtos.data_fabricacao = mtbFabricacaoInf.Text;
                    produtos.lote_medicamento = Convert.ToInt32(txbLoteCadInf.Text);
                    produtos.responsavel_medicamento = txtNomeRespInf.Text;
                    produtos.local_medicamento = txbLocal.Text;
                    produtos.temperatura_medicamento = cbTemperatura.Text;
                    if (rbMaterialConsumoInf.Checked == true)
                    {
                        produtos.setor_medicamento = rbMaterialConsumoInf.Text;
                    }
                    else if (rbMateriaInf.Checked == true)
                    {
                        produtos.setor_medicamento = rbMateriaInf.Text;
                    }
                    else
                    {
                        produtos.setor_medicamento = rbUtensilioInf.Text;
                    }

                    prodcrud.AlterarProduto(produtos);
                    MessageBox.Show("Alterado com Sucesso!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:" + ex);
                }
            }
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

        private void frmTelaInformacao_Load(object sender, EventArgs e)
        {

        }
    }
}
