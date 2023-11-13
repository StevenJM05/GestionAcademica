using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Carrera;
using GestionAcademica.modelos.Usuario;
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
    public partial class Alumno : Form
    {
        modelos.Alumno.AlumnoC alumno = new modelos.Alumno.AlumnoC();
        AlumnoCRUD alumnoCRUD = new AlumnoCRUD();
        Action onUpdate = null;

        public Alumno()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = alumnoCRUD.obtener();
            dataGridView1.Refresh();
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
        private bool VerificarSiExisteDUIAlumno(string DuiAlumno)
        {

            DataTable dt = (DataTable)alumnoCRUD.obtener();
            foreach (DataRow row in dt.Rows)
            {
                string DUI = ((string)row["DUI_Carnet_Propio"]);
                if(DuiAlumno == "")
                {
                    return false;
                }
                if (DUI == DuiAlumno)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DuiAlumno = textBox1.Text;
            string carnet = numericUpDown1.Value.ToString();
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
                return;
            }if (VerificarExistencarnet(carnet))
            {
                MessageBox.Show("El carnet ya existe");
                return;
            }if (VerificarSiExisteDUIAlumno(DuiAlumno))
            {
                MessageBox.Show("El DUI ha sido registrado anterirormente");
                return;
            }else
            {
                alumno.Carnet = numericUpDown1.Value.ToString();
                alumno.NumeroPartida = numericUpDown2.Value.ToString();
                alumno.FolioPartida = numericUpDown3.Value.ToString();
                alumno.DuiCarnetPropio = textBox1.Text;
                alumno.Nie = textBox2.Text;
                alumno.TipoBachillerato = textBox3.Text;
                alumno.AnioEstudio = textBox4.Text;
                alumnoCRUD.crear(alumno);
                refrescar();
                button1.Visible = false;
            }
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los Campos antes de pasar al siguiente formulario");
            }
            else {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                DatosPersonalesAlumno personalesAlumno = new DatosPersonalesAlumno();
                personalesAlumno.numericUpDown1.Value = Convert.ToDecimal(id);
                personalesAlumno.ShowDialog();
                this.Close();
            }

           

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            AlumnoMatriculaActualizar alumno = new AlumnoMatriculaActualizar(datos);
            alumno.OnUpdate = refrescar;
            alumno.ShowDialog();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
