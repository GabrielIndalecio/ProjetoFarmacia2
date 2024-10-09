using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using ProjetoFarmacia;




namespace ProjetoFarmacia
{
    public partial class frmLogin : Form
    {
        string _conexao = ProjetoFarmacia.Properties.Settings.Default.conexao;
        public frmLogin()
        {
            InitializeComponent();
            txbSenhaLogin.UseSystemPasswordChar = true;
            txbSenhaCad.UseSystemPasswordChar = true;

        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                txbSenhaLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txbSenhaLogin.UseSystemPasswordChar=true;
            }
            
        }

        private void cbMostrarSenhaCad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenhaCad.Checked)
            {
                txbSenhaCad.UseSystemPasswordChar = false;
            }
            else
            {
                txbSenhaCad.UseSystemPasswordChar = true;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (cbCheckDocente.Checked)
            {
                Docentes docentes = new Docentes();

                DocenteCRUD docentecrud = new DocenteCRUD(_conexao);
                if (string.IsNullOrEmpty(txbNomeCad.Text) ||
                    string.IsNullOrEmpty(txbEmailCad.Text) ||
                        string.IsNullOrEmpty(txbSenhaCad.Text))
                {
                    MessageBox.Show("Preencha todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbCheckDocente.Checked = false;
                }
                else
                {
                    docentes.nome_docente = txbNomeCad.Text;
                    docentes.email_docente = txbEmailCad.Text;
                    docentes.senha_docente = txbSenhaCad.Text;

                    docentecrud.IncluiDocente(docentes);

                    MessageBox.Show("Docente cadastrado com sucesso!");
                    cbCheckDocente.Checked = false;
                    txbEmailCad.Text = string.Empty; txbNomeCad.Text = string.Empty; txbSenhaCad.Text = string.Empty;
                }
            }
            else
            {
                Alunos alunos = new Alunos();

                AlunoCRUD alunoscrud = new AlunoCRUD(_conexao);
                if (string.IsNullOrEmpty(txbNomeCad.Text) ||
                    string.IsNullOrEmpty(txbEmailCad.Text) ||
                        string.IsNullOrEmpty(txbSenhaCad.Text))
                {
                    MessageBox.Show("Preencha todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    alunos.nome_aluno = txbNomeCad.Text;
                    alunos.email_aluno = txbEmailCad.Text;
                    alunos.senha_aluno= txbSenhaCad.Text;

                    alunoscrud.IncluiAluno(alunos);

                    MessageBox.Show("Aluno cadastrado com sucesso!");
                    txbEmailCad.Text = string.Empty; txbNomeCad.Text = string.Empty; txbSenhaCad.Text = string.Empty;
                }
            }
            
        }


    }
}
