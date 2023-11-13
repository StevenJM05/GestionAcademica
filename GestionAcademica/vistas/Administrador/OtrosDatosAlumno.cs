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
    public partial class OtrosDatosAlumno : Form
    {
       modelos.Alumno.OtrosDatosAlumno otrosDatosAlumno = new modelos.Alumno.OtrosDatosAlumno();
        OtrosDadosAlumnoCRUD otrosDadosAlumnoCRUD = new OtrosDadosAlumnoCRUD();

        public OtrosDatosAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")

            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {
                otrosDatosAlumno.TipoSangre = textBox2.Text;
                otrosDatosAlumno.TrabajaEnQue = textBox3.Text;
                otrosDatosAlumno.HijosCuantos = numericUpDown1.Value.ToString();
                otrosDatosAlumno.DependenciaEconomicaResponsable = textBox4.Text;
                otrosDatosAlumno.Discapacidad = textBox5.Text;
                otrosDatosAlumno.EnfermedadCronica = textBox6.Text;
                otrosDadosAlumnoCRUD.crear(otrosDadosAlumnoCRUD);
                refrescar();
                button1.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Responsable responsable = new Responsable();
                responsable.numericUpDown1.Value.ToString();
                responsable.ShowDialog();
                this.Close();
            }
        }

        private void refrescar()
        {
            dataGridView1.DataSource = otrosDadosAlumnoCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void OtrosDatosAlumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
