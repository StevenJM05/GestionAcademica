using GestionAcademica.Clases;
using GestionAcademica.modelos.Usuario;
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

namespace GestionAcademica.vistas.USUARIO
{
    public partial class Registrar_Usuarios : Form
    {
        
        ConexionBD conexionBD = new ConexionBD();

        Usuario usuario =  new Usuario();
        UsuarioCRUD usuarioCRUD = new UsuarioCRUD();
        public Registrar_Usuarios()
        {
            InitializeComponent();
        }
        private bool VerificarExistenciausuario(string nombreU)
        {
            
            DataTable dt = (DataTable)usuarioCRUD.obtener();
            foreach (DataRow row in dt.Rows)
            {
                string NombreUsuario = ((string)row["login"]);
                if (NombreUsuario == nombreU)
                {
                    return true; 
                }
            }
            return false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreU = textBox5.Text;
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }if (VerificarExistenciausuario(nombreU))
            {
                MessageBox.Show("El nombre de usuario ya existe");
            }else {
                usuario.Apellido = textBox1.Text;
                usuario.Direccion = textBox3.Text;
                usuario.Email = textBox2.Text;
                usuario.Login = textBox5.Text;
                usuario.Clave = textBox4.Text;
                usuario.Tipo = comboBox1.Text;

                usuarioCRUD.crear(usuario);
                refrescar();
            }
            
            
        }

        private void Registrar_Usuarios_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            dataGridView1.DataSource = usuarioCRUD.obtener();
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection datos = dataGridView1.CurrentRow.Cells;
            ActualizarUsuario usuario = new ActualizarUsuario(datos);
            usuario.OnUpdate1 = refrescar;
            usuario.ShowDialog();
        }
    }
}
