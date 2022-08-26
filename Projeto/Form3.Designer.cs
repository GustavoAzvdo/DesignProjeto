namespace Projeto
{
    partial class Login
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
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.labelSenhaLogin = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenhaLogin = new MetroFramework.Controls.MetroTextBox();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(187, 131);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(56, 19);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuário:";
            // 
            // labelSenhaLogin
            // 
            this.labelSenhaLogin.AutoSize = true;
            this.labelSenhaLogin.Location = new System.Drawing.Point(187, 181);
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            this.labelSenhaLogin.Size = new System.Drawing.Size(47, 19);
            this.labelSenhaLogin.TabIndex = 1;
            this.labelSenhaLogin.Text = "Senha:";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(280, 127);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(317, 23);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSenhaLogin
            // 
            // 
            // 
            // 
            this.txtSenhaLogin.CustomButton.Image = null;
            this.txtSenhaLogin.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSenhaLogin.CustomButton.Name = "";
            this.txtSenhaLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenhaLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenhaLogin.CustomButton.TabIndex = 1;
            this.txtSenhaLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenhaLogin.CustomButton.UseSelectable = true;
            this.txtSenhaLogin.CustomButton.Visible = false;
            this.txtSenhaLogin.Lines = new string[0];
            this.txtSenhaLogin.Location = new System.Drawing.Point(280, 181);
            this.txtSenhaLogin.MaxLength = 32767;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '\0';
            this.txtSenhaLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenhaLogin.SelectedText = "";
            this.txtSenhaLogin.SelectionLength = 0;
            this.txtSenhaLogin.SelectionStart = 0;
            this.txtSenhaLogin.ShortcutsEnabled = true;
            this.txtSenhaLogin.Size = new System.Drawing.Size(317, 23);
            this.txtSenhaLogin.TabIndex = 3;
            this.txtSenhaLogin.UseSelectable = true;
            this.txtSenhaLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenhaLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(467, 228);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(130, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseSelectable = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelSenhaLogin);
            this.Controls.Add(this.labelUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelUsuario;
        private MetroFramework.Controls.MetroLabel labelSenhaLogin;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenhaLogin;
        private MetroFramework.Controls.MetroButton btnEntrar;
    }
}