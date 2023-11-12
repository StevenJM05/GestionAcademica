using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class DatosContactoAlumno
    {
        private int IdContacto;
        private int Id_Alumno;
        private string Correo;
        private string TelefonoPropio;
        private string TelefonoFijo;
        private string TelefonoEmergencia;

        public int IdContacto1 { get => IdContacto; set => IdContacto = value; }
        public int Id_Alumno1 { get => Id_Alumno; set => Id_Alumno = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string TelefonoPropio1 { get => TelefonoPropio; set => TelefonoPropio = value; }
        public string TelefonoFijo1 { get => TelefonoFijo; set => TelefonoFijo = value; }
        public string TelefonoEmergencia1 { get => TelefonoEmergencia; set => TelefonoEmergencia = value; }
    }
}
