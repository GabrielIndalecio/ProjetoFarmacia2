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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMaterialConsumo = new System.Windows.Forms.RadioButton();
            this.rbUtensilios = new System.Windows.Forms.RadioButton();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbReturnExpand = new System.Windows.Forms.PictureBox();
            this.pbFlechaExpand = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLista = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnManipulacao = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_NomePrincipal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetFiltro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProdutoManipulado = new System.Windows.Forms.RadioButton();
            this.rbProdutosControlados = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnManiBaixa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProdutos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txbNomePesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInformacao = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBox2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlechaExpand)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rbMaterialConsumo);
            this.groupBox2.Controls.Add(this.rbUtensilios);
            this.groupBox2.Controls.Add(this.rbMateria);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(97, 222);
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
            this.rbMaterialConsumo.Text = "Material de Consumo";
            this.rbMaterialConsumo.UseVisualStyleBackColor = true;
            this.rbMaterialConsumo.CheckedChanged += new System.EventHandler(this.rbMaterialConsumo_CheckedChanged);
            // 
            // rbUtensilios
            // 
            this.rbUtensilios.AutoSize = true;
            this.rbUtensilios.Location = new System.Drawing.Point(3, 85);
            this.rbUtensilios.Name = "rbUtensilios";
            this.rbUtensilios.Size = new System.Drawing.Size(96, 24);
            this.rbUtensilios.TabIndex = 1;
            this.rbUtensilios.Text = "Utensílios";
            this.rbUtensilios.UseVisualStyleBackColor = true;
            this.rbUtensilios.CheckedChanged += new System.EventHandler(this.rbUtensilios_CheckedChanged);
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Location = new System.Drawing.Point(3, 55);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(124, 24);
            this.rbMateria.TabIndex = 0;
            this.rbMateria.Text = "Matéria Prima";
            this.rbMateria.UseVisualStyleBackColor = true;
            this.rbMateria.CheckedChanged += new System.EventHandler(this.rbMateria_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(371, 681);
            this.sidebar.MinimumSize = new System.Drawing.Size(87, 681);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(87, 681);
            this.sidebar.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 80);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbReturnExpand);
            this.panel1.Controls.Add(this.pbFlechaExpand);
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 71);
            this.panel1.TabIndex = 1;
            // 
            // pbReturnExpand
            // 
            this.pbReturnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReturnExpand.Image = ((System.Drawing.Image)(resources.GetObject("pbReturnExpand.Image")));
            this.pbReturnExpand.Location = new System.Drawing.Point(0, 3);
            this.pbReturnExpand.Name = "pbReturnExpand";
            this.pbReturnExpand.Size = new System.Drawing.Size(84, 50);
            this.pbReturnExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturnExpand.TabIndex = 13;
            this.pbReturnExpand.TabStop = false;
            this.pbReturnExpand.Visible = false;
            this.pbReturnExpand.Click += new System.EventHandler(this.pbReturnExpand_Click);
            // 
            // pbFlechaExpand
            // 
            this.pbFlechaExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlechaExpand.Image = ((System.Drawing.Image)(resources.GetObject("pbFlechaExpand.Image")));
            this.pbFlechaExpand.Location = new System.Drawing.Point(0, 9);
            this.pbFlechaExpand.Name = "pbFlechaExpand";
            this.pbFlechaExpand.Size = new System.Drawing.Size(84, 50);
            this.pbFlechaExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFlechaExpand.TabIndex = 0;
            this.pbFlechaExpand.TabStop = false;
            this.pbFlechaExpand.Click += new System.EventHandler(this.pbFlechaExpand_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCadastro);
            this.panel2.Location = new System.Drawing.Point(3, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.White;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(3, 3);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(365, 94);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastrar Produto";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLista);
            this.panel3.Location = new System.Drawing.Point(3, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 100);
            this.panel3.TabIndex = 3;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.White;
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Image = ((System.Drawing.Image)(resources.GetObject("btnLista.Image")));
            this.btnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.Location = new System.Drawing.Point(5, 3);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(363, 94);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Lista de Compra";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnManipulacao);
            this.panel5.Location = new System.Drawing.Point(3, 378);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 100);
            this.panel5.TabIndex = 3;
            // 
            // btnManipulacao
            // 
            this.btnManipulacao.BackColor = System.Drawing.Color.White;
            this.btnManipulacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManipulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManipulacao.Image = ((System.Drawing.Image)(resources.GetObject("btnManipulacao.Image")));
            this.btnManipulacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManipulacao.Location = new System.Drawing.Point(3, 3);
            this.btnManipulacao.Name = "btnManipulacao";
            this.btnManipulacao.Size = new System.Drawing.Size(365, 94);
            this.btnManipulacao.TabIndex = 0;
            this.btnManipulacao.Text = "Cadastrar Manipulação";
            this.btnManipulacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManipulacao.UseVisualStyleBackColor = false;
            this.btnManipulacao.Click += new System.EventHandler(this.btnManipulacao_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // lbl_NomePrincipal
            // 
            this.lbl_NomePrincipal.AutoSize = true;
            this.lbl_NomePrincipal.BackColor = System.Drawing.Color.White;
            this.lbl_NomePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomePrincipal.Location = new System.Drawing.Point(94, 41);
            this.lbl_NomePrincipal.Name = "lbl_NomePrincipal";
            this.lbl_NomePrincipal.Size = new System.Drawing.Size(57, 20);
            this.lbl_NomePrincipal.TabIndex = 13;
            this.lbl_NomePrincipal.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnResetFiltro
            // 
            this.btnResetFiltro.BackColor = System.Drawing.Color.White;
            this.btnResetFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnResetFiltro.Image")));
            this.btnResetFiltro.Location = new System.Drawing.Point(298, 223);
            this.btnResetFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetFiltro.Name = "btnResetFiltro";
            this.btnResetFiltro.Size = new System.Drawing.Size(44, 40);
            this.btnResetFiltro.TabIndex = 17;
            this.btnResetFiltro.UseVisualStyleBackColor = false;
            this.btnResetFiltro.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbProdutoManipulado);
            this.groupBox1.Controls.Add(this.rbProdutosControlados);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(97, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // rbProdutoManipulado
            // 
            this.rbProdutoManipulado.AutoSize = true;
            this.rbProdutoManipulado.Location = new System.Drawing.Point(6, 110);
            this.rbProdutoManipulado.Name = "rbProdutoManipulado";
            this.rbProdutoManipulado.Size = new System.Drawing.Size(185, 24);
            this.rbProdutoManipulado.TabIndex = 6;
            this.rbProdutoManipulado.TabStop = true;
            this.rbProdutoManipulado.Text = "Produtos Manipulados";
            this.rbProdutoManipulado.UseVisualStyleBackColor = true;
            this.rbProdutoManipulado.CheckedChanged += new System.EventHandler(this.rbProdutoManipulado_CheckedChanged);
            // 
            // rbProdutosControlados
            // 
            this.rbProdutosControlados.AutoSize = true;
            this.rbProdutosControlados.Location = new System.Drawing.Point(6, 85);
            this.rbProdutosControlados.Name = "rbProdutosControlados";
            this.rbProdutosControlados.Size = new System.Drawing.Size(181, 24);
            this.rbProdutosControlados.TabIndex = 5;
            this.rbProdutosControlados.TabStop = true;
            this.rbProdutosControlados.Text = "Produtos Controlados";
            this.rbProdutosControlados.UseVisualStyleBackColor = true;
            this.rbProdutosControlados.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Produtos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // btnManiBaixa
            // 
            this.btnManiBaixa.BackColor = System.Drawing.Color.White;
            this.btnManiBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManiBaixa.Location = new System.Drawing.Point(97, 510);
            this.btnManiBaixa.Name = "btnManiBaixa";
            this.btnManiBaixa.Size = new System.Drawing.Size(200, 38);
            this.btnManiBaixa.TabIndex = 21;
            this.btnManiBaixa.Text = "Baixa";
            this.btnManiBaixa.UseVisualStyleBackColor = false;
            this.btnManiBaixa.Visible = false;
            this.btnManiBaixa.Click += new System.EventHandler(this.btnManiBaixa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filtros:";
            // 
            // dgvProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.ColumnHeadersHeight = 4;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProdutos.Location = new System.Drawing.Point(377, 22);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.Size = new System.Drawing.Size(868, 645);
            this.dgvProdutos.TabIndex = 25;
            this.dgvProdutos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProdutos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProdutos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProdutos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProdutos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProdutos.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProdutos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProdutos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProdutos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProdutos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProdutos.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProdutos.ThemeStyle.ReadOnly = true;
            this.dgvProdutos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProdutos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProdutos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProdutos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProdutos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProdutos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick_1);
            this.dgvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProdutos_CellFormatting_1);
            // 
            // txbNomePesquisa
            // 
            this.txbNomePesquisa.Animated = true;
            this.txbNomePesquisa.BackColor = System.Drawing.Color.White;
            this.txbNomePesquisa.BorderRadius = 10;
            this.txbNomePesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNomePesquisa.DefaultText = "";
            this.txbNomePesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNomePesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNomePesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNomePesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNomePesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNomePesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNomePesquisa.ForeColor = System.Drawing.Color.Black;
            this.txbNomePesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNomePesquisa.Location = new System.Drawing.Point(97, 172);
            this.txbNomePesquisa.Name = "txbNomePesquisa";
            this.txbNomePesquisa.PasswordChar = '\0';
            this.txbNomePesquisa.PlaceholderText = "";
            this.txbNomePesquisa.SelectedText = "";
            this.txbNomePesquisa.Size = new System.Drawing.Size(233, 26);
            this.txbNomePesquisa.TabIndex = 26;
            this.txbNomePesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNomePesquisa_KeyDown_1);
            // 
            // btnInformacao
            // 
            this.btnInformacao.Animated = true;
            this.btnInformacao.BackColor = System.Drawing.Color.White;
            this.btnInformacao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInformacao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInformacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInformacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInformacao.FillColor = System.Drawing.Color.Gainsboro;
            this.btnInformacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInformacao.ForeColor = System.Drawing.Color.White;
            this.btnInformacao.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacao.Image")));
            this.btnInformacao.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInformacao.Location = new System.Drawing.Point(309, 322);
            this.btnInformacao.Name = "btnInformacao";
            this.btnInformacao.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnInformacao.Size = new System.Drawing.Size(57, 54);
            this.btnInformacao.TabIndex = 27;
            this.btnInformacao.Visible = false;
            this.btnInformacao.Click += new System.EventHandler(this.btnInformacao_Click_1);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-402, -39);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(774, 760);
            this.guna2CirclePictureBox1.TabIndex = 29;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.btnInformacao);
            this.Controls.Add(this.txbNomePesquisa);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManiBaixa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_NomePrincipal);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1270, 720);
            this.MinimumSize = new System.Drawing.Size(1270, 720);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Farmacia";
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturnExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlechaExpand)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMaterialConsumo;
        private System.Windows.Forms.RadioButton rbUtensilios;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFlechaExpand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbReturnExpand;
        private System.Windows.Forms.Label lbl_NomePrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProdutosControlados;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnManiBaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnManipulacao;
        private System.Windows.Forms.RadioButton rbProdutoManipulado;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProdutos;
        private Guna.UI2.WinForms.Guna2TextBox txbNomePesquisa;
        private Guna.UI2.WinForms.Guna2CircleButton btnInformacao;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}

