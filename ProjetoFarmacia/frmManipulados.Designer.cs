namespace ProjetoFarmacia
{
    partial class frmManipulados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManipulados));
            this.dgvManipulados = new System.Windows.Forms.DataGridView();
            this.txbNomeMani = new System.Windows.Forms.TextBox();
            this.txbQuantidadeMani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLocalMani = new System.Windows.Forms.TextBox();
            this.cbUnidadeMani = new System.Windows.Forms.ComboBox();
            this.txbUnidadeOutrosMani = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTemperatura = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbValidadeMani = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFabricacaoMani = new System.Windows.Forms.MaskedTextBox();
            this.chbProdutoControlMani = new System.Windows.Forms.CheckBox();
            this.txbLoteMani = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbResponsavelMani = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalvarMani = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManipulados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManipulados
            // 
            this.dgvManipulados.AllowUserToAddRows = false;
            this.dgvManipulados.AllowUserToDeleteRows = false;
            this.dgvManipulados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManipulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManipulados.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvManipulados.Location = new System.Drawing.Point(671, 0);
            this.dgvManipulados.Name = "dgvManipulados";
            this.dgvManipulados.ReadOnly = true;
            this.dgvManipulados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManipulados.Size = new System.Drawing.Size(571, 651);
            this.dgvManipulados.TabIndex = 0;
            this.dgvManipulados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManipulados_CellContentClick);
            // 
            // txbNomeMani
            // 
            this.txbNomeMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeMani.Location = new System.Drawing.Point(80, 136);
            this.txbNomeMani.Name = "txbNomeMani";
            this.txbNomeMani.Size = new System.Drawing.Size(340, 26);
            this.txbNomeMani.TabIndex = 1;
            // 
            // txbQuantidadeMani
            // 
            this.txbQuantidadeMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidadeMani.Location = new System.Drawing.Point(80, 211);
            this.txbQuantidadeMani.Name = "txbQuantidadeMani";
            this.txbQuantidadeMani.Size = new System.Drawing.Size(340, 26);
            this.txbQuantidadeMani.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // txbLocalMani
            // 
            this.txbLocalMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocalMani.Location = new System.Drawing.Point(80, 280);
            this.txbLocalMani.Name = "txbLocalMani";
            this.txbLocalMani.Size = new System.Drawing.Size(340, 26);
            this.txbLocalMani.TabIndex = 5;
            // 
            // cbUnidadeMani
            // 
            this.cbUnidadeMani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadeMani.FormattingEnabled = true;
            this.cbUnidadeMani.Items.AddRange(new object[] {
            "Gramas(g)",
            "Mililitro(ml)",
            "Unidade",
            "Frasco",
            "Outros"});
            this.cbUnidadeMani.Location = new System.Drawing.Point(471, 136);
            this.cbUnidadeMani.Name = "cbUnidadeMani";
            this.cbUnidadeMani.Size = new System.Drawing.Size(172, 28);
            this.cbUnidadeMani.TabIndex = 6;
            this.cbUnidadeMani.SelectedIndexChanged += new System.EventHandler(this.cbUnidadeMani_SelectedIndexChanged);
            // 
            // txbUnidadeOutrosMani
            // 
            this.txbUnidadeOutrosMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUnidadeOutrosMani.Location = new System.Drawing.Point(471, 213);
            this.txbUnidadeOutrosMani.Name = "txbUnidadeOutrosMani";
            this.txbUnidadeOutrosMani.Size = new System.Drawing.Size(172, 26);
            this.txbUnidadeOutrosMani.TabIndex = 7;
            this.txbUnidadeOutrosMani.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Outros:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidade";
            // 
            // cbTemperatura
            // 
            this.cbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemperatura.FormattingEnabled = true;
            this.cbTemperatura.Items.AddRange(new object[] {
            "Temp Ambiente",
            "Geladeira",
            "Freezer"});
            this.cbTemperatura.Location = new System.Drawing.Point(471, 280);
            this.cbTemperatura.Name = "cbTemperatura";
            this.cbTemperatura.Size = new System.Drawing.Size(172, 28);
            this.cbTemperatura.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(467, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "Temperatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Local";
            // 
            // txbValidadeMani
            // 
            this.txbValidadeMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValidadeMani.Location = new System.Drawing.Point(260, 335);
            this.txbValidadeMani.Mask = "00/00/0000";
            this.txbValidadeMani.Name = "txbValidadeMani";
            this.txbValidadeMani.Size = new System.Drawing.Size(89, 26);
            this.txbValidadeMani.TabIndex = 40;
            this.txbValidadeMani.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Data de Fabricação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Data de Validade:";
            // 
            // txbFabricacaoMani
            // 
            this.txbFabricacaoMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFabricacaoMani.Location = new System.Drawing.Point(260, 373);
            this.txbFabricacaoMani.Mask = "00/00/0000";
            this.txbFabricacaoMani.Name = "txbFabricacaoMani";
            this.txbFabricacaoMani.Size = new System.Drawing.Size(89, 26);
            this.txbFabricacaoMani.TabIndex = 44;
            this.txbFabricacaoMani.ValidatingType = typeof(System.DateTime);
            // 
            // chbProdutoControlMani
            // 
            this.chbProdutoControlMani.AutoSize = true;
            this.chbProdutoControlMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbProdutoControlMani.Location = new System.Drawing.Point(471, 337);
            this.chbProdutoControlMani.Name = "chbProdutoControlMani";
            this.chbProdutoControlMani.Size = new System.Drawing.Size(166, 24);
            this.chbProdutoControlMani.TabIndex = 45;
            this.chbProdutoControlMani.Text = "Produto Controlado";
            this.chbProdutoControlMani.UseVisualStyleBackColor = true;
            // 
            // txbLoteMani
            // 
            this.txbLoteMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoteMani.Location = new System.Drawing.Point(77, 437);
            this.txbLoteMani.Name = "txbLoteMani";
            this.txbLoteMani.Size = new System.Drawing.Size(299, 26);
            this.txbLoteMani.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Lote:";
            // 
            // txbResponsavelMani
            // 
            this.txbResponsavelMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResponsavelMani.Location = new System.Drawing.Point(77, 510);
            this.txbResponsavelMani.Name = "txbResponsavelMani";
            this.txbResponsavelMani.Size = new System.Drawing.Size(302, 26);
            this.txbResponsavelMani.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Responsavel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 39);
            this.label10.TabIndex = 50;
            this.label10.Text = "Manipulação";
            // 
            // btnSalvarMani
            // 
            this.btnSalvarMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMani.Location = new System.Drawing.Point(454, 565);
            this.btnSalvarMani.Name = "btnSalvarMani";
            this.btnSalvarMani.Size = new System.Drawing.Size(89, 35);
            this.btnSalvarMani.TabIndex = 51;
            this.btnSalvarMani.Text = "Salvar";
            this.btnSalvarMani.UseVisualStyleBackColor = true;
            this.btnSalvarMani.Click += new System.EventHandler(this.btnSalvarMani_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(475, 12);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(168, 26);
            this.txbPesquisa.TabIndex = 52;
            this.txbPesquisa.Visible = false;
            // 
            // frmManipulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1242, 651);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.btnSalvarMani);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbResponsavelMani);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbLoteMani);
            this.Controls.Add(this.chbProdutoControlMani);
            this.Controls.Add(this.txbFabricacaoMani);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbValidadeMani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUnidadeOutrosMani);
            this.Controls.Add(this.cbUnidadeMani);
            this.Controls.Add(this.txbLocalMani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbQuantidadeMani);
            this.Controls.Add(this.txbNomeMani);
            this.Controls.Add(this.dgvManipulados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1258, 690);
            this.MinimumSize = new System.Drawing.Size(1258, 690);
            this.Name = "frmManipulados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManipulados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManipulados;
        private System.Windows.Forms.TextBox txbNomeMani;
        private System.Windows.Forms.TextBox txbQuantidadeMani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLocalMani;
        private System.Windows.Forms.ComboBox cbUnidadeMani;
        private System.Windows.Forms.TextBox txbUnidadeOutrosMani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTemperatura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txbValidadeMani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txbFabricacaoMani;
        private System.Windows.Forms.CheckBox chbProdutoControlMani;
        private System.Windows.Forms.TextBox txbLoteMani;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbResponsavelMani;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalvarMani;
        private System.Windows.Forms.TextBox txbPesquisa;
    }
}