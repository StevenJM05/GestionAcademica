using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class MateriaCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            Materia materia = (Materia)modelo;  
            string sql = $"UPDATE Materias SET " +
            $"Nombre = '{materia.Nombre1}', " +
            $"Descripcion = '{materia.Descripcion1}', " +
            $"Id_Anio = {materia.IdYear1}, " +
            $"Id_Carrera = {materia.IdCarrera1} " +
            $"WHERE Id_Materias = {id}";
            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            Materia materia = (Materia)modelo;
            string sql = $"INSERT INTO Materias (Nombre, Descripcion, Id_Anio, Id_Carrera) " +
             $"VALUES ('{materia.Nombre1}', '{materia.Descripcion1}'," +
             $" {materia.IdYear1}, {materia.IdCarrera1})";
            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Materias WHERE Id_Materias = {id}";
            conexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT M.Nombre, M.Descripcion, C.Nombre, A.Anio_Establecido, M.Id_Carrera, M.Id_Anio FROM Materias M INNER JOIN Anio_Academico A ON M.Id_Anio = A.Id_Anio INNER JOIN Carrera C ON M.Id_Carrera = C.Id_Carrera";
            DataTable datatable = conexionBD.consultas(sql);
            return datatable;
        }

       
    }
}
