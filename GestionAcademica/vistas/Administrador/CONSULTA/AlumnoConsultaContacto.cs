using GestionAcademica.modelos.Alumno;
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
    public partial class AlumnoConsultaContacto : Form
    {
        DatosContactoAlumnoCRUD datos = new DatosContactoAlumnoCRUD();
        public AlumnoConsultaContacto()
        {
            InitializeComponent();
        }

        private void AlumnoConsultaContacto_Load(object sender, EventArgs e)
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
