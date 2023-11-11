using GestionAcademica.Clases;
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
    public partial class Grado : Form
    {
        YearAcademico yearAcademico = new YearAcademico();
        YearAcademicoCRUD academicoCRUD = new YearAcademicoCRUD();
        Action onUpdate = null;

        public Grado()
        {
            InitializeComponent();
        }

        private void Grado_Load(object sender, EventArgs e)
        {
            refrescar();
            carreraCRUD carreraCRUD = new carreraCRUD();
            DataTable dt = (DataTable)carreraCRUD.obtener();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Carrera";
            comboBox1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yearAcademico.IdCarrera1 = Convert.ToInt32(comboBox1.SelectedValue);
            yearAcademico.Yearacademico1 = textBox1.Text;
            if (comboBox1.SelectedIndex == 0 || textBox1.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                academicoCRUD.crear(yearAcademico);
                refrescar();
            }
            
        }

        private void refrescar()
        {
            dataGridView1.DataSource = academicoCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    DialogResult boton = MessageBox.Show("Desea eliminar a:" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (boton == DialogResult.Yes)
                    {
                        academicoCRUD.eliminar(id);
                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("El año academico no se ha eliminado ");
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            GradoActualizar gradoActualizar = new GradoActualizar(datos);
            gradoActualizar.OnUpdate = refrescar;
            gradoActualizar.ShowDialog();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string buscar = textBox2.Text;
            dataGridView1.DataSource = academicoCRUD.filtro(buscar);
            dataGridView1.Refresh();
        }
    }
}
