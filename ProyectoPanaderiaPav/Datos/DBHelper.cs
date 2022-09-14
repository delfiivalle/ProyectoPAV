using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos
{
    internal class DBHelper
    {
        private static DBHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;

        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = Properties.Resources.StringConexion;
        }
        public static DBHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;
        }

        // Método utilizado para realizar una consulta en la base de datos
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }

        // Método utilizado para un insert, update y delete en la base de datos
        public int actualizar(string actualizacionSQL)
        {
            int filasAfectadas = 0;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = actualizacionSQL;
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
        }
    }
}
