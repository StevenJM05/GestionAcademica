﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Responsable
{
    internal class DatosContactoResponsableC
    {
        private int idContacto;
        private int idAlumno;
        private string telefonoOtro;
        private string telefonoPropio;
        private string telefonoFijo;
        private string telefonoEmergencia;

        public int IdContacto { get => idContacto; set => idContacto = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
       
        public string TelefonoPropio { get => telefonoPropio; set => telefonoPropio = value; }
        public string TelefonoFijo { get => telefonoFijo; set => telefonoFijo = value; }
        public string TelefonoEmergencia { get => telefonoEmergencia; set => telefonoEmergencia = value; }
        public string TelefonoOtro { get => telefonoOtro; set => telefonoOtro = value; }
    }
}
