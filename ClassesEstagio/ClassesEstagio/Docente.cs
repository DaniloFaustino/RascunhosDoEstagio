using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstagio
{
    class Docente
    {
        public int Matricula { get; set; } 
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string Email { get; set; }
        public int Tempo { get; set; }
        public string Foto { get; set; }
        public bool Coordenador { get; set; }

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
                    //MessageBox.Show("Senha Inválida. Necessário ter no mínimo 8 caracteres e no máximo 16);
                }
            }
        }

        public void VisualizarGrade()
        {
            string[ , ] GradeHorária = new string[13,4];
        }
    }
}
