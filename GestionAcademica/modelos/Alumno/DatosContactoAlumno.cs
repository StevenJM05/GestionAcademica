﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class DatosContactoAlumno
    {
        private int idContacto;
        private int carnet;
        private string correo;
        private string telefonoPropio;
        private string telefonoFijo;
        private string telefonoEmergencia;

        public int IdContacto { get => idContacto; set => idContacto = value; }
        public int Carnet { get => carnet; set => carnet = value; }
        public string Correo { get => correo; set => correo = value; }
        public string TelefonoPropio { get => telefonoPropio; set => telefonoPropio = value; }
        public string TelefonoFijo { get => telefonoFijo; set => telefonoFijo = value; }
        public string TelefonoEmergencia { get => telefonoEmergencia; set => telefonoEmergencia = value; }
    }
}
