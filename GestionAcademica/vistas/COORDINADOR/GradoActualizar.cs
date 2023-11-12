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
    public partial class GradoActualizar : Form
    {
        YearAcademico YearAcademico = new YearAcademico();
        YearAcademicoCRUD academicoCRUD = new YearAcademicoCRUD();
        Action onUpdate = null;

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }
        public GradoActualizar(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            establecerDatos(datos);
        }

        public void establecerDatos(DataGridViewCellCollection datos)
        {
            numericUpDown1.Value = Convert.ToInt32(datos[1].Value);
            textBox1.Text = datos[2].Value.ToString();

            
        }
        
        private void GradoActualizar_Load(object sender, EventArgs e)
        {
            carreraCRUD carreraCRUD = new carreraCRUD();
            DataTable dt = (DataTable)carreraCRUD.obtener();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Carrera";
            comboBox1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown1.Value);
            YearAcademico.Yearacademico1 = textBox1.Text;
            YearAcademico.IdCarrera1 = (int)comboBox1.SelectedValue;
            academicoCRUD.actualizar(YearAcademico, id);
            onUpdate();
            this.Close();
        }
    }
}
