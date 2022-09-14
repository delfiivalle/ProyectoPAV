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
    public partial class frmABMCUsuarios : Form
    {
        PerfilService servicioPerfilABMC = new PerfilService();
        UsuarioService servicioUsuarioABMC = new UsuarioService();
        private Usuario usuario = new Usuario();
        private Perfil perfil = new Perfil();
        private Acciones accion = Acciones.insert;
        
        public enum Acciones
        {
            insert,
            update,
            delete
        }

        public frmABMCUsuarios()
        {
            InitializeComponent();

        }
        //Load ABMC para cargar combo perfil
        private void frmABMCUsuarios_Load(object sender, EventArgs e)
        {
            this.CargarComboPerfilABMC(cmbPerfilABMC, servicioPerfilABMC.traerTodos());
            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nuevo usuario";
                        break;
                    }

                case Acciones.update:
                    {
                        this.Text = "Actualizar usuario";
                        // Recuperar usuario seleccionado en la grilla 
                        CargarDatos();
                        txtNombreABMC.Enabled = true;
                        txtClaveABMC.Enabled = true;
                        txtRepetirClaveABMC.Enabled = true;
                        cmbPerfilABMC.Enabled = true;
                        break;
                    }

                case Acciones.delete:
                    {
                        CargarDatos();
                        this.Text = "Eliminar usuario";
                        txtNombreABMC.Enabled = false;
                        txtClaveABMC.Enabled = false;
                        txtRepetirClaveABMC.Enabled = false;
                        cmbPerfilABMC.Enabled = false;
                        break;
                    }
            }
        }

        private void CargarDatos()
        {
            if (usuario != null)
            {
                txtNombreABMC.Text = usuario.NombreUsuario;

                string clave = servicioUsuarioABMC.traerClave(usuario.NombreUsuario);
                txtClaveABMC.Text = clave;
                txtRepetirClaveABMC.Text = clave;
                cmbPerfilABMC.Text = usuario.Perfil.Nombre;
            }
        }

        public void SeleccionarUsuario(Acciones opcion, Usuario usuarioSeleccionado)
        {
            accion = opcion;
            usuario = usuarioSeleccionado;
        }

        private void CargarComboPerfilABMC(ComboBox cmbPerfilABMC, DataTable tablaPerfilABMC)
        {
            cmbPerfilABMC.DataSource = tablaPerfilABMC;
            cmbPerfilABMC.DisplayMember = tablaPerfilABMC.Columns[1].ColumnName;
            cmbPerfilABMC.ValueMember = tablaPerfilABMC.Columns[0].ColumnName;
            cmbPerfilABMC.SelectedIndex = -1;
        }

        private bool ValidarUsuario()
        {
            string nombreUsuario = txtNombreABMC.Text;
            string claveUsuario = txtClaveABMC.Text;
            //Validamos que se haya cargado un usuario
            if (nombreUsuario == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreABMC.BackColor = Color.Red;
                txtNombreABMC.Focus();
                return false;
            }

            //Validamos que se ingrese la contraseña
            if (claveUsuario == string.Empty)
            {
                MessageBox.Show("Se debe ingresar una contraseña.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Validamos que las contraseñas sean iguales
            if (claveUsuario != txtRepetirClaveABMC.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor ingrese nuevamente los datos",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //VER!!! SI QUEREMOS BORRARLO
                txtClaveABMC.Focus();
                return false;
            }

            //Validación de perfil
            if (cmbPerfilABMC.SelectedIndex == -1)
            {
                MessageBox.Show("Se debe seleccionar un perfil para el usuario",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnCancelarABMC_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Está seguro que desea salir?",
                "Saliendo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnAceptarABMC_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreABMC.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    if (servicioUsuarioABMC.existeUsuario(nombreUsuario) == 0)
                    {
                        if (ValidarUsuario())
                        {
                            usuario.NombreUsuario = txtNombreABMC.Text.ToString();
                            usuario.Clave = txtClaveABMC.Text.ToString();
                            usuario.Perfil = perfil;
                            usuario.Perfil.IdPerfil = (int)cmbPerfilABMC.SelectedValue;

                            // Pedirle al usuario servicio que inserte el usuario en la base de datos con el dao
                            if(servicioUsuarioABMC.crearUsuario(usuario) != 0)
                            {
                                MessageBox.Show("El usuario se ha registrado correctamente.", "Información", 
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombreABMC.BackColor = Color.Tomato;
                        txtNombreABMC.Focus();
                    }
                    break;

                case Acciones.update:
                    //if (ValidarUsuario())
                    //{
                    //    usuario.IdUsuario = servicioUsuarioABMC.existeUsuario(usuario.NombreUsuario);
                    //    usuario.Clave = txtClaveABMC.Text.ToString();
                    //    usuario.Perfil = perfil;
                    //    usuario.Perfil.IdPerfil = (int)cmbPerfilABMC.SelectedValue;
                    //    if (usuario.NombreUsuario != nombreUsuario)
                    //    {      
                    //        if (servicioUsuarioABMC.existeUsuario(nombreUsuario) != 0)
                    //        {
                    //            MessageBox.Show("El usuario ya se encuentra registrado en el sistema, vuelva a intentarlo",
                    //                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //            txtNombreABMC.BackColor = Color.Tomato;
                    //            txtNombreABMC.Focus();
                    //        }
                    //        else
                    //            usuario.NombreUsuario = txtNombreABMC.Text.ToString();

                    //        break;
                    //    }
                    //    if (servicioUsuarioABMC.modificarUsuario(usuario) != 0)
                    //    {
                    //        MessageBox.Show("El usuario se ha actualizado correctamente.", "Información",
                    //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        this.Close();
                    //    }
                    //    else
                    //        MessageBox.Show("El usuario no se ha actualizado correctamente.", "Error",
                    //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    // LO QUE FUNCIONA
                    if (usuario.NombreUsuario != nombreUsuario)
                    {
                        if (servicioUsuarioABMC.existeUsuario(nombreUsuario) != 0)
                        {
                            MessageBox.Show("El usuario ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNombreABMC.BackColor = Color.Tomato;
                            txtNombreABMC.Focus();
                            //usuario.NombreUsuario = txtNombreABMC.Text.ToString();
                        }

                        else
                        {
                            if (ValidarUsuario())
                            {
                                usuario.IdUsuario = servicioUsuarioABMC.existeUsuario(usuario.NombreUsuario);
                                usuario.NombreUsuario = txtNombreABMC.Text.ToString();
                                usuario.Clave = txtClaveABMC.Text.ToString();
                                usuario.Perfil = perfil;
                                usuario.Perfil.IdPerfil = (int)cmbPerfilABMC.SelectedValue;
                            }
                            // Pedirle al usuario servicio que inserte el usuario en la base de datos con el dao
                            if (servicioUsuarioABMC.modificarUsuario(usuario) != 0)
                            {
                                MessageBox.Show("El usuario se ha modificado correctamente.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (ValidarUsuario())
                        {
                            usuario.IdUsuario = servicioUsuarioABMC.existeUsuario(usuario.NombreUsuario);
                            usuario.NombreUsuario = txtNombreABMC.Text.ToString();
                            usuario.Clave = txtClaveABMC.Text.ToString();
                            usuario.Perfil = perfil;
                            usuario.Perfil.IdPerfil = (int)cmbPerfilABMC.SelectedValue;
                        }
                        // Pedirle al usuario servicio que inserte el usuario en la base de datos con el dao
                        if (servicioUsuarioABMC.modificarUsuario(usuario) != 0)
                        {
                            MessageBox.Show("El usuario se ha modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;
         
                    

                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar el usuario " + nombreUsuario + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        // Pedirle al usuario servicio que elimine (borrado = 1) el usuario en la base de datos con el dao
                        if (servicioUsuarioABMC.eliminarUsuario(usuario) != 0)
                        {
                            MessageBox.Show("El usuario se ha eliminado correctamente.", "Información", 
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        // Método para limpiar los campos
        private void Limpiar()
        {
            txtNombreABMC.Text = string.Empty;
            txtClaveABMC.Text = string.Empty;
            txtRepetirClaveABMC.Text = string.Empty;
            cmbPerfilABMC.SelectedIndex = -1;
        }
    }
}
