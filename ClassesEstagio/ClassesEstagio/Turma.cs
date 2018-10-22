using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstagio
{
    class Turma
    {
        public string Nome { get; set; }
        public string Turno { get; set; }
        public bool Tecnico { get; set; }
        public string Sala { get; set; }
        public string[] Conselheiros = new string[2];
        public string[] Representantes = new string[2];

        public void VisualizarGrade()
        {
            string[,] GradeHorária = new string[13, 4];
        }
    }
}
