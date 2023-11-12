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
    public partial class DatosContactoAlumno : Form
    {
        modelos.Alumno.DatosContactoAlumno datoscontactoalumno = new modelos.Alumno.DatosContactoAlumno();
        OtrosDadosAlumnoCRUD otrosdatosalumnocrud = new OtrosDadosAlumnoCRUD();
        public DatosContactoAlumno()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = otrosdatosalumnocrud.obtener();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {

               

             
                datoscontactoalumno.Correo1 = textBox2.Text;
                datoscontactoalumno.TelefonoFijo1= textBox4.Text;
                datoscontactoalumno.TelefonoEmergencia1 = textBox5.Text;
                datoscontactoalumno.TelefonoPropio1 = textBox3.Text;
                otrosdatosalumnocrud.crear(datoscontactoalumno);
                refrescar();
                button1.Visible = false;

              

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void DatosContactoAlumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
