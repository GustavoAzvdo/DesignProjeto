namespace Projeto
{
    partial class Form2
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
            this.labelNomeCadastro = new MetroFramework.Controls.MetroLabel();
            this.labelSenha = new MetroFramework.Controls.MetroLabel();
            this.txtNomeUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnInserirUsuario = new MetroFramework.Controls.MetroButton();
            this.labelEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFuncao = new MetroFramework.Controls.MetroLabel();
            this.btnDeletarUsuario = new MetroFramework.Controls.MetroButton();
            this.btnAlterarUsuario = new MetroFramework.Controls.MetroButton();
            this.btnBuscarUsuario = new MetroFramework.Controls.MetroButton();
            this.btnVoltarUsuario = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelNomeCadastro
            // 
            this.labelNomeCadastro.AutoSize = true;
            this.labelNomeCadastro.Location = new System.Drawing.Point(173, 91);
            this.labelNomeCadastro.Name = "labelNomeCadastro";
            this.labelNomeCadastro.Size = new System.Drawing.Size(97, 19);
            this.labelNomeCadastro.TabIndex = 0;
            this.labelNomeCadastro.Text = "Nome Usuário:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(173, 130);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(47, 19);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha:";
            // 
            // txtNomeUsuario
            // 
            // 
            // 
            // 
            this.txtNomeUsuario.CustomButton.Image = null;
            this.txtNomeUsuario.CustomButton.Location = new System.Drawing.Point(295, 1);
            this.txtNomeUsuario.CustomButton.Name = "";
            this.txtNomeUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeUsuario.CustomButton.TabIndex = 1;
            this.txtNomeUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeUsuario.CustomButton.UseSelectable = true;
            this.txtNomeUsuario.CustomButton.Visible = false;
            this.txtNomeUsuario.Lines = new string[0];
            this.txtNomeUsuario.Location = new System.Drawing.Point(303, 87);
            this.txtNomeUsuario.MaxLength = 32767;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.SelectionLength = 0;
            this.txtNomeUsuario.SelectionStart = 0;
            this.txtNomeUsuario.ShortcutsEnabled = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(317, 23);
            this.txtNomeUsuario.TabIndex = 3;
            this.txtNomeUsuario.UseSelectable = true;
            this.txtNomeUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(295, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(303, 126);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(317, 23);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInserirUsuario
            // 
            this.btnInserirUsuario.BackColor = System.Drawing.Color.White;
            this.btnInserirUsuario.Location = new System.Drawing.Point(303, 242);
            this.btnInserirUsuario.Name = "btnInserirUsuario";
            this.btnInserirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnInserirUsuario.TabIndex = 6;
            this.btnInserirUsuario.Text = "Inserir";
            this.btnInserirUsuario.UseSelectable = true;
            this.btnInserirUsuario.Click += new System.EventHandler(this.btnConfirmarCadastro_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(173, 170);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 19);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(295, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(303, 165);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(317, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // labelFuncao
            // 
            this.labelFuncao.AutoSize = true;
            this.labelFuncao.Location = new System.Drawing.Point(173, 204);
            this.labelFuncao.Name = "labelFuncao";
            this.labelFuncao.Size = new System.Drawing.Size(54, 19);
            this.labelFuncao.TabIndex = 13;
            this.labelFuncao.Text = "Função:";
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.Location = new System.Drawing.Point(384, 242);
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarUsuario.TabIndex = 14;
            this.btnDeletarUsuario.Text = "Deletar";
            this.btnDeletarUsuario.UseSelectable = true;
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.Location = new System.Drawing.Point(465, 242);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarUsuario.TabIndex = 15;
            this.btnAlterarUsuario.Text = "Alterar";
            this.btnAlterarUsuario.UseSelectable = true;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(545, 242);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 16;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseSelectable = true;
            // 
            // btnVoltarUsuario
            // 
            this.btnVoltarUsuario.Location = new System.Drawing.Point(23, 404);
            this.btnVoltarUsuario.Name = "btnVoltarUsuario";
            this.btnVoltarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarUsuario.TabIndex = 17;
            this.btnVoltarUsuario.Text = "Voltar";
            this.btnVoltarUsuario.UseSelectable = true;
            this.btnVoltarUsuario.Click += new System.EventHandler(this.btnVoltarUsuario_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.btnDeletarUsuario);
            this.Controls.Add(this.labelFuncao);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnInserirUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelNomeCadastro);
            this.Name = "Form2";
            this.Text = "Cadastrar Usuário";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelNomeCadastro;
        private MetroFramework.Controls.MetroLabel labelSenha;
        private MetroFramework.Controls.MetroTextBox txtNomeUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnInserirUsuario;
        private MetroFramework.Controls.MetroLabel labelEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroLabel labelFuncao;
        private MetroFramework.Controls.MetroButton btnDeletarUsuario;
        private MetroFramework.Controls.MetroButton btnAlterarUsuario;
        private MetroFramework.Controls.MetroButton btnBuscarUsuario;
        private MetroFramework.Controls.MetroButton btnVoltarUsuario;
    }
}