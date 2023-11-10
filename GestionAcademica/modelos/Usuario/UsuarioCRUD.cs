using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademica.modelos.Usuario
{
    internal class UsuarioCRUD : ICRUD
    {
        ConexionBD conexionBD = new ConexionBD();

        public void actualizar(object modelo, int id)
        {
           Usuario usuario = (Usuario)modelo;
            string sql = "UPDATE Usuario SET apellido = '"+usuario.Apellido+ "', direccion ='"+usuario.Direccion+ "', email = '"+usuario.Email+ "', login ='"+usuario.Login+ "', clave ='"+usuario.Clave+ "', tipo ='"+usuario.Tipo+ "' where id_usuario = " + id + "";
            conexionBD.ejecutarComando(sql);
        }

        public void crear(object modelo)
        {
            Usuario usuario = (Usuario)modelo;
            string sql = "INSERT INTO Usuario(apellido,direccion,email,login,clave,tipo) " +
                "VALUES('"+usuario.Apellido+"','"+usuario.Direccion+"','"+usuario.Email+"','"+usuario.Login+"','"+usuario.Clave+"','"+usuario.Tipo+"')";
            conexionBD.ejecutarComando(sql);
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM Usuario WHERE id_usuario = " + id + "";
            conexionBD.ejecutarComando(sql);

        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Usuario";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }

        public Usuario obtenerUsuario(string login, string clave)
        {
            string sql = "select * from Usuario where login = '" + login + "' and clave='" + clave + "'";
            DataTable dataTable = conexionBD.consultas(sql);
            if (dataTable.Rows.Count > 0)
            {
                Usuario usuario = new Usuario();
                DataRow row = dataTable.Rows[0];

                usuario.Id_usuario = row.Field<int>("id_usuario");
               
                usuario.Apellido = row.Field<string>("Apellido");
                usuario.Tipo = row.Field<string>("tipo");

                return usuario;

            } else
            {
                return null;
            }
        }
    }
}
