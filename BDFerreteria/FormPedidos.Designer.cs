namespace BDFerreteria
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.gbxLateralMenu = new System.Windows.Forms.GroupBox();
            this.btnLateralEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnLateralVentas = new FontAwesome.Sharp.IconButton();
            this.btnLateralSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnLateralProductos = new FontAwesome.Sharp.IconButton();
            this.btnLateralProveedores = new FontAwesome.Sharp.IconButton();
            this.btnLateralPedidos = new FontAwesome.Sharp.IconButton();
            this.btnLateralClientes = new FontAwesome.Sharp.IconButton();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.gbxPedidos = new System.Windows.Forms.GroupBox();
            this.btnLimpiarRegistro = new FontAwesome.Sharp.IconButton();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadProductos = new System.Windows.Forms.TextBox();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnLateralDevoluciones = new FontAwesome.Sharp.IconButton();
            this.gbxLateralMenu.SuspendLayout();
            this.gbxPedidos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLateralMenu
            // 
            this.gbxLateralMenu.Controls.Add(this.btnLateralEmpleados);
            this.gbxLateralMenu.Controls.Add(this.btnLateralVentas);
            this.gbxLateralMenu.Controls.Add(this.btnLateralSeguridad);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProductos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProveedores);
            this.gbxLateralMenu.Controls.Add(this.btnLateralPedidos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralClientes);
            this.gbxLateralMenu.Controls.Add(this.btnLateralMenu);
            this.gbxLateralMenu.Location = new System.Drawing.Point(12, 13);
            this.gbxLateralMenu.Name = "gbxLateralMenu";
            this.gbxLateralMenu.Size = new System.Drawing.Size(180, 556);
            this.gbxLateralMenu.TabIndex = 4;
            this.gbxLateralMenu.TabStop = false;
            this.gbxLateralMenu.Text = "Opciones";
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
            // gbxPedidos
            // 
            this.gbxPedidos.Controls.Add(this.btnLimpiarRegistro);
            this.gbxPedidos.Controls.Add(this.gbxLista);
            this.gbxPedidos.Controls.Add(this.gbxBusqueda);
            this.gbxPedidos.Controls.Add(this.gbxDatos);
            this.gbxPedidos.Controls.Add(this.btnEliminarRegistro);
            this.gbxPedidos.Controls.Add(this.btnModificarRegistro);
            this.gbxPedidos.Controls.Add(this.btnAgregarRegistro);
            this.gbxPedidos.Location = new System.Drawing.Point(212, 13);
            this.gbxPedidos.Name = "gbxPedidos";
            this.gbxPedidos.Size = new System.Drawing.Size(658, 556);
            this.gbxPedidos.TabIndex = 6;
            this.gbxPedidos.TabStop = false;
            this.gbxPedidos.Text = "Pedido a Proveedor";
            // 
            // btnLimpiarRegistro
            // 
            this.btnLimpiarRegistro.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarRegistro.Location = new System.Drawing.Point(15, 493);
            this.btnLimpiarRegistro.Name = "btnLimpiarRegistro";
            this.btnLimpiarRegistro.Size = new System.Drawing.Size(131, 46);
            this.btnLimpiarRegistro.TabIndex = 8;
            this.btnLimpiarRegistro.Text = "Limpiar";
            this.btnLimpiarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarRegistro.UseVisualStyleBackColor = true;
            this.btnLimpiarRegistro.Click += new System.EventHandler(this.btnLimpiarRegistro_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(6, 270);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(646, 217);
            this.gbxLista.TabIndex = 6;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 26);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(631, 177);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.txtBusqueda);
            this.gbxBusqueda.Controls.Add(this.lblBusqueda);
            this.gbxBusqueda.Location = new System.Drawing.Point(6, 198);
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
            this.lblBusqueda.Location = new System.Drawing.Point(7, 31);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(138, 16);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Nombre del Producto:";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxProducto);
            this.gbxDatos.Controls.Add(this.txtCodigoProducto);
            this.gbxDatos.Controls.Add(this.txtCantidadProductos);
            this.gbxDatos.Controls.Add(this.txtCodigoProveedor);
            this.gbxDatos.Controls.Add(this.lblProveedor);
            this.gbxDatos.Controls.Add(this.cbxProveedor);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.txtCodigoPedido);
            this.gbxDatos.Controls.Add(this.lblFechaEntrega);
            this.gbxDatos.Controls.Add(this.lblCantidadProductos);
            this.gbxDatos.Controls.Add(this.txtFechaPedido);
            this.gbxDatos.Controls.Add(this.txtFechaEntrega);
            this.gbxDatos.Controls.Add(this.lblFechaPedido);
            this.gbxDatos.Controls.Add(this.lblCodigoPedido);
            this.gbxDatos.Location = new System.Drawing.Point(6, 21);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(646, 171);
            this.gbxDatos.TabIndex = 5;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(491, 36);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(109, 24);
            this.cbxProducto.TabIndex = 26;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Location = new System.Drawing.Point(404, 37);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(81, 22);
            this.txtCodigoProducto.TabIndex = 25;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Location = new System.Drawing.Point(122, 111);
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.Size = new System.Drawing.Size(153, 22);
            this.txtCantidadProductos.TabIndex = 24;
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Enabled = false;
            this.txtCodigoProveedor.Location = new System.Drawing.Point(122, 70);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(81, 22);
            this.txtCodigoProveedor.TabIndex = 23;
            this.txtCodigoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(24, 74);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(74, 16);
            this.lblProveedor.TabIndex = 22;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(209, 68);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(90, 24);
            this.cbxProveedor.TabIndex = 20;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Producto:";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.Location = new System.Drawing.Point(122, 33);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(177, 22);
            this.txtCodigoPedido.TabIndex = 12;
            this.txtCodigoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(319, 111);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(117, 16);
            this.lblFechaEntrega.TabIndex = 11;
            this.lblFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Location = new System.Drawing.Point(27, 111);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(64, 16);
            this.lblCantidadProductos.TabIndex = 10;
            this.lblCantidadProductos.Text = "Cantidad:";
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.Location = new System.Drawing.Point(451, 74);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(149, 22);
            this.txtFechaPedido.TabIndex = 7;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(451, 111);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(149, 22);
            this.txtFechaEntrega.TabIndex = 6;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(319, 77);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(117, 16);
            this.lblFechaPedido.TabIndex = 3;
            this.lblFechaPedido.Text = "Fecha del Pedido:";
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(24, 36);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(89, 16);
            this.lblCodigoPedido.TabIndex = 0;
            this.lblCodigoPedido.Text = "ID de Pedido:";
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
            // btnLateralDevoluciones
            // 
            this.btnLateralDevoluciones.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnLateralDevoluciones.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLateralDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLateralDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLateralDevoluciones.Location = new System.Drawing.Point(18, 506);
            this.btnLateralDevoluciones.Name = "btnLateralDevoluciones";
            this.btnLateralDevoluciones.Size = new System.Drawing.Size(162, 53);
            this.btnLateralDevoluciones.TabIndex = 11;
            this.btnLateralDevoluciones.Text = "Devoluciones";
            this.btnLateralDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateralDevoluciones.UseVisualStyleBackColor = true;
            this.btnLateralDevoluciones.Click += new System.EventHandler(this.btnLateralDevoluciones_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.btnLateralDevoluciones);
            this.Controls.Add(this.gbxPedidos);
            this.Controls.Add(this.gbxLateralMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suministro";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.gbxLateralMenu.ResumeLayout(false);
            this.gbxPedidos.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLateralMenu;
        private FontAwesome.Sharp.IconButton btnLateralEmpleados;
        private FontAwesome.Sharp.IconButton btnLateralVentas;
        private FontAwesome.Sharp.IconButton btnLateralSeguridad;
        private FontAwesome.Sharp.IconButton btnLateralPedidos;
        private FontAwesome.Sharp.IconButton btnLateralProveedores;
        private FontAwesome.Sharp.IconButton btnLateralProductos;
        private FontAwesome.Sharp.IconButton btnLateralClientes;
        private FontAwesome.Sharp.IconButton btnLateralMenu;
        private System.Windows.Forms.GroupBox gbxPedidos;
        private FontAwesome.Sharp.IconButton btnLimpiarRegistro;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.TextBox txtFechaPedido;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label lblCodigoPedido;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private FontAwesome.Sharp.IconButton btnLateralDevoluciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtCantidadProductos;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
    }
}