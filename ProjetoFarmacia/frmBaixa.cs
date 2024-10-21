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
    public partial class frmBaixa : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;
        public frmBaixa(string codigo)
        {
            InitializeComponent();
            if (codigo != null)
            {
                Produtos produtos = new Produtos();
                ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
                ProdutosControlados produtoscontrolado = new ProdutosControlados();
                ProdutosControladosCRUD produtoscontroladocrud = new ProdutosControladosCRUD(_conexao);

                produtos = produtocrud.ObtemProduto(codigo);
                produtoscontrolado = produtoscontroladocrud.ObtemProdutoControlado(codigo);

                if(produtos == null)
                {
                    lblCodigo.Text = produtoscontrolado.id_produto_controlado.ToString();
                    txtNomeMani.Text = produtoscontrolado.nome_medicamento_controlado;
                    txtQuantidadeAtual.Text = produtoscontrolado.estoque_medicamento_controlado.ToString();
                    txtUnidade.Text = produtoscontrolado.unidade_medicamento_controlado;

                    cbProdutoControlado.Checked = true;
                }
                else
                {
                    lblCodigo.Text = produtos.id_produto.ToString();
                    txtNomeMani.Text = produtos.nome_medicamento;
                    txtQuantidadeAtual.Text = produtos.estoque_medicamento.ToString();
                    txtUnidade.Text = produtos.unidade_medicamento;

                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cbProdutoControlado.Checked)
            {
                
                ProdutosControlados produtoscontrolados = new ProdutosControlados();
                ProdutosControladosCRUD prodcontrolcrud = new ProdutosControladosCRUD(_conexao);
                int subtrair = Convert.ToInt32(txtQuantidadeRetirar.Text);
                try
                {
                    produtoscontrolados.id_produto_controlado = Convert.ToInt32(lblCodigo.Text);
                    produtoscontrolados.estoque_medicamento_controlado = Convert.ToInt32(txtQuantidadeAtual.Text) - subtrair;

                    if (MessageBox.Show("Tem certeza que deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        prodcontrolcrud.DarBaixaControlado(produtoscontrolados);
                        this.Close();
                    }
                    
                }
                catch(Exception ex) { throw new Exception("Erro", ex); }
            }
            else
            {
                Produtos produtos = new Produtos();
                ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
                int subtrair = Convert.ToInt32(txtQuantidadeRetirar.Text);
                try
                {
                    produtos.id_produto = Convert.ToInt32(lblCodigo.Text);
                    produtos.estoque_medicamento = Convert.ToInt32(txtQuantidadeAtual.Text) - subtrair;


                    if (MessageBox.Show("Tem certeza que deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        produtocrud.DarBaixa(produtos);
                        this.Close();
                    }
                }
                catch (Exception ex) { throw new Exception("Erro", ex); }
            }
        }
    }
}
