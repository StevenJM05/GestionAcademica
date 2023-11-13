using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Bitacora
{
    internal class CRUDBitacora : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();
        public void actualizar(object modelo, int id)
        {
            BitacoraAlumno bitacora = (BitacoraAlumno)modelo;
            string sql = $"UPDATE Bitacora SET " +
                $" Id_Alumno = {bitacora.Id_Alumno1}, Id_Carrera = {bitacora.Id_Carrera1}," +
                $" Año_Electivo = {bitacora.Año_Electivo1}, Institucion = {bitacora.Institucion1}," +
                $" Nivel = {bitacora.Nivel1}," +
                $" Id_Anio = {bitacora.IdYear1}," +
                $" Id_Secion = {bitacora.IdSeccion1}," +
                $" WHERE Numero_Registro = {id}";
            conexionBD.ejecutarComando(sql);
                
                
        }

        public void crear(object modelo)
        {
            BitacoraAlumno bitacora = (BitacoraAlumno)modelo;
            string sql = $"INSERT INTO Bitacora (Id_Alumno, Id_Carrera, Año_Electivo, Institucion, Nivel, Id_Anio, Id_Secion) VALUES " +
                $"({bitacora.Id_Alumno1}, {bitacora.Id_Carrera1}, {bitacora.Año_Electivo1}, '{bitacora.Institucion1}'," +
                $" {bitacora.Nivel1}, {bitacora.IdYear1}, {bitacora.IdSeccion1})";
            conexionBD.ejecutarComando(sql);

        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Bitacora WHERE Numero_Registro = {id}";
            conexionBD.ejecutarComando(sql);

        }

        public object obtener()
        {
            string sql = "select b.Numero_Registro, b.Id_Alumno, a.Carnet, b.Id_Carrera, c.Nombre, b.Año_Electivo, b.Institucion, b.Nivel, b.Id_Anio, an.Anio_Establecido, b.Id_Secion, s.Secion_Letra from Bitacora b INNER JOIN Alumno a on b.Id_Alumno = a.Id_Alumno INNER JOIN Carrera c on b.Id_Carrera = c.Id_Carrera INNER JOIN Anio_Academico an on b.Id_Anio = an.Id_Anio INNER JOIN Seciones s on b.Id_Secion = s.Id_Secion ";
            DataTable dataTable = conexionBD.consultas(sql);
            return dataTable;

        }

       
    }
}
