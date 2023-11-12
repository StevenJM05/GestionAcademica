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
    public partial class Responsable : Form
    {
        modelos.Responsable.Responsable responsable =new modelos.Responsable.Responsable();
        CRUDResponsable crudresponsable =new CRUDResponsable();
        public Responsable()
        {
            InitializeComponent();
        }

        private bool VerificarExistendui(string dui)
        {

            DataTable dt = (DataTable)crudresponsable.obtener();
            foreach (DataRow row in dt.Rows)
            {
                string duie = ((string)row["Dui"]);
                if (duie == dui)
                {
                    return true;
                }
            }
            return false;
        }

        private void refrescar()
        {
            dataGridView1.DataSource = crudresponsable.obtener();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dui = textBox1.Text;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }
            if (VerificarExistendui(dui))
            {
                MessageBox.Show("El DUI de usuario ya existe");
            }
            else
            {

                responsable.Dui = textBox1.Text;
                responsable.Parentezco = textBox2.Text;
                crudresponsable.crear(responsable);
             
                refrescar();
                button1.Visible = false;




            }
        }

        private void Responsable_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Complete todos los Campos antes de pasar al siguiente formulario");
            }
            else
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                DatosPersonalesResponsable datosPersonalesResponsable = new DatosPersonalesResponsable();
                datosPersonalesResponsable.numericUpDown1.Value = Convert.ToDecimal(id);
                datosPersonalesResponsable.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
