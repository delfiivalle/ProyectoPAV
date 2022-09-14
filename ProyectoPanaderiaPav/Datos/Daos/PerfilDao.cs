using ProyectoPanaderiaPav.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Daos
{
    internal class PerfilDao : IPerfil
    {

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Perfiles WHERE borrado = 0 order by 2";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
