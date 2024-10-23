namespace ProjetoFarmacia
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbLoteCad = new System.Windows.Forms.TextBox();
            this.txbDataEntradaProd = new System.Windows.Forms.MaskedTextBox();
            this.mtbFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpsetor = new System.Windows.Forms.GroupBox();
            this.rbMaterialConsumo = new System.Windows.Forms.RadioButton();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.rbUtensilio = new System.Windows.Forms.RadioButton();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarCad = new System.Windows.Forms.Button();
            this.txbUnidadeOutros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProdutoControlado = new System.Windows.Forms.CheckBox();
            this.txtNomeResp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTemperatura = new System.Windows.Forms.ComboBox();
            this.gpsetor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "Gramas(g)",
            "Mililitro(ml)",
            "Unidade",
            "Frasco",
            "Outros"});
            this.cbUnidade.Location = new System.Drawing.Point(351, 445);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(187, 21);
            this.cbUnidade.TabIndex = 28;
            this.cbUnidade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Unidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Lote:";
            // 
            // txbLoteCad
            // 
            this.txbLoteCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoteCad.Location = new System.Drawing.Point(121, 445);
            this.txbLoteCad.Name = "txbLoteCad";
            this.txbLoteCad.Size = new System.Drawing.Size(211, 26);
            this.txbLoteCad.TabIndex = 25;
            // 
            // txbDataEntradaProd
            // 
            this.txbDataEntradaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataEntradaProd.Location = new System.Drawing.Point(243, 354);
            this.txbDataEntradaProd.Mask = "00/00/0000";
            this.txbDataEntradaProd.Name = "txbDataEntradaProd";
            this.txbDataEntradaProd.Size = new System.Drawing.Size(89, 26);
            this.txbDataEntradaProd.TabIndex = 24;
            this.txbDataEntradaProd.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFabricacao
            // 
            this.mtbFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFabricacao.Location = new System.Drawing.Point(243, 383);
            this.mtbFabricacao.Mask = "00/00/0000";
            this.mtbFabricacao.Name = "mtbFabricacao";
            this.mtbFabricacao.Size = new System.Drawing.Size(89, 26);
            this.mtbFabricacao.TabIndex = 23;
            this.mtbFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataValidade
            // 
            this.mtbDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataValidade.Location = new System.Drawing.Point(243, 416);
            this.mtbDataValidade.Mask = "00/00/0000";
            this.mtbDataValidade.Name = "mtbDataValidade";
            this.mtbDataValidade.Size = new System.Drawing.Size(89, 26);
            this.mtbDataValidade.TabIndex = 22;
            this.mtbDataValidade.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data de Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data de Fabricação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Data de Validade:";
            // 
            // gpsetor
            // 
            this.gpsetor.Controls.Add(this.rbMaterialConsumo);
            this.gpsetor.Controls.Add(this.rbMateria);
            this.gpsetor.Controls.Add(this.rbUtensilio);
            this.gpsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsetor.Location = new System.Drawing.Point(68, 147);
            this.gpsetor.Name = "gpsetor";
            this.gpsetor.Size = new System.Drawing.Size(471, 75);
            this.gpsetor.TabIndex = 18;
            this.gpsetor.TabStop = false;
            this.gpsetor.Text = "Setor";
            // 
            // rbMaterialConsumo
            // 
            this.rbMaterialConsumo.AutoSize = true;
            this.rbMaterialConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaterialConsumo.Location = new System.Drawing.Point(288, 28);
            this.rbMaterialConsumo.Name = "rbMaterialConsumo";
            this.rbMaterialConsumo.Size = new System.Drawing.Size(177, 24);
            this.rbMaterialConsumo.TabIndex = 2;
            this.rbMaterialConsumo.TabStop = true;
            this.rbMaterialConsumo.Text = "Material de Consumo";
            this.rbMaterialConsumo.UseVisualStyleBackColor = true;
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMateria.Location = new System.Drawing.Point(140, 28);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(124, 24);
            this.rbMateria.TabIndex = 1;
            this.rbMateria.TabStop = true;
            this.rbMateria.Text = "Matéria Prima";
            this.rbMateria.UseVisualStyleBackColor = true;
            // 
            // rbUtensilio
            // 
            this.rbUtensilio.AutoSize = true;
            this.rbUtensilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUtensilio.Location = new System.Drawing.Point(6, 28);
            this.rbUtensilio.Name = "rbUtensilio";
            this.rbUtensilio.Size = new System.Drawing.Size(96, 24);
            this.rbUtensilio.TabIndex = 0;
            this.rbUtensilio.TabStop = true;
            this.rbUtensilio.Text = "Utensílios";
            this.rbUtensilio.UseVisualStyleBackColor = true;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(68, 256);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(471, 26);
            this.txbQuantidade.TabIndex = 17;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeProduto.Location = new System.Drawing.Point(68, 115);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(471, 26);
            this.txbNomeProduto.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de Produtos:";
            // 
            // btnSalvarCad
            // 
            this.btnSalvarCad.Location = new System.Drawing.Point(457, 578);
            this.btnSalvarCad.Name = "btnSalvarCad";
            this.btnSalvarCad.Size = new System.Drawing.Size(103, 32);
            this.btnSalvarCad.TabIndex = 29;
            this.btnSalvarCad.Text = "Salvar";
            this.btnSalvarCad.UseVisualStyleBackColor = true;
            this.btnSalvarCad.Click += new System.EventHandler(this.btnSalvarCad_Click);
            // 
            // txbUnidadeOutros
            // 
            this.txbUnidadeOutros.Location = new System.Drawing.Point(351, 498);
            this.txbUnidadeOutros.Name = "txbUnidadeOutros";
            this.txbUnidadeOutros.Size = new System.Drawing.Size(187, 20);
            this.txbUnidadeOutros.TabIndex = 30;
            this.txbUnidadeOutros.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Outros:";
            this.label9.Visible = false;
            // 
            // cbProdutoControlado
            // 
            this.cbProdutoControlado.AutoSize = true;
            this.cbProdutoControlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdutoControlado.Location = new System.Drawing.Point(121, 480);
            this.cbProdutoControlado.Name = "cbProdutoControlado";
            this.cbProdutoControlado.Size = new System.Drawing.Size(166, 24);
            this.cbProdutoControlado.TabIndex = 32;
            this.cbProdutoControlado.Text = "Produto Controlado";
            this.cbProdutoControlado.UseVisualStyleBackColor = true;
            this.cbProdutoControlado.CheckedChanged += new System.EventHandler(this.cbProdutoControlado_CheckedChanged);
            // 
            // txtNomeResp
            // 
            this.txtNomeResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeResp.Location = new System.Drawing.Point(68, 547);
            this.txtNomeResp.Name = "txtNomeResp";
            this.txtNomeResp.ReadOnly = true;
            this.txtNomeResp.Size = new System.Drawing.Size(355, 26);
            this.txtNomeResp.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Responsavel";
            // 
            // txbLocal
            // 
            this.txbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocal.Location = new System.Drawing.Point(68, 312);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(471, 26);
            this.txbLocal.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Local:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(347, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "Temperatura:";
            // 
            // cbTemperatura
            // 
            this.cbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemperatura.FormattingEnabled = true;
            this.cbTemperatura.Items.AddRange(new object[] {
            "Temp Ambiente",
            "Geladeira",
            "Freezer"});
            this.cbTemperatura.Location = new System.Drawing.Point(351, 381);
            this.cbTemperatura.Name = "cbTemperatura";
            this.cbTemperatura.Size = new System.Drawing.Size(187, 21);
            this.cbTemperatura.TabIndex = 38;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 626);
            this.Controls.Add(this.cbTemperatura);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbLocal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomeResp);
            this.Controls.Add(this.cbProdutoControlado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbUnidadeOutros);
            this.Controls.Add(this.btnSalvarCad);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbLoteCad);
            this.Controls.Add(this.txbDataEntradaProd);
            this.Controls.Add(this.mtbFabricacao);
            this.Controls.Add(this.mtbDataValidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpsetor);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbNomeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.gpsetor.ResumeLayout(false);
            this.gpsetor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbLoteCad;
        private System.Windows.Forms.MaskedTextBox txbDataEntradaProd;
        private System.Windows.Forms.MaskedTextBox mtbFabricacao;
        private System.Windows.Forms.MaskedTextBox mtbDataValidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpsetor;
        private System.Windows.Forms.RadioButton rbMaterialConsumo;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.RadioButton rbUtensilio;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarCad;
        private System.Windows.Forms.TextBox txbUnidadeOutros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbProdutoControlado;
        private System.Windows.Forms.TextBox txtNomeResp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTemperatura;
    }
}