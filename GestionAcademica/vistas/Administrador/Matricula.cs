﻿using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Bitacora;
using GestionAcademica.modelos.Responsable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica.vistas.Administrador
{
    public partial class Matricula : Form
    {
        //Clases de Alumno
        Alumno alumno = new Alumno();
        AlumnoCRUD AlumnoCRUD = new AlumnoCRUD();
        DatosContactoAlumno datosContactoAlumno = new DatosContactoAlumno();
        DatosContactoAlumnoCRUD datosContactoAlumnoCRUD = new DatosContactoAlumnoCRUD();
        DatosPersonalesAlumno datosPersonalesAlumno = new DatosPersonalesAlumno();
        DatosPersonalesAlumnoCRUD datosPersonalesAlumnoCRUD = new DatosPersonalesAlumnoCRUD();
        OtrosDatosAlumno otrosDatosAlumno = new OtrosDatosAlumno();
        OtrosDadosAlumnoCRUD otrosDadosAlumnoCRUD = new OtrosDadosAlumnoCRUD();

        //Clases de Responsable 
        Responsable Responsable = new Responsable();
        CRUDResponsable cRUDResponsable = new CRUDResponsable();
        DatosPersonalesResponsable datosPersonalesResponsable = new DatosPersonalesResponsable();
        DatosPersonalesResponsableCRUD datosPersonalesResponsableCRUD = new DatosPersonalesResponsableCRUD();
        DatosContactoResponsable datosContactoResponsable = new DatosContactoResponsable();
        DatosContactoResponsableCRUD datosContactoResponsableCRUD = new DatosContactoResponsableCRUD();
        DatosOtrosResponsable datosOtrosResponsable = new DatosOtrosResponsable();
        DatosOtrosResponsableCRUD datosOtrosResponsableCRUD = new DatosOtrosResponsableCRUD();

        //Bitacora 
        Bitacora bitacora = new Bitacora();

        public Matricula()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alumno.Carnet = (int)numericUpDown1.Value;
            alumno.Numero_partida = numericUpDown2.ToString();
            alumno.Folio_partida1 = numericUpDown3.ToString();
            alumno.DUI_Carnet_Propio1 = maskedTextBox1.Text;
            alumno.

        }
    }
}
