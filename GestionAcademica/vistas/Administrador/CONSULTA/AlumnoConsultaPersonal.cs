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
    public partial class AlumnoConsultaPersonal : Form
    {
        DatosPersonalesAlumnoCRUD datos = new DatosPersonalesAlumnoCRUD();
        public AlumnoConsultaPersonal()
        {
            InitializeComponent();
        }

        private void AlumnoConsultaPersonal_Load(object sender, EventArgs e)
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
