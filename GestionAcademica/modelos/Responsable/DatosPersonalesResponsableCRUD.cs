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
    internal class DatosPersonalesResponsableCRUD : ICRUD
    {
        ConexionBD ConexionBD = new ConexionBD();

        public void actualizar(object modelo, int id)
        {
            DatosPersonalesResponsable datosPersonalesResponsable= (DatosPersonalesResponsable)modelo;
            string sql = $"UPDATE Dato_Personales_Responsable SET " +
            $"Id_Responsable = {datosPersonalesResponsable.IdResponsable}, " +
            $"Primer_Nombre = '{datosPersonalesResponsable.PrimerNombre}', " +
            $"Segundo_Nombre = '{datosPersonalesResponsable.SegundoNombre}', " +
            $"Tercer_Nombre = '{datosPersonalesResponsable.TercerNombre}', " +
            $"Primer_Apellido = '{datosPersonalesResponsable.PrimerApellido}', " +
            $"Segundo_Apellido = '{datosPersonalesResponsable.SegundoApellido}', " +
            $"Tercer_Apellido = '{datosPersonalesResponsable.TercerApellido}', " +
            $"Fecha_Nacimiento = '{datosPersonalesResponsable.FechaNacimiento}', " +
            $"Residencia = '{datosPersonalesResponsable.Residencia}', " +
            $"Direccion = '{datosPersonalesResponsable.Direccion}', " +
            $"Nacionalidad = '{datosPersonalesResponsable.Nacionalidad}', " +
            $"Departamento_Municipio_Nacimiento = '{datosPersonalesResponsable.DeptoMunicipioNacimiento}' " +
            $"WHERE id_Personal_res = {id};";
            ConexionBD.ejecutarComando(sql);

        }

        public void crear(object modelo)
        {
            DatosPersonalesResponsable datosPersonalesResponsable = (DatosPersonalesResponsable)modelo;
            string sql = $"INSERT INTO Dato_Personales_Responsable (Id_Responsable," +
            $"Primer_Nombre, Segundo_Nombre, Tercer_Nombre, Primer_Apellido, Segundo_Apellido, Tercer_Apellido, Fecha_Nacimiento, " +
            $"Residencia, Direccion, Nacionalidad, Departamento_Municipio_Nacimiento) " +
            $"VALUES ({datosPersonalesResponsable.IdResponsable}, '{datosPersonalesResponsable.PrimerNombre}', " +
            $"'{datosPersonalesResponsable.SegundoNombre}', '{datosPersonalesResponsable.TercerNombre}', " +
            $"'{datosPersonalesResponsable.PrimerApellido}', '{datosPersonalesResponsable.SegundoApellido}', " +
            $"'{datosPersonalesResponsable.TercerApellido}', '{datosPersonalesResponsable.FechaNacimiento}', " +
            $"'{datosPersonalesResponsable.Residencia}', '{datosPersonalesResponsable.Direccion}', " +
            $"'{datosPersonalesResponsable.Nacionalidad}', '{datosPersonalesResponsable.DeptoMunicipioNacimiento}');";

            ConexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Dato_Personales_Responsable WHERE id_Personal_res = {id};";

            ConexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT * FROM Dato_Personales_Responsable;";
            DataTable dataTable = ConexionBD.consultas(sql);
            return dataTable;

        }
    }
}
