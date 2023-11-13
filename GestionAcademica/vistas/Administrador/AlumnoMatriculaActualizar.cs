using GestionAcademica.modelos.Alumno;
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
    public partial class AlumnoMatriculaActualizar : Form
    {
        AlumnoC alumnoC = new AlumnoC();
        AlumnoCRUD alumnoCRUD = new AlumnoCRUD();
        Action onUpdate = null;

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }
        public AlumnoMatriculaActualizar(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            establecerDatos(datos);
        }
        private bool VerificarExistencarnet(string carnet)
        {

            DataTable dt = (DataTable)alumnoCRUD.obtener();
            foreach (DataRow row in dt.Rows)
            {
                string CarnetE = ((string)row["Carnet"]);
                if (CarnetE == carnet)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string carnet = numericUpDown1.Value.ToString();
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }if (VerificarExistencarnet(carnet))
            {
                MessageBox.Show("El nombre de usuario ya existe");
            }else{
                int id = (int)numericUpDown4.Value;
                alumnoC.IdAlumno = (int)numericUpDown1.Value;
                alumnoC.NumeroPartida = numericUpDown2.Value.ToString();
                alumnoC.FolioPartida = numericUpDown3.Value.ToString();
                alumnoC.DuiCarnetPropio = textBox1.Text;
                alumnoC.Nie = textBox2.Text;
                alumnoC.TipoBachillerato = textBox3.Text;
                alumnoC.AnioEstudio = textBox4.Text;
                alumnoCRUD.actualizar(alumnoC, id);
                onUpdate();
            }

        }
        public void establecerDatos(DataGridViewCellCollection datos)
        {
            
            numericUpDown1.Value = Convert.ToInt32(datos[1].Value);
            numericUpDown2.Text = datos[2].Value.ToString();
            numericUpDown3.Text = datos[3].Value.ToString();
            textBox1.Text = datos[4].Value.ToString();
            textBox2.Text = datos[5].Value.ToString();
            textBox3.Text = datos[6].Value.ToString();
            textBox4.Text = datos[7].Value.ToString();
        }

        private void AlumnoMatriculaActualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
