﻿using GestionAcademica.vistas.Administrador.CONSULTA;
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
    public partial class MenúAlumno : Form
    {
        public MenúAlumno()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlumnoConsulta alumno = new AlumnoConsulta();
            alumno.Show();
          

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoConsultaPersonal alumno = new AlumnoConsultaPersonal();
            alumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlumnoConsultaContacto alumno = new AlumnoConsultaContacto();
            alumno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlumnoConsultaOtros alumnoConsultaOtros = new AlumnoConsultaOtros();
            alumnoConsultaOtros.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
