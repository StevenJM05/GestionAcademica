using GestionAcademica.vistas.Administrador.CONSULTA;
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
    public partial class MenuResponsable : Form
    {
        public MenuResponsable()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResponsableConsulta responsable = new ResponsableConsulta();
            responsable.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResponsableConsultaPersonales responsable = new ResponsableConsultaPersonales();
            responsable.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResponsableConsultaContacto responsable = new ResponsableConsultaContacto();
            responsable.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OtrosConsultaResponsable responsable = new OtrosConsultaResponsable();
            responsable.Show();
        }
    }
}
