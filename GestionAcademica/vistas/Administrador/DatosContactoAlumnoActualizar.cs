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
    public partial class DatosContactoAlumnoActualizar : Form
    {
        DatosContactoAlumnoC DatosContactoAlumnoC = new DatosContactoAlumnoC();
        DatosContactoAlumnoCRUD DatosContactoAlumnoCRUD = new DatosContactoAlumnoCRUD();
        Action onUpdate = null;

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }
        public DatosContactoAlumnoActualizar(DataGridViewCellCollection datos)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosContactoAlumnoC.Id_Alumno1 = (int)numericUpDown1.Value;
            DatosContactoAlumnoC.Correo1 = textBox2.Text;
            DatosContactoAlumnoC.TelefonoPropio1 = textBox3.Text;
            DatosContactoAlumnoC.TelefonoFijo1 = textBox4.Text;
            DatosContactoAlumnoC.TelefonoEmergencia1 = textBox5.Text;
            DatosContactoAlumnoCRUD.actualizar(DatosContactoAlumnoC, id);
        }
        public void establecerDatos(DataGridViewCellCollection datos)
        {

            numericUpDown1.Value = (int)datos[5].Value;
            textBox2.Text = datos[1].Value.ToString();
            textBox3.Text = datos[2].Value.ToString();
            textBox4.Text = datos[3].Value.ToString(); 
            textBox5.Text = datos[4].Value.ToString();

        }
    }
}
