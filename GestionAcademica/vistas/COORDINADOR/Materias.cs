using GestionAcademica.modelos.Carrera;
using GestionAcademica.vistas.Administrador;
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
    public partial class Materias : Form
    {
        Materia materia = new Materia();
        MateriaCRUD materiaCRUD = new MateriaCRUD();
        Action onUpdate = null;

        public Materias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");

            }
            else
            {
                materia.Nombre1 = textBox1.Text;
                materia.Descripcion1 = textBox2.Text;
                materia.IdCarrera1 = (int)comboBox1.SelectedValue;
                materia.IdYear1 = (int)comboBox2.SelectedValue;


                materiaCRUD.crear(materia);
                refrescar();
            }


        }
        private void refrescar()
        {
            dataGridView1.DataSource = materiaCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    DialogResult boton = MessageBox.Show("Desea eliminar la materia:" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (boton == DialogResult.Yes)
                    {
                        materiaCRUD.eliminar(id);
                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("La materia no se ha eliminado ");
                    }


                }


            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            MateriaActualizar materiaActualizar = new MateriaActualizar(datos);
            materiaActualizar.OnUpdate = refrescar;
            materiaActualizar.ShowDialog();

        }

        private void Materias_Load(object sender, EventArgs e)
        {
            refrescar();
            carreraCRUD carreraCRUD = new carreraCRUD();
            DataTable dt = (DataTable)carreraCRUD.obtener();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Carrera";
            comboBox1.DataSource = dt;
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDependiente() {
            int id = (int)comboBox2.SelectedValue;
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
