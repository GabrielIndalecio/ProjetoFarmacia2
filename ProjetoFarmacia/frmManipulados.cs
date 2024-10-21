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
    public partial class frmManipulados : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;
        private string nomeUsuario;
        public frmManipulados(string nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
            txbResponsavelMani.Text = nomeUsuario;
            ListarProdutoMani();
            ConfigurarDataGrid();
            
        }

        private void btnSalvarMani_Click(object sender, EventArgs e)
        {
            Manipulados manipulados = new Manipulados();
            ManipuladoCRUD manipuladocrud = new ManipuladoCRUD(_conexao);
            try
            {
                manipulados.nome_manipulado = txbNomeMani.Text;
                manipulados.estoque_manipulado = Convert.ToInt32(txbQuantidadeMani.Text);
                manipulados.datavalidade_manipulado = txbUnidadeOutrosMani.Text;
                manipulados.datafabricacao_manipulado = txbFabricacaoMani.Text;
                manipulados.local_manipulado = txbLocalMani.Text;
                if (cbUnidadeMani.SelectedIndex != 4) { manipulados.unidade_manipulado = cbUnidadeMani.Text; } else { manipulados.unidade_manipulado = txbUnidadeOutrosMani.Text; }
                manipulados.temperatura_manipulado = cbTemperatura.Text;
                manipulados.responsavel_manipulado = txbResponsavelMani.Text;
                manipulados.lote_manipulado = Convert.ToInt32(txbLoteMani.Text);
                if (chbProdutoControlMani.Checked == true) { manipulados.manipulado_controlado = "Sim"; } else { manipulados.manipulado_controlado = "Nao"; }

                manipuladocrud.IncluiProdutoManipulacao(manipulados);

                MessageBox.Show("Cadastrado com Sucesso!");

            }
            catch(Exception ex)
            {
                throw new Exception("erro", ex);
            }
        }

        private void cbUnidadeMani_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnidadeMani.SelectedIndex == 4)
            {
                label3.Visible = true;
                txbUnidadeOutrosMani.Visible = true;
            }
            else
            {
                label3.Visible = false;
                txbUnidadeOutrosMani.Visible = false;
            }
        }
        private void ListarProdutoMani()
        {
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
            string busca = txbPesquisa.Text.ToString();
            DataSet dsProduto = new DataSet();
            dsProduto = produtocrud.BuscarProduto(busca);
            dgvManipulados.DataSource = dsProduto.Tables[0];
        }
        private void ConfigurarDataGrid()
        {
            dgvManipulados.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgvManipulados.RowHeadersWidth = 25;

            dgvManipulados.Columns["id_produto"].Visible = false;
            dgvManipulados.Columns["nome_medicamento"].HeaderText = "Nome";
            dgvManipulados.Columns["setor_medicamento"].HeaderText = "Setor";
            dgvManipulados.Columns["unidade_medicamento"].HeaderText = "Unidade";
            dgvManipulados.Columns["estoque_medicamento"].HeaderText = "Estoque";
            dgvManipulados.Columns["datavalidade_medicamento"].Visible = false;
            dgvManipulados.Columns["lote_medicamento"].HeaderText = "Lote";
            dgvManipulados.Columns["data_fabricacao"].Visible = false;
            dgvManipulados.Columns["data_entrada"].Visible = false;
            dgvManipulados.Columns["responsavel_medicamento"].Visible = false;
            dgvManipulados.Columns["local_medicamento"].Visible = false;
            dgvManipulados.Columns["temperatura_medicamento"].Visible = false;

            dgvManipulados.Columns["nome_medicamento"].DisplayIndex = 0;
            dgvManipulados.Columns["setor_medicamento"].DisplayIndex = 1;
            dgvManipulados.Columns["unidade_medicamento"].DisplayIndex = 2;
            dgvManipulados.Columns["estoque_medicamento"].DisplayIndex = 3;
            dgvManipulados.Columns["lote_medicamento"].DisplayIndex = 4;
        }

        private void dgvManipulados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManipulados.SelectedRows.Count > 0)
            {
                string codigo = dgvManipulados.CurrentRow.Cells["nome_medicamento"].Value.ToString();
                frmBaixa baixa = new frmBaixa(codigo);
                baixa.ShowDialog();
            }
        }
    }
}
