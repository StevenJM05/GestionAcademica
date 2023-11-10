using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class Alumno
    {
        private int carnet;
        private string numero_partida;
        private string Folio_partida;
        private string DUI_Carnet_Propio;
        private string NIE;
        private string tipo_bachillerato;
        private string Anio_estudio;

        public int Carnet { get => carnet; set => carnet = value; }
        public string Numero_partida { get => numero_partida; set => numero_partida = value; }
        
        public string DUI_Carnet_Propio1 { get => DUI_Carnet_Propio; set => DUI_Carnet_Propio = value; }
        public string NIE1 { get => NIE; set => NIE = value; }
        public string Tipo_bachillerato { get => tipo_bachillerato; set => tipo_bachillerato = value; }
        public string Folio_partida1 { get => Folio_partida; set => Folio_partida = value; }
        public string Anio_estudio1 { get => Anio_estudio; set => Anio_estudio = value; }
    }
}
