using GestionAcademica.vistas.COORDINADOR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Bitacora
{
    internal class Bitacora
    {
        private int Numero_Registro;
        private int Id_Alumno;
        private int Id_Carrera;
        private int Año_Electivo;
        private string Institucion;
        private string Nivel;
        private string Year_proceso;
        private string Seccion;

        public int Numero_Registro1 { get => Numero_Registro; set => Numero_Registro = value; }
        public int Id_Alumno1 { get => Id_Alumno; set => Id_Alumno = value; }
        public int Id_Carrera1 { get => Id_Carrera; set => Id_Carrera = value; }
        public int Año_Electivo1 { get => Año_Electivo; set => Año_Electivo = value; }
        public string Institucion1 { get => Institucion; set => Institucion = value; }
        public string Nivel1 { get => Nivel; set => Nivel = value; }
        public string Year_proceso1 { get => Year_proceso; set => Year_proceso = value; }
        public string Seccion1 { get => Seccion; set => Seccion = value; }
    }
}
