using GestionAcademica.modelos.Alumno;
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
    public partial class seccion : Form
    {
        carreraCRUD carrera = new carreraCRUD();
        Seccion secion = new Seccion();
        SeccionCRUD SeccionCRUD = new SeccionCRUD();
        Action onUpdate = null;
        public seccion()
        {
            InitializeComponent();
        }
        private void refrescar()
        {
            dataGridView1.DataSource = SeccionCRUD.obtener();
            dataGridView1.Refresh();
        }
        private void seccion_Load(object sender, EventArgs e)
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

        private void comboBoxDependiente()
        {
            int id = (int)comboBox1.SelectedValue;
            YearAcademicoCRUD yearAcademicoCRUD = new YearAcademicoCRUD();
            DataTable data = (DataTable)yearAcademicoCRUD.comboConsulta(id);
            comboBox2.DisplayMember = "Anio_Establecido";
            comboBox2.ValueMember = "Id_Anio";
            comboBox2.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Complete los campos");
            }
            else
            {
                secion.IdYear1 = (int)comboBox2.SelectedValue;
                secion.IdCarrera1 = (int)comboBox1.SelectedValue;
                secion.SecionLetra1 = textBox1.Text;
                SeccionCRUD.crear(secion);
                refrescar();
            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            SeccionActualizar alumno = new SeccionActualizar(datos);
            alumno.OnUpdate = refrescar;
            alumno.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescar();
            comboBoxDependiente();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    DialogResult boton = MessageBox.Show("Desea eliminar la materia:" + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(), "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (boton == DialogResult.Yes)
                    {
                        SeccionCRUD.eliminar(id);
                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("La seccion no se ha eliminado ");
                    }


                }


            }
        }
    }
}
