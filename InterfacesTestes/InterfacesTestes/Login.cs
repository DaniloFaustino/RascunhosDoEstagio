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

        string usuario= "programador";
        string senha = "Cp2";

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

            comd.CommandText = "SELECT Matricula FROM Adm WHERE MATRICULA = @Matricula AND SENHA = @Senha";
            comd.Parameters.AddWithValue("Matricula", TxtMatricula.Text);
            comd.Parameters.AddWithValue("Senha", TxtSenha.Text);

            comd.Connection.Open();
            SqlDataReader reader = comd.ExecuteReader();
            int id = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            comd.Connection.Close();

            if (id == 0)
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
