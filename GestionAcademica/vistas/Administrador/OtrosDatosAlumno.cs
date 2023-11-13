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

        OtrosDatosAlumno OtrosDatosalumno=new OtrosDatosAlumno();
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

               // OtrosDatosalumno.Id_Alumno1 = Convert.ToInt32(numericUpDown1.Value);



            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void OtrosDatosAlumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
