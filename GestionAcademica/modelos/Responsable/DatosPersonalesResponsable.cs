using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Responsable
{
    internal class DatosPersonalesResponsable
    {
        private int idPersonalRes;
        private int idResponsable;
        private string primerNombre;
        private string segundoNombre;
        private string tercerNombre;
        private string primerApellido;
        private string segundoApellido;
        private string tercerApellido;
        private string fechaNacimiento;
        private string residencia;
        private string direccion;
        private string nacionalidad;
        private string deptoMunicipioNacimiento;

        public int IdPersonalRes { get => idPersonalRes; set => idPersonalRes = value; }
        public int IdResponsable { get => idResponsable; set => idResponsable = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string TercerNombre { get => tercerNombre; set => tercerNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string TercerApellido { get => tercerApellido; set => tercerApellido = value; }
        public string  FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Residencia { get => residencia; set => residencia = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string DeptoMunicipioNacimiento { get => deptoMunicipioNacimiento; set => deptoMunicipioNacimiento = value; }
    }
}
