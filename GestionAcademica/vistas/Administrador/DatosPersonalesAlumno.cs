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

namespace GestionAcademica.vistas.Administrador
{
    public partial class DatosPersonalesAlumno : Form
    {
        DatosPersonalesAlumno personalesAlumno = new DatosPersonalesAlumno();
        DatosPersonalesAlumnoCRUD alumnoCRUD = new DatosPersonalesAlumnoCRUD(); 

        public DatosPersonalesAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
