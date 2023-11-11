﻿using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Carrera
{
    internal class YearAcademicoCRUD : ICRUD
    {
        ConexionBD ConexionBD = new ConexionBD();

        public void actualizar(object modelo, int id)
        {
            YearAcademico yearAcademico = (YearAcademico)modelo;
            string sql = $"UPDATE Anio_Academico SET " +
            $"Anio_Establecido = '{yearAcademico.Yearacademico1}', " +
            $"IdCarrera = {yearAcademico.IdCarrera1} " +
            $"WHERE Id_Anio = {id};";
            ConexionBD.ejecutarComando(sql);
        }

        public void crear(object modelo)
        {
            YearAcademico yearAcademico = (YearAcademico)modelo;
            string sql = $"INSERT INTO Anio_Academico (Anio_Establecido, IdCarrera) " +
            $"VALUES ('{yearAcademico.Yearacademico1}', {yearAcademico.IdCarrera1});";
            ConexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = $"DELETE FROM Anio_Academico WHERE Id_Anio = {id};";
            ConexionBD.ejecutarComando(sql);
        }

        public object obtener()
        {
            string sql = "SELECT * FROM Anio_Academico;";
            DataTable dataTable = ConexionBD.consultas(sql);
            return dataTable;

        }
    }
}