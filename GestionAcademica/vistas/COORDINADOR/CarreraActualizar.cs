using GestionAcademica.modelos.Carrera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica.vistas.COORDINADOR
{
    public partial class CarreraActualizar : Form
    {
        carreraCRUD CarreraCRUD = new carreraCRUD();
        Carrera Carrera = new Carrera();
        Action onUpdate = null;

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }

        public CarreraActualizar(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            establecerDatos(datos);
        }

        public void establecerDatos(DataGridViewCellCollection datos)
        {
            numericUpDown2.Value = Convert.ToInt32(datos[0].Value);
            textBox1.Text = datos[1].Value.ToString();
            textBox2.Text = datos[2].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(datos[3].Value);
            

        }

        private void CarreraActualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          int id = Convert.ToInt32(numericUpDown2.Value);
          Carrera.Nombre1 = textBox1.Text;
          Carrera.Descripcion1 = textBox2.Text;
          Carrera.DuracionYear1 = Convert.ToInt32(numericUpDown1.Value);
          CarreraCRUD.actualizar(Carrera, id);
          onUpdate();
        }
    }
}
