using GestionAcademica.Clases;
using GestionAcademica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.modelos.Usuario
{
    internal class UsuarioCRUD : ICRUD
    {
        public void actualizar(object modelo, int id)
        {
           Usuario usuario = (Usuario)modelo;
            string sql = "UPDATE usuarios SET nombre ='"+usuario.Nombre+ "', apellido = '"+usuario.Apellido+ "', direccion ='"+usuario.Direccion+ "', email = '"+usuario.Email+ "', login ='"+usuario.Login+ "', clave ='"+usuario.Clave+ "', tipo ='"+usuario.Tipo+ "' where id_usuario = " + id + "";



        }

        public void crear(object modelo)
        {
            Usuario usuario = (Usuario)modelo;
            string sql = "INSERT INTO usuarios(nombre,apellido,direccion,email,login,clave,tipo) " +
                "VALUES('"+usuario.Nombre+"','"+usuario.Apellido+"','"+usuario.Direccion+"','"+usuario.Email+"','"+usuario.Login+"','"+usuario.Clave+"','"+usuario.Tipo+"')";
        }

        public void eliminar(int id)
        {
            string sql = "DELETE FROM usuarios WHERE id_usuario = " + id + "";
        }

        public object obtener()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM usuarios";
            DataTable dataTable = conexion.consultas(sql);
            return dataTable;
        }
    }
}
