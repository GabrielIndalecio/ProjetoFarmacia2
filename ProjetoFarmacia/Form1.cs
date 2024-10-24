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
        bool teste;
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
            lbl_NomePrincipal.Text = $"Bem-Vindo,\n {nomeUsuario}!";
            ListarProduto();
            ConfigurarDataGrid();
            this.KeyDown += new KeyEventHandler(txbNomePesquisa_KeyDown);
            BackColor = SystemColors.ActiveCaption;
            

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
            dgvProdutos.Columns["local_medicamento"].Visible = false;
            dgvProdutos.Columns["temperatura_medicamento"].Visible = false;

            dgvProdutos.Columns["nome_medicamento"].DisplayIndex = 0;
            dgvProdutos.Columns["setor_medicamento"].DisplayIndex = 1;
            dgvProdutos.Columns["unidade_medicamento"].DisplayIndex = 2;
            dgvProdutos.Columns["estoque_medicamento"].DisplayIndex = 3;
            dgvProdutos.Columns["datavalidade_medicamento"].DisplayIndex = 4;
            dgvProdutos.Columns["lote_medicamento"].DisplayIndex = 5;
            dgvProdutos.Columns["data_fabricacao"].DisplayIndex = 6;
            dgvProdutos.Columns["data_entrada"].DisplayIndex = 7;
        }
        private void ConfigurarDataGridControlado()
        {
            dgvProdutos.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgvProdutos.RowHeadersWidth = 25;

            dgvProdutos.Columns["id_produto_controlado"].Visible = false;
            dgvProdutos.Columns["nome_medicamento_controlado"].HeaderText = "Nome";
            dgvProdutos.Columns["setor_medicamento_controlado"].HeaderText = "Setor";
            dgvProdutos.Columns["unidade_medicamento_controlado"].HeaderText = "Unidade";
            dgvProdutos.Columns["estoque_medicamento_controlado"].HeaderText = "Estoque";
            dgvProdutos.Columns["datavalidade_medicamento_controlado"].HeaderText = "Validade";
            dgvProdutos.Columns["lote_medicamento_controlado"].HeaderText = "Lote";
            dgvProdutos.Columns["data_fabricacao_controlado"].HeaderText = "Fabricação";
            dgvProdutos.Columns["data_entrada_controlado"].HeaderText = "Entrada";
            dgvProdutos.Columns["responsavel_medicamento_controlado"].Visible = false;
            dgvProdutos.Columns["local_medicamento_controlado"].Visible = false;
            dgvProdutos.Columns["temperatura_medicamento_controlado"].Visible = false;

            dgvProdutos.Columns["nome_medicamento_controlado"].DisplayIndex = 0;
            dgvProdutos.Columns["setor_medicamento_controlado"].DisplayIndex = 1;
            dgvProdutos.Columns["unidade_medicamento_controlado"].DisplayIndex = 2;
            dgvProdutos.Columns["estoque_medicamento_controlado"].DisplayIndex = 3;
            dgvProdutos.Columns["datavalidade_medicamento_controlado"].DisplayIndex = 4;
            dgvProdutos.Columns["lote_medicamento_controlado"].DisplayIndex = 5;
            dgvProdutos.Columns["data_fabricacao_controlado"].DisplayIndex = 6;
            dgvProdutos.Columns["data_entrada_controlado"].DisplayIndex = 7;
        }
        private void ConfigurarDataGridManipulado() // ARRUMAR ISSO AQUI.
        {
            dgvProdutos.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgvProdutos.RowHeadersWidth = 25;

            dgvProdutos.Columns["id_manipulado"].Visible = false;
            dgvProdutos.Columns["nome_manipulado"].HeaderText = "Nome";
            dgvProdutos.Columns["unidade_manipulado"].HeaderText = "Unidade";
            dgvProdutos.Columns["estoque_manipulado"].HeaderText = "Estoque";
            dgvProdutos.Columns["datavalidade_manipulado"].HeaderText = "Validade";
            dgvProdutos.Columns["lote_manipulado"].HeaderText = "Lote";
            dgvProdutos.Columns["datafabricacao_manipulado"].HeaderText = "Fabricação";
            dgvProdutos.Columns["responsavel_manipulado"].Visible = false;
            dgvProdutos.Columns["local_manipulado"].Visible = false;
            dgvProdutos.Columns["temperatura_manipulado"].Visible = false;
            dgvProdutos.Columns["manipulado_controlado"].HeaderText = "Controlado";

            dgvProdutos.Columns["nome_manipulado"].DisplayIndex = 0;
            dgvProdutos.Columns["unidade_manipulado"].DisplayIndex = 1;
            dgvProdutos.Columns["estoque_manipulado"].DisplayIndex = 2;
            dgvProdutos.Columns["datavalidade_manipulado"].DisplayIndex = 3;
            dgvProdutos.Columns["lote_manipulado"].DisplayIndex = 4;
            dgvProdutos.Columns["datafabricacao_manipulado"].DisplayIndex = 5;
            dgvProdutos.Columns["manipulado_controlado"].DisplayIndex = 6;
            
        }

        private void ListarProduto()
        {
            
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
            string busca = txbNomePesquisa.Text.ToString();
            DataSet dsProduto = new DataSet();
            dsProduto = produtocrud.BuscarProduto(busca);
            dgvProdutos.DataSource = dsProduto.Tables[0];
            
        }

        private void ListarProdutoControlado()
        {
           ProdutosControladosCRUD prodctrcrud = new ProdutosControladosCRUD(_conexao);
            string busca2 = txbNomePesquisa.Text.ToString();
            DataSet dsProduto2 = new DataSet();
            dsProduto2 = prodctrcrud.BuscarProdutoControlado(busca2);
            dgvProdutos.DataSource = dsProduto2;
            dgvProdutos.DataMember = "medicamento_controlado";

        }
        private void ListarProdutosEntrada()
        {
            ProdutoCRUD prodcrud = new ProdutoCRUD(_conexao);
            string busca3 = txbNomePesquisa.Text.ToString();
            DataSet dsProduto3 = new DataSet();
            dsProduto3 = prodcrud.BuscaUnicaProduto(busca3);
            dgvProdutos.DataSource= dsProduto3.Tables[0];
            
        }

        private void txbNomePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void rbMaterialConsumo_CheckedChanged(object sender, EventArgs e)
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string Busca = rbMaterialConsumo.Text.ToString();

            DataSet dsProdutosSetor = new DataSet();
            dsProdutosSetor = produtocrud.BuscarSetor(Busca);
            dgvProdutos.DataSource = dsProdutosSetor;
            dgvProdutos.DataMember = "entrada_medicamento";
            ConfigurarDataGrid();
        }

        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string Busca = rbMateria.Text.ToString();

            DataSet dsProdutosSetor = new DataSet();
            dsProdutosSetor = produtocrud.BuscarSetor(Busca);
            dgvProdutos.DataSource = dsProdutosSetor;
            dgvProdutos.DataMember = "entrada_medicamento";
            ConfigurarDataGrid();
        }

        private void rbUtensilios_CheckedChanged(object sender, EventArgs e)
        {

            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);

            string Busca = rbUtensilios.Text.ToString();

            DataSet dsProdutosSetor = new DataSet();
            dsProdutosSetor = produtocrud.BuscarSetor(Busca);
            dgvProdutos.DataSource = dsProdutosSetor;
            dgvProdutos.DataMember = "entrada_medicamento";
            ConfigurarDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarProduto();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 100;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 100;
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
            btnResetFiltro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnResetFiltro.Width, btnResetFiltro.Height, 30, 30));
            btnManipulacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnManipulacao.Width, btnManipulacao.Height, 30, 30));

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
            
        }

        private void btnInformacao_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnLista_Click_1(object sender, EventArgs e)
        {
            frmListaCompra listacompra = new frmListaCompra();
            listacompra.ShowDialog();
        }

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rbMaterialConsumo.Checked = false;
            rbUtensilios.Checked = false;
            rbMateria.Checked = false;
            txbNomePesquisa.Text = string.Empty;
            ListarProduto();
            ConfigurarDataGrid();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ListarProdutoControlado();
            ConfigurarDataGridControlado();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ListarProdutosEntrada();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            ListarProduto();
            ConfigurarDataGrid();
        }

        private void btnManiBaixa_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                string codigo = dgvProdutos.CurrentRow.Cells["nome_medicamento"].Value.ToString();
                frmBaixa manipulados = new frmBaixa(codigo);
                manipulados.ShowDialog();
                ListarProduto();
            }
        }

        private void btnManipulacao_Click(object sender, EventArgs e)
        {
            frmManipulados frmmanipulado = new frmManipulados(nomeUsuario);
            frmmanipulado.ShowDialog();
            ListarProduto();
        }

        private void rbProdutoManipulado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProdutoManipulado.Checked == true)
            {
                btnInformacao.Visible = false;
                btnManiBaixa.Visible = false;
            }
            else
            {
                
            }
            ManipuladoCRUD manipuladocrud = new ManipuladoCRUD(_conexao);
            string busca3 = txbNomePesquisa.Text.ToString();
            DataSet dsProduto3 = new DataSet();
            dsProduto3 = manipuladocrud.BuscaUnicaProdutoManipulacao(busca3);
            dgvProdutos.DataSource = dsProduto3.Tables[0];
            ConfigurarDataGridManipulado();
            
        }

        private void dgvProdutos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                btnInformacao.Visible = true;
                btnManiBaixa.Visible = true;
            }
            else if (dgvProdutos.SelectedColumns.Count < 0)
            {
                btnInformacao.Visible = false;
                btnManiBaixa.Visible = false;
            }
        }

        private void dgvProdutos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProdutos.Columns[e.ColumnIndex].Name == "datavalidade_medicamento")
            {
                if (e.Value != null)
                {
                    DateTime dataValidade;
                    if (DateTime.TryParse(e.Value.ToString(), out dataValidade))
                    {
                        TimeSpan diferenca = dataValidade - DateTime.Now;

                        if (diferenca.Days < 20 && diferenca.Days >= 0)
                        {
                            dgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;

                        }
                        else if (diferenca.Days < 0)
                        {
                            dgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        }

                    }

                }

            }
        }

        private void txbNomePesquisa_KeyDown_1(object sender, KeyEventArgs e)
        {
            ListarProduto();
        }

        private void btnInformacao_Click_1(object sender, EventArgs e)
        {
            if (rbProdutosControlados.Checked == true)
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    string codigo = dgvProdutos.CurrentRow.Cells["nome_medicamento_controlado"].Value.ToString();
                    frmTelaInformacao informacao = new frmTelaInformacao(codigo);
                    informacao.ShowDialog();

                    ListarProduto();
                }
                else
                {
                    MessageBox.Show("Selecione um registro para alterar.");
                }
            }
            else
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    string codigo = dgvProdutos.CurrentRow.Cells["nome_medicamento"].Value.ToString();
                    frmTelaInformacao informacao = new frmTelaInformacao(codigo);
                    informacao.ShowDialog();

                    ListarProduto();
                }
                else
                {
                    MessageBox.Show("Selecione um registro para alterar.");
                }
            }
        }
    }
}
