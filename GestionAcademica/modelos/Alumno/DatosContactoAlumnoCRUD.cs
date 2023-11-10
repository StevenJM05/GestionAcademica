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
            DatosContactoAlumno datosContactoAlumno = (DatosContactoAlumno)modelo;
            string sql = $"UPDATE Datos_Contactos_Alumnos SET " +
            $"Id_Alumno = {datosContactoAlumno.Carnet}, " +
            $"Correo = '{datosContactoAlumno.Correo}', " +
            $"Telefono_Propio = '{datosContactoAlumno.TelefonoPropio}', " +
            $"Telefono_Fijo = '{datosContactoAlumno.TelefonoFijo}', " +
            $"Telefono_Emergencia = '{datosContactoAlumno.TelefonoEmergencia}' " +
            $"WHERE Id_Contacto = {id};";
            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            DatosContactoAlumno datosContactoAlumno = (DatosContactoAlumno)modelo;
            string sql = $"INSERT INTO Datos_Contactos_Alumnos (Id_Alumno, Correo, Telefono_Propio, Telefono_Fijo, Telefono_Emergencia) " +
            $"VALUES ({datosContactoAlumno.Carnet}, '{datosContactoAlumno.Correo}', '{datosContactoAlumno.TelefonoPropio}', '{datosContactoAlumno.TelefonoFijo}', '{datosContactoAlumno.TelefonoEmergencia}');";
            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"Delete from Datos_Contactos_Alumnos where id_Contacto = {id}";
            conexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Datos_Contacto_Alumnos";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }
    }
}
