using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesTestes
{
    public partial class CadastroAdm : Form
    {
        public CadastroAdm()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = BancoMec; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            comd.CommandText = "INSERT INTO Usuarios (Login, Senha, Matricula, Nome, Email) VALUES (@Login, @Senha, @Matricula, @Nome, @Email)";
            comd.Parameters.AddWithValue("Login", TxtLogin.Text);
            comd.Parameters.AddWithValue("Senha", TxtSenha.Text);
            comd.Parameters.AddWithValue("Matricula", TxtMatricula.Text);
            comd.Parameters.AddWithValue("Nome", TxtNome.Text);
            comd.Parameters.AddWithValue("Email", TxtEmail.Text);

            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

        }
    }
}
