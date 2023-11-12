using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class DatosContactoAlumnoCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            DatosContactoAlumnoC datosContactoAlumno = (DatosContactoAlumnoC)modelo;
            string sql = $"update Datos_Contactos_Alumnos set Id_Alumno = {datosContactoAlumno.IdContacto1}, Correo = '{datosContactoAlumno.Correo1}', Telefono_Propio = {datosContactoAlumno.TelefonoPropio1}, Telefono_Fijo = {datosContactoAlumno.TelefonoFijo1}, Telefono_Emergencia = {datosContactoAlumno.TelefonoEmergencia1} where Id_Alumno = '{id}';";
            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            DatosContactoAlumnoC datosContactoAlumno = (DatosContactoAlumnoC)modelo;
            string sql = $"insert into Datos_Contactos_Alumnos (Id_Alumno, Correo, Telefono_Propio, Telefono_Fijo, Telefono_Emergencia) values ('{datosContactoAlumno.Id_Alumno1}', '{datosContactoAlumno.Correo1}', '{datosContactoAlumno.TelefonoPropio1}', '{datosContactoAlumno.TelefonoFijo1}', '{datosContactoAlumno.TelefonoEmergencia1}')";
            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"Delete from Datos_Contactos_Alumnos where Id_Contacto = '{id}'";
            conexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM  Datos_Contactos_Alumnos";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }
    }
}
