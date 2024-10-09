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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.cbDocente = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbSenhaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmailLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabCadastro = new System.Windows.Forms.TabPage();
            this.cbCheckDocente = new System.Windows.Forms.CheckBox();
            this.cbMostrarSenhaCad = new System.Windows.Forms.CheckBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.TabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.TabCadastro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabLogin.Controls.Add(this.cbMostrarSenha);
            this.TabLogin.Controls.Add(this.cbDocente);
            this.TabLogin.Controls.Add(this.btnLogin);
            this.TabLogin.Controls.Add(this.txbSenhaLogin);
            this.TabLogin.Controls.Add(this.label2);
            this.TabLogin.Controls.Add(this.txbEmailLogin);
            this.TabLogin.Controls.Add(this.label1);
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TabLogin.Size = new System.Drawing.Size(655, 322);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.Text = "Login";
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.Location = new System.Drawing.Point(514, 148);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(125, 22);
            this.cbMostrarSenha.TabIndex = 6;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // cbDocente
            // 
            this.cbDocente.AutoSize = true;
            this.cbDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocente.Location = new System.Drawing.Point(263, 188);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(130, 22);
            this.cbDocente.TabIndex = 5;
            this.cbDocente.Text = "É um Docente?";
            this.cbDocente.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(273, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txbSenhaLogin
            // 
            this.txbSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaLogin.Location = new System.Drawing.Point(141, 142);
            this.txbSenhaLogin.Name = "txbSenhaLogin";
            this.txbSenhaLogin.Size = new System.Drawing.Size(367, 29);
            this.txbSenhaLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txbEmailLogin
            // 
            this.txbEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailLogin.Location = new System.Drawing.Point(141, 65);
            this.txbEmailLogin.Name = "txbEmailLogin";
            this.txbEmailLogin.Size = new System.Drawing.Size(367, 29);
            this.txbEmailLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // TabCadastro
            // 
            this.TabCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabCadastro.Controls.Add(this.cbCheckDocente);
            this.TabCadastro.Controls.Add(this.cbMostrarSenhaCad);
            this.TabCadastro.Controls.Add(this.btnCadastro);
            this.TabCadastro.Controls.Add(this.label5);
            this.TabCadastro.Controls.Add(this.label4);
            this.TabCadastro.Controls.Add(this.txbSenhaCad);
            this.TabCadastro.Controls.Add(this.txbEmailCad);
            this.TabCadastro.Controls.Add(this.label3);
            this.TabCadastro.Controls.Add(this.txbNomeCad);
            this.TabCadastro.Location = new System.Drawing.Point(4, 22);
            this.TabCadastro.Name = "TabCadastro";
            this.TabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadastro.Size = new System.Drawing.Size(655, 322);
            this.TabCadastro.TabIndex = 1;
            this.TabCadastro.Text = "Cadastro";
            // 
            // cbCheckDocente
            // 
            this.cbCheckDocente.AutoSize = true;
            this.cbCheckDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckDocente.Location = new System.Drawing.Point(55, 271);
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
            this.cbMostrarSenhaCad.Location = new System.Drawing.Point(428, 223);
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
            this.btnCadastro.Location = new System.Drawing.Point(475, 262);
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
            this.label5.Location = new System.Drawing.Point(51, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaCad.Location = new System.Drawing.Point(55, 217);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(367, 29);
            this.txbSenhaCad.TabIndex = 5;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailCad.Location = new System.Drawing.Point(55, 146);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(367, 29);
            this.txbEmailCad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(55, 66);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(367, 29);
            this.txbNomeCad.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 372);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(703, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 411);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.TabCadastro.ResumeLayout(false);
            this.TabCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage TabCadastro;
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
        private System.Windows.Forms.CheckBox cbDocente;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.CheckBox cbMostrarSenhaCad;
        private System.Windows.Forms.CheckBox cbCheckDocente;
    }
}