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
            string sql = $"update Alumno set Carnet = '{alumno.Carnet1}', Numero_Partida = '{alumno.NoPartida1}', Folio_Partida = '{alumno.Folio1}', DUI_Carnet_Propio = '{alumno.Dui1}', NIE = '{alumno.Nit1}', Tipo_Bachillerato = '{alumno.TipoBachiller1}', Anio_estudio = '{alumno.Duracion1}' where Carnet = '{id}';";
            conexionBD.ejecutarComando(sql);
        }

        public void crear(object modelo)
        {
            Alumno alumno = (Alumno)modelo;
            string sql= $"INSERT INTO Alumno(Carnet, Numero_Partida,Folio_Partida, DUI_Carnet_Propio, NIE, Tipo_Bachillerato, Anio_estudio) values ({alumno.Carnet1}, {alumno.NoPartida1}, {alumno.Folio1}, '{alumno.Dui1}', '{alumno.Nit1}', '{alumno.TipoBachiller1}', '{alumno.Duracion1}')";
            conexionBD.ejecutarComando(sql);
           
        }

        public void eliminar(int id)
        {
            string sql = $"delete from Alumno where Carnet = '{id}'";
        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "select * from Alumno";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }
    }
}
