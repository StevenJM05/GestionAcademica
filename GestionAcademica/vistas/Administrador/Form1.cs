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

namespace GestionAcademica
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void iNGRESIONDECARRERASTECNICASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void matrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            matricula.Show();
        }
    }
}
