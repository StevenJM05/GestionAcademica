﻿using GestionAcademica.modelos.Alumno;
using GestionAcademica.vistas.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vistas.Administrador.Alumno alumno = new vistas.Administrador.Alumno();
            alumno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenúAlumno menúAlumno = new MenúAlumno();
            menúAlumno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MenuResponsable responsable = new MenuResponsable();
            responsable.Show();
        }
    }
}
