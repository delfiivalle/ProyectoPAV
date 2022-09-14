using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IUsuario
    {
        int RecuperarUsuario(string nombreUsuario, string clave);
        int RecuperarUsuario(string nombreUsuario);
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string nombre, string perfil);
        int InsertarUsuario(Usuario usuarioAInsertar);
        string RecuperarClave(string nombreUsuario);
        int ActualizarUsuario(Usuario usuario);
        int EliminarUsuario(Usuario usuario);
    }
}
