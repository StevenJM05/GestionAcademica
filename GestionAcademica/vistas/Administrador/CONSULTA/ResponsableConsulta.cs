using GestionAcademica.modelos.Alumno;
using GestionAcademica.modelos.Responsable;
using GestionAcademica.vistas.COORDINADOR;
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
    public partial class ResponsableConsulta : Form
    {
        CRUDResponsable CRUDResponsable = new CRUDResponsable();    
        public ResponsableConsulta()
        {
            InitializeComponent();
            
        }

        private void ResponsableConsulta_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        
        private void refrescar()
        {
            dataGridView1.DataSource = CRUDResponsable.obtener();
            dataGridView1.Refresh();
        }
    }
}
