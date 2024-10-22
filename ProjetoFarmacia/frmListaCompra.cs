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
    public partial class frmListaCompra : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;
        public frmListaCompra()
        {
            InitializeComponent();
            ExibirValidade();
            ExibirQuantidade();
            
        }
        private void ExibirValidade()
        {
            ProdutoCRUD prodcrud = new ProdutoCRUD(_conexao);
            DataTable produtos = prodcrud.Puxardadosvalidade();

            DateTime dataatual = DateTime.Now;

            int diasparavencer = 20;

            foreach (DataRow row in produtos.Rows) 
            {
                DateTime validade = Convert.ToDateTime(row["Validade"]);
                string nomeProduto = row["Nome"].ToString();

                if((validade - dataatual).TotalDays <= diasparavencer)
                {
                    lbLista.Items.Add($"{nomeProduto} - Vence em: {validade.ToShortDateString()}");
                }
            }
        }
        private void ExibirQuantidade()
        {
            ProdutoCRUD prodcrud = new ProdutoCRUD(_conexao);
            DataTable Produtos = prodcrud.VerificarEstoque();

            int quantidademin = 5;

            foreach(DataRow row in Produtos.Rows)
            {
                int quantidadeatual = Convert.ToInt32(row["Quantidade"]);
                string nomeProduto2 = row["Nome"].ToString();
                if(quantidadeatual <= quantidademin)
                {
                    lbLista.Items.Add($"{nomeProduto2} - Quantidade Baixa {quantidadeatual}");
                }
            }
        }
    }
}
