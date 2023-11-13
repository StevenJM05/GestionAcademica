using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Alumno
{
    internal class DatosPersonalesAlumnoCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            DatosPersonalesAlumnoC datosPersonalesAlumno = (DatosPersonalesAlumnoC)modelo;
            string sql = $"UPDATE Datos_Personales_Alumno SET " +
            $"Id_Alumno = {datosPersonalesAlumno.IdAlumno1}, " +
            $"Primer_Nombre = '{datosPersonalesAlumno.PrimerNombre}', " +
            $"Segundo_Nombre = '{datosPersonalesAlumno.SegundoNombre}', " +
            $"Tercer_Nombre = '{datosPersonalesAlumno.TercerNombre}', " +
            $"Primer_Apellido = '{datosPersonalesAlumno.PrimerApellido}', " +
            $"Segundo_Apellido = '{datosPersonalesAlumno.SegundoApellido}', " +
            $"Tercer_Apellido = '{datosPersonalesAlumno.TercerApellido}', " +
            $"Fecha_Nacimiento = '{datosPersonalesAlumno.FechaNacimiento}', " +
            $"Residencia = '{datosPersonalesAlumno.Residencia}', " +
            $"Direccion = '{datosPersonalesAlumno.Direccion}', " +
            $"Nacionalidad = '{datosPersonalesAlumno.Nacionalidad}', " +
            $"Departamento_Municipio_Nacimiento = '{datosPersonalesAlumno.DepartamentoMunicipioNacimiento}', " +
            $"Sexo = '{datosPersonalesAlumno.Sexo}', " +
            $"Estado_Civil = '{datosPersonalesAlumno.EstadoCivil}' " +
            $"WHERE Id_Personal = {id}";
            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            DatosPersonalesAlumnoC datosPersonalesAlumno = (DatosPersonalesAlumnoC)modelo;
            string sql = $"INSERT INTO Datos_Personales_Alumno(Id_Alumno, Primer_Nombre, Segundo_Nombre, Tercer_Nombre, Primer_Apellido, Segundo_Apellido, Tercer_Apellido, Fecha_Nacimiento, Residencia, Direccion, Nacionalidad, Departamento_Municipio_Nacimiento, Sexo, Estado_Civil)" +
                $"VALUES({datosPersonalesAlumno.IdAlumno1}," +
                $" {datosPersonalesAlumno.PrimerNombre}, " +
                $"{datosPersonalesAlumno.SegundoNombre}, " +
                $"{datosPersonalesAlumno.TercerNombre}, " +
                $"{datosPersonalesAlumno.PrimerApellido}, " +
                $"{datosPersonalesAlumno.SegundoApellido}, " +
                $"{datosPersonalesAlumno.TercerApellido}, " +
                $"{datosPersonalesAlumno.FechaNacimiento}, " +
                $"{datosPersonalesAlumno.Residencia}, " +
                $"{datosPersonalesAlumno.Direccion}, " +
                $"{datosPersonalesAlumno.Nacionalidad}, " +
                $"{datosPersonalesAlumno.DepartamentoMunicipioNacimiento}, " +
                $"{datosPersonalesAlumno.Sexo}, " +
                $"{datosPersonalesAlumno.EstadoCivil});";
            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM Datos_Personales_Alumno WHERE  = " + id + "";
            conexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Datos_Personales_Alumno";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }
    }
}
