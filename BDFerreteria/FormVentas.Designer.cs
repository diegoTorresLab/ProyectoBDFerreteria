namespace BDFerreteria
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.gbxLateralMenu = new System.Windows.Forms.GroupBox();
            this.btnLateralDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnLateralProveedores = new FontAwesome.Sharp.IconButton();
            this.btnLateralProductos = new FontAwesome.Sharp.IconButton();
            this.btnLateralSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnLateralVentas = new FontAwesome.Sharp.IconButton();
            this.btnLateralPedidos = new FontAwesome.Sharp.IconButton();
            this.btnLateralEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnLateralClientes = new FontAwesome.Sharp.IconButton();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.gbxVentas = new System.Windows.Forms.GroupBox();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarRegistro = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtEmpleadoBuscar = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxEmpleadoApellido = new System.Windows.Forms.ComboBox();
            this.cbxClienteApellidos = new System.Windows.Forms.ComboBox();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtVentasID = new System.Windows.Forms.TextBox();
            this.lblVentasID = new System.Windows.Forms.Label();
            this.gbxLateralMenu.SuspendLayout();
            this.gbxVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLateralMenu
            // 
            this.gbxLateralMenu.Controls.Add(this.btnEliminarRegistro);
            this.gbxLateralMenu.Controls.Add(this.btnLateralDevoluciones);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProveedores);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProductos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralSeguridad);
            this.gbxLateralMenu.Controls.Add(this.btnLateralVentas);
            this.gbxLateralMenu.Controls.Add(this.btnLateralPedidos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralEmpleados);
            this.gbxLateralMenu.Controls.Add(this.btnLateralClientes);
            this.gbxLateralMenu.Controls.Add(this.btnLateralMenu);
            this.gbxLateralMenu.Location = new System.Drawing.Point(12, 8);
            this.gbxLateralMenu.Name = "gbxLateralMenu";
            this.gbxLateralMenu.Size = new System.Drawing.Size(180, 555);
            this.gbxLateralMenu.TabIndex = 3;
            this.gbxLateralMenu.TabStop = false;
            this.gbxLateralMenu.Text = "Opciones";
            this.gbxLateralMenu.UseWaitCursor = true;
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
            this.btnLateralDevoluciones.TabIndex = 11;
            this.btnLateralDevoluciones.Text = "Devoluciones";
            this.btnLateralDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralDevoluciones.UseVisualStyleBackColor = true;
            this.btnLateralDevoluciones.UseWaitCursor = true;
            this.btnLateralDevoluciones.Click += new System.EventHandler(this.btnLateralDevoluciones_Click);
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
            this.btnLateralProveedores.UseWaitCursor = true;
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
            this.btnLateralProductos.UseWaitCursor = true;
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
            this.btnLateralSeguridad.TabIndex = 9;
            this.btnLateralSeguridad.Text = "Seguridad";
            this.btnLateralSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralSeguridad.UseVisualStyleBackColor = true;
            this.btnLateralSeguridad.UseWaitCursor = true;
            this.btnLateralSeguridad.Click += new System.EventHandler(this.btnLateralSeguridad_Click);
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
            this.btnLateralVentas.UseWaitCursor = true;
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
            this.btnLateralPedidos.UseWaitCursor = true;
            this.btnLateralPedidos.Click += new System.EventHandler(this.btnLateralPedidos_Click);
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
            this.btnLateralEmpleados.TabIndex = 3;
            this.btnLateralEmpleados.Text = "Empleados";
            this.btnLateralEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralEmpleados.UseVisualStyleBackColor = true;
            this.btnLateralEmpleados.UseWaitCursor = true;
            this.btnLateralEmpleados.Click += new System.EventHandler(this.btnLateralEmpleados_Click);
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
            this.btnLateralClientes.UseWaitCursor = true;
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
            this.btnLateralMenu.UseWaitCursor = true;
            this.btnLateralMenu.Click += new System.EventHandler(this.btnLateralMenu_Click);
            // 
            // gbxVentas
            // 
            this.gbxVentas.Controls.Add(this.btnModificarRegistro);
            this.gbxVentas.Controls.Add(this.btnAgregarRegistro);
            this.gbxVentas.Controls.Add(this.btnLimpiarRegistro);
            this.gbxVentas.Controls.Add(this.groupBox1);
            this.gbxVentas.Controls.Add(this.gbxBusqueda);
            this.gbxVentas.Controls.Add(this.gbxDatos);
            this.gbxVentas.Location = new System.Drawing.Point(198, 12);
            this.gbxVentas.Name = "gbxVentas";
            this.gbxVentas.Size = new System.Drawing.Size(661, 555);
            this.gbxVentas.TabIndex = 8;
            this.gbxVentas.TabStop = false;
            this.gbxVentas.Text = "Ventas";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(0, 4);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(10, 10);
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
            this.btnAgregarRegistro.Location = new System.Drawing.Point(144, 496);
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
            this.gbxBusqueda.Controls.Add(this.txtEmpleadoBuscar);
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
            this.lblBusqueda.Size = new System.Drawing.Size(164, 16);
            this.lblBusqueda.TabIndex = 13;
            this.lblBusqueda.Text = "Busqueda de Empleados:";
            // 
            // txtEmpleadoBuscar
            // 
            this.txtEmpleadoBuscar.Location = new System.Drawing.Point(205, 40);
            this.txtEmpleadoBuscar.Name = "txtEmpleadoBuscar";
            this.txtEmpleadoBuscar.Size = new System.Drawing.Size(423, 22);
            this.txtEmpleadoBuscar.TabIndex = 13;
            this.txtEmpleadoBuscar.TextChanged += new System.EventHandler(this.txtEmpleadoBuscar_TextChanged);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxEmpleadoApellido);
            this.gbxDatos.Controls.Add(this.cbxClienteApellidos);
            this.gbxDatos.Controls.Add(this.txtTotalVenta);
            this.gbxDatos.Controls.Add(this.lblTotalVenta);
            this.gbxDatos.Controls.Add(this.txtFechaVenta);
            this.gbxDatos.Controls.Add(this.lblFechaVenta);
            this.gbxDatos.Controls.Add(this.txtEmpleadoID);
            this.gbxDatos.Controls.Add(this.txtClienteID);
            this.gbxDatos.Controls.Add(this.lblEmpleado);
            this.gbxDatos.Controls.Add(this.lblClientes);
            this.gbxDatos.Controls.Add(this.txtVentasID);
            this.gbxDatos.Controls.Add(this.lblVentasID);
            this.gbxDatos.Location = new System.Drawing.Point(7, 22);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(648, 180);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // cbxEmpleadoApellido
            // 
            this.cbxEmpleadoApellido.FormattingEnabled = true;
            this.cbxEmpleadoApellido.Location = new System.Drawing.Point(231, 119);
            this.cbxEmpleadoApellido.Name = "cbxEmpleadoApellido";
            this.cbxEmpleadoApellido.Size = new System.Drawing.Size(121, 24);
            this.cbxEmpleadoApellido.TabIndex = 23;
            this.cbxEmpleadoApellido.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleadoApellido_SelectedIndexChanged);
            // 
            // cbxClienteApellidos
            // 
            this.cbxClienteApellidos.FormattingEnabled = true;
            this.cbxClienteApellidos.Location = new System.Drawing.Point(231, 75);
            this.cbxClienteApellidos.Name = "cbxClienteApellidos";
            this.cbxClienteApellidos.Size = new System.Drawing.Size(121, 24);
            this.cbxClienteApellidos.TabIndex = 22;
            this.cbxClienteApellidos.SelectedIndexChanged += new System.EventHandler(this.cbxClienteApellidos_SelectedIndexChanged);
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(471, 75);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(109, 22);
            this.txtTotalVenta.TabIndex = 21;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(376, 75);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(41, 16);
            this.lblTotalVenta.TabIndex = 20;
            this.lblTotalVenta.Text = "Total:";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new System.Drawing.Point(471, 35);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(157, 22);
            this.txtFechaVenta.TabIndex = 19;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(342, 38);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(105, 16);
            this.lblFechaVenta.TabIndex = 18;
            this.lblFechaVenta.Text = "Fecha de Venta:";
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.Enabled = false;
            this.txtEmpleadoID.Location = new System.Drawing.Point(102, 121);
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.Size = new System.Drawing.Size(104, 22);
            this.txtEmpleadoID.TabIndex = 16;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Enabled = false;
            this.txtClienteID.Location = new System.Drawing.Point(102, 75);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(104, 22);
            this.txtClienteID.TabIndex = 15;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(21, 122);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 16);
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(21, 78);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(58, 16);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes:";
            // 
            // txtVentasID
            // 
            this.txtVentasID.Enabled = false;
            this.txtVentasID.Location = new System.Drawing.Point(137, 35);
            this.txtVentasID.Name = "txtVentasID";
            this.txtVentasID.Size = new System.Drawing.Size(157, 22);
            this.txtVentasID.TabIndex = 1;
            // 
            // lblVentasID
            // 
            this.lblVentasID.AutoSize = true;
            this.lblVentasID.Location = new System.Drawing.Point(21, 35);
            this.lblVentasID.Name = "lblVentasID";
            this.lblVentasID.Size = new System.Drawing.Size(87, 16);
            this.lblVentasID.TabIndex = 0;
            this.lblVentasID.Text = "ID de Ventas:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.gbxVentas);
            this.Controls.Add(this.gbxLateralMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.gbxLateralMenu.ResumeLayout(false);
            this.gbxVentas.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnLateralSeguridad;
        private FontAwesome.Sharp.IconButton btnLateralVentas;
        private FontAwesome.Sharp.IconButton btnLateralPedidos;
        private FontAwesome.Sharp.IconButton btnLateralProveedores;
        private FontAwesome.Sharp.IconButton btnLateralProductos;
        private FontAwesome.Sharp.IconButton btnLateralEmpleados;
        private FontAwesome.Sharp.IconButton btnLateralClientes;
        private FontAwesome.Sharp.IconButton btnLateralMenu;
        private FontAwesome.Sharp.IconButton btnLateralDevoluciones;
        private System.Windows.Forms.GroupBox gbxVentas;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private FontAwesome.Sharp.IconButton btnLimpiarRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtEmpleadoBuscar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtVentasID;
        private System.Windows.Forms.Label lblVentasID;
        private System.Windows.Forms.TextBox txtEmpleadoID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.ComboBox cbxEmpleadoApellido;
        private System.Windows.Forms.ComboBox cbxClienteApellidos;
    }
}