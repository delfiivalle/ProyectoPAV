using ProyectoPanaderiaPav.Datos.Daos;
using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav.Servicios
{
    internal class UsuarioService
    {
        private IUsuario daoUsuario;

        public UsuarioService()
        {
            daoUsuario = new UsuarioDao();
        }
        public int encontrarUsuario(string nombreUsuario, string clave)
        {
            return daoUsuario.RecuperarUsuario(nombreUsuario, clave);
        }
        public DataTable traerTodos()
        {
            return daoUsuario.RecuperarTodos();
        }
        internal DataTable traerFiltrados(string nombre, string perfil)
        {
            return daoUsuario.RecuperarFiltrados(nombre, perfil);
        }
        internal int crearUsuario(Usuario usuarioAInsertar)
        {
            return daoUsuario.InsertarUsuario(usuarioAInsertar);
        }
        internal int existeUsuario(string nombreUsuario)
        {
            return daoUsuario.RecuperarUsuario(nombreUsuario);
        }
        internal string traerClave(string nombreUsuario)
        {
            return daoUsuario.RecuperarClave(nombreUsuario);
        }
        internal int modificarUsuario(Usuario usuario)
        {
            return daoUsuario.ActualizarUsuario(usuario);
        }
        internal int eliminarUsuario(Usuario usuario)
        {
            return daoUsuario.EliminarUsuario(usuario);
        }
    }
}
