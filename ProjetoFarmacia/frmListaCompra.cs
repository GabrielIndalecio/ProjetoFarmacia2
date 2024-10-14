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
            ProdutoCRUD produtocrud = new ProdutoCRUD(_conexao);
            List<string> produtosVencidos = produtocrud.DataValidadeProduto();
            lbLista.Items.Clear();
            foreach (var prod in  produtosVencidos)
            {
                lbLista.Items.Add(prod);
            }
            if (produtosVencidos.Count == 0) 
            {
                MessageBox.Show("Não há produtos vencidos.");
            }
        }
    }
}
