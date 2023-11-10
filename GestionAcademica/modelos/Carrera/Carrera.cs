using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class Carrera
    {
        private int Id_Carrera;
        private string Nombre;
        private string Descripcion;
        private string Duracion_Year;

        public int Id_Carrera1 { get => Id_Carrera; set => Id_Carrera = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Duracion_Year1 { get => Duracion_Year; set => Duracion_Year = value; }
    }
}
