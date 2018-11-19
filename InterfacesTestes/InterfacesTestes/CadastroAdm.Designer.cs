namespace InterfacesTestes
{
    partial class CadastroAdm
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
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(42, 26);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(100, 20);
            this.TxtLogin.TabIndex = 0;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(42, 65);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 1;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(42, 103);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.TxtMatricula.TabIndex = 2;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(42, 142);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(281, 26);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 4;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(281, 61);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "button1";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // CadastroAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 248);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtLogin);
            this.Name = "CadastroAdm";
            this.Text = "CadastroAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}