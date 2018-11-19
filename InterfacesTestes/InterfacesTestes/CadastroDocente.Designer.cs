namespace InterfacesTestes
{
    partial class CadastroDocente
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.TxtTempo = new System.Windows.Forms.TextBox();
            this.TxtDisciplina = new System.Windows.Forms.TextBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.ComboCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(36, 24);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(36, 61);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(100, 20);
            this.TxtCPF.TabIndex = 1;
            // 
            // TxtTempo
            // 
            this.TxtTempo.Location = new System.Drawing.Point(36, 105);
            this.TxtTempo.Name = "TxtTempo";
            this.TxtTempo.Size = new System.Drawing.Size(100, 20);
            this.TxtTempo.TabIndex = 2;
            // 
            // TxtDisciplina
            // 
            this.TxtDisciplina.Location = new System.Drawing.Point(36, 191);
            this.TxtDisciplina.Name = "TxtDisciplina";
            this.TxtDisciplina.Size = new System.Drawing.Size(100, 20);
            this.TxtDisciplina.TabIndex = 4;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Contratado ",
            "Dedicação Exclusiva"});
            this.ComboTipo.Location = new System.Drawing.Point(36, 228);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 5;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(215, 228);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "button1";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // ComboCargo
            // 
            this.ComboCargo.FormattingEnabled = true;
            this.ComboCargo.Items.AddRange(new object[] {
            "Coordenação ",
            "Docente"});
            this.ComboCargo.Location = new System.Drawing.Point(36, 150);
            this.ComboCargo.Name = "ComboCargo";
            this.ComboCargo.Size = new System.Drawing.Size(121, 21);
            this.ComboCargo.TabIndex = 7;
            // 
            // CadastroDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 370);
            this.Controls.Add(this.ComboCargo);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.TxtDisciplina);
            this.Controls.Add(this.TxtTempo);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtNome);
            this.Name = "CadastroDocente";
            this.Text = "CadastroDocente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtTempo;
        private System.Windows.Forms.TextBox TxtDisciplina;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.ComboBox ComboCargo;
    }
}