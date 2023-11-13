using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class AlumnoC
    {
        private int idAlumno;
        private string carnet;
        private string numeroPartida;
        private string folioPartida;
        private string duiCarnetPropio;
        private string nie;
        private string tipoBachillerato;
        private string anioEstudio;

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Carnet { get => carnet; set => carnet = value; }
        public string NumeroPartida { get => numeroPartida; set => numeroPartida = value; }
        public string FolioPartida { get => folioPartida; set => folioPartida = value; }
        public string DuiCarnetPropio { get => duiCarnetPropio; set => duiCarnetPropio = value; }
        public string Nie { get => nie; set => nie = value; }
        public string TipoBachillerato { get => tipoBachillerato; set => tipoBachillerato = value; }
        public string AnioEstudio { get => anioEstudio; set => anioEstudio = value; }
    }
}
