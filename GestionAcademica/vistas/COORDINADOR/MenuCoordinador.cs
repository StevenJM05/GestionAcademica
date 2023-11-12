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
    public partial class MenuCoordinador : Form
    {
        public MenuCoordinador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carreras carreras = new carreras();
            carreras.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            materias.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Grado grado = new Grado();
            grado.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seccion seccion = new seccion();
            seccion.Show();
        }

        private void MenuCoordinador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
