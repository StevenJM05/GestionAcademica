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
    public partial class OtrosConsultaResponsable : Form
    {
        DatosOtrosResponsableCRUD datos = new DatosOtrosResponsableCRUD();
        public OtrosConsultaResponsable()
        {
            InitializeComponent();
        }

        private void OtrosConsultaResponsable_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            dataGridView1.DataSource = datos.obtener();
            dataGridView1.Refresh();
        }

    }
}
