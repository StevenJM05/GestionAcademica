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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox7.Text == "" || textBox6.Text == "" || dateTimePicker1.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            else
            {
                datosPersonalesResponsable.IdResponsable=Convert.ToInt32(numericUpDown1.Value);
                datosPersonalesResponsable.PrimerNombre = textBox2.Text;
                datosPersonalesResponsable.SegundoNombre = textBox3.Text;
                datosPersonalesResponsable.TercerNombre= textBox4.Text;

                datosPersonalesResponsable.PrimerApellido = textBox7.Text;
                datosPersonalesResponsable.SegundoNombre = textBox6.Text;
                datosPersonalesResponsable.TercerNombre = textBox5.Text;

                datosPersonalesResponsable.FechaNacimiento = dateTimePicker1.Text;
                datosPersonalesResponsable.Residencia = textBox8.Text;
                datosPersonalesResponsable.Direccion = textBox9.Text;

                datosPersonalesResponsable.Nacionalidad = textBox10.Text;
                datosPersonalesResponsable.DeptoMunicipioNacimiento=textBox11.Text;
                datospersonalescrud.crear(datosPersonalesResponsable);
                refrescar();
                button1.Visible = false;



            }
        }

        private void DatosPersonalesResponsable_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if  (numericUpDown1.Value == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox7.Text == "" || textBox6.Text == "" || dateTimePicker1.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Porfavor completa los campos obligatorios");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[1].Value;
                DatosContactoResponsable datosContactoresponsable = new DatosContactoResponsable();
                datosContactoresponsable.numericUpDown1.Value = id;
                datosContactoresponsable.ShowDialog();
                this.Close();
            }
        }
    }
}
