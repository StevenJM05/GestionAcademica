using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class DatosPersonalesAlumno
    {
            private int idPersonal;
            private int carnet;
            private string primerNombre;
            private string segundoNombre;
            private string tercerNombre;
            private string primerApellido;
            private string segundoApellido;
            private string tercerApellido;
            private DateTime fechaNacimiento;
            private string residencia;
            private string direccion;
            private string nacionalidad;
            private string departamentoMunicipioNacimiento;
            private string sexo;
            private string estadoCivil;

            public int IdPersonal
            {
                get => idPersonal;
                set => idPersonal = value;
            }

            public int Carnet
            {
                get => carnet;
                set => carnet = value;
            }

            public string PrimerNombre
            {
                get => primerNombre;
                set => primerNombre = value;
            }

            public string SegundoNombre
            {
                get => segundoNombre;
                set => segundoNombre = value;
            }

            public string TercerNombre
            {
                get => tercerNombre;
                set => tercerNombre = value;
            }

            public string PrimerApellido
            {
                get => primerApellido;
                set => primerApellido = value;
            }

            public string SegundoApellido
            {
                get => segundoApellido;
                set => segundoApellido = value;
            }

            public string TercerApellido
            {
                get => tercerApellido;
                set => tercerApellido = value;
            }

            public DateTime FechaNacimiento
            {
                get => fechaNacimiento;
                set => fechaNacimiento = value;
            }

            public string Residencia
            {
                get => residencia;
                set => residencia = value;
            }

            public string Direccion
            {
                get => direccion;
                set => direccion = value;
            }

            public string Nacionalidad
            {
                get => nacionalidad;
                set => nacionalidad = value;
            }

            public string DepartamentoMunicipioNacimiento
            {
                get => departamentoMunicipioNacimiento;
                set => departamentoMunicipioNacimiento = value;
            }

            public string Sexo
            {
                get => sexo;
                set => sexo = value;
            }

            public string EstadoCivil
            {
                get => estadoCivil;
                set => estadoCivil = value;
            }
    }
}



