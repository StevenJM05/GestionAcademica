using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica.Alumnos
{
    public partial class Registra : Form
    {
        Clases.ConexionBD BaseDatos = new Clases.ConexionBD();
        public Registra()
        {
            InitializeComponent();
        }

        private void consulta()
        {
            string sql = "select * from carrera";
            DataTable dt = new DataTable();
            dt = BaseDatos.consultas(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Registra_Load(object sender, EventArgs e)
        {

        }
    }
}
