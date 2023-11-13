using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Responsable
{
    internal class DatosContactoResponsableCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();

        public void actualizar(object modelo, int id)
        {
            DatosContactoResponsableC datosContactoResponsable = (DatosContactoResponsableC)modelo;
            string sql = $"UPDATE Datos_Contactos_Alumnos SET " +
            $"Id_Alumno = {datosContactoResponsable.IdAlumno}, " +
            $"Telefono_Propio = '{datosContactoResponsable.TelefonoPropio}', " +
            $"Telefono_Fijo = '{datosContactoResponsable.TelefonoFijo}', " +
            $"Telefono_Emergencia = '{datosContactoResponsable.TelefonoEmergencia}' " +
            $"WHERE Id_Contacto = {id};";

            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            DatosContactoResponsableC datosContactoResponsable = (DatosContactoResponsableC)modelo;
            string sql = $"INSERT INTO Datos_Contactos_Alumnos (Id_Alumno, Correo," +
            $" Telefono_Propio, Telefono_Fijo, Telefono_Emergencia) " +
            $"VALUES ({datosContactoResponsable.IdAlumno}," +
            $"'{datosContactoResponsable.TelefonoPropio}', '{datosContactoResponsable.TelefonoFijo}'," +
            $" '{datosContactoResponsable.TelefonoEmergencia}');";

            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Datos_Contacto_Responsable WHERE Id_Contacto = {id};";
            conexionBD.ejecutarComando(sql);

        }

        public object obtener()
        {
            string sql = "SELECT * FROM Datos_Contacto_Responsable;";
            DataTable dataTable = conexionBD.consultas(sql);
            return dataTable;

        }
    }
}
