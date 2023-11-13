using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Responsable;
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
    public partial class DatosPersonalesResponsable : Form
    {
       modelos.Responsable.DatosPersonalesResponsable datosPersonalesResponsable=new modelos.Responsable.DatosPersonalesResponsable();
        DatosPersonalesResponsableCRUD datospersonalescrud = new DatosPersonalesResponsableCRUD();

        public DatosPersonalesResponsable()
        {
            InitializeComponent();
        }
        private void refrescar()
        {
            dataGridView1.DataSource = datospersonalescrud.obtener();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {




              





            }
        }

        private void DatosPersonalesResponsable_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
