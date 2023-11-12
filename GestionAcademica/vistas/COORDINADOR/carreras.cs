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

namespace GestionAcademica.vistas.COORDINADOR
{
    public partial class carreras : Form
    {
        Carrera carrera = new Carrera();
        carreraCRUD CarreraCRUD = new carreraCRUD();
        
        public carreras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "" || textBox2.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Rellene todos los campos");

            }
            else {
                carrera.Nombre1 = textBox1.Text;
                carrera.Descripcion1 = textBox2.Text;
                carrera.DuracionYear1 = Convert.ToInt32(numericUpDown1.Value);

                CarreraCRUD.crear(carrera);
                refrescar();
            }
        }

        private void carreras_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = CarreraCRUD.obtener();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    string nombre = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DialogResult boton = MessageBox.Show("Desea eliminar a:"+nombre,"Confirme la eliminacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(boton == DialogResult.Yes)
                    {
                        CarreraCRUD.eliminar(id);
                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("La carrera no se ha eliminado ");
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            CarreraActualizar carreraActualizar = new CarreraActualizar(datos);
            carreraActualizar.OnUpdate = refrescar;
            carreraActualizar.ShowDialog();
        }

        
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string buscar = textBox3.Text;
            dataGridView1.DataSource = CarreraCRUD.filtro(buscar);
            dataGridView1.Refresh();
        }
    }
}
