using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Responsable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica.vistas.Administrador.CONSULTA
{
    public partial class ResponsableConsultaContacto : Form
    {
        DatosContactoResponsableCRUD datos = new DatosContactoResponsableCRUD();
        public ResponsableConsultaContacto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void refrescar()
        {
            dataGridView1.DataSource = datos.obtener();
            dataGridView1.Refresh();
        }

        private void ResponsableConsultaContacto_Load(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
