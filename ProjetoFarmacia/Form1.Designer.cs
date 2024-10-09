namespace ProjetoFarmacia
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMaterialConsumo = new System.Windows.Forms.RadioButton();
            this.rbUtensilios = new System.Windows.Forms.RadioButton();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLista);
            this.groupBox1.Controls.Add(this.btnRemoverProduto);
            this.groupBox1.Controls.Add(this.btnCadastro);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(10, 470);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(340, 44);
            this.btnCadastro.TabIndex = 7;
            this.btnCadastro.Text = "Cadastrar Novos Produtos";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMaterialConsumo);
            this.groupBox2.Controls.Add(this.rbUtensilios);
            this.groupBox2.Controls.Add(this.rbMateria);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setor";
            // 
            // rbMaterialConsumo
            // 
            this.rbMaterialConsumo.AutoSize = true;
            this.rbMaterialConsumo.Location = new System.Drawing.Point(3, 25);
            this.rbMaterialConsumo.Name = "rbMaterialConsumo";
            this.rbMaterialConsumo.Size = new System.Drawing.Size(177, 24);
            this.rbMaterialConsumo.TabIndex = 2;
            this.rbMaterialConsumo.TabStop = true;
            this.rbMaterialConsumo.Text = "Material de Consumo";
            this.rbMaterialConsumo.UseVisualStyleBackColor = true;
            // 
            // rbUtensilios
            // 
            this.rbUtensilios.AutoSize = true;
            this.rbUtensilios.Location = new System.Drawing.Point(3, 85);
            this.rbUtensilios.Name = "rbUtensilios";
            this.rbUtensilios.Size = new System.Drawing.Size(96, 24);
            this.rbUtensilios.TabIndex = 1;
            this.rbUtensilios.TabStop = true;
            this.rbUtensilios.Text = "Utensílios";
            this.rbUtensilios.UseVisualStyleBackColor = true;
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Location = new System.Drawing.Point(3, 55);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(124, 24);
            this.rbMateria.TabIndex = 0;
            this.rbMateria.TabStop = true;
            this.rbMateria.Text = "Matéria Prima";
            this.rbMateria.UseVisualStyleBackColor = true;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(10, 54);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(340, 26);
            this.txbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 646);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoverProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverProduto.Location = new System.Drawing.Point(10, 596);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(340, 44);
            this.btnRemoverProduto.TabIndex = 8;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = false;
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(12, 532);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(338, 44);
            this.btnLista.TabIndex = 9;
            this.btnLista.Text = "Lista de Compras";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.RadioButton rbMaterialConsumo;
        private System.Windows.Forms.RadioButton rbUtensilios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnRemoverProduto;
    }
}

