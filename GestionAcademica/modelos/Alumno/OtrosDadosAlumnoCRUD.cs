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
    internal class OtrosDadosAlumnoCRUD : ICRUD
    {
        ConexionBD ConexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            OtrosDatosAlumno otrosDatosAlumno = (OtrosDatosAlumno)modelo;
            string sql = $"UPDATE Otros_Datos_Alumnos SET " +
            $"Id_Alumno = {otrosDatosAlumno.Id_Alumno1}, " +
            $"Tipo_Sangre = '{otrosDatosAlumno.TipoSangre}', " +
            $"Trabaja_EN_QUE = '{otrosDatosAlumno.TrabajaEnQue}', " +
            $"Hijos_Cuantos = '{otrosDatosAlumno.HijosCuantos}', " +
            $"Depencia_Economica_Responsable = '{otrosDatosAlumno.DependenciaEconomicaResponsable}', " +
            $"Discapacidad = '{otrosDatosAlumno.Discapacidad}', " +
            $"Enfermedad_Cronica = '{otrosDatosAlumno.EnfermedadCronica}' " +
            $"WHERE Id_Otros = {id};";
            ConexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            OtrosDatosAlumno otrosDatosAlumno = (OtrosDatosAlumno)modelo;
            string sql = $"INSERT INTO Otros_Datos_Alumnos (Id_Alumno, " +
                $"Tipo_Sangre, Trabaja_EN_QUE, Hijos_Cuantos, Depencia_Economica_Responsable, " +
                $"Discapacidad, Enfermedad_Cronica) " +
                $"VALUES ({otrosDatosAlumno.Id_Alumno1}, " +
                $"'{otrosDatosAlumno.TipoSangre}', " +
                $"'{otrosDatosAlumno.TrabajaEnQue}', " +
                $"'{otrosDatosAlumno.HijosCuantos}', " +
                $"'{otrosDatosAlumno.DependenciaEconomicaResponsable}', " +
                $"'{otrosDatosAlumno.Discapacidad}', " +
                $"'{otrosDatosAlumno.EnfermedadCronica}');";
            ConexionBD.ejecutarComando(sql);

        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Otros_Datos_Alumnos WHERE Id_Otros= {id}";
            ConexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT FROM Otros_Datos_Alumnos";
            DataTable dataTable = ConexionBD.consultas(sql);
            return dataTable;
        }
    }
}
