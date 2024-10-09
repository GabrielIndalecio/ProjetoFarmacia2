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
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            var frmListadeCompras = new frmListadeCompras();
            frmListadeCompras.ShowDialog();
        }
    }
}
