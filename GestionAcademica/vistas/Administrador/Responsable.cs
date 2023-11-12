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

        private void refrescar()
        {
            dataGridView1.DataSource = crudresponsable.obtener();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
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

            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            //CRUDResponsable crudresponsable = new CRUDResponsable();
           // crudresponsable.numericUpDown1.Value.ToString();
            //crudresponsable.ShowDialog();

            this.Close();
        }
    }
}
