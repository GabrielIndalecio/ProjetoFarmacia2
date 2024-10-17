namespace ProjetoFarmacia
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.cbDocenteLogin = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbSenhaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmailLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCheckDocente = new System.Windows.Forms.CheckBox();
            this.cbMostrarSenhaCad = new System.Windows.Forms.CheckBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.lblCadastroLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAnuncio = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnuncio)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.Location = new System.Drawing.Point(382, 151);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(125, 22);
            this.cbMostrarSenha.TabIndex = 6;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // cbDocenteLogin
            // 
            this.cbDocenteLogin.AutoSize = true;
            this.cbDocenteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocenteLogin.Location = new System.Drawing.Point(9, 191);
            this.cbDocenteLogin.Name = "cbDocenteLogin";
            this.cbDocenteLogin.Size = new System.Drawing.Size(130, 22);
            this.cbDocenteLogin.TabIndex = 5;
            this.cbDocenteLogin.Text = "É um Docente?";
            this.cbDocenteLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(141, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbSenhaLogin
            // 
            this.txbSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaLogin.Location = new System.Drawing.Point(9, 145);
            this.txbSenhaLogin.Name = "txbSenhaLogin";
            this.txbSenhaLogin.Size = new System.Drawing.Size(367, 29);
            this.txbSenhaLogin.TabIndex = 3;
            this.txbSenhaLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSenhaLogin_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txbEmailLogin
            // 
            this.txbEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailLogin.Location = new System.Drawing.Point(9, 68);
            this.txbEmailLogin.Name = "txbEmailLogin";
            this.txbEmailLogin.Size = new System.Drawing.Size(367, 29);
            this.txbEmailLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // cbCheckDocente
            // 
            this.cbCheckDocente.AutoSize = true;
            this.cbCheckDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckDocente.Location = new System.Drawing.Point(20, 238);
            this.cbCheckDocente.Name = "cbCheckDocente";
            this.cbCheckDocente.Size = new System.Drawing.Size(130, 22);
            this.cbCheckDocente.TabIndex = 10;
            this.cbCheckDocente.Text = "É um Docente?";
            this.cbCheckDocente.UseVisualStyleBackColor = true;
            // 
            // cbMostrarSenhaCad
            // 
            this.cbMostrarSenhaCad.AutoSize = true;
            this.cbMostrarSenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenhaCad.Location = new System.Drawing.Point(392, 202);
            this.cbMostrarSenhaCad.Name = "cbMostrarSenhaCad";
            this.cbMostrarSenhaCad.Size = new System.Drawing.Size(125, 22);
            this.cbMostrarSenhaCad.TabIndex = 9;
            this.cbMostrarSenhaCad.Text = "Mostrar Senha";
            this.cbMostrarSenhaCad.UseVisualStyleBackColor = true;
            this.cbMostrarSenhaCad.CheckedChanged += new System.EventHandler(this.cbMostrarSenhaCad_CheckedChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(183, 280);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(106, 38);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaCad.Location = new System.Drawing.Point(19, 196);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(367, 29);
            this.txbSenhaCad.TabIndex = 5;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailCad.Location = new System.Drawing.Point(19, 125);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(367, 29);
            this.txbEmailCad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(19, 45);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(367, 29);
            this.txbNomeCad.TabIndex = 2;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.cbMostrarSenha);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.cbDocenteLogin);
            this.panelLogin.Controls.Add(this.txbEmailLogin);
            this.panelLogin.Controls.Add(this.txbSenhaLogin);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(583, 171);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(512, 270);
            this.panelLogin.TabIndex = 1;
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.lblCadastroLogin);
            this.panelCadastro.Controls.Add(this.cbCheckDocente);
            this.panelCadastro.Controls.Add(this.txbNomeCad);
            this.panelCadastro.Controls.Add(this.cbMostrarSenhaCad);
            this.panelCadastro.Controls.Add(this.label3);
            this.panelCadastro.Controls.Add(this.btnCadastro);
            this.panelCadastro.Controls.Add(this.txbEmailCad);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Controls.Add(this.txbSenhaCad);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Location = new System.Drawing.Point(575, 114);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(520, 327);
            this.panelCadastro.TabIndex = 2;
            this.panelCadastro.Visible = false;
            // 
            // lblCadastroLogin
            // 
            this.lblCadastroLogin.AutoSize = true;
            this.lblCadastroLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroLogin.Location = new System.Drawing.Point(180, 241);
            this.lblCadastroLogin.Name = "lblCadastroLogin";
            this.lblCadastroLogin.Size = new System.Drawing.Size(234, 16);
            this.lblCadastroLogin.TabIndex = 3;
            this.lblCadastroLogin.Text = "Já tem um Cadastro? Clique aqui";
            this.lblCadastroLogin.Click += new System.EventHandler(this.lblCadastroLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ainda não tem um Cadastro? Clique aqui";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbAnuncio);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 574);
            this.panel1.TabIndex = 3;
            // 
            // pbAnuncio
            // 
            this.pbAnuncio.Image = ((System.Drawing.Image)(resources.GetObject("pbAnuncio.Image")));
            this.pbAnuncio.Location = new System.Drawing.Point(-60, 2);
            this.pbAnuncio.Name = "pbAnuncio";
            this.pbAnuncio.Size = new System.Drawing.Size(691, 571);
            this.pbAnuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnuncio.TabIndex = 0;
            this.pbAnuncio.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(717, 69);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(115, 42);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 572);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1123, 611);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1123, 611);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnuncio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmailLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSenhaLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.CheckBox cbDocenteLogin;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.CheckBox cbMostrarSenhaCad;
        private System.Windows.Forms.CheckBox cbCheckDocente;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label lblCadastroLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAnuncio;
        private System.Windows.Forms.Label lblLogin;
    }
}