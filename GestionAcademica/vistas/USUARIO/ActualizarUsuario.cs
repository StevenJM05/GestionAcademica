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
    public partial class ActualizarUsuario : Form
    {
        Usuario Usuario = new Usuario();
        UsuarioCRUD UsuarioCRUD = new UsuarioCRUD();
        Action OnUpdate = null;
        public Action OnUpdate1 { get => OnUpdate; set => OnUpdate = value; }



        public ActualizarUsuario(DataGridViewCellCollection datos)
        {
            InitializeComponent();
            EstablecerDatos(datos);

        }

        public void EstablecerDatos(DataGridViewCellCollection datos)
        {
            numericUpDown1.Value = Convert.ToInt32(datos[0].Value);
            textBox1.Text = datos[1].Value.ToString();
            textBox2.Text = datos[3].Value.ToString();
            textBox3.Text = datos[2].Value.ToString();
            textBox4.Text = datos[4].Value.ToString();
            textBox5.Text = datos[5].Value.ToString();
            comboBox1.Text = datos[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;

            int tipo = 0;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Complete todos los Campos");
            }

            else
            {

                if (comboBox1.Text == "Administrador")
                {
                    tipo = 1;
                }
                else if (comboBox1.Text == "Coordinador")
                {
                    tipo = 2;
                }
                else
                {
                    tipo = 3;
                }
                Usuario.Apellido = textBox1.Text;
                Usuario.Direccion = textBox3.Text;
                Usuario.Email = textBox2.Text;
                Usuario.Clave = textBox4.Text;
                Usuario.Login = textBox5.Text;
                Usuario.Tipo = tipo.ToString();

                UsuarioCRUD.actualizar(Usuario, id);
                OnUpdate1();

            }
        }
    }
}
