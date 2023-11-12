using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class Alumno
    {
        private int Id_Alumno;
        private string Carnet;
        private string NoPartida;
        private string Folio;
        private string Dui;
        private string Nit;
        private string TipoBachiller;
        private string Duracion;

        public int Id_Alumno1 { get => Id_Alumno; set => Id_Alumno = value; }
        public string Carnet1 { get => Carnet; set => Carnet = value; }
        public string NoPartida1 { get => NoPartida; set => NoPartida = value; }
        public string Folio1 { get => Folio; set => Folio = value; }
        public string Dui1 { get => Dui; set => Dui = value; }
        public string Nit1 { get => Nit; set => Nit = value; }
        public string TipoBachiller1 { get => TipoBachiller; set => TipoBachiller = value; }
        public string Duracion1 { get => Duracion; set => Duracion = value; }
    }
}
