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

namespace GestionAcademica.vistas.Administrador
{
    public partial class Bitacora : Form
    {
        carreraCRUD carreraCRUD = new carreraCRUD();
        BitacoraC 
        
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            carreraCRUD carreraCRUD = new carreraCRUD();
            DataTable dt = (DataTable)carreraCRUD.obtener();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Carrera";
            comboBox1.DataSource = dt;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDependiente();
        }

        private void ComboBoxDependiente2()
        {
            int id = (int)comboBox2.SelectedValue;
            SeccionCRUD seccionCRUD = new SeccionCRUD();
            DataTable data = (DataTable)seccionCRUD.comboConsulta(id);
            comboBox3.DisplayMember = "secion_Letra";
            comboBox3.ValueMember = "Id_Secion";
            comboBox3.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox3.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Bitacora
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDependiente2();
        }
    }
}
