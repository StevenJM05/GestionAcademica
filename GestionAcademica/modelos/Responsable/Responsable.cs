using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Responsable
{
    internal class Responsable
    {
        private int idResponsable;
        private int dui;
        private string parentezco;
        private int idAlumno;

        public int IdResponsable { get => idResponsable; set => idResponsable = value; }
        public int Dui { get => dui; set => dui = value; }
        public string Parentezco { get => parentezco; set => parentezco = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
    }
}
