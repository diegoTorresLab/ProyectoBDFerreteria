using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;
using Clase_cbxClientes;
using Clase_cbxEmpleados;
using Clase_cbxProductos;

namespace BDFerreteria
{
    public partial class FormVentas : Form
    {
        public FormVentas()
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
        ClaseCBXClientes claseCBXClientes = new ClaseCBXClientes();
        ClaseCBXEmpleados claseCBXEmpleados = new ClaseCBXEmpleados();

        ClaseEntidadVentas claseEntidadVentas = new ClaseEntidadVentas();
        ClaseNegocioVentas claseNegocioVentas = new ClaseNegocioVentas();
        
        string selectedCliente;
        string selectedEmpleado;

        private void FormVentas_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioVentas.vent_ListarVentas();
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
            //Combobox Clientes
            cbxClienteApellidos.SelectedIndexChanged += cbxClienteApellidos_SelectedIndexChanged;
            cbxClienteApellidos.DataSource = claseCBXClientes.CargarCBXClientes();
            cbxClienteApellidos.DisplayMember = "clie_Apellidos";
            cbxClienteApellidos.ValueMember = "clie_ClienteID";
            cbxClienteApellidos.SelectedIndex = -1;
            txtClienteID.Text = "";
            //Combobox Empleados
            cbxEmpleadoApellido.SelectedIndexChanged += cbxEmpleadoApellido_SelectedIndexChanged;
            cbxEmpleadoApellido.DataSource = claseCBXEmpleados.CargarCBXEmpleados();
            cbxEmpleadoApellido.DisplayMember = "empl_Apellidos";
            cbxEmpleadoApellido.ValueMember = "empl_EmpleadoID";
            cbxEmpleadoApellido.SelectedIndex = -1;
            txtEmpleadoID.Text = "";
        }
        private void cerrarFormulario(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }
        void vent_MantenimientoVentas(string vent_accion)
        {
            claseEntidadVentas.vent_VentaID = txtVentasID.Text;
            claseEntidadVentas.vent_Fecha = txtFechaVenta.Text;
            claseEntidadVentas.vent_ClienteID = txtClienteID.Text;
            claseEntidadVentas.vent_ClienteApellidos = cbxClienteApellidos.Text;
            claseEntidadVentas.vent_EmpleadoID = txtEmpleadoID.Text;
            claseEntidadVentas.vent_EmpleadoApellidos = cbxEmpleadoApellido.Text;
            claseEntidadVentas.vent_TotalVenta = Convert.ToDecimal(txtTotalVenta.Text);
            claseEntidadVentas.vent_accion = vent_accion;
            string mensaje = claseNegocioVentas.vent_MantenimientoVentas(claseEntidadVentas);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtVentasID.Text = "";
            txtFechaVenta.Text = "";
            txtClienteID.Text = "";
            cbxClienteApellidos.Text = "";
            txtEmpleadoID.Text = "";
            cbxEmpleadoApellido.Text = "";
            txtTotalVenta.Text = "";
            dgvLista.DataSource = claseNegocioVentas.vent_ListarVentas();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtVentasID.Text == "")
            {
                if (MessageBox.Show("Deseas registrar la venta " + txtVentasID.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    vent_MantenimientoVentas("1");
                    limpiar();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtVentasID.Text != "")
            {
                if (MessageBox.Show("Deseas modificar la venta " + txtVentasID.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    vent_MantenimientoVentas("2");
                    limpiar();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtVentasID.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar la venta " + txtVentasID.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    vent_MantenimientoVentas("3");
                    limpiar();
                }
            }
        }

        private void btnLimpiarRegistro_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void txtEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpleadoBuscar.Text != "")
            {
                claseEntidadVentas.vent_EmpleadoApellidos = txtEmpleadoBuscar.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocioVentas.vent_BuscarVentas(claseEntidadVentas);
                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioVentas.vent_ListarVentas();
            }
        }
        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtVentasID.Text = dgvLista[0, fila].Value.ToString();
            txtFechaVenta.Text = dgvLista[1, fila].Value.ToString();
            txtClienteID.Text = dgvLista[2, fila].Value.ToString();
            cbxClienteApellidos.Text = dgvLista[3, fila].Value.ToString();
            txtEmpleadoID.Text = dgvLista[4, fila].Value.ToString();
            cbxEmpleadoApellido.Text = dgvLista[5, fila].Value.ToString();
            txtTotalVenta.Text = dgvLista[6, fila].Value.ToString();
        }

        private void cbxClienteApellidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClienteApellidos.SelectedValue != null)
            {
                selectedCliente = cbxClienteApellidos.SelectedValue.ToString();
                txtClienteID.Text = selectedCliente;
            }
        }

        private void cbxEmpleadoApellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmpleadoApellido.SelectedValue != null)
            {
                selectedEmpleado = cbxEmpleadoApellido.SelectedValue.ToString();
                txtEmpleadoID.Text = selectedEmpleado;
            }
        }
    }
}
