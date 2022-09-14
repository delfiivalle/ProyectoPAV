namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpFiltrosUsuarios = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ttAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttEditar = new System.Windows.Forms.ToolTip(this.components);
            this.ttEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttSalir = new System.Windows.Forms.ToolTip(this.components);
            this.grpFiltrosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltrosUsuarios
            // 
            this.grpFiltrosUsuarios.Controls.Add(this.pictureBox1);
            this.grpFiltrosUsuarios.Controls.Add(this.dgvUsuarios);
            this.grpFiltrosUsuarios.Controls.Add(this.btnConsultar);
            this.grpFiltrosUsuarios.Controls.Add(this.cmbPerfil);
            this.grpFiltrosUsuarios.Controls.Add(this.lblPerfil);
            this.grpFiltrosUsuarios.Controls.Add(this.txtNombreUsuario);
            this.grpFiltrosUsuarios.Controls.Add(this.lblNombreUsuario);
            this.grpFiltrosUsuarios.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltrosUsuarios.Location = new System.Drawing.Point(16, 15);
            this.grpFiltrosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltrosUsuarios.Name = "grpFiltrosUsuarios";
            this.grpFiltrosUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltrosUsuarios.Size = new System.Drawing.Size(704, 558);
            this.grpFiltrosUsuarios.TabIndex = 0;
            this.grpFiltrosUsuarios.TabStop = false;
            this.grpFiltrosUsuarios.Text = "Filtros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPanaderiaPav.Properties.Resources.iconoGranPan;
            this.pictureBox1.Location = new System.Drawing.Point(600, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.colPerfil});
            this.dgvUsuarios.Location = new System.Drawing.Point(69, 192);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(607, 358);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // colPerfil
            // 
            this.colPerfil.HeaderText = "Perfil";
            this.colPerfil.MinimumWidth = 6;
            this.colPerfil.Name = "colPerfil";
            this.colPerfil.ReadOnly = true;
            this.colPerfil.Width = 200;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Image = global::ProyectoPanaderiaPav.Properties.Resources.lupa;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(561, 139);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 34);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(166, 97);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(232, 26);
            this.cmbPerfil.TabIndex = 3;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(72, 107);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 18);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUsuario.Location = new System.Drawing.Point(166, 49);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(232, 26);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(72, 53);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(65, 18);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevoUsuario.Image = global::ProyectoPanaderiaPav.Properties.Resources.addUser;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(16, 581);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(85, 59);
            this.btnNuevoUsuario.TabIndex = 7;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarUsuario.Image = global::ProyectoPanaderiaPav.Properties.Resources.editUser;
            this.btnEditarUsuario.Location = new System.Drawing.Point(129, 581);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(79, 59);
            this.btnEditarUsuario.TabIndex = 8;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarUsuario.Image = global::ProyectoPanaderiaPav.Properties.Resources.deleteUser;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(239, 581);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(85, 59);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = global::ProyectoPanaderiaPav.Properties.Resources.logOut;
            this.btnSalir.Location = new System.Drawing.Point(635, 581);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 59);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(733, 653);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.grpFiltrosUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.grpFiltrosUsuarios.ResumeLayout(false);
            this.grpFiltrosUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltrosUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttAgregar;
        private System.Windows.Forms.ToolTip ttEditar;
        private System.Windows.Forms.ToolTip ttEliminar;
        private System.Windows.Forms.ToolTip ttSalir;
    }
}