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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionAcademica.vistas.COORDINADOR
{
    public partial class SeccionActualizar : Form
    {
        Seccion seccion = new Seccion();
        SeccionCRUD seccionCRUD = new SeccionCRUD();
        Action onUpdate = null;
        carreraCRUD carrera = new carreraCRUD();
        public SeccionActualizar(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            establecerDatos(datos);
        }

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }

        private void SeccionActualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)carrera.obtener();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Carrera";
            comboBox1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            seccion.IdCarrera1 = (int)comboBox1.SelectedValue;
            seccion.IdYear1 = (int)comboBox2.SelectedValue;
            seccion.SecionLetra1 = textBox1.Text;
            seccionCRUD.actualizar(seccion, id);
            onUpdate();
        }

        public void establecerDatos(DataGridViewCellCollection datos)
        {
            numericUpDown1.Value = (int)datos[1].Value;
            comboBox1.Text = datos[3].Value.ToString();
            comboBox2.Text = datos[5].Value.ToString();
            textBox1.Text = datos[6].Value.ToString();
            
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
    }
}
