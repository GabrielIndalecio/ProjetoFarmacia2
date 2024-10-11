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
    public partial class frmTelaPrincipal : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;
        public frmTelaPrincipal()
        {
            InitializeComponent();
            ListarProduto();
            ConfigurarDataGrid();
            this.KeyDown += new KeyEventHandler(txbNomePesquisa_KeyDown);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var cadastro = new frmCadastro();
            cadastro.ShowDialog();
            ListarProduto();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            var frmlistacompra = new frmListaCompra();
            frmlistacompra.ShowDialog();
        }
        private void ConfigurarDataGrid()
        {
            dgvProdutos.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgvProdutos.RowHeadersWidth = 25;

            dgvProdutos.Columns["id_produto"].Visible = false;
            dgvProdutos.Columns["nome_medicamento"].HeaderText = "Nome";
            dgvProdutos.Columns["setor_medicamento"].HeaderText = "Setor";
            dgvProdutos.Columns["unidade_medicamento"].HeaderText = "Unidade";
            dgvProdutos.Columns["estoque_medicamento"].HeaderText = "Estoque";
            dgvProdutos.Columns["datavalidade_medicamento"].HeaderText = "Validade";
            dgvProdutos.Columns["lote_medicamento"].HeaderText = "Lote";
            dgvProdutos.Columns["data_fabricacao"].HeaderText = "Fabricação";
            dgvProdutos.Columns["data_entrada"].HeaderText = "Entrada";

            dgvProdutos.Columns["nome_medicamento"].DisplayIndex = 0;
            dgvProdutos.Columns["setor_medicamento"].DisplayIndex = 1;
            dgvProdutos.Columns["unidade_medicamento"].DisplayIndex = 2;
            dgvProdutos.Columns["estoque_medicamento"].DisplayIndex = 3;
            dgvProdutos.Columns["datavalidade_medicamento"].DisplayIndex = 4;
            dgvProdutos.Columns["lote_medicamento"].DisplayIndex = 5;
            dgvProdutos.Columns["data_fabricacao"].DisplayIndex = 6;
            dgvProdutos.Columns["data_entrada"].DisplayIndex = 7;
        }
        
        private void ListarProduto()
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string busca = txbNomePesquisa.Text.ToString();

            DataSet dsProduto = new DataSet();
            dsProduto = produtocrud.BuscarProduto(busca);
            dgvProdutos.DataSource = dsProduto;
            dgvProdutos.DataMember = "entrada_medicamento";
        }

        private void txbNomePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            ListarProduto();
        }

        private void rbMaterialConsumo_CheckedChanged(object sender, EventArgs e)
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string Busca = rbMaterialConsumo.Text.ToString();

            DataSet dsProdutosSetor = new DataSet();
            dsProdutosSetor = produtocrud.BuscarSetor(Busca);
            dgvProdutos.DataSource = dsProdutosSetor;
            dgvProdutos.DataMember = "entrada_medicamento";
        }

        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string Busca = rbMateria.Text.ToString();

            DataSet dsProdutosSetor = new DataSet();
            dsProdutosSetor = produtocrud.BuscarSetor(Busca);
            dgvProdutos.DataSource = dsProdutosSetor;
            dgvProdutos.DataMember = "entrada_medicamento";
        }

        private void rbUtensilios_CheckedChanged(object sender, EventArgs e)
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string Busca = rbUtensilios.Text.ToString();

            DataSet dsProdutosSetor = new DataSet();
            dsProdutosSetor = produtocrud.BuscarSetor(Busca);
            dgvProdutos.DataSource = dsProdutosSetor;
            dgvProdutos.DataMember = "entrada_medicamento";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarProduto();
        }
    }
}
