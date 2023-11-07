using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Profesor
{
    internal class ProfesorCRUD : Clases.ConexionBD, ICRUD
    {
        public void actualizar(object modelo, int id)
        {
            Profesor profesor = (Profesor)modelo;
            string sql = "UPDATE profesor SET " +
            "primer_nombre = '" + profesor.Primer_nombre + "', " +
            "segundo_nombre = '" + profesor.Segundo_nombre + "', " +
            "primer_apellido = '" + profesor.Primer_apellido + "', " +
            "segundo_apellido = '" + profesor.Segundo_apellido + "', " +
            "departamento_profesor = '" + profesor.Departamento_profesor + "', " +
            "municipio_profesor = '" + profesor.Municipio_profesor + "', " +
            "colonia = '" + profesor.Colonia + "', " +
            "fecha_nacimiento = '" + profesor.Fecha_nacimiento + "', " +
            "titulo_profe = '" + profesor.Titulo_profe + "', " +
            "sexo = '" + profesor.Sexo + "', " +
            "nivel_academico = '" + profesor.Nivel_academico + "', " +
            "experiencia_laboral = '" + profesor.Experiencia_laboral + "', " +
            "telefono_personal = '" + profesor.Telefono_personal + "', " +
            "telefono_emergencia = '" + profesor.Telefono_emergencia + "', " +
            "condicion_medica = '" + profesor.Condicion_medica + "', " +
            "corre_profe = '" + profesor.Corre_profe + "' " +
            "WHERE id = "+profesor.Id_profesor+"";

        }

        public void crear(object modelo)
        {
            Profesor profesor = (Profesor)modelo;
            string sql = "INSERT INTO profesor(primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,departamento_profesor,municipio_profesor,colonia,fecha_nacimiento,titulo_profe,sexo,nivel_academico,experiencia_laboral,telefono_personal,telefono_emergencia,condicion_medica,corre_profe)" +
            "values('" + profesor.Primer_nombre + "','" + profesor.Segundo_nombre + "', '" + profesor.Primer_apellido + "', '" + profesor.Segundo_apellido + "', '" + profesor.Departamento_profesor + "', '" + profesor.Municipio_profesor + "','" + profesor.Colonia + "', '" + profesor.Fecha_nacimiento + "', '" + profesor.Titulo_profe + "','" + profesor.Sexo + "','" + profesor.Nivel_academico + "','" + profesor.Experiencia_laboral + "','" + profesor.Telefono_personal + "','" + profesor.Telefono_emergencia + "','" + profesor.Condicion_medica + "','" + profesor.Corre_profe + "')";
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM profesor WHERE id_profesor = " + id + "";
        }

        public object obtener()
        {
          
            string sql = "SELECT * FROM profesor";
           return consultas(sql);
            
        }
    }
}
