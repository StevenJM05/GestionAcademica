using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Carrera;
using GestionAcademica.modelos.Responsable;
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

namespace GestionAcademica.vistas.Administrador.CONSULTA
{
    public partial class AlumnoConsulta : Form
    {
        CRUDResponsable responsable = new CRUDResponsable();
        AlumnoCRUD AlumnoCRUD = new AlumnoCRUD();
    
        public AlumnoConsulta()
        {
            InitializeComponent();
        }

        private void AlumnoConsulta_Load(object sender, EventArgs e)
        {
            refrescar();
        }
      

        private void refrescar()
        {
            dataGridView1.DataSource = AlumnoCRUD.obtener();
            dataGridView1.Refresh();
        }

       

       
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    string nombre = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DialogResult boton = MessageBox.Show("Desea eliminar todos los datos de:" + nombre, "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (boton == DialogResult.Yes)
                    {

                      

                        AlumnoCRUD.eliminar(id);

                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Todos los datos del alumno se han eliminado ");
                    }
                }
            }
        }
    }
}

