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
    public partial class DatosPersonalesAlumno : Form
    {
        modelos.Alumno.DatosPersonalesAlumnoC datosPersonales = new modelos.Alumno.DatosPersonalesAlumnoC();
        modelos.Alumno.DatosPersonalesAlumnoCRUD datosPersonalesAlumnoCRUD = new modelos.Alumno.DatosPersonalesAlumnoCRUD();

        public DatosPersonalesAlumno()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = datosPersonalesAlumnoCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Completar Todos los Campos");
            }
            else
            {
                datosPersonales.IdAlumno1 = Convert.ToInt32(numericUpDown1.Value);
                datosPersonales.PrimerNombre = textBox2.Text;
                datosPersonales.SegundoNombre = textBox3.Text;
                datosPersonales.TercerNombre = textBox4.Text;
                datosPersonales.PrimerApellido = textBox7.Text;
                datosPersonales.SegundoApellido = textBox6.Text;
                datosPersonales.TercerApellido = textBox5.Text;
                datosPersonales.Residencia = textBox8.Text;
                datosPersonales.Direccion = textBox9.Text;
                datosPersonales.Nacionalidad = textBox10.Text;
                datosPersonales.FechaNacimiento = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                datosPersonales.Sexo = comboBox1.Text;
                datosPersonales.EstadoCivil = comboBox2.Text;

                datosPersonalesAlumnoCRUD.crear(datosPersonales);
                refrescar();
                button1.Visible = false;

            }
        }

        private void DatosPersonalesAlumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Complete los Campos");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                DatosContactoAlumno datosContactoAlumno = new DatosContactoAlumno();
                datosContactoAlumno.numericUpDown1.Value.ToString();
                datosContactoAlumno.ShowDialog();

                this.Close();
            }
            
        }
    }
}
