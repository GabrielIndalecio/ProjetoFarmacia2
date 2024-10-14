using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFarmacia
{
    public partial class frmTelaPrincipal : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;

        bool sidebarExpand;

        private string nomeUsuario;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBotton,
                int nWidhtEllipse,
                int nHeightEllipse
            );
        public frmTelaPrincipal(string nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
            lbl_NomePrincipal.Text = $"Bem-Vindo de volta, {nomeUsuario}!";
            ListarProduto();
            ListarProdutoControlado();
            ConfigurarDataGrid();
            this.KeyDown += new KeyEventHandler(txbNomePesquisa_KeyDown);

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro(nomeUsuario);
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
            dgvProdutos.Columns["responsavel_medicamento"].Visible = false;

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
            ProdutosControladosCRUD produtocontroladocrud = new ProdutosControladosCRUD(_conexao);
            string busca = txbNomePesquisa.Text.ToString();
            DataSet dsProdutos_Controlados = new DataSet();
            dsProdutos_Controlados = produtocontroladocrud.BuscarProdutoControlado(busca);
            DataSet dsProduto = new DataSet();
            dsProduto = produtocrud.BuscarProduto(busca);
            dgvProdutos.DataSource = dsProduto;
            dgvProdutos.DataMember = "entrada_medicamento";
            
        }

        private void ListarProdutoControlado()
        {
            ProdutosControladosCRUD produtocontroladocrud = new ProdutosControladosCRUD(_conexao);
            string busca = txbNomePesquisa.Text.ToString();
            DataSet dsProdutos_Controlados = new DataSet();
            dsProdutos_Controlados = produtocontroladocrud.BuscarProdutoControlado(busca);
            dgvProdutos.DataSource = dsProdutos_Controlados;
            dgvProdutos.DataMember = "medicamento_controlado";

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

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 70;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 70;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pbFlechaExpand_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            pbFlechaExpand.Visible = false;
            pbReturnExpand.Visible = true;
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            btnCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCadastro.Width, btnCadastro.Height, 30, 30));
            btnLista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLista.Width, btnLista.Height, 30, 30));
            
            sidebar.BringToFront();
            

        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro(nomeUsuario);
            cadastro.ShowDialog();
            ListarProduto();
        }

        private void pbReturnExpand_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            pbReturnExpand.Visible = false;
            pbFlechaExpand.Visible = true;
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                btnInformacao.Visible = true;
            }
            else if(dgvProdutos.SelectedColumns.Count < 0)
            {
                btnInformacao.Visible = false;
            }
        }

        private void btnInformacao_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["id_produto"].Value);
                frmTelaInformacao informacao = new frmTelaInformacao(codigo);
                informacao.ShowDialog();

                ListarProduto();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar.");
            }
            
        }

        private void btnLista_Click_1(object sender, EventArgs e)
        {
            frmListaCompra listacompra = new frmListaCompra();
            listacompra.ShowDialog();
        }

    }
}
