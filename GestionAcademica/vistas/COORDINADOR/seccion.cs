using GestionAcademica.modelos.Alumno;
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
    public partial class seccion : Form
    {
        carreraCRUD carrera = new carreraCRUD();
        Seccion secion = new Seccion();
        SeccionCRUD SeccionCRUD = new SeccionCRUD();
        public seccion()
        {
            InitializeComponent();
        }
        private void refrescar()
        {
            dataGridView1.DataSource = SeccionCRUD.obtener();
            dataGridView1.Refresh();
        }
        private void seccion_Load(object sender, EventArgs e)
        {

            carreraCRUD carreraCRUD = new carreraCRUD();
            DataTable dt = (DataTable)carreraCRUD.obtener();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Carrera";
            comboBox1.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescar();
            comboBoxDependiente();
        }

        private void comboBoxDependiente()
        {
            int id = (int)comboBox1.SelectedValue;
            YearAcademicoCRUD yearAcademicoCRUD = new YearAcademicoCRUD();
            DataTable data = (DataTable)yearAcademicoCRUD.comboConsulta(id);
            comboBox2.DisplayMember = "Anio_Establecido";
            comboBox2.ValueMember = "Id_Anio";
            comboBox2.DataSource = data;
        }
    }
}
