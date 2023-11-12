using GestionAcademica.modelos.Alumno;
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
    public partial class DatosPersonalesAlumno : Form
    {
        DatosPersonalesAlumnoC personalesAlumno = new DatosPersonalesAlumnoC();
        DatosPersonalesAlumnoCRUD alumnoCRUD = new DatosPersonalesAlumnoCRUD(); 

        public DatosPersonalesAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox3.Text == ""|| textBox7.Text == "" || textBox6.Text == ""|| dateTimePicker1.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Algunos campos obligatorios estan vacios");
            }
            else
            {
                personalesAlumno.IdAlumno1 = Convert.ToInt32(numericUpDown1.Value);
                personalesAlumno.PrimerNombre = textBox2.Text;
                personalesAlumno.SegundoNombre = textBox3.Text;
                personalesAlumno.TercerNombre = textBox4.Text;
                personalesAlumno.PrimerApellido = textBox7.Text;
                personalesAlumno.SegundoApellido = textBox6.Text;
                personalesAlumno.TercerApellido = textBox5.Text;
                personalesAlumno.FechaNacimiento = dateTimePicker1.Text;
                personalesAlumno.Residencia = textBox8.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosContactoAlumno datosContactoAlumno = new DatosContactoAlumno();
            datosContactoAlumno.ShowDialog();
            this.Close();

        }
    }
}
