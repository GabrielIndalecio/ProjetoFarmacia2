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
            this.txtNomeMani = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtQuantidadeAtual = new System.Windows.Forms.TextBox();
            this.txtQuantidadeRetirar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.cbProdutoControlado = new System.Windows.Forms.CheckBox();
            this.gpsetor = new System.Windows.Forms.GroupBox();
            this.rbMaterialConsumoInf = new System.Windows.Forms.RadioButton();
            this.rbMateriaInf = new System.Windows.Forms.RadioButton();
            this.rbUtensilioInf = new System.Windows.Forms.RadioButton();
            this.gpsetor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeMani
            // 
            this.txtNomeMani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMani.Location = new System.Drawing.Point(121, 85);
            this.txtNomeMani.Name = "txtNomeMani";
            this.txtNomeMani.ReadOnly = true;
            this.txtNomeMani.Size = new System.Drawing.Size(273, 29);
            this.txtNomeMani.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(121, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "label1";
            // 
            // txtQuantidadeAtual
            // 
            this.txtQuantidadeAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeAtual.Location = new System.Drawing.Point(121, 280);
            this.txtQuantidadeAtual.Name = "txtQuantidadeAtual";
            this.txtQuantidadeAtual.ReadOnly = true;
            this.txtQuantidadeAtual.Size = new System.Drawing.Size(85, 29);
            this.txtQuantidadeAtual.TabIndex = 2;
            // 
            // txtQuantidadeRetirar
            // 
            this.txtQuantidadeRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeRetirar.Location = new System.Drawing.Point(309, 280);
            this.txtQuantidadeRetirar.Name = "txtQuantidadeRetirar";
            this.txtQuantidadeRetirar.Size = new System.Drawing.Size(85, 29);
            this.txtQuantidadeRetirar.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(199, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 42);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(121, 227);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(109, 29);
            this.txtUnidade.TabIndex = 6;
            // 
            // cbProdutoControlado
            // 
            this.cbProdutoControlado.AutoSize = true;
            this.cbProdutoControlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdutoControlado.Location = new System.Drawing.Point(121, 333);
            this.cbProdutoControlado.Name = "cbProdutoControlado";
            this.cbProdutoControlado.Size = new System.Drawing.Size(176, 22);
            this.cbProdutoControlado.TabIndex = 7;
            this.cbProdutoControlado.Text = "Produto Controlado";
            this.cbProdutoControlado.UseVisualStyleBackColor = true;
            // 
            // gpsetor
            // 
            this.gpsetor.Controls.Add(this.rbMaterialConsumoInf);
            this.gpsetor.Controls.Add(this.rbMateriaInf);
            this.gpsetor.Controls.Add(this.rbUtensilioInf);
            this.gpsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsetor.Location = new System.Drawing.Point(12, 127);
            this.gpsetor.Name = "gpsetor";
            this.gpsetor.Size = new System.Drawing.Size(471, 75);
            this.gpsetor.TabIndex = 41;
            this.gpsetor.TabStop = false;
            this.gpsetor.Text = "Setor";
            // 
            // rbMaterialConsumoInf
            // 
            this.rbMaterialConsumoInf.AutoSize = true;
            this.rbMaterialConsumoInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaterialConsumoInf.Location = new System.Drawing.Point(288, 28);
            this.rbMaterialConsumoInf.Name = "rbMaterialConsumoInf";
            this.rbMaterialConsumoInf.Size = new System.Drawing.Size(177, 24);
            this.rbMaterialConsumoInf.TabIndex = 2;
            this.rbMaterialConsumoInf.TabStop = true;
            this.rbMaterialConsumoInf.Text = "Material de Consumo";
            this.rbMaterialConsumoInf.UseVisualStyleBackColor = true;
            // 
            // rbMateriaInf
            // 
            this.rbMateriaInf.AutoSize = true;
            this.rbMateriaInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMateriaInf.Location = new System.Drawing.Point(140, 28);
            this.rbMateriaInf.Name = "rbMateriaInf";
            this.rbMateriaInf.Size = new System.Drawing.Size(124, 24);
            this.rbMateriaInf.TabIndex = 1;
            this.rbMateriaInf.TabStop = true;
            this.rbMateriaInf.Text = "Matéria Prima";
            this.rbMateriaInf.UseVisualStyleBackColor = true;
            // 
            // rbUtensilioInf
            // 
            this.rbUtensilioInf.AutoSize = true;
            this.rbUtensilioInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUtensilioInf.Location = new System.Drawing.Point(6, 28);
            this.rbUtensilioInf.Name = "rbUtensilioInf";
            this.rbUtensilioInf.Size = new System.Drawing.Size(96, 24);
            this.rbUtensilioInf.TabIndex = 0;
            this.rbUtensilioInf.TabStop = true;
            this.rbUtensilioInf.Text = "Utensílios";
            this.rbUtensilioInf.UseVisualStyleBackColor = true;
            // 
            // frmManipulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 476);
            this.Controls.Add(this.gpsetor);
            this.Controls.Add(this.cbProdutoControlado);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidadeRetirar);
            this.Controls.Add(this.txtQuantidadeAtual);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNomeMani);
            this.Name = "frmManipulados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulação";
            this.gpsetor.ResumeLayout(false);
            this.gpsetor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeMani;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtQuantidadeAtual;
        private System.Windows.Forms.TextBox txtQuantidadeRetirar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.CheckBox cbProdutoControlado;
        private System.Windows.Forms.GroupBox gpsetor;
        private System.Windows.Forms.RadioButton rbMaterialConsumoInf;
        private System.Windows.Forms.RadioButton rbMateriaInf;
        private System.Windows.Forms.RadioButton rbUtensilioInf;
    }
}