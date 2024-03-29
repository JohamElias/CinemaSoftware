﻿namespace CinemaSoftLP2
{
    partial class frmGestionPeliculas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPeliculas));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionPeliculas = new System.Windows.Forms.Label();
            this.tcDatosPelicula = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.dtpDuracion = new System.Windows.Forms.DateTimePicker();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.cbSubtitulada = new System.Windows.Forms.CheckBox();
            this.cbDoblada = new System.Windows.Forms.CheckBox();
            this.lblIdiomas = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtIDPelicula = new System.Windows.Forms.TextBox();
            this.btnSubirPortada = new System.Windows.Forms.Button();
            this.lblIDPelicula = new System.Windows.Forms.Label();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.tpDatosCasting = new System.Windows.Forms.TabPage();
            this.btnEliminarActor = new System.Windows.Forms.Button();
            this.btnAgregarActor = new System.Windows.Forms.Button();
            this.btnBuscarActor = new System.Windows.Forms.Button();
            this.txtNombreCompletoActor = new System.Windows.Forms.TextBox();
            this.txtIDActor = new System.Windows.Forms.TextBox();
            this.lblNombreCompletoActor = new System.Windows.Forms.Label();
            this.lblIdActor = new System.Windows.Forms.Label();
            this.lblActores = new System.Windows.Forms.Label();
            this.dgvActores = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.tcDatosPelicula.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.tpDatosCasting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1125, 27);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 24);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionPeliculas
            // 
            this.lblGestionPeliculas.AutoSize = true;
            this.lblGestionPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPeliculas.Location = new System.Drawing.Point(16, 43);
            this.lblGestionPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionPeliculas.Name = "lblGestionPeliculas";
            this.lblGestionPeliculas.Size = new System.Drawing.Size(305, 20);
            this.lblGestionPeliculas.TabIndex = 2;
            this.lblGestionPeliculas.Text = "Formulario de Gestión de Películas";
            // 
            // tcDatosPelicula
            // 
            this.tcDatosPelicula.Controls.Add(this.tpDatosGenerales);
            this.tcDatosPelicula.Controls.Add(this.tpDatosCasting);
            this.tcDatosPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDatosPelicula.Location = new System.Drawing.Point(20, 78);
            this.tcDatosPelicula.Margin = new System.Windows.Forms.Padding(4);
            this.tcDatosPelicula.Name = "tcDatosPelicula";
            this.tcDatosPelicula.SelectedIndex = 0;
            this.tcDatosPelicula.Size = new System.Drawing.Size(1089, 372);
            this.tcDatosPelicula.TabIndex = 3;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.dtpDuracion);
            this.tpDatosGenerales.Controls.Add(this.txtSinopsis);
            this.tpDatosGenerales.Controls.Add(this.lblSinopsis);
            this.tpDatosGenerales.Controls.Add(this.cbSubtitulada);
            this.tpDatosGenerales.Controls.Add(this.cbDoblada);
            this.tpDatosGenerales.Controls.Add(this.lblIdiomas);
            this.tpDatosGenerales.Controls.Add(this.lblDuracion);
            this.tpDatosGenerales.Controls.Add(this.cboGenero);
            this.tpDatosGenerales.Controls.Add(this.lblGenero);
            this.tpDatosGenerales.Controls.Add(this.dtpFechaEstreno);
            this.tpDatosGenerales.Controls.Add(this.lblFechaEstreno);
            this.tpDatosGenerales.Controls.Add(this.lblTitulo);
            this.tpDatosGenerales.Controls.Add(this.txtTitulo);
            this.tpDatosGenerales.Controls.Add(this.txtIDPelicula);
            this.tpDatosGenerales.Controls.Add(this.btnSubirPortada);
            this.tpDatosGenerales.Controls.Add(this.lblIDPelicula);
            this.tpDatosGenerales.Controls.Add(this.pbPortada);
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 26);
            this.tpDatosGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(4);
            this.tpDatosGenerales.Size = new System.Drawing.Size(1081, 342);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales";
            // 
            // dtpDuracion
            // 
            this.dtpDuracion.CustomFormat = "hh:mm";
            this.dtpDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuracion.Location = new System.Drawing.Point(469, 134);
            this.dtpDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDuracion.Name = "dtpDuracion";
            this.dtpDuracion.ShowUpDown = true;
            this.dtpDuracion.Size = new System.Drawing.Size(119, 23);
            this.dtpDuracion.TabIndex = 17;
            this.dtpDuracion.Value = new System.DateTime(2022, 11, 2, 1, 30, 0, 0);
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(285, 225);
            this.txtSinopsis.Margin = new System.Windows.Forms.Padding(4);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(776, 91);
            this.txtSinopsis.TabIndex = 16;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(281, 206);
            this.lblSinopsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(74, 17);
            this.lblSinopsis.TabIndex = 15;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // cbSubtitulada
            // 
            this.cbSubtitulada.AutoSize = true;
            this.cbSubtitulada.Location = new System.Drawing.Point(469, 166);
            this.cbSubtitulada.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubtitulada.Name = "cbSubtitulada";
            this.cbSubtitulada.Size = new System.Drawing.Size(112, 21);
            this.cbSubtitulada.TabIndex = 14;
            this.cbSubtitulada.Text = "Subtitulada";
            this.cbSubtitulada.UseVisualStyleBackColor = true;
            // 
            // cbDoblada
            // 
            this.cbDoblada.AutoSize = true;
            this.cbDoblada.Location = new System.Drawing.Point(597, 166);
            this.cbDoblada.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoblada.Name = "cbDoblada";
            this.cbDoblada.Size = new System.Drawing.Size(90, 21);
            this.cbDoblada.TabIndex = 13;
            this.cbDoblada.Text = "Doblada";
            this.cbDoblada.UseVisualStyleBackColor = true;
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.Location = new System.Drawing.Point(297, 169);
            this.lblIdiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(157, 17);
            this.lblIdiomas.TabIndex = 12;
            this.lblIdiomas.Text = "Idiomas Disponibles:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(379, 138);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(78, 17);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duración:";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(469, 103);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(592, 25);
            this.cboGenero.TabIndex = 9;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(281, 107);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(170, 17);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Género de la Película:";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(469, 73);
            this.dtpFechaEstreno.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(592, 23);
            this.dtpFechaEstreno.TabIndex = 7;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(313, 76);
            this.lblFechaEstreno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(141, 17);
            this.lblFechaEstreno.TabIndex = 6;
            this.lblFechaEstreno.Text = "Fecha de Estreno:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(291, 47);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 17);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título de la Película:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(469, 43);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(592, 23);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtIDPelicula
            // 
            this.txtIDPelicula.Location = new System.Drawing.Point(469, 16);
            this.txtIDPelicula.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDPelicula.Name = "txtIDPelicula";
            this.txtIDPelicula.ReadOnly = true;
            this.txtIDPelicula.Size = new System.Drawing.Size(100, 23);
            this.txtIDPelicula.TabIndex = 3;
            this.txtIDPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubirPortada
            // 
            this.btnSubirPortada.BackgroundImage = global::CinemaSoftLP2.Properties.Resources.upload;
            this.btnSubirPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirPortada.Location = new System.Drawing.Point(213, 272);
            this.btnSubirPortada.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirPortada.Name = "btnSubirPortada";
            this.btnSubirPortada.Size = new System.Drawing.Size(60, 46);
            this.btnSubirPortada.TabIndex = 2;
            this.btnSubirPortada.UseVisualStyleBackColor = true;
            this.btnSubirPortada.Click += new System.EventHandler(this.btnSubirPortada_Click);
            // 
            // lblIDPelicula
            // 
            this.lblIDPelicula.AutoSize = true;
            this.lblIDPelicula.Location = new System.Drawing.Point(319, 20);
            this.lblIDPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPelicula.Name = "lblIDPelicula";
            this.lblIDPelicula.Size = new System.Drawing.Size(131, 17);
            this.lblIDPelicula.TabIndex = 1;
            this.lblIDPelicula.Text = "ID de la Película:";
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(24, 20);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(249, 297);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // tpDatosCasting
            // 
            this.tpDatosCasting.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosCasting.Controls.Add(this.btnEliminarActor);
            this.tpDatosCasting.Controls.Add(this.btnAgregarActor);
            this.tpDatosCasting.Controls.Add(this.btnBuscarActor);
            this.tpDatosCasting.Controls.Add(this.txtNombreCompletoActor);
            this.tpDatosCasting.Controls.Add(this.txtIDActor);
            this.tpDatosCasting.Controls.Add(this.lblNombreCompletoActor);
            this.tpDatosCasting.Controls.Add(this.lblIdActor);
            this.tpDatosCasting.Controls.Add(this.lblActores);
            this.tpDatosCasting.Controls.Add(this.dgvActores);
            this.tpDatosCasting.Location = new System.Drawing.Point(4, 26);
            this.tpDatosCasting.Margin = new System.Windows.Forms.Padding(4);
            this.tpDatosCasting.Name = "tpDatosCasting";
            this.tpDatosCasting.Padding = new System.Windows.Forms.Padding(4);
            this.tpDatosCasting.Size = new System.Drawing.Size(1081, 342);
            this.tpDatosCasting.TabIndex = 1;
            this.tpDatosCasting.Text = "Datos del Casting";
            // 
            // btnEliminarActor
            // 
            this.btnEliminarActor.Location = new System.Drawing.Point(1008, 38);
            this.btnEliminarActor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarActor.Name = "btnEliminarActor";
            this.btnEliminarActor.Size = new System.Drawing.Size(60, 28);
            this.btnEliminarActor.TabIndex = 8;
            this.btnEliminarActor.Text = "-";
            this.btnEliminarActor.UseVisualStyleBackColor = true;
            this.btnEliminarActor.Click += new System.EventHandler(this.btnEliminarActor_Click);
            // 
            // btnAgregarActor
            // 
            this.btnAgregarActor.Location = new System.Drawing.Point(947, 38);
            this.btnAgregarActor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarActor.Name = "btnAgregarActor";
            this.btnAgregarActor.Size = new System.Drawing.Size(60, 28);
            this.btnAgregarActor.TabIndex = 7;
            this.btnAgregarActor.Text = "+";
            this.btnAgregarActor.UseVisualStyleBackColor = true;
            this.btnAgregarActor.Click += new System.EventHandler(this.btnAgregarActor_Click);
            // 
            // btnBuscarActor
            // 
            this.btnBuscarActor.BackgroundImage = global::CinemaSoftLP2.Properties.Resources.search_icon_hi;
            this.btnBuscarActor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarActor.Location = new System.Drawing.Point(361, 14);
            this.btnBuscarActor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarActor.Name = "btnBuscarActor";
            this.btnBuscarActor.Size = new System.Drawing.Size(36, 25);
            this.btnBuscarActor.TabIndex = 6;
            this.btnBuscarActor.UseVisualStyleBackColor = true;
            this.btnBuscarActor.Click += new System.EventHandler(this.btnBuscarActor_Click);
            // 
            // txtNombreCompletoActor
            // 
            this.txtNombreCompletoActor.Location = new System.Drawing.Point(248, 41);
            this.txtNombreCompletoActor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompletoActor.Name = "txtNombreCompletoActor";
            this.txtNombreCompletoActor.ReadOnly = true;
            this.txtNombreCompletoActor.Size = new System.Drawing.Size(533, 23);
            this.txtNombreCompletoActor.TabIndex = 5;
            // 
            // txtIDActor
            // 
            this.txtIDActor.Location = new System.Drawing.Point(248, 14);
            this.txtIDActor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDActor.Name = "txtIDActor";
            this.txtIDActor.ReadOnly = true;
            this.txtIDActor.Size = new System.Drawing.Size(108, 23);
            this.txtIDActor.TabIndex = 4;
            this.txtIDActor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreCompletoActor
            // 
            this.lblNombreCompletoActor.AutoSize = true;
            this.lblNombreCompletoActor.Location = new System.Drawing.Point(20, 44);
            this.lblNombreCompletoActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompletoActor.Name = "lblNombreCompletoActor";
            this.lblNombreCompletoActor.Size = new System.Drawing.Size(211, 17);
            this.lblNombreCompletoActor.TabIndex = 3;
            this.lblNombreCompletoActor.Text = "Nombre Completo del Actor:";
            // 
            // lblIdActor
            // 
            this.lblIdActor.AutoSize = true;
            this.lblIdActor.Location = new System.Drawing.Point(135, 17);
            this.lblIdActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdActor.Name = "lblIdActor";
            this.lblIdActor.Size = new System.Drawing.Size(98, 17);
            this.lblIdActor.TabIndex = 2;
            this.lblIdActor.Text = "ID del Actor:";
            // 
            // lblActores
            // 
            this.lblActores.AutoSize = true;
            this.lblActores.Location = new System.Drawing.Point(8, 86);
            this.lblActores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActores.Name = "lblActores";
            this.lblActores.Size = new System.Drawing.Size(254, 17);
            this.lblActores.TabIndex = 1;
            this.lblActores.Text = "Actores principales de la película:";
            // 
            // dgvActores
            // 
            this.dgvActores.AllowUserToAddRows = false;
            this.dgvActores.AllowUserToDeleteRows = false;
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.Nacionalidad});
            this.dgvActores.Location = new System.Drawing.Point(8, 108);
            this.dgvActores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.ReadOnly = true;
            this.dgvActores.RowHeadersWidth = 51;
            this.dgvActores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActores.Size = new System.Drawing.Size(1063, 224);
            this.dgvActores.TabIndex = 0;
            this.dgvActores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActores_CellFormatting);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 400;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.MinimumWidth = 6;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Width = 200;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "openFileDialog1";
            // 
            // frmGestionPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 464);
            this.Controls.Add(this.tcDatosPelicula);
            this.Controls.Add(this.lblGestionPeliculas);
            this.Controls.Add(this.tsMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionPeliculas";
            this.Text = "Formulario de Gestión de Películas";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcDatosPelicula.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.tpDatosCasting.ResumeLayout(false);
            this.tpDatosCasting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblGestionPeliculas;
        private System.Windows.Forms.TabControl tcDatosPelicula;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.TabPage tpDatosCasting;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtIDPelicula;
        private System.Windows.Forms.Button btnSubirPortada;
        private System.Windows.Forms.Label lblIDPelicula;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.CheckBox cbSubtitulada;
        private System.Windows.Forms.CheckBox cbDoblada;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnEliminarActor;
        private System.Windows.Forms.Button btnAgregarActor;
        private System.Windows.Forms.Button btnBuscarActor;
        private System.Windows.Forms.TextBox txtNombreCompletoActor;
        private System.Windows.Forms.TextBox txtIDActor;
        private System.Windows.Forms.Label lblNombreCompletoActor;
        private System.Windows.Forms.Label lblIdActor;
        private System.Windows.Forms.Label lblActores;
        private System.Windows.Forms.DataGridView dgvActores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DateTimePicker dtpDuracion;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
    }
}

