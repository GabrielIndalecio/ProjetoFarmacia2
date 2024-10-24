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
    public partial class frmCadastro : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;

        private string nomeUsuario;
        public frmCadastro(string nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
            txtNomeResp.Text = nomeUsuario;
            txbDataEntradaProd.Text = DateTime.Now.ToString();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnidade.SelectedIndex == 4)
            {
                label9.Visible = true;
                txbUnidadeOutros.Visible = true;

            }
            else
            {
                label9.Visible = false;
                txbUnidadeOutros.Visible = false;
            }
        }

        private void btnSalvarCad_Click(object sender, EventArgs e)
        {
            //if (txbNomeProduto.Text == string.Empty && txbQuantidade.Text == string.Empty && txbUnidadeOutros.Text == string.Empty && mtbDataValidade.Text == string.Empty)
            Produtos produtos = new Produtos();
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
            ProdutosControlados produtoscontrolados = new ProdutosControlados();
            ProdutosControladosCRUD produtoscontroladocrud = new ProdutosControladosCRUD(_conexao);
            if (cbProdutoControlado.Checked)
            {
                try
                {
                    produtoscontrolados.nome_medicamento_controlado = txbNomeProduto.Text;
                    if (rbMateria.Checked) { produtoscontrolados.setor_medicamento_controlado = rbMateria.Text; }
                    if (rbMaterialConsumo.Checked) { produtoscontrolados.setor_medicamento_controlado = rbMaterialConsumo.Text; }
                    if (rbUtensilio.Checked) { produtoscontrolados.setor_medicamento_controlado = rbUtensilio.Text; }
                    if (cbUnidade.SelectedIndex != 4) { produtoscontrolados.unidade_medicamento_controlado = cbUnidade.Text; } else { produtoscontrolados.unidade_medicamento_controlado = txbUnidadeOutros.Text; }
                    produtoscontrolados.estoque_medicamento_controlado = Convert.ToInt32(txbQuantidade.Text);
                    produtoscontrolados.datavalidade_medicamento_controlado = mtbDataValidade.Text;
                    produtoscontrolados.data_fabricacao_controlado = mtbFabricacao.Text;
                    produtoscontrolados.data_entrada_controlado = txbDataEntradaProd.Text;
                    produtoscontrolados.lote_medicamento_controlado = Convert.ToInt32(txbLoteCad.Text);
                    produtoscontrolados.responsavel_medicamento_controlado = txtNomeResp.Text;
                    produtoscontrolados.local_medicamento_controlado = txbLocal.Text;
                    produtoscontrolados.temperatura_medicamento_controlado = cbTemperatura.Text;

                    produtoscontroladocrud.IncluiProdutoControlado(produtoscontrolados);

                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                try
                {
                    produtos.nome_medicamento = txbNomeProduto.Text;
                    if (rbMateria.Checked) { produtos.setor_medicamento = rbMateria.Text; }
                    if (rbMaterialConsumo.Checked) { produtos.setor_medicamento = rbMaterialConsumo.Text; }
                    if (rbUtensilio.Checked) { produtos.setor_medicamento = rbUtensilio.Text; }
                    if (cbUnidade.SelectedIndex != 4) { produtos.unidade_medicamento = cbUnidade.Text; } else { produtos.unidade_medicamento = txbUnidadeOutros.Text; }
                    produtos.estoque_medicamento = Convert.ToInt32(txbQuantidade.Text);
                    produtos.datavalidade_medicamento = mtbDataValidade.Text;
                    produtos.data_fabricacao = mtbFabricacao.Text;
                    produtos.data_entrada = txbDataEntradaProd.Text;
                    produtos.lote_medicamento = Convert.ToInt32(txbLoteCad.Text);
                    produtos.responsavel_medicamento = txtNomeResp.Text;
                    produtos.local_medicamento = txbLocal.Text;
                    produtos.temperatura_medicamento = cbTemperatura.Text;

                    produtocrud.IncluiProduto(produtos);

                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void cbProdutoControlado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
