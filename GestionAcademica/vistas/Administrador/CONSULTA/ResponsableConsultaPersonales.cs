using GestionAcademica.modelos.Alumno;
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

namespace GestionAcademica.vistas.Administrador.CONSULTA
{
    public partial class ResponsableConsultaPersonales : Form
    {
        DatosPersonalesResponsableCRUD responsableCRUD = new DatosPersonalesResponsableCRUD();
        public ResponsableConsultaPersonales()
        {
            InitializeComponent();
        }

        private void ResponsableConsultaPersonales_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            dataGridView1.DataSource = responsableCRUD.obtener();
            dataGridView1.Refresh();
        }
    }
}
