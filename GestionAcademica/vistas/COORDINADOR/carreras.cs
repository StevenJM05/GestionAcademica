using GestionAcademica.modelos.Carrera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica.vistas.COORDINADOR
{
    public partial class carreras : Form
    {
        Carrera carrera = new Carrera();
        CarreraCRUD CarreraCRUD = new CarreraCRUD();
        public carreras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "" || textBox2.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Rellene todos los campos");

            }else {
                carrera.Nombre1 = textBox1.Text;
                carrera.Descripcion1 = textBox2.Text;
                carrera.DuracionYear1 = Convert.ToInt32(numericUpDown1.Value);

                CarreraCRUD.crear(carrera);
                refrescar();
            }
        }

        private void carreras_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = CarreraCRUD.obtener();
            dataGridView1.Refresh();
        }
    }
}
