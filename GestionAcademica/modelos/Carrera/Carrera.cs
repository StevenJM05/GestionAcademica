using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class Carrera
    {
        private int IdCarrera;
        private string Nombre;
        private string Descripcion;
        private int DuracionYear;

        public int IdCarrera1 { get => IdCarrera; set => IdCarrera = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int DuracionYear1 { get => DuracionYear; set => DuracionYear = value; }
    }
}
