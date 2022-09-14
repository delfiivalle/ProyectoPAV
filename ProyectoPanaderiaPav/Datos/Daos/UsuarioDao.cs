using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Daos
{
    internal class UsuarioDao : IUsuario
    {
        public int RecuperarUsuario(string nombreUsuario, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" + 
                               nombreUsuario + "' AND clave='" + clave + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public int RecuperarUsuario(string nombreUsuario)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" +
                               nombreUsuario + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }


        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT u.usuario, p.nombre FROM Usuarios u " +
                              "JOIN Perfiles p ON (u.idPerfil = p.idPerfil) " +
                              "WHERE u.borrado = 0 AND p.borrado = 0 order by u.usuario";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string nombre, string perfil)
        {
            string consulta = "SELECT u.usuario, p.nombre FROM Usuarios u " +
                              "JOIN Perfiles p ON (u.idPerfil = p.idPerfil)" +
                              " WHERE u.borrado = 0 AND p.borrado = 0";
            if (nombre != "")
            {
                consulta += " AND u.usuario LIKE '%" + nombre + "%'";
            }
            if (!string.IsNullOrEmpty(perfil))
            {
                consulta += " AND u.idPerfil = " + perfil;
            }
            consulta += " ORDER BY u.usuario";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }

        public int InsertarUsuario(Usuario usuarioAInsertar)
        {
            string insert = "INSERT INTO Usuarios (usuario, clave, borrado, idPerfil)" +
                            " VALUES (" +
                            "'" + usuarioAInsertar.NombreUsuario + "'" + ", " +
                            "'" + usuarioAInsertar.Clave + "' , 0, " +
                             usuarioAInsertar.Perfil.IdPerfil + ")";

            return DBHelper.obtenerInstancia().actualizar(insert);
        }

        public string RecuperarClave(string nombreUsuario)
        {
            string consulta = "SELECT clave FROM Usuarios WHERE usuario = '" + nombreUsuario + "'";
            return DBHelper.obtenerInstancia().consultar(consulta).Rows[0]["clave"].ToString();
        }

        public int ActualizarUsuario(Usuario usuario)
        {
            string update = "UPDATE Usuarios " +
                "SET usuario = '" + usuario.NombreUsuario + "'" + "," +
                             " clave = " + "'" + usuario.Clave + "'" + "," +
                             " borrado = 0," +  
                             " idPerfil = " + usuario.Perfil.IdPerfil +
                             " WHERE idUsuario = " + usuario.IdUsuario;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public int EliminarUsuario(Usuario usuario)
        {
            string delete = "UPDATE Usuarios SET borrado = 1 WHERE usuario = '" + usuario.NombreUsuario + "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }
    }
}
