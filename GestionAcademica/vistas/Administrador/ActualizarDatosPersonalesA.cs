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
    public partial class ActualizarDatosPersonalesA : Form
    {
        DatosPersonalesAlumnoC DatosPersonalesAlumnoC = new DatosPersonalesAlumnoC();
        DatosPersonalesAlumnoCRUD alumnoCRUD = new DatosPersonalesAlumnoCRUD();
        Action onUpdate = null;

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }
        public ActualizarDatosPersonalesA(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            establecerDatos(datos);
        }

        private void ActualizarDatosPersonalesA_Load(object sender, EventArgs e)
        {

        }
        public void establecerDatos(DataGridViewCellCollection datos)
        {
            numericUpDown2.Value = (int)datos[0].Value;
            numericUpDown1.Value = (int)datos[1].Value;
            textBox2.Text = datos[2].Value.ToString();
            textBox3.Text = datos[3].Value.ToString();
            textBox4.Text = datos[4].Value.ToString();
            textBox7.Text = datos[5].Value.ToString();
            textBox6.Text = datos[6].Value.ToString();
            textBox5.Text = datos[7].Value.ToString();
            dateTimePicker1.Text = datos[8].Value.ToString();
            textBox8.Text = datos[9].Value.ToString();
            textBox9.Text = datos[10].Value.ToString();
            textBox10.Text = datos[11].Value.ToString();
            textBox11.Text = datos[12].Value.ToString();
            comboBox1.Text = datos[13].Value.ToString();
            comboBox2.Text = datos[14].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown2.Value;
            DatosPersonalesAlumnoC.IdAlumno1 = (int)numericUpDown1.Value;
            DatosPersonalesAlumnoC.PrimerNombre = textBox2.Text;
            DatosPersonalesAlumnoC.SegundoNombre = textBox3.Text;
            DatosPersonalesAlumnoC.TercerNombre = textBox4.Text;
            DatosPersonalesAlumnoC.PrimerApellido = textBox7.Text;
            DatosPersonalesAlumnoC.SegundoApellido = textBox6.Text;
            DatosPersonalesAlumnoC.TercerNombre = textBox5.Text;
            DatosPersonalesAlumnoC.FechaNacimiento = dateTimePicker1.Text;
            DatosPersonalesAlumnoC.Residencia = textBox8.Text;
            DatosPersonalesAlumnoC.Direccion = textBox9.Text;
            DatosPersonalesAlumnoC.Nacionalidad = textBox10.Text;
            DatosPersonalesAlumnoC.DepartamentoMunicipioNacimiento = textBox11.Text;
            alumnoCRUD.actualizar(DatosPersonalesAlumnoC, id);
        }
    }
}
