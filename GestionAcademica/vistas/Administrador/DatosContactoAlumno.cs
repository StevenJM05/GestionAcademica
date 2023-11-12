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
        modelos.Alumno.DatosContactoAlumnoC datoscontactoalumno = new DatosContactoAlumnoC();
        DatosContactoAlumnoCRUD DatosContactoAlumnoCRUD = new DatosContactoAlumnoCRUD();
        public DatosContactoAlumno()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = DatosContactoAlumnoCRUD.obtener();
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
                DatosContactoAlumnoCRUD.crear(datoscontactoalumno);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            DatosContactoAlumnoActualizar alumno = new DatosContactoAlumnoActualizar(datos);
            alumno.OnUpdate = refrescar;
            alumno.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            OtrosDatosAlumno otrosDatosAlumno = new OtrosDatosAlumno();
            otrosDatosAlumno.numericUpDown2.Value.ToString();
            otrosDatosAlumno.ShowDialog();

            this.Close();
        }
    }
}
