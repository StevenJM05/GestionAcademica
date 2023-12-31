﻿using GestionAcademica.Clases;
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
            $"secion_Letra = '{seccion.SecionLetra1}', " +
            $"Id_Carrera = '{seccion.IdCarrera1}'," +
            $"Id_Anio = {seccion.IdYear1} " +
            $"WHERE Id_Secion = {id};";
            conexion.ejecutarComando(sql);
        }

        public void crear(object modelo)
        {
            Seccion seccion = (Seccion)modelo;
            string sql = $"INSERT INTO Seciones (secion_Letra, Id_Carrera, Id_Anio) " +
            $"VALUES ('{seccion.SecionLetra1}', '{seccion.IdCarrera1}','{seccion.IdYear1}');";
            conexion.ejecutarComando(sql);


        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Seciones WHERE Id_Secion = {id};";
            conexion.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT S.Id_Secion, C.Id_Carrera, C.Nombre, A.Id_Anio, A.Anio_Establecido, S.secion_Letra FROM Seciones S INNER JOIN Carrera C on S.Id_Carrera = C.Id_Carrera INNER JOIN Anio_Academico A ON S.Id_Anio = A.Id_Anio";
            DataTable datatable = conexion.consultas(sql);
            return datatable;
        }
        public object comboConsulta(int id)
        {
            string sql = $"SELECT * FROM Seciones WHERE Id_Secion = {id}";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }


    }
}
