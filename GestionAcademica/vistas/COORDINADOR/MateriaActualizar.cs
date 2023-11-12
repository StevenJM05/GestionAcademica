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
    public partial class MateriaActualizar : Form
    {
        Materia Materia = new Materia();
        MateriaCRUD materiaCRUD = new MateriaCRUD();
        Action onUpdate = null;

        public Action OnUpdate { get => onUpdate; set => onUpdate = value; }
        public MateriaActualizar(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            establecerDatos(datos);
        }

        private void MateriaActualizar_Load(object sender, EventArgs e)
        {

        }

        public void establecerDatos(DataGridViewCellCollection datos)
        {
            numericUpDown1.Value = Convert.ToInt32(datos[0].Value);
            textBox1.Text = datos[1].Value.ToString();
            textBox2.Text = datos[2].Value.ToString();
            comboBox1.SelectedValue = datos[3].Value;
            comboBox2.SelectedValue = datos[4].Value;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
