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
    internal class DatosOtrosResponsableCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();

        public void actualizar(object modelo, int id)
        {
            DatosOtrosResponsable datosOtrosResponsable = (DatosOtrosResponsable)modelo;
            string sql = $"UPDATE Otros_Datos_Alumnos SET " +
            $"Id_Alumno = {datosOtrosResponsable.IdAlumno}, " +
            $"Tipo_Sangre = '{datosOtrosResponsable.TipoSangre}', " +
            $"Trabaja_EN_QUE = '{datosOtrosResponsable.TrabajaEnQue}', " +
            $"Hijos_Cuantos = '{datosOtrosResponsable.HijosCuantos}', " +
            $"Depencia_Economica_Responsable = '{datosOtrosResponsable.DependenciaEconomicaResponsable}', " +
            $"Discapacidad = '{datosOtrosResponsable.Discapacidad}', " +
            $"Enfermedad_Cronica = '{datosOtrosResponsable.EnfermedadCronica}' " +
            $"WHERE Id_Otros = {id};";

            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            DatosOtrosResponsable datosOtrosResponsable = (DatosOtrosResponsable)modelo;
            string sql = $"INSERT INTO Otros_Datos_Alumnos (Id_Alumno, Tipo_Sangre, Trabaja_EN_QUE, Hijos_Cuantos," +
            $" Depencia_Economica_Responsable, Discapacidad, Enfermedad_Cronica) " +
            $"VALUES ({datosOtrosResponsable.IdAlumno}, '{datosOtrosResponsable.TipoSangre}', " +
            $"'{datosOtrosResponsable.TrabajaEnQue}', '{datosOtrosResponsable.HijosCuantos}', " +
            $"'{datosOtrosResponsable.DependenciaEconomicaResponsable}', '{datosOtrosResponsable.Discapacidad}', " +
            $"'{datosOtrosResponsable.EnfermedadCronica}');";

            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Otros_Datos_Alumnos WHERE Id_Otros = {id};";
            conexionBD.ejecutarComando(sql);

        }

        public object obtener()
        {
            string sql = "SELECT * FROM Otros_Datos_Alumnos;";
            DataTable dataTable = conexionBD.consultas(sql);
            return dataTable;

        }
    }
}
