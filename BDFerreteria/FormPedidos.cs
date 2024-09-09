using Capa_Entidad;
using Capa_Negocio;
using Clase_cbxClientes;
using Clase_cbxProductos;
using Clase_cbxProveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFerreteria
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
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
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show(this);
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
        ClaseCBXProductos claseCBXProductos = new ClaseCBXProductos();

        ClaseEntidadPedidos claseEntidadPedidos = new ClaseEntidadPedidos();
        ClaseNegocioPedidos claseNegocioPedidos = new ClaseNegocioPedidos();

        string selectedProveedor;
        string selectedProducto;
        private void FormPedidos_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioPedidos.pedi_ListarPedidos();
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
            //Combobox Proveedores
            cbxProveedor.SelectedIndexChanged += cbxProveedor_SelectedIndexChanged;
            cbxProveedor.DataSource = claseCBXProveedores.CargarCBXProveedores();
            cbxProveedor.DisplayMember = "prov_Nombre";
            cbxProveedor.ValueMember = "prov_ProveedorID";
            cbxProveedor.SelectedIndex = -1;
            txtCodigoProveedor.Text = "";
            //Combobox Productos
            cbxProducto.SelectedIndexChanged += cbxProducto_SelectedIndexChanged;
            cbxProducto.DataSource = claseCBXProductos.CargarCBXProductos();
            cbxProducto.DisplayMember = "prod_Producto";
            cbxProducto.ValueMember = "prod_ProductoID";
            cbxProducto.SelectedIndex = -1;
            txtCodigoProveedor.Text = "";
        }
        private void cerrarFormulario(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        void pedi_MantenimientoPedido(string pedi_accion)
        {
            claseEntidadPedidos.pedi_PedidoID = txtCodigoPedido.Text;
            claseEntidadPedidos.pedi_ProveedorID = txtCodigoProveedor.Text;
            claseEntidadPedidos.pedi_Proveedor = cbxProveedor.Text;
            claseEntidadPedidos.pedi_ProductoID = txtCodigoProducto.Text;
            claseEntidadPedidos.pedi_Producto = cbxProducto.Text;
            claseEntidadPedidos.pedi_FechaPedido = txtFechaPedido.Text;
            claseEntidadPedidos.pedi_FechaEntrega = txtFechaEntrega.Text;
            claseEntidadPedidos.pedi_Cantidad = Convert.ToInt32(txtCantidadProductos.Text);
            claseEntidadPedidos.pedi_accion = pedi_accion;
            string mensaje = claseNegocioPedidos.pedi_MantenimientoPedido(claseEntidadPedidos);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigoPedido.Text = "";
            txtCodigoProveedor.Text = "";
            cbxProveedor.Text = "";
            txtCodigoProducto.Text = "";
            cbxProducto.Text = "";
            txtFechaPedido.Text = "";
            txtFechaEntrega.Text = "";
            txtCantidadProductos.Text = "";
            dgvLista.DataSource = claseNegocioPedidos.pedi_ListarPedidos();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoPedido.Text == "")
            {
                if (MessageBox.Show("Deseas registrar el pedido de " + txtCodigoPedido.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    pedi_MantenimientoPedido("1");
                    limpiar();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoPedido.Text != "")
            {
                if (MessageBox.Show("Deseas modificar el pedido de " + txtCodigoPedido.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    pedi_MantenimientoPedido("2");
                    limpiar();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoPedido.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar el pedido de  " + txtCodigoPedido.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    pedi_MantenimientoPedido("3");
                    limpiar();
                }
            }
        }

        private void btnLimpiarRegistro_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                claseEntidadPedidos.pedi_Producto = txtBusqueda.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocioPedidos.pedi_BuscarPedidos(claseEntidadPedidos);
                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioPedidos.pedi_ListarPedidos();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtCodigoPedido.Text = dgvLista[0, fila].Value.ToString();
            txtCodigoProveedor.Text = dgvLista[1, fila].Value.ToString();
            cbxProveedor.Text = dgvLista[2, fila].Value.ToString();
            txtCodigoProducto.Text = dgvLista[3, fila].Value.ToString();
            cbxProducto.Text = dgvLista[4, fila].Value.ToString();
            txtFechaPedido.Text = dgvLista[5, fila].Value.ToString();
            txtFechaEntrega.Text = dgvLista[6, fila].Value.ToString();
            txtCantidadProductos.Text = dgvLista[7, fila].Value.ToString();
        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProveedor.SelectedValue != null)
            {
                selectedProveedor = cbxProveedor.SelectedValue.ToString();
                txtCodigoProveedor.Text = selectedProveedor;
            }
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedValue != null)
            {
                selectedProducto = cbxProducto.SelectedValue.ToString();
                txtCodigoProducto.Text = selectedProducto;
            }
        }
    }
}
