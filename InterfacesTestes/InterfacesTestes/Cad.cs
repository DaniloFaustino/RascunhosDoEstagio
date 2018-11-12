using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesTestes
{
    public partial class Cad : Form
    {
        public Cad()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            PreCadastro cad = new PreCadastro();
            cad.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar visu = new Visualizar();
            visu.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar att = new Atualizar();
            att.Show();
        }
    }
}
