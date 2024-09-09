namespace BDFerreteria
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.gbxLateralMenu = new System.Windows.Forms.GroupBox();
            this.btnLateralProveedores = new FontAwesome.Sharp.IconButton();
            this.btnLateralDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnLateralProductos = new FontAwesome.Sharp.IconButton();
            this.btnLateralSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnLateralEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnLateralVentas = new FontAwesome.Sharp.IconButton();
            this.btnLateralPedidos = new FontAwesome.Sharp.IconButton();
            this.btnLateralClientes = new FontAwesome.Sharp.IconButton();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.gbxGestionInventario = new System.Windows.Forms.GroupBox();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarRegistro = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtProductoBuscar = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtCantidadActual = new System.Windows.Forms.TextBox();
            this.lblCantidadActual = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtRevisionID = new System.Windows.Forms.TextBox();
            this.lblRevisionID = new System.Windows.Forms.Label();
            this.gbxLateralMenu.SuspendLayout();
            this.gbxGestionInventario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLateralMenu
            // 
            this.gbxLateralMenu.Controls.Add(this.btnLateralProveedores);
            this.gbxLateralMenu.Controls.Add(this.btnLateralDevoluciones);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProductos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralSeguridad);
            this.gbxLateralMenu.Controls.Add(this.btnLateralEmpleados);
            this.gbxLateralMenu.Controls.Add(this.btnLateralVentas);
            this.gbxLateralMenu.Controls.Add(this.btnLateralPedidos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralClientes);
            this.gbxLateralMenu.Controls.Add(this.btnLateralMenu);
            this.gbxLateralMenu.Location = new System.Drawing.Point(12, 12);
            this.gbxLateralMenu.Name = "gbxLateralMenu";
            this.gbxLateralMenu.Size = new System.Drawing.Size(180, 556);
            this.gbxLateralMenu.TabIndex = 6;
            this.gbxLateralMenu.TabStop = false;
            this.gbxLateralMenu.Text = "Opciones";
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
            // btnLateralDevoluciones
            // 
            this.btnLateralDevoluciones.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnLateralDevoluciones.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralDevoluciones.Location = new System.Drawing.Point(6, 493);
            this.btnLateralDevoluciones.Name = "btnLateralDevoluciones";
            this.btnLateralDevoluciones.Size = new System.Drawing.Size(162, 53);
            this.btnLateralDevoluciones.TabIndex = 10;
            this.btnLateralDevoluciones.Text = "Devoluciones";
            this.btnLateralDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralDevoluciones.UseVisualStyleBackColor = true;
            this.btnLateralDevoluciones.Click += new System.EventHandler(this.btnLateralDevoluciones_Click);
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
            // gbxGestionInventario
            // 
            this.gbxGestionInventario.Controls.Add(this.btnEliminarRegistro);
            this.gbxGestionInventario.Controls.Add(this.btnModificarRegistro);
            this.gbxGestionInventario.Controls.Add(this.btnAgregarRegistro);
            this.gbxGestionInventario.Controls.Add(this.btnLimpiarRegistro);
            this.gbxGestionInventario.Controls.Add(this.groupBox1);
            this.gbxGestionInventario.Controls.Add(this.gbxBusqueda);
            this.gbxGestionInventario.Controls.Add(this.gbxDatos);
            this.gbxGestionInventario.Location = new System.Drawing.Point(209, 13);
            this.gbxGestionInventario.Name = "gbxGestionInventario";
            this.gbxGestionInventario.Size = new System.Drawing.Size(661, 555);
            this.gbxGestionInventario.TabIndex = 7;
            this.gbxGestionInventario.TabStop = false;
            this.gbxGestionInventario.Text = "Gestion de Inventario";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(418, 495);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnEliminarRegistro.TabIndex = 13;
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
            this.btnModificarRegistro.Location = new System.Drawing.Point(281, 495);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnModificarRegistro.TabIndex = 12;
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
            this.btnAgregarRegistro.Location = new System.Drawing.Point(144, 495);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnAgregarRegistro.TabIndex = 11;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnLimpiarRegistro
            // 
            this.btnLimpiarRegistro.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarRegistro.Location = new System.Drawing.Point(7, 495);
            this.btnLimpiarRegistro.Name = "btnLimpiarRegistro";
            this.btnLimpiarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnLimpiarRegistro.TabIndex = 10;
            this.btnLimpiarRegistro.Text = "Limpiar";
            this.btnLimpiarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarRegistro.UseVisualStyleBackColor = true;
            this.btnLimpiarRegistro.Click += new System.EventHandler(this.btnLimpiarRegistro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLista);
            this.groupBox1.Location = new System.Drawing.Point(7, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(24, 21);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(604, 157);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.lblBusqueda);
            this.gbxBusqueda.Controls.Add(this.txtProductoBuscar);
            this.gbxBusqueda.Location = new System.Drawing.Point(7, 209);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(648, 79);
            this.gbxBusqueda.TabIndex = 1;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Buscar Registros";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(21, 40);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(148, 16);
            this.lblBusqueda.TabIndex = 13;
            this.lblBusqueda.Text = "Busqueda de Producto:";
            // 
            // txtProductoBuscar
            // 
            this.txtProductoBuscar.Location = new System.Drawing.Point(205, 40);
            this.txtProductoBuscar.Name = "txtProductoBuscar";
            this.txtProductoBuscar.Size = new System.Drawing.Size(423, 22);
            this.txtProductoBuscar.TabIndex = 13;
            this.txtProductoBuscar.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxEstado);
            this.gbxDatos.Controls.Add(this.txtNotas);
            this.gbxDatos.Controls.Add(this.lblNotas);
            this.gbxDatos.Controls.Add(this.txtUbicacion);
            this.gbxDatos.Controls.Add(this.lblUbicacion);
            this.gbxDatos.Controls.Add(this.txtCantidadActual);
            this.gbxDatos.Controls.Add(this.lblCantidadActual);
            this.gbxDatos.Controls.Add(this.cbxProducto);
            this.gbxDatos.Controls.Add(this.txtProductoID);
            this.gbxDatos.Controls.Add(this.lblEstado);
            this.gbxDatos.Controls.Add(this.lblProducto);
            this.gbxDatos.Controls.Add(this.txtRevisionID);
            this.gbxDatos.Controls.Add(this.lblRevisionID);
            this.gbxDatos.Location = new System.Drawing.Point(7, 22);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(648, 180);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(133, 119);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(183, 24);
            this.cbxEstado.TabIndex = 14;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(420, 113);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(208, 22);
            this.txtNotas.TabIndex = 12;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(342, 119);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(46, 16);
            this.lblNotas.TabIndex = 11;
            this.lblNotas.Text = "Notas:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(446, 72);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(182, 22);
            this.txtUbicacion.TabIndex = 10;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(342, 78);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(71, 16);
            this.lblUbicacion.TabIndex = 9;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // txtCantidadActual
            // 
            this.txtCantidadActual.Location = new System.Drawing.Point(471, 35);
            this.txtCantidadActual.Name = "txtCantidadActual";
            this.txtCantidadActual.Size = new System.Drawing.Size(157, 22);
            this.txtCantidadActual.TabIndex = 8;
            // 
            // lblCantidadActual
            // 
            this.lblCantidadActual.AutoSize = true;
            this.lblCantidadActual.Location = new System.Drawing.Point(342, 35);
            this.lblCantidadActual.Name = "lblCantidadActual";
            this.lblCantidadActual.Size = new System.Drawing.Size(104, 16);
            this.lblCantidadActual.TabIndex = 7;
            this.lblCantidadActual.Text = "Cantidad Actual:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(133, 75);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(99, 24);
            this.cbxProducto.TabIndex = 6;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // txtProductoID
            // 
            this.txtProductoID.Enabled = false;
            this.txtProductoID.Location = new System.Drawing.Point(238, 75);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(78, 22);
            this.txtProductoID.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(21, 116);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(21, 75);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // txtRevisionID
            // 
            this.txtRevisionID.Enabled = false;
            this.txtRevisionID.Location = new System.Drawing.Point(159, 35);
            this.txtRevisionID.Name = "txtRevisionID";
            this.txtRevisionID.Size = new System.Drawing.Size(157, 22);
            this.txtRevisionID.TabIndex = 1;
            // 
            // lblRevisionID
            // 
            this.lblRevisionID.AutoSize = true;
            this.lblRevisionID.Location = new System.Drawing.Point(21, 35);
            this.lblRevisionID.Name = "lblRevisionID";
            this.lblRevisionID.Size = new System.Drawing.Size(98, 16);
            this.lblRevisionID.TabIndex = 0;
            this.lblRevisionID.Text = "ID de Revision:";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.gbxGestionInventario);
            this.Controls.Add(this.gbxLateralMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.gbxLateralMenu.ResumeLayout(false);
            this.gbxGestionInventario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLateralMenu;
        private FontAwesome.Sharp.IconButton btnLateralProveedores;
        private FontAwesome.Sharp.IconButton btnLateralDevoluciones;
        private FontAwesome.Sharp.IconButton btnLateralSeguridad;
        private FontAwesome.Sharp.IconButton btnLateralProductos;
        private FontAwesome.Sharp.IconButton btnLateralEmpleados;
        private FontAwesome.Sharp.IconButton btnLateralVentas;
        private FontAwesome.Sharp.IconButton btnLateralPedidos;
        private FontAwesome.Sharp.IconButton btnLateralClientes;
        private FontAwesome.Sharp.IconButton btnLateralMenu;
        private System.Windows.Forms.GroupBox gbxGestionInventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtRevisionID;
        private System.Windows.Forms.Label lblRevisionID;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtCantidadActual;
        private System.Windows.Forms.Label lblCantidadActual;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtProductoBuscar;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotas;
        private FontAwesome.Sharp.IconButton btnLimpiarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private System.Windows.Forms.ComboBox cbxEstado;
    }
}