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
    internal class AlumnoCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {

            Alumno alumno = (Alumno)modelo;
            string sql = $"UPDATE Alumno " +
             $"SET Numero_Partida = '{alumno.Numero_partida}', " +
             $"Folio_Partida = '{alumno.Folio_partida1}', " +
             $"DUI_Carnet_Propio = '{alumno.DUI_Carnet_Propio1}', " +
             $"NIE = '{alumno.NIE1}', " +
             $"Tipo_Bachillerato = '{alumno.Tipo_bachillerato}' " +
             $"WHERE Carnet = '{id}';";
            conexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            Alumno alumno = (Alumno)modelo;
            string sql = $"INSERT INTO Alumno(Carnet, Numero_Partida, Folio_Partida, DUI_Carnet_Propio,NIE, Tipo_Bachillerato,Anio_estudio) " +
                $"VALUES('{alumno.Carnet}'," +
                $" '{alumno.Numero_partida}', " +
                $"'{alumno.Folio_partida1}', " +
                $"'{alumno.DUI_Carnet_Propio1}'," +
                $"'{alumno.NIE1}'," +
                $"'{alumno.Tipo_bachillerato}'," +
                $"'{alumno.Anio_estudio1}');";
                conexionBD.ejecutarComando(sql);
           
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM  Alumno WHERE  = " + id + "";
            conexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Alumno";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }
    }
}
