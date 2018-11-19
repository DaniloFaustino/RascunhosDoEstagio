using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfacesTestes
{
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
        }

        private void LabCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cad cadastro = new Cad();
            cadastro.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = BancoMec; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            comd.CommandText = "SELECT Login FROM Usuarios WHERE Login = @Login AND Senha = @Senha";
            comd.Parameters.AddWithValue("Login", TxtMatricula.Text);
            comd.Parameters.AddWithValue("Senha", TxtSenha.Text);

            comd.Connection.Open();
            SqlDataReader reader = comd.ExecuteReader();
            string id = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetString(0);
                }
            }
            reader.Close();
            comd.Connection.Close();

            if (id == "")
            {
                MessageBox.Show("Informações Inválidas");
            }
            else
            {
                Cad cadastro = new Cad();
                cadastro.Show();
            }

            /* 
             if (TxtMatricula.Text == usuario && TxtSenha.Text == senha)
            {
               Cad cad = new Cad();
                cad.Show();
            }
            else
            {
                MessageBox.Show("Usuario invalido");
            } 
            */
        }
    }
}
