namespace BDFerreteria
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.gbxLateralMenu = new System.Windows.Forms.GroupBox();
            this.btnLateralProveedores = new FontAwesome.Sharp.IconButton();
            this.btnLateralVentas = new FontAwesome.Sharp.IconButton();
            this.btnLateralDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnLateralSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnLateralProductos = new FontAwesome.Sharp.IconButton();
            this.btnLateralEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnLateralPedidos = new FontAwesome.Sharp.IconButton();
            this.btnLateralClientes = new FontAwesome.Sharp.IconButton();
            this.btnLateralMenu = new FontAwesome.Sharp.IconButton();
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.pnlFormProductos = new System.Windows.Forms.Panel();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.cbxCategoriaBuscar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaBuscar = new System.Windows.Forms.Label();
            this.btnLimpiarRegistro = new FontAwesome.Sharp.IconButton();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.cbxCategoriaAgregar = new System.Windows.Forms.ComboBox();
            this.txtProveedorID = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProductos = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.gbxLateralMenu.SuspendLayout();
            this.gbxProductos.SuspendLayout();
            this.pnlFormProductos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLateralMenu
            // 
            this.gbxLateralMenu.Controls.Add(this.btnLateralProveedores);
            this.gbxLateralMenu.Controls.Add(this.btnLateralVentas);
            this.gbxLateralMenu.Controls.Add(this.btnLateralDevoluciones);
            this.gbxLateralMenu.Controls.Add(this.btnLateralSeguridad);
            this.gbxLateralMenu.Controls.Add(this.btnLateralProductos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralEmpleados);
            this.gbxLateralMenu.Controls.Add(this.btnLateralPedidos);
            this.gbxLateralMenu.Controls.Add(this.btnLateralClientes);
            this.gbxLateralMenu.Controls.Add(this.btnLateralMenu);
            this.gbxLateralMenu.Location = new System.Drawing.Point(12, 12);
            this.gbxLateralMenu.Name = "gbxLateralMenu";
            this.gbxLateralMenu.Size = new System.Drawing.Size(180, 556);
            this.gbxLateralMenu.TabIndex = 5;
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
            // gbxProductos
            // 
            this.gbxProductos.Controls.Add(this.pnlFormProductos);
            this.gbxProductos.Location = new System.Drawing.Point(199, 14);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(671, 554);
            this.gbxProductos.TabIndex = 6;
            this.gbxProductos.TabStop = false;
            this.gbxProductos.Text = "Productos";
            // 
            // pnlFormProductos
            // 
            this.pnlFormProductos.AutoScroll = true;
            this.pnlFormProductos.Controls.Add(this.btnInventario);
            this.pnlFormProductos.Controls.Add(this.btnModificarRegistro);
            this.pnlFormProductos.Controls.Add(this.btnEliminarRegistro);
            this.pnlFormProductos.Controls.Add(this.gbxLista);
            this.pnlFormProductos.Controls.Add(this.gbxBusqueda);
            this.pnlFormProductos.Controls.Add(this.btnLimpiarRegistro);
            this.pnlFormProductos.Controls.Add(this.gbxDatos);
            this.pnlFormProductos.Controls.Add(this.btnAgregarRegistro);
            this.pnlFormProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormProductos.Location = new System.Drawing.Point(3, 18);
            this.pnlFormProductos.Name = "pnlFormProductos";
            this.pnlFormProductos.Size = new System.Drawing.Size(665, 533);
            this.pnlFormProductos.TabIndex = 0;
            // 
            // btnInventario
            // 
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.btnInventario.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(526, 480);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(117, 46);
            this.btnInventario.TabIndex = 25;
            this.btnInventario.Text = "Gestion ";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnModificarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRegistro.Location = new System.Drawing.Point(249, 480);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(112, 46);
            this.btnModificarRegistro.TabIndex = 24;
            this.btnModificarRegistro.Text = "Modificar";
            this.btnModificarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(367, 480);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(117, 46);
            this.btnEliminarRegistro.TabIndex = 19;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(3, 227);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(646, 247);
            this.gbxLista.TabIndex = 21;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(9, 21);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(631, 207);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.cbxCategoriaBuscar);
            this.gbxBusqueda.Controls.Add(this.lblCategoriaBuscar);
            this.gbxBusqueda.Location = new System.Drawing.Point(3, 155);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(646, 66);
            this.gbxBusqueda.TabIndex = 22;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Filtrar";
            // 
            // cbxCategoriaBuscar
            // 
            this.cbxCategoriaBuscar.FormattingEnabled = true;
            this.cbxCategoriaBuscar.Location = new System.Drawing.Point(188, 28);
            this.cbxCategoriaBuscar.Name = "cbxCategoriaBuscar";
            this.cbxCategoriaBuscar.Size = new System.Drawing.Size(407, 24);
            this.cbxCategoriaBuscar.TabIndex = 1;
            this.cbxCategoriaBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriaBuscar_SelectedIndexChanged);
            // 
            // lblCategoriaBuscar
            // 
            this.lblCategoriaBuscar.AutoSize = true;
            this.lblCategoriaBuscar.Location = new System.Drawing.Point(6, 31);
            this.lblCategoriaBuscar.Name = "lblCategoriaBuscar";
            this.lblCategoriaBuscar.Size = new System.Drawing.Size(148, 16);
            this.lblCategoriaBuscar.TabIndex = 0;
            this.lblCategoriaBuscar.Text = "Categoria del Producto:";
            // 
            // btnLimpiarRegistro
            // 
            this.btnLimpiarRegistro.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarRegistro.Location = new System.Drawing.Point(12, 480);
            this.btnLimpiarRegistro.Name = "btnLimpiarRegistro";
            this.btnLimpiarRegistro.Size = new System.Drawing.Size(114, 46);
            this.btnLimpiarRegistro.TabIndex = 23;
            this.btnLimpiarRegistro.Text = "Limpiar";
            this.btnLimpiarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarRegistro.UseVisualStyleBackColor = true;
            this.btnLimpiarRegistro.Click += new System.EventHandler(this.btnLimpiarRegistro_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtMarcaProducto);
            this.gbxDatos.Controls.Add(this.lblMarcaProducto);
            this.gbxDatos.Controls.Add(this.txtCategoriaID);
            this.gbxDatos.Controls.Add(this.cbxCategoriaAgregar);
            this.gbxDatos.Controls.Add(this.txtProveedorID);
            this.gbxDatos.Controls.Add(this.lblProveedor);
            this.gbxDatos.Controls.Add(this.cbxProveedor);
            this.gbxDatos.Controls.Add(this.txtPrecioProducto);
            this.gbxDatos.Controls.Add(this.txtCodigoProducto);
            this.gbxDatos.Controls.Add(this.txtNombreProducto);
            this.gbxDatos.Controls.Add(this.lblPrecioProductos);
            this.gbxDatos.Controls.Add(this.lblCategoriaProducto);
            this.gbxDatos.Controls.Add(this.lblNombreProducto);
            this.gbxDatos.Controls.Add(this.lblCodigoProducto);
            this.gbxDatos.Location = new System.Drawing.Point(3, 3);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(646, 146);
            this.gbxDatos.TabIndex = 20;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(137, 118);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(140, 22);
            this.txtMarcaProducto.TabIndex = 18;
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Location = new System.Drawing.Point(24, 116);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(48, 16);
            this.lblMarcaProducto.TabIndex = 17;
            this.lblMarcaProducto.Text = "Marca:";
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Enabled = false;
            this.txtCategoriaID.Location = new System.Drawing.Point(510, 116);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(85, 22);
            this.txtCategoriaID.TabIndex = 16;
            // 
            // cbxCategoriaAgregar
            // 
            this.cbxCategoriaAgregar.FormattingEnabled = true;
            this.cbxCategoriaAgregar.Location = new System.Drawing.Point(390, 116);
            this.cbxCategoriaAgregar.Name = "cbxCategoriaAgregar";
            this.cbxCategoriaAgregar.Size = new System.Drawing.Size(104, 24);
            this.cbxCategoriaAgregar.TabIndex = 15;
            this.cbxCategoriaAgregar.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriaAgregar_SelectedIndexChanged);
            // 
            // txtProveedorID
            // 
            this.txtProveedorID.Enabled = false;
            this.txtProveedorID.Location = new System.Drawing.Point(510, 36);
            this.txtProveedorID.Name = "txtProveedorID";
            this.txtProveedorID.Size = new System.Drawing.Size(85, 22);
            this.txtProveedorID.TabIndex = 12;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(309, 41);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(71, 16);
            this.lblProveedor.TabIndex = 11;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(390, 36);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(104, 24);
            this.cbxProveedor.TabIndex = 10;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(390, 77);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(205, 22);
            this.txtPrecioProducto.TabIndex = 9;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Location = new System.Drawing.Point(137, 36);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(140, 22);
            this.txtCodigoProducto.TabIndex = 8;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(137, 77);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(140, 22);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // lblPrecioProductos
            // 
            this.lblPrecioProductos.AutoSize = true;
            this.lblPrecioProductos.Location = new System.Drawing.Point(309, 77);
            this.lblPrecioProductos.Name = "lblPrecioProductos";
            this.lblPrecioProductos.Size = new System.Drawing.Size(49, 16);
            this.lblPrecioProductos.TabIndex = 3;
            this.lblPrecioProductos.Text = "Precio:";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(309, 116);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(69, 16);
            this.lblCategoriaProducto.TabIndex = 2;
            this.lblCategoriaProducto.Text = "Categoria:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(24, 77);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(64, 16);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Producto:";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(24, 36);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(99, 16);
            this.lblCodigoProducto.TabIndex = 0;
            this.lblCodigoProducto.Text = "ID de Producto:";
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAgregarRegistro.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(132, 480);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(111, 46);
            this.btnAgregarRegistro.TabIndex = 18;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.gbxProductos);
            this.Controls.Add(this.gbxLateralMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.gbxLateralMenu.ResumeLayout(false);
            this.gbxProductos.ResumeLayout(false);
            this.pnlFormProductos.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbxProductos;
        private FontAwesome.Sharp.IconButton btnLateralDevoluciones;
        private System.Windows.Forms.Panel pnlFormProductos;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.ComboBox cbxCategoriaBuscar;
        private System.Windows.Forms.Label lblCategoriaBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarRegistro;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.ComboBox cbxCategoriaAgregar;
        private System.Windows.Forms.TextBox txtProveedorID;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioProductos;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
    }
}