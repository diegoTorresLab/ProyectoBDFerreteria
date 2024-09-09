namespace BDFerreteria
{
    partial class FormEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.gbxEmpleados = new System.Windows.Forms.GroupBox();
            this.btnLimpiarRegistro = new FontAwesome.Sharp.IconButton();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreoEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidosEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.lblApellidosEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.gbxLateralMenu = new System.Windows.Forms.GroupBox();
            this.btnLateralDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnLateralEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnLateralVentas = new FontAwesome.Sharp.IconButton();
            this.btnLateralSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnLateralPedidos = new FontAwesome.Sharp.IconButton();
            this.btnLateralProveedores = new FontAwesome.Sharp.IconButton();
            this.btnLateralProductos = new FontAwesome.Sharp.IconButton();
            this.btnLateralClientes = new FontAwesome.Sharp.IconButton();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.gbxEmpleados.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxLateralMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEmpleados
            // 
            this.gbxEmpleados.Controls.Add(this.btnLimpiarRegistro);
            this.gbxEmpleados.Controls.Add(this.gbxLista);
            this.gbxEmpleados.Controls.Add(this.gbxBusqueda);
            this.gbxEmpleados.Controls.Add(this.gbxDatos);
            this.gbxEmpleados.Controls.Add(this.btnEliminarRegistro);
            this.gbxEmpleados.Controls.Add(this.btnModificarRegistro);
            this.gbxEmpleados.Controls.Add(this.btnAgregarRegistro);
            this.gbxEmpleados.Location = new System.Drawing.Point(212, 12);
            this.gbxEmpleados.Name = "gbxEmpleados";
            this.gbxEmpleados.Size = new System.Drawing.Size(658, 555);
            this.gbxEmpleados.TabIndex = 4;
            this.gbxEmpleados.TabStop = false;
            this.gbxEmpleados.Text = "Empleados";
            // 
            // btnLimpiarRegistro
            // 
            this.btnLimpiarRegistro.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarRegistro.Location = new System.Drawing.Point(15, 496);
            this.btnLimpiarRegistro.Name = "btnLimpiarRegistro";
            this.btnLimpiarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnLimpiarRegistro.TabIndex = 10;
            this.btnLimpiarRegistro.Text = "Limpiar";
            this.btnLimpiarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarRegistro.UseVisualStyleBackColor = true;
            this.btnLimpiarRegistro.Click += new System.EventHandler(this.btnLimpiarRegistro_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(6, 245);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(646, 245);
            this.gbxLista.TabIndex = 6;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(9, 22);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(631, 203);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.txtBusqueda);
            this.gbxBusqueda.Controls.Add(this.lblBusqueda);
            this.gbxBusqueda.Location = new System.Drawing.Point(6, 173);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(646, 66);
            this.gbxBusqueda.TabIndex = 6;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(185, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(455, 22);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(6, 31);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(147, 16);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Nombre del Empleado:";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.txtCorreoEmpleado);
            this.gbxDatos.Controls.Add(this.txtApellidosEmpleado);
            this.gbxDatos.Controls.Add(this.txtTelefonoEmpleado);
            this.gbxDatos.Controls.Add(this.txtNombreEmpleado);
            this.gbxDatos.Controls.Add(this.txtCodigoEmpleado);
            this.gbxDatos.Controls.Add(this.lblTelefonoEmpleado);
            this.gbxDatos.Controls.Add(this.lblApellidosEmpleado);
            this.gbxDatos.Controls.Add(this.lblNombreEmpleado);
            this.gbxDatos.Controls.Add(this.lblCodigoEmpleado);
            this.gbxDatos.Location = new System.Drawing.Point(6, 21);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(646, 146);
            this.gbxDatos.TabIndex = 5;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-mail:";
            // 
            // txtCorreoEmpleado
            // 
            this.txtCorreoEmpleado.Location = new System.Drawing.Point(94, 118);
            this.txtCorreoEmpleado.Name = "txtCorreoEmpleado";
            this.txtCorreoEmpleado.Size = new System.Drawing.Size(183, 22);
            this.txtCorreoEmpleado.TabIndex = 9;
            // 
            // txtApellidosEmpleado
            // 
            this.txtApellidosEmpleado.Location = new System.Drawing.Point(374, 77);
            this.txtApellidosEmpleado.Name = "txtApellidosEmpleado";
            this.txtApellidosEmpleado.Size = new System.Drawing.Size(228, 22);
            this.txtApellidosEmpleado.TabIndex = 7;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(374, 112);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(185, 22);
            this.txtTelefonoEmpleado.TabIndex = 6;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(94, 77);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(185, 22);
            this.txtNombreEmpleado.TabIndex = 5;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Enabled = false;
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(146, 36);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(131, 22);
            this.txtCodigoEmpleado.TabIndex = 4;
            this.txtCodigoEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(301, 121);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoEmpleado.TabIndex = 3;
            this.lblTelefonoEmpleado.Text = "Telefono:";
            // 
            // lblApellidosEmpleado
            // 
            this.lblApellidosEmpleado.AutoSize = true;
            this.lblApellidosEmpleado.Location = new System.Drawing.Point(301, 77);
            this.lblApellidosEmpleado.Name = "lblApellidosEmpleado";
            this.lblApellidosEmpleado.Size = new System.Drawing.Size(67, 16);
            this.lblApellidosEmpleado.TabIndex = 2;
            this.lblApellidosEmpleado.Text = "Apellidos:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(24, 77);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEmpleado.TabIndex = 1;
            this.lblNombreEmpleado.Text = "Nombre:";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(24, 36);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(108, 16);
            this.lblCodigoEmpleado.TabIndex = 0;
            this.lblCodigoEmpleado.Text = "ID de Empleado:";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(426, 493);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnEliminarRegistro.TabIndex = 4;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnModificarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRegistro.Location = new System.Drawing.Point(289, 493);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnModificarRegistro.TabIndex = 3;
            this.btnModificarRegistro.Text = "Modificar";
            this.btnModificarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAgregarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(152, 493);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnAgregarRegistro.TabIndex = 2;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // gbxLateralMenu
            // 
            this.gbxLateralMenu.Controls.Add(this.btnLateralDevoluciones);
            this.gbxLateralMenu.Controls.Add(this.btnLateralEmpleados);
            this.gbxLateralMenu.Controls.Add(this.btnLateralVentas);
            this.gbxLateralMenu.Controls.Add(this.btnLateralSeguridad);
            this.gbxLateralMenu.Controls.Add(this.btnLateralPedidos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProveedores);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProductos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralClientes);
            this.gbxLateralMenu.Controls.Add(this.btnLateralMenu);
            this.gbxLateralMenu.Location = new System.Drawing.Point(13, 12);
            this.gbxLateralMenu.Name = "gbxLateralMenu";
            this.gbxLateralMenu.Size = new System.Drawing.Size(180, 555);
            this.gbxLateralMenu.TabIndex = 3;
            this.gbxLateralMenu.TabStop = false;
            this.gbxLateralMenu.Text = "Opciones";
            // 
            // btnLateralDevoluciones
            // 
            this.btnLateralDevoluciones.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnLateralDevoluciones.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralDevoluciones.Location = new System.Drawing.Point(6, 493);
            this.btnLateralDevoluciones.Name = "btnLateralDevoluciones";
            this.btnLateralDevoluciones.Size = new System.Drawing.Size(162, 53);
            this.btnLateralDevoluciones.TabIndex = 12;
            this.btnLateralDevoluciones.Text = "Devoluciones";
            this.btnLateralDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralDevoluciones.UseVisualStyleBackColor = true;
            this.btnLateralDevoluciones.Click += new System.EventHandler(this.btnLateralDevoluciones_Click);
            // 
            // btnLateralEmpleados
            // 
            this.btnLateralEmpleados.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnLateralEmpleados.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralEmpleados.Location = new System.Drawing.Point(6, 139);
            this.btnLateralEmpleados.Name = "btnLateralEmpleados";
            this.btnLateralEmpleados.Size = new System.Drawing.Size(162, 53);
            this.btnLateralEmpleados.TabIndex = 9;
            this.btnLateralEmpleados.Text = "Empleados";
            this.btnLateralEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralEmpleados.UseVisualStyleBackColor = true;
            this.btnLateralEmpleados.Click += new System.EventHandler(this.btnLateralEmpleados_Click);
            // 
            // btnLateralVentas
            // 
            this.btnLateralVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnLateralVentas.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralVentas.Location = new System.Drawing.Point(6, 198);
            this.btnLateralVentas.Name = "btnLateralVentas";
            this.btnLateralVentas.Size = new System.Drawing.Size(162, 53);
            this.btnLateralVentas.TabIndex = 8;
            this.btnLateralVentas.Text = "Ventas";
            this.btnLateralVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralVentas.UseVisualStyleBackColor = true;
            this.btnLateralVentas.Click += new System.EventHandler(this.btnLateralVentas_Click);
            // 
            // btnLateralSeguridad
            // 
            this.btnLateralSeguridad.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnLateralSeguridad.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralSeguridad.Location = new System.Drawing.Point(6, 316);
            this.btnLateralSeguridad.Name = "btnLateralSeguridad";
            this.btnLateralSeguridad.Size = new System.Drawing.Size(162, 53);
            this.btnLateralSeguridad.TabIndex = 7;
            this.btnLateralSeguridad.Text = "Seguridad";
            this.btnLateralSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralSeguridad.UseVisualStyleBackColor = true;
            this.btnLateralSeguridad.Click += new System.EventHandler(this.btnLateralSeguridad_Click);
            // 
            // btnLateralPedidos
            // 
            this.btnLateralPedidos.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnLateralPedidos.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralPedidos.Location = new System.Drawing.Point(6, 434);
            this.btnLateralPedidos.Name = "btnLateralPedidos";
            this.btnLateralPedidos.Size = new System.Drawing.Size(162, 53);
            this.btnLateralPedidos.TabIndex = 6;
            this.btnLateralPedidos.Text = "Suministro";
            this.btnLateralPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralPedidos.UseVisualStyleBackColor = true;
            this.btnLateralPedidos.Click += new System.EventHandler(this.btnLateralPedidos_Click);
            // 
            // btnLateralProveedores
            // 
            this.btnLateralProveedores.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.btnLateralProveedores.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralProveedores.Location = new System.Drawing.Point(6, 375);
            this.btnLateralProveedores.Name = "btnLateralProveedores";
            this.btnLateralProveedores.Size = new System.Drawing.Size(162, 53);
            this.btnLateralProveedores.TabIndex = 5;
            this.btnLateralProveedores.Text = "Proveedores";
            this.btnLateralProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralProveedores.UseVisualStyleBackColor = true;
            this.btnLateralProveedores.Click += new System.EventHandler(this.btnLateralProveedores_Click);
            // 
            // btnLateralProductos
            // 
            this.btnLateralProductos.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.btnLateralProductos.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralProductos.Location = new System.Drawing.Point(6, 257);
            this.btnLateralProductos.Name = "btnLateralProductos";
            this.btnLateralProductos.Size = new System.Drawing.Size(162, 53);
            this.btnLateralProductos.TabIndex = 4;
            this.btnLateralProductos.Text = "Productos";
            this.btnLateralProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralProductos.UseVisualStyleBackColor = true;
            this.btnLateralProductos.Click += new System.EventHandler(this.btnLateralProductos_Click);
            // 
            // btnLateralClientes
            // 
            this.btnLateralClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btnLateralClientes.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralClientes.Location = new System.Drawing.Point(6, 80);
            this.btnLateralClientes.Name = "btnLateralClientes";
            this.btnLateralClientes.Size = new System.Drawing.Size(162, 53);
            this.btnLateralClientes.TabIndex = 2;
            this.btnLateralClientes.Text = "Clientes";
            this.btnLateralClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralClientes.UseVisualStyleBackColor = true;
            this.btnLateralClientes.Click += new System.EventHandler(this.btnLateralClientes_Click);
            // 
            // btnLateralMenu
            // 
            this.btnLateralMenu.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnLateralMenu.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralMenu.Location = new System.Drawing.Point(6, 21);
            this.btnLateralMenu.Name = "btnLateralMenu";
            this.btnLateralMenu.Size = new System.Drawing.Size(162, 53);
            this.btnLateralMenu.TabIndex = 1;
            this.btnLateralMenu.Text = "Menu Principal";
            this.btnLateralMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralMenu.UseVisualStyleBackColor = true;
            this.btnLateralMenu.Click += new System.EventHandler(this.btnLateralMenu_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.gbxEmpleados);
            this.Controls.Add(this.gbxLateralMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.gbxEmpleados.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLateralMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmpleados;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtApellidosEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblApellidosEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private System.Windows.Forms.GroupBox gbxLateralMenu;
        private FontAwesome.Sharp.IconButton btnLateralVentas;
        private FontAwesome.Sharp.IconButton btnLateralSeguridad;
        private FontAwesome.Sharp.IconButton btnLateralPedidos;
        private FontAwesome.Sharp.IconButton btnLateralProveedores;
        private FontAwesome.Sharp.IconButton btnLateralProductos;
        private FontAwesome.Sharp.IconButton btnLateralClientes;
        private FontAwesome.Sharp.IconButton btnLateralMenu;
        private System.Windows.Forms.TextBox txtCorreoEmpleado;
        private FontAwesome.Sharp.IconButton btnLateralEmpleados;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLimpiarRegistro;
        private FontAwesome.Sharp.IconButton btnLateralDevoluciones;
    }
}