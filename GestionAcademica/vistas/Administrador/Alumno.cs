﻿using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Carrera;
using GestionAcademica.modelos.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionAcademica.vistas.Administrador
{
    public partial class Alumno : Form
    {
        modelos.Alumno.Alumno alumno = new modelos.Alumno.Alumno();
        AlumnoCRUD alumnoCRUD = new AlumnoCRUD();

        public Alumno()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = alumnoCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {
                alumno.Carnet = numericUpDown1.Value.ToString();
                alumno.NumeroPartida = numericUpDown2.Value.ToString();
                alumno.FolioPartida = numericUpDown3.Value.ToString();
                alumno.DuiCarnetPropio = textBox1.Text;
                alumno.Nie = textBox2.Text;
                alumno.TipoBachillerato = textBox3.Text;
                alumno.AnioEstudio = textBox4.Text;
                alumnoCRUD.crear(alumno);
                refrescar();
                button1.Visible = false;
            }
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
