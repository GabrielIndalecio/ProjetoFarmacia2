namespace ProjetoFarmacia
{
    partial class frmListaCompra
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 15);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(332, 420);
            this.lbLista.TabIndex = 1;
            // 
            // frmListaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.lbLista);
            this.Name = "frmListaCompra";
            this.Text = "Lista de Compras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
    }
}