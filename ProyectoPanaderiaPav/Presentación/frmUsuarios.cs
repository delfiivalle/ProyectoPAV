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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ProyectoPanaderiaPav.Presentación
{
    public partial class frmUsuarios : Form
    {
        PerfilService servicioPerfil = new PerfilService();
        UsuarioService servicioUsuario = new UsuarioService();
        public frmUsuarios()
        {
            InitializeComponent();
            ttAgregar.SetToolTip(btnNuevoUsuario, "Agregar usuario");
            ttEditar.SetToolTip(btnEditarUsuario, "Editar usuario");
            ttEliminar.SetToolTip(btnEliminarUsuario, "Eliminar usuario");
            ttSalir.SetToolTip(btnSalir, "Salir");
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.Limpiar();

            this.CargarGrillaUsuarios(dgvUsuarios, servicioUsuario.traerTodos());
            this.CargarComboPerfil(cmbPerfil, servicioPerfil.traerTodos());

            // Inhabilitar botones de eliminar y editar usuarios
            btnEditarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
        }

        private void CargarGrillaUsuarios(DataGridView grillaUsuarios, DataTable tablaUsuarios)
        {
            grillaUsuarios.Rows.Clear();
            for (int i = 0; i < tablaUsuarios.Rows.Count; i++)
            {
                grillaUsuarios.Rows.Add(tablaUsuarios.Rows[i]["usuario"],
                                        tablaUsuarios.Rows[i]["nombre"]);
            }
        }

        private void CargarComboPerfil(ComboBox comboPerfil, DataTable tablaPerfiles)
        {
            comboPerfil.DataSource = tablaPerfiles;
            comboPerfil.DisplayMember = tablaPerfiles.Columns[1].ColumnName;
            comboPerfil.ValueMember = tablaPerfiles.Columns[0].ColumnName;
            comboPerfil.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            this.txtNombreUsuario.Text = string.Empty;
            this.cmbPerfil.SelectedIndex = -1;
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = string.Empty; 
            string perfil = string.Empty;
            DataTable tabla = new DataTable();
            if (txtNombreUsuario.Text != string.Empty)
            {
                nombre = txtNombreUsuario.Text.ToString();
            }
            if (cmbPerfil.SelectedIndex != -1)
            {
                perfil = cmbPerfil.SelectedValue.ToString();
            }

            tabla = servicioUsuario.traerFiltrados(nombre, perfil);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún usuario.",
                "USUARIO NO ENCONTRADO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                this.Limpiar();
                this.CargarGrillaUsuarios(dgvUsuarios, servicioUsuario.traerTodos());
            }
            else
                this.CargarGrillaUsuarios(dgvUsuarios, tabla);
            this.Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // NUEVO USUARIO
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmABMCUsuarios nuevoUsuario = new frmABMCUsuarios();
            nuevoUsuario.ShowDialog();
            this.CargarGrillaUsuarios(dgvUsuarios, servicioUsuario.traerTodos());
        }

        // MODIFICAR USUARIO
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            frmABMCUsuarios frmActualizarUsuario = new frmABMCUsuarios();
            Usuario usuarioAEditar = new Usuario();
            usuarioAEditar.NombreUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Perfil perfilAAsignar = new Perfil();
            usuarioAEditar.Perfil = perfilAAsignar;
            usuarioAEditar.Perfil.Nombre = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            frmActualizarUsuario.SeleccionarUsuario(frmABMCUsuarios.Acciones.update, usuarioAEditar);
            frmActualizarUsuario.ShowDialog();

            // Volver a cargar la grilla
            this.CargarGrillaUsuarios(dgvUsuarios, servicioUsuario.traerTodos());
        }

        // ELIMINAR USUARIO
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            frmABMCUsuarios frmEliminarUsuario = new frmABMCUsuarios();
            Usuario usuarioAEliminar = new Usuario();
            usuarioAEliminar.NombreUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Perfil perfilAAsignar = new Perfil();
            usuarioAEliminar.Perfil = perfilAAsignar;
            usuarioAEliminar.Perfil.Nombre = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            frmEliminarUsuario.SeleccionarUsuario(frmABMCUsuarios.Acciones.delete, usuarioAEliminar);
            frmEliminarUsuario.ShowDialog();

            // Volver a cargar la grilla
            this.CargarGrillaUsuarios(dgvUsuarios, servicioUsuario.traerTodos());
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;
        }
    }
}
