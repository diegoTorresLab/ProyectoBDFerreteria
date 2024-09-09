using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_cbxPedidos;
using Capa_Datos;
using Clase_cbxProveedores;

namespace BDFerreteria
{
    public partial class FormDevoluciones : Form
    {
        public FormDevoluciones()
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

        private void btnLateralVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show(this);
            this.Hide();
        }

        private void btnLateralProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show(this);
            this.Hide();
        }

        private void btnLateralSeguridad_Click(object sender, EventArgs e)
        {
            FormSeguridad formSeguridad = new FormSeguridad();
            formSeguridad.Show(this);
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

        private void btnLateralDevoluciones_Click(object sender, EventArgs e)
        {
            FormDevoluciones formDevoluciones = new FormDevoluciones();
            formDevoluciones.Show(this);
            this.Hide();
        }
        ClaseCBXPedidos claseCBXPedidos = new ClaseCBXPedidos();

        ClaseEntidadDevoluciones claseEntidadDevoluciones = new ClaseEntidadDevoluciones();
        ClaseNegocioDevoluciones claseNegocioDevoluciones = new ClaseNegocioDevoluciones();

        string selectedPedido;
        private void FormDevoluciones_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioDevoluciones.devo_ListarDevoluciones();
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
            //Combobox Pedidos
            cbxPedidos.SelectedIndexChanged += cbxPedidos_SelectedIndexChanged;
            cbxPedidos.DataSource = claseCBXPedidos.CargarCBXPedidos();
            cbxPedidos.DisplayMember = "pedi_Producto";
            cbxPedidos.ValueMember = "pedi_PedidoID";
            cbxPedidos.SelectedIndex = -1;
            txtCodigoPedido.Text = "";
        }
        private void cerrarFormulario(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }
        void devo_MantenimientoDevoluciones(string devo_accion)
        {
            claseEntidadDevoluciones.devo_DevolucionID = txtCodigoDevolucion.Text;
            claseEntidadDevoluciones.devo_PedidoID = txtCodigoPedido.Text;
            claseEntidadDevoluciones.devo_Pedido = cbxPedidos.Text;
            claseEntidadDevoluciones.devo_Observaciones = txtObservaciones.Text;
            claseEntidadDevoluciones.devo_CantidadDevolucion = Convert.ToInt32(txtCantidad.Text);
            claseEntidadDevoluciones.devo_accion = devo_accion;
            string mensaje = claseNegocioDevoluciones.devo_MantenimientoDevoluciones(claseEntidadDevoluciones);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigoDevolucion.Text = "";
            txtCodigoPedido.Text = "";
            cbxPedidos.Text = "";
            txtObservaciones.Text = "";
            txtCantidad.Text = "";
            dgvLista.DataSource = claseNegocioDevoluciones.devo_ListarDevoluciones();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoDevolucion.Text == "")
            {
                if (MessageBox.Show("Deseas eliminar la devolucion " + txtCodigoDevolucion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    devo_MantenimientoDevoluciones("1");
                    limpiar();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoDevolucion.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar la devolucion " + txtCodigoDevolucion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    devo_MantenimientoDevoluciones("2");
                    limpiar();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoDevolucion.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar la devolucion " + txtCodigoDevolucion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    devo_MantenimientoDevoluciones("3");
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
                claseEntidadDevoluciones.devo_DevolucionID = txtBusqueda.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocioDevoluciones.devo_BuscarDevoluciones(claseEntidadDevoluciones);
                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioDevoluciones.devo_ListarDevoluciones();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtCodigoDevolucion.Text = dgvLista[0, fila].Value.ToString();
            txtCodigoPedido.Text = dgvLista[1, fila].Value.ToString();
            cbxPedidos.Text = dgvLista[2, fila].Value.ToString();
            txtObservaciones.Text = dgvLista[3, fila].Value.ToString();
            txtCantidad.Text = dgvLista[4, fila].Value.ToString();
        }

        private void cbxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPedidos.SelectedValue != null)
            {
                selectedPedido = cbxPedidos.SelectedValue.ToString();
                txtCodigoPedido.Text = selectedPedido;
            }
        }
    }
}
