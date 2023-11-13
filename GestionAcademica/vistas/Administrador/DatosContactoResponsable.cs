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
    public partial class DatosContactoResponsable : Form
    {

        
        DatosContactoResponsableCRUD datosContactoResponsableCRUD = new DatosContactoResponsableCRUD();
        DatosContactoResponsableC DatosContactoResponsableC = new DatosContactoResponsableC();
        
        public DatosContactoResponsable()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = datosContactoResponsableCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void DatosContactoResponsable_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show("Complete los Campos");
            }
            else
            {

                DatosContactoResponsableC.IdAlumno = Convert.ToInt32(numericUpDown1);
                DatosContactoResponsableC.TelefonoPropio = textBox1.Text;
                DatosContactoResponsableC.TelefonoFijo = textBox2.Text;
                DatosContactoResponsableC.TelefonoEmergencia = textBox3.Text;
                DatosContactoResponsableC.TelefonoOtro = textBox4.Text;
                datosContactoResponsableCRUD.crear(DatosContactoResponsableC);
                refrescar();
                button1.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Complete los Campos");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                DatosContactoResponsable datosContactoResponsable = new DatosContactoResponsable();
                datosContactoResponsable.numericUpDown1.Value.ToString();
                datosContactoResponsable.ShowDialog();

                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
