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
    public partial class PreCadastro : Form
    {
        public PreCadastro()
        {
            InitializeComponent();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            CadastroAdm cadAdm = new CadastroAdm();
            cadAdm.Show(); 
        }

        private void BtnDocente_Click(object sender, EventArgs e)
        {
            CadastroDocente cadDocente  = new CadastroDocente();
            cadDocente.Show(); 
        }

        private void BtnTurma_Click(object sender, EventArgs e)
        {
            CadastroTurma cadTurma = new CadastroTurma();
            cadTurma.Show(); 
        }
    }
}
