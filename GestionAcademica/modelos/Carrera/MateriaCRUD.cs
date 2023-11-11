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
            $"WHERE Id_Materias = {id};";
            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            Materia materia = (Materia)modelo;
            string sql = $"INSERT INTO Materias (Nombre, Descripcion, Id_Anio, Id_Carrera) " +
             $"VALUES ('{materia.Nombre1}', '{materia.Descripcion1}'," +
             $" {materia.IdYear1}, {materia.IdCarrera1});";
            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Materias WHERE Id_Materias = {id};";
            conexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT * FROM Materias;";
            DataTable datatable = conexionBD.consultas(sql);
            return datatable;
        }
    }
}
