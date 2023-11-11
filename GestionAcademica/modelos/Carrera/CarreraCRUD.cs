using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using GestionAcademica.vistas.COORDINADOR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class carreraCRUD : ICRUD
    {
        ConexionBD ConexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            Carrera carrera = (Carrera)modelo;
            string sql = $"UPDATE Carrera SET " +
            $"Nombre = '{carrera.Nombre1}', " +
            $"Descripcion = '{carrera.Descripcion1}', " +
            $"Duracion_anios = {carrera.DuracionYear1} " +
            $"WHERE Id_Carrera = {id};";
            ConexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            Carrera carrera = (Carrera)modelo;
            string sql = $"INSERT INTO Carrera (Nombre, Descripcion, Duracion_anios) " +
            $"VALUES ('{carrera.Nombre1}', '{carrera.Descripcion1}', {carrera.DuracionYear1});";
            ConexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Carrera WHERE Id_Carrera = {id};";
            ConexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT *,'Eliminar' as Eliminar FROM Carrera;";
            DataTable dataTable = ConexionBD.consultas(sql);
            return dataTable;
        }

        public object filtro(string buscar)
        {
            string sql = "SELECT Id_Carrera, Nombre, Descripcion, Duracion_anios FROM Carrera WHERE Nombre LIKE '" + buscar + "%'";
            DataTable dataTable = ConexionBD.consultas(sql); 
            return dataTable;
        }
        
           
        
    }
}
