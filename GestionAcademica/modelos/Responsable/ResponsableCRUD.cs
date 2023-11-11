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
    internal class ResponsableCRUD : ICRUD
    {
        ConexionBD ConexionBD = new ConexionBD();

        public void actualizar(object modelo, int id)
        {
            Responsable responsable = (Responsable)modelo;
            string sql = $"UPDATE Responsable SET " +
            $"Dui = {responsable.Dui}, " +
            $"Parentezco = '{responsable.Parentezco}', " +
            $"Id_Alumno = {responsable.IdAlumno} " +
            $"WHERE Id_Responsable = {id};";
            ConexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            Responsable responsable = (Responsable)modelo;
            string sql = $"INSERT INTO Responsable (Id_Responsable, Dui, Parentezco, Id_Alumno) " +
            $"VALUES ({responsable.IdResponsable}, {responsable.Dui}, '{responsable.Parentezco}', " +
            $"{responsable.IdAlumno});";

            ConexionBD.ejecutarComando(sql);

        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Responsable WHERE Id_Responsable = {id};";
            ConexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT * FROM Responsable";
            DataTable dataTable = ConexionBD.consultas(sql);
            return dataTable;
        }
    }
}
