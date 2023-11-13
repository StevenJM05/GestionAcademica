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
            string sql = $"update Alumno set Carnet = '{alumno.Carnet}', Numero_Partida = '{alumno.NumeroPartida}', Folio_Partida = '{alumno.FolioPartida}', DUI_Carnet_Propio = '{alumno.DuiCarnetPropio}', NIE = '{alumno.Nie}', Tipo_Bachillerato = '{alumno.TipoBachillerato}', Anio_estudio = '{alumno.AnioEstudio}' where Carnet = '{id}';";
            conexionBD.ejecutarComando(sql);
        }

        public void crear(object modelo)
        {
            Alumno alumno = (Alumno)modelo;
            string sql= $"INSERT INTO Alumno(Carnet, Numero_Partida,Folio_Partida, DUI_Carnet_Propio, NIE, Tipo_Bachillerato, Anio_estudio) values ({alumno.Carnet}, {alumno.NumeroPartida}, {alumno.FolioPartida}, '{alumno.DuiCarnetPropio}', '{alumno.Nie}', '{alumno.TipoBachillerato}', '{alumno.AnioEstudio}')";
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
