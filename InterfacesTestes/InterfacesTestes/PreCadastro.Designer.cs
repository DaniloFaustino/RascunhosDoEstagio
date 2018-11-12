namespace InterfacesTestes
{
    partial class PreCadastro
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
            this.BtnAdministrador = new System.Windows.Forms.Button();
            this.BtnDocente = new System.Windows.Forms.Button();
            this.BtnTurma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdministrador
            // 
            this.BtnAdministrador.Location = new System.Drawing.Point(57, 187);
            this.BtnAdministrador.Name = "BtnAdministrador";
            this.BtnAdministrador.Size = new System.Drawing.Size(75, 117);
            this.BtnAdministrador.TabIndex = 0;
            this.BtnAdministrador.Text = "button1";
            this.BtnAdministrador.UseVisualStyleBackColor = true;
            this.BtnAdministrador.Click += new System.EventHandler(this.BtnAdministrador_Click);
            // 
            // BtnDocente
            // 
            this.BtnDocente.Location = new System.Drawing.Point(296, 187);
            this.BtnDocente.Name = "BtnDocente";
            this.BtnDocente.Size = new System.Drawing.Size(75, 117);
            this.BtnDocente.TabIndex = 1;
            this.BtnDocente.Text = "button1";
            this.BtnDocente.UseVisualStyleBackColor = true;
            this.BtnDocente.Click += new System.EventHandler(this.BtnDocente_Click);
            // 
            // BtnTurma
            // 
            this.BtnTurma.Location = new System.Drawing.Point(565, 187);
            this.BtnTurma.Name = "BtnTurma";
            this.BtnTurma.Size = new System.Drawing.Size(75, 117);
            this.BtnTurma.TabIndex = 2;
            this.BtnTurma.Text = "button2";
            this.BtnTurma.UseVisualStyleBackColor = true;
            this.BtnTurma.Click += new System.EventHandler(this.BtnTurma_Click);
            // 
            // PreCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTurma);
            this.Controls.Add(this.BtnDocente);
            this.Controls.Add(this.BtnAdministrador);
            this.Name = "PreCadastro";
            this.Text = "Pré-Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdministrador;
        private System.Windows.Forms.Button BtnDocente;
        private System.Windows.Forms.Button BtnTurma;
    }
}