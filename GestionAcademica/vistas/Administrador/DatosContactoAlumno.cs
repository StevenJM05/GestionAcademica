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
    public partial class DatosContactoAlumno : Form
    {
        modelos.Alumno.DatosContactoAlumnoC datosContacto = new modelos.Alumno.DatosContactoAlumnoC();
        modelos.Alumno.DatosContactoAlumnoCRUD datosContactoAlumnoCRUD = new modelos.Alumno.DatosContactoAlumnoCRUD();
        public DatosContactoAlumno()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = datosContactoAlumnoCRUD.obtener();
            dataGridView1.Refresh();
        }
        private void DatosContactoAlumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {
                datosContacto.Id_Alumno1 = Convert.ToInt32(numericUpDown1.Value);
                datosContacto.Correo1 = textBox2.Text;
                datosContacto.TelefonoPropio1 = textBox3.Text;
                datosContacto.TelefonoEmergencia1 = textBox5.Text;
                datosContacto.TelefonoFijo1 = textBox4.Text;

                datosContactoAlumnoCRUD.crear(datosContacto);
                Refresh();
                button1.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Complete los Campos");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                vistas.Administrador.OtrosDatosAlumno otrosDatosAlumno = new vistas.Administrador.OtrosDatosAlumno();
                otrosDatosAlumno.numericUpDown2.Value.ToString();
                otrosDatosAlumno.ShowDialog();

                this.Close();
            }
        }
    }
}
