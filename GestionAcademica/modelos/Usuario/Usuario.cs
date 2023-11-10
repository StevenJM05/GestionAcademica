using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Usuario
{
    public class Usuario
    {

        private int id_usuario;
        private string apellido;
        private string direccion;
        private string email;
        private string login;
        private string clave;
        private string tipo;


        public Usuario() { 
        
        }

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Login { get => login; set => login = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
