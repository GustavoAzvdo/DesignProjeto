namespace Projeto
{
    partial class Form4
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
            this.btnProdutos = new MetroFramework.Controls.MetroButton();
            this.btnEstoque = new MetroFramework.Controls.MetroButton();
            this.btnCliente = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(320, 125);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(150, 23);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Cadastro de produtos";
            this.btnProdutos.UseSelectable = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(320, 311);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(150, 23);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseSelectable = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(320, 219);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(150, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cadastro de clientes";
            this.btnCliente.UseSelectable = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnProdutos);
            this.Name = "Form4";
            this.Text = "Administração";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnProdutos;
        private MetroFramework.Controls.MetroButton btnEstoque;
        private MetroFramework.Controls.MetroButton btnCliente;
    }
}