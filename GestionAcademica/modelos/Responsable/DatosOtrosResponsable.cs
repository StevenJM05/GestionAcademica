using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Responsable
{
    internal class DatosOtrosResponsable
    {
        private int idOtros;
        private int idAlumno;
        private string tipoSangre;
        private string trabajaEnQue;
        private string hijosCuantos;
        private string dependenciaEconomicaResponsable;
        private string discapacidad;
        private string enfermedadCronica;

        public int IdOtros { get => idOtros; set => idOtros = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
        public string TrabajaEnQue { get => trabajaEnQue; set => trabajaEnQue = value; }
        public string HijosCuantos { get => hijosCuantos; set => hijosCuantos = value; }
        public string DependenciaEconomicaResponsable { get => dependenciaEconomicaResponsable; set => dependenciaEconomicaResponsable = value; }
        public string Discapacidad { get => discapacidad; set => discapacidad = value; }
        public string EnfermedadCronica { get => enfermedadCronica; set => enfermedadCronica = value; }
    }
}
