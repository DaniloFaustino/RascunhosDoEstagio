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
    public partial class CadastroDocente : Form
    {
        public CadastroDocente()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = BancoMec; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            comd.CommandText = "INSERT INTO Professor (NomeProfessor, CPFProfessor, TempoDeAtuação, CargoProfessor, DisciplinaProfessor, TipoDeContrato) VALUES (@Nome, @CPF, @Tempo, @Cargo, @Disciplina, @Tipo)";
            comd.Parameters.AddWithValue("Nome", TxtNome.Text);
            comd.Parameters.AddWithValue("CPF", TxtCPF.Text);
            comd.Parameters.AddWithValue("Tempo", TxtTempo.Text);
            comd.Parameters.AddWithValue("Cargo", ComboCargo.Text);
            comd.Parameters.AddWithValue("Disciplina", TxtDisciplina.Text);
            comd.Parameters.AddWithValue("Tipo", ComboTipo.Text);

            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();
        }
    }
}
