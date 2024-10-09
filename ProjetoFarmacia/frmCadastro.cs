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
        public frmCadastro()
        {
            InitializeComponent();
            txbDataEntradaProd.Text = DateTime.Now.ToString();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
