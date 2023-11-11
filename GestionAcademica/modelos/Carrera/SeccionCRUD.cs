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
    internal class SeccionCRUD : ICRUD
    {
        ConexionBD conexion = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            Seccion seccion = (Seccion)modelo;
            string sql = $"UPDATE Seciones SET " +
            $"SecionLetra = '{seccion.SecionLetra1}', " +
            $"IdYear = {seccion.IdYear1} " +
            $"WHERE IdSecion = {id};";
            conexion.ejecutarComando(sql);
        }

        public void crear(object modelo)
        {
            Seccion seccion = (Seccion)modelo;
            string sql = $"INSERT INTO Seciones (SecionLetra, IdYear) " +
            $"VALUES ('{seccion.SecionLetra1}', {seccion.IdYear1});";
            conexion.ejecutarComando(sql);


        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Seciones WHERE IdSecion = {id};";
            conexion.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT * FROM Seciones;";
            DataTable datatable = conexion.consultas(sql);
            return datatable;
        }
    }
}
