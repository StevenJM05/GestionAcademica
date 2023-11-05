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
    public partial class Login : Form
    {
        Clases.ConexionBD BaseDatos = new Clases.ConexionBD();
        public Login()
        {
            InitializeComponent();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = this.textBox1.Text;
            string clave = this.textBox2.Text;
            string sql = "select * from usuarios where login = '" + login + "' and clave='" + clave + "'";
            DataTable dataTable = BaseDatos.consultas(sql);
            if(dataTable.Rows.Count > 0 )
            {
                string tipo = null;
                foreach(DataRow row in dataTable.Rows )
                {
                    tipo = row["tipo"].ToString();
                }

                if( tipo == "1" ) {
                    FormAdministrador formAdministrador = new FormAdministrador();
                    formAdministrador.Show();
                }

                if( tipo == "2")
                {
                    //LLamar al formulario de profesor
                }
                  
            }

            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
