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
        modelos.Responsable.DatosContactoResponsable contactoResponsable = new modelos.Responsable.DatosContactoResponsable();
        
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
                contactoResponsable.IdAlumno = Convert.ToInt32(numericUpDown1);
                contactoResponsable.TelefonoPropio = textBox1.Text;
                contactoResponsable.TelefonoFijo = textBox2.Text;
                contactoResponsable.TelefonoEmergencia = textBox3.Text;
                contactoResponsable.TelefonoOtro = textBox4.Text;
                datosContactoResponsableCRUD.crear(contactoResponsable);
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
    }
}
