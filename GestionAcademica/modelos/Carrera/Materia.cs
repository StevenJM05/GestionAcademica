using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class Materia
    {
        private int IdMAterias;
        private string Nombre;
        private string Descripcion;
        private int IdYear;
        private int IdCarrera;

        public int IdMAterias1 { get => IdMAterias; set => IdMAterias = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int IdYear1 { get => IdYear; set => IdYear = value; }
        public int IdCarrera1 { get => IdCarrera; set => IdCarrera = value; }
    }
}
