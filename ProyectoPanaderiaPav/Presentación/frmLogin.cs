using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav.Presentación
{
    public partial class frmLogin : Form
    {
        //Atributos formulario login
        private Usuario usuario = new Usuario();
        private UsuarioService servicioUsuario = new UsuarioService();
        public frmLogin()
        {
            InitializeComponent();
        }
        //FIJARSE Y BORRARLO SI NOLO USAMOS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //private void frmLogin_Load(object sender, EventArgs e)
        //{
        //    this.Text = "Logeo!!!";
        //    this.BackColor = Color.Green;
        //}
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validación de "no vacio" en ingreso
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario...");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña...");
                this.txtClave.Focus();
                return;
            }

            //Asignar atributos al usuario con los datos cargados
            this.usuario.NombreUsuario = this.txtUsuario.Text;
            this.usuario.Clave = this.txtClave.Text;

            //Cargar atributo ID con lo que devuelve el método encontrar usuario del servicio usuario
            this.usuario.IdUsuario = this.servicioUsuario.encontrarUsuario(usuario.NombreUsuario, usuario.Clave);

            //Validación de usuario cargado
            if (usuario.IdUsuario != 0)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Método para cerrar el formulario cuando toca el boton salir
            Environment.Exit(0);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(0);
        }
    }
}
