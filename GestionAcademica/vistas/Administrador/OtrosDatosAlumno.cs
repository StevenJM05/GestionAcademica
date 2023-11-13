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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionAcademica.vistas.Administrador
{
    public partial class OtrosDatosAlumno : Form
    {

      OtrosDatosAlumnoC otrosdatosalumno=new OtrosDatosAlumnoC();
        OtrosDadosAlumnoCRUD Otrosdadosalumnocrud =new OtrosDadosAlumnoCRUD();

        public OtrosDatosAlumno()
        {
            InitializeComponent();
        }
        private void refrescar()
        {
            dataGridView1.DataSource = Otrosdadosalumnocrud.obtener();
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || numericUpDown1.Value == 0 || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" )
            {
                MessageBox.Show("Algunos campos obligatorios estan vacios");
            }
            else
            {


                otrosdatosalumno.TipoSangre = textBox2.Text;
                otrosdatosalumno.TrabajaEnQue = textBox3.Text;
                otrosdatosalumno.DependenciaEconomicaResponsable = textBox4.Text;
                otrosdatosalumno.Discapacidad= textBox5.Text;
                otrosdatosalumno.EnfermedadCronica = textBox6.Text;
                otrosdatosalumno.HijosCuantos = numericUpDown1.Value.ToString();

                Otrosdadosalumnocrud.crear(otrosdatosalumno);
                refrescar();
                button1.Visible = false;


            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[1].Value;
                OtrosDatosAlumno otrosDatosAlumno = new OtrosDatosAlumno();
                otrosDatosAlumno.numericUpDown2.Value.ToString();
                otrosDatosAlumno.ShowDialog();

                this.Close();
            }

        }

        private void OtrosDatosAlumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
