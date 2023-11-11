using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class Seccion
    {
        private int IdSecion;
        private string SecionLetra;
        private int IdYear;

        public int IdSecion1 { get => IdSecion; set => IdSecion = value; }
        public string SecionLetra1 { get => SecionLetra; set => SecionLetra = value; }
        public int IdYear1 { get => IdYear; set => IdYear = value; }
    }
}
