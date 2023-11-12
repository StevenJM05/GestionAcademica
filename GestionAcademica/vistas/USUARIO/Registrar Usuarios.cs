using GestionAcademica.Clases;
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

        private void button1_Click(object sender, EventArgs e)
        {

            int tipo = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }

            else {
                
                if (comboBox1.Text == "Administrador")
                {
                     tipo = 1;
                }
                else if(comboBox1.Text == "Coordinador")
                {
                    tipo = 2;
                }
                else
                {
                    tipo = 3;
                }

                usuario.Apellido = textBox1.Text;
                usuario.Direccion = textBox3.Text;
                usuario.Email = textBox2.Text;
                usuario.Login = textBox5.Text;
                usuario.Clave = textBox4.Text;
                usuario.Tipo = tipo.ToString();

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
    }
}
