using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

using Capa_Entidad;
using Capa_Negocio;
using Clase_cbxCategorias;
using Clase_cbxProveedores;

namespace BDFerreteria
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnLateralMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show(this);
            this.Hide();
        }

        private void btnLateralClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show(this);
            this.Hide();
        }

        private void btnLateralEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.Show(this);
            this.Hide();
        }

        private void btnLateralProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show(this);
            this.Hide();
        }

        private void btnLateralProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.Show(this);
            this.Hide();
        }

        private void btnLateralPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show(this);
            this.Hide();
        }

        private void btnLateralSeguridad_Click(object sender, EventArgs e)
        {
            FormSeguridad formSeguridad = new FormSeguridad();
            formSeguridad.Show(this);
            this.Hide();
        }

        private void btnLateralVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show(this);
            this.Hide();
        }

        private void btnLateralDevoluciones_Click(object sender, EventArgs e)
        {
            FormDevoluciones formDevoluciones = new FormDevoluciones();
            formDevoluciones.Show(this);
            this.Hide();
        }
        
        ClaseCBXProveedores claseCBXProveedores = new ClaseCBXProveedores();
        ClaseCBXCategoria claseCBXCategoria = new ClaseCBXCategoria();
        
        ClaseEntidadProductos claseEntidadProductos = new ClaseEntidadProductos();
        ClaseNegocioProductos claseNegocioProductos = new ClaseNegocioProductos();

        string selectedProveedor;
        string selectedCategoria;

        private void FormProductos_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioProductos.prod_ListarProductos();
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
            //ComboBox Proveedor
            cbxProveedor.SelectedIndexChanged += cbxProveedor_SelectedIndexChanged;
            cbxProveedor.DataSource = claseCBXProveedores.CargarCBXProveedores();
            cbxProveedor.DisplayMember = "prov_Nombre";
            cbxProveedor.ValueMember = "prov_ProveedorID";
            cbxProveedor.SelectedIndex = -1;
            txtProveedorID.Text = "";
            //ComboBox Categoria
            cbxCategoriaAgregar.SelectedIndexChanged += cbxCategoriaAgregar_SelectedIndexChanged;
            cbxCategoriaAgregar.DataSource = claseCBXCategoria.CargarCBXCategoria();
            cbxCategoriaAgregar.DisplayMember = "cate_Nombre";
            cbxCategoriaAgregar.ValueMember = "cate_CategoriaID";
            cbxCategoriaAgregar.SelectedIndex = -1;
            txtCategoriaID.Text = "";
            //ComboBox Buscar por Categoria
            cbxCategoriaBuscar.SelectedIndexChanged += cbxCategoriaBuscar_SelectedIndexChanged;
            cbxCategoriaBuscar.DataSource = claseCBXCategoria.CargarCBXCategoria();
            cbxCategoriaBuscar.DisplayMember = "cate_Nombre";
            cbxCategoriaBuscar.ValueMember = "cate_CategoriaID";
            cbxCategoriaBuscar.SelectedIndex = -1;
        }

        private void cerrarFormulario(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        void prod_MantenimientoProductos(string prod_accion)
        {
            claseEntidadProductos.prod_ProductoID = txtCodigoProducto.Text;
            claseEntidadProductos.prod_Producto = txtNombreProducto.Text;
            claseEntidadProductos.prod_Precio = Convert.ToDecimal(txtPrecioProducto.Text);
            claseEntidadProductos.prod_ProveedorID = txtProveedorID.Text;
            claseEntidadProductos.prod_Proveedor = cbxProveedor.Text;
            claseEntidadProductos.prod_Marca = txtMarcaProducto.Text;
            claseEntidadProductos.prod_CategoriaID = txtCategoriaID.Text;
            claseEntidadProductos.prod_Categoria = cbxCategoriaAgregar.Text;
            claseEntidadProductos.prod_accion = prod_accion;
            string mensaje = claseNegocioProductos.prod_MantenimientoProductos(claseEntidadProductos);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtProveedorID.Text = "";
            cbxProveedor.Text = "";
            txtMarcaProducto.Text = "";
            txtCategoriaID.Text = "";
            cbxCategoriaAgregar.Text = "";
            dgvLista.DataSource = claseNegocioProductos.prod_ListarProductos();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                if (MessageBox.Show("Deseas registrar el producto " + txtNombreProducto.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    prod_MantenimientoProductos("1");
                    limpiar();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text != "")
            {
                if (MessageBox.Show("Deseas modificar el producto " + txtNombreProducto.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    prod_MantenimientoProductos("2");
                    limpiar();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar el pedido de  " + txtNombreProducto.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    prod_MantenimientoProductos("3");
                    limpiar();
                }
            }
        }

        private void btnLimpiarRegistro_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cbxCategoriaBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoriaBuscar.SelectedValue != "")
            {
                string categoriaSeleccionada = cbxCategoriaBuscar.Text;
                claseEntidadProductos.prod_Categoria = categoriaSeleccionada;
                DataTable dataTable = claseNegocioProductos.prod_BuscarProductos(claseEntidadProductos);

                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioProductos.prod_ListarProductos();
            }
        }
        
        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtCodigoProducto.Text = dgvLista[0, fila].Value.ToString();
            txtNombreProducto.Text = dgvLista[1, fila].Value.ToString();
            txtPrecioProducto.Text = dgvLista[2, fila].Value.ToString();
            txtProveedorID.Text = dgvLista[3, fila].Value.ToString();
            cbxProveedor.Text = dgvLista[4, fila].Value.ToString();
            txtMarcaProducto.Text = dgvLista[5, fila].Value.ToString();
            txtCategoriaID.Text = dgvLista[6, fila].Value.ToString();
            cbxCategoriaAgregar.Text = dgvLista[7, fila].Value.ToString();
        }

        private void cbxCategoriaAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoriaAgregar.SelectedValue != null)
            {
                selectedCategoria = cbxCategoriaAgregar.SelectedValue.ToString();
                txtCategoriaID.Text = selectedCategoria;
            }
        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProveedor.SelectedValue != null)
            {
                selectedProveedor = cbxProveedor.SelectedValue.ToString();
                txtProveedorID.Text = selectedProveedor;
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario formInventario = new FormInventario();
            formInventario.Show(this);
            this.Hide();
        }
    }
}
