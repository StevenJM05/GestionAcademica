using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica.Clases
{
    internal class ConexionBD
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string cadena = "Data Source = .; initial catalog = ACADEMICA_DAE; integrated security = true;";

        public ConexionBD()
        {
            this.con.ConnectionString = cadena;
        }

        public DataTable consultas(string sql)
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            return dt;
        }

        public bool ejecutarComando(string sql)
        {
            cmd.CommandText = sql;
            cmd.Connection = this.con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return true;
        }
    }
}

