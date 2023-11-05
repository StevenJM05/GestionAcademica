using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Profesor
{
    internal class Profesor
    {
        private int id_profesor;
        private string primer_nombre;
        private string segundo_nombre;
        private string primer_apellido;
        private string segundo_apellido;
        private string departamento_profesor;
        private string municipio_profesor;
        private string colonia;
        private string fecha_nacimiento;
        private string titulo_profe;
        private string sexo;
        private string nivel_academico;
        private string experiencia_laboral;
        private string telefono_personal;
        private string telefono_emergencia;
        private string condicion_medica;
        private string corre_profe;

        public int Id_profesor { get => id_profesor; set => id_profesor = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public string Departamento_profesor { get => departamento_profesor; set => departamento_profesor = value; }
        public string Municipio_profesor { get => municipio_profesor; set => municipio_profesor = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Titulo_profe { get => titulo_profe; set => titulo_profe = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nivel_academico { get => nivel_academico; set => nivel_academico = value; }
        public string Experiencia_laboral { get => experiencia_laboral; set => experiencia_laboral = value; }
        public string Telefono_personal { get => telefono_personal; set => telefono_personal = value; }
        public string Telefono_emergencia { get => telefono_emergencia; set => telefono_emergencia = value; }
        public string Condicion_medica { get => condicion_medica; set => condicion_medica = value; }
        public string Corre_profe { get => corre_profe; set => corre_profe = value; }
    }
}
