using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Responsable
{
    internal class CRUDResponsable : ICRUD
    {
        ConexionBD ConexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            Responsable responsable = (Responsable)modelo;
            string sql = $"UPDATE Responsable SET DUI = {responsable.Dui}, Parentezco = {responsable.Parentezco}, " +
            $"Id_Alumno = {responsable.IdAlumno} " +
            $"WHERE Id_Responsable = {id}";
            ConexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            Responsable responsable = (Responsable)modelo;
            string sql = $"INSERT INTO Responsable(Dui,Parentezco,Id_Alumno) VALUES({responsable.Dui}, {responsable.Parentezco},{responsable.IdAlumno})";
            ConexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Responsable WHERE Id_Responsable = {id}";
            ConexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT R.Id_Responsable, R.Parentezco, A.Nombre, A.Id_Alumno FROM Responsable R INNER JOIN Alumno A ON R.Id_Alumno = A.Id_Alumno";
            DataTable data = ConexionBD.consultas(sql);
            return data;
        }
    }
}
