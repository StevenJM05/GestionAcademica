using GestionAcademica.modelos.Usuario;
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
            UsuarioCRUD usuarioCRUD = new UsuarioCRUD();
            string login = this.textBox1.Text;
            string clave = this.textBox2.Text;

            Usuario usuario = usuarioCRUD.obtenerUsuario(login, clave);

            if (usuario != null) {
                if(usuario.Tipo == "1" ) {
                    FormAdministrador formAdministrador = new FormAdministrador();
                    formAdministrador.Show();
                } else if(usuario.Tipo == "2") {
                    //LLamar al formulario de profesor
                }
                  
            } else {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
