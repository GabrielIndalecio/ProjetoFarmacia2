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
    }
}
