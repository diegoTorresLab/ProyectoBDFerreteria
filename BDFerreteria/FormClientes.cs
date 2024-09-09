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

namespace BDFerreteria
{
    public partial class FormClientes : Form
    {
        public FormClientes()
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

        ClaseEntidadCliente claseEntidadCliente = new ClaseEntidadCliente();
        ClaseNegocioClientes claseNegocioClientes = new ClaseNegocioClientes();
        void clie_MantenimientoClientes(string clie_accion)
        {
            claseEntidadCliente.clie_ClienteID = txtCodigoCliente.Text;
            claseEntidadCliente.clie_Nombre = txtNombreCliente.Text;
            claseEntidadCliente.clie_Apellidos = txtApellidosCliente.Text;
            claseEntidadCliente.clie_Telefono = txtTelefonoCliente.Text;
            claseEntidadCliente.clie_accion = clie_accion;
            string mensaje = claseNegocioClientes.clie_MantenimientoClientes(claseEntidadCliente);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidosCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtBusqueda.Text = "";
            dgvLista.DataSource = claseNegocioClientes.clie_ListarClientes();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioClientes.clie_ListarClientes();
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);

        }
        private void cerrarFormulario(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a " + txtNombreCliente.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    clie_MantenimientoClientes("1");
                    limpiar();
                }
            }
        }
        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a " + txtNombreCliente.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    clie_MantenimientoClientes("2");
                    limpiar();
                }
            }
        }
        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a " + txtNombreCliente.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    clie_MantenimientoClientes("3");
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
                claseEntidadCliente.clie_Nombre = txtBusqueda.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocioClientes.clie_BuscarClientes(claseEntidadCliente);
                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioClientes.clie_ListarClientes();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtCodigoCliente.Text = dgvLista[0, fila].Value.ToString();
            txtNombreCliente.Text = dgvLista[1, fila].Value.ToString();
            txtApellidosCliente.Text = dgvLista[2, fila].Value.ToString();
            txtTelefonoCliente.Text = dgvLista[3, fila].Value.ToString();
        }
    }
}
