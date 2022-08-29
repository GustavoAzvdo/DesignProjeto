namespace Projeto
{
    partial class Form1
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
            this.btnCadastrarUsuario = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnCadastrarFuncao = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(311, 209);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(170, 23);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.UseSelectable = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarse_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(311, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCadastrarFuncao
            // 
            this.btnCadastrarFuncao.Location = new System.Drawing.Point(311, 164);
            this.btnCadastrarFuncao.Name = "btnCadastrarFuncao";
            this.btnCadastrarFuncao.Size = new System.Drawing.Size(170, 23);
            this.btnCadastrarFuncao.TabIndex = 2;
            this.btnCadastrarFuncao.Text = "Cadastrar Função";
            this.btnCadastrarFuncao.UseSelectable = true;
            this.btnCadastrarFuncao.Click += new System.EventHandler(this.btnCadastrarFuncao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarFuncao);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Name = "Form1";
            this.Text = "Menu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCadastrarUsuario;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnCadastrarFuncao;
    }
}

