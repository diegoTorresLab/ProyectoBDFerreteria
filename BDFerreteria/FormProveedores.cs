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

namespace BDFerreteria
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
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

        ClaseEntidadProveedor claseEntidadProveedor = new ClaseEntidadProveedor();
        ClaseNegocioProveedores claseNegocio = new ClaseNegocioProveedores();
        void prov_MantenimientoProveedores(string prov_accion)
        {
            claseEntidadProveedor.prov_ProveedorID = txtCodigoProveedor.Text;
            claseEntidadProveedor.prov_Nombre = txtNombreProveedor.Text;
            claseEntidadProveedor.prov_Direccion = txtDireccionProveedor.Text;
            claseEntidadProveedor.prov_Telefono = txtTelefonoProveedor.Text;
            claseEntidadProveedor.prov_CorreoElectronico = txtCorreoProveedor.Text; 
            claseEntidadProveedor.prov_accion = prov_accion;
            string mensaje = claseNegocio.prov_MantenimientoProveedores(claseEntidadProveedor);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigoProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtCorreoProveedor.Text = "";
            txtBusqueda.Text = "";
            dgvLista.DataSource = claseNegocio.prov_ListarProveedores();
        }
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocio.prov_ListarProveedores();
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
            if(txtCodigoProveedor.Text == "")
            {
                if(MessageBox.Show("Deseas registrar a " + txtNombreProveedor.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    prov_MantenimientoProveedores("1");
                    limpiar();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoProveedor.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a " + txtNombreProveedor.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    prov_MantenimientoProveedores("2");
                    limpiar();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoProveedor.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a " + txtNombreProveedor.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    prov_MantenimientoProveedores("3");
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
            if(txtBusqueda.Text != "")
            {
                claseEntidadProveedor.prov_Nombre = txtBusqueda.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocio.prov_BuscarProveedores(claseEntidadProveedor);
                dgvLista.DataSource = dataTable;
                
            }
            else
            {
                dgvLista.DataSource = claseNegocio.prov_ListarProveedores();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtCodigoProveedor.Text = dgvLista[0, fila].Value.ToString();
            txtNombreProveedor.Text = dgvLista[1, fila].Value.ToString();
            txtDireccionProveedor.Text = dgvLista[2, fila].Value.ToString();
            txtTelefonoProveedor.Text = dgvLista[3, fila].Value.ToString();
            txtCorreoProveedor.Text = dgvLista[4, fila].Value.ToString();
        }
    }
}
