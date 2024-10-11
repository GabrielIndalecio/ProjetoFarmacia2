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
        public frmCadastro()
        {
            InitializeComponent();
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
            Produtos produtos = new Produtos();
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            try
            {
                produtos.nome_medicamento = txbNomeProduto.Text;
                if (rbMateria.Checked) { produtos.setor_medicamento = rbMateria.Text; }
                if (rbMaterialConsumo.Checked) { produtos.setor_medicamento = rbMaterialConsumo.Text; }
                if (rbUtensilio.Checked) { produtos.setor_medicamento=rbUtensilio.Text; }
                if (cbUnidade.SelectedIndex != 4) { produtos.unidade_medicamento = cbUnidade.Text; } else { produtos.unidade_medicamento = txbUnidadeOutros.Text; }
                produtos.estoque_medicamento = Convert.ToInt32(txbQuantidade.Text);
                produtos.datavalidade_medicamento = mtbDataValidade.Text;
                produtos.data_fabricacao = mtbFabricacao.Text;
                produtos.data_entrada = txbDataEntradaProd.Text;
                produtos.lote_medicamento = Convert.ToInt32(txbLoteCad.Text);

                produtocrud.IncluiProduto(produtos);

                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch(Exception ex)
            {
                throw new Exception("Erro", ex);
            }

        }
    }
}
