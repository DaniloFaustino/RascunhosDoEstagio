using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstagio
{
    class Administrador
    {
        public int Matrícula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        private string senha;
        public string Senha
        {
            set
            {
                if (value.Length >= 8 || value.Length <= 16)
                {
                    senha = value;
                }
                else
                {
                    //MessageBox.Show(Senha Inválida. Necessário ter no mínimo 8 caracteres e no máximo 16 )
                }
            }
        }

    }
}
