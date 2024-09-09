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
using Clase_cbxProductos;
using Clase_cbxEstado;
using Clase_cbxProveedores;

namespace BDFerreteria
{
    public partial class FormInventario : Form
    {
        public FormInventario()
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

        private void btnLateralVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show(this);
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

        ClaseCBXProductos claseCBXProductos = new ClaseCBXProductos();
        ClaseCBXEstado claseCBXEstado = new ClaseCBXEstado();

        ClaseEntidadInventarios claseEntidadInventarios = new ClaseEntidadInventarios();
        ClaseNegocioInventarios claseNegocioInventarios = new ClaseNegocioInventarios();

        string selectedProducto;
        string selectedEstado;
        private void FormInventario_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioInventarios.inve_ListarRevisiones();
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
            //ComboBox Producto
            cbxProducto.SelectedIndexChanged += cbxProducto_SelectedIndexChanged;
            cbxProducto.DataSource = claseCBXProductos.CargarCBXProductos();
            cbxProducto.DisplayMember = "prod_Producto";
            cbxProducto.ValueMember = "prod_ProductoID";
            cbxProducto.SelectedIndex = -1;
            txtProductoID.Text = "";
            //ComboBox Estado
            cbxEstado.SelectedIndexChanged += cbxEstado_SelectedIndexChanged;
            cbxEstado.DataSource = claseCBXEstado.CargarCBXEstados();
            cbxEstado.DisplayMember = "esta_Estado";
            cbxEstado.ValueMember = "esta_EstadoID";
            cbxEstado.SelectedIndex = -1;
        }
        private void cerrarFormulario(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        void inve_MantenimientoRevisiones(string inve_accion)
        {
            claseEntidadInventarios.inve_RevisionID = txtRevisionID.Text;
            claseEntidadInventarios.inve_ProductoID = txtProductoID.Text;
            claseEntidadInventarios.inve_ProductoNombre = cbxProducto.Text;
            claseEntidadInventarios.inve_CantidadActual = Convert.ToInt32(txtCantidadActual.Text);
            claseEntidadInventarios.inve_Notas = txtNotas.Text;
            claseEntidadInventarios.inve_Estado = cbxEstado.Text;
            claseEntidadInventarios.inve_Ubicacion = txtUbicacion.Text;
            claseEntidadInventarios.inve_accion = inve_accion;
            string mensaje = claseNegocioInventarios.inve_MantenimientoRevisiones(claseEntidadInventarios);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiarRevision()
        {
            txtRevisionID.Text = "";
            txtProductoID.Text = "";
            cbxProducto.Text = "";
            txtCantidadActual.Text = "";
            txtNotas.Text = "";
            cbxEstado.Text = "";
            txtUbicacion.Text = "";
            dgvLista.DataSource = claseNegocioInventarios.inve_ListarRevisiones();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtProductoID.Text != "")
            {
                if (MessageBox.Show("Deseas registrar la revision " + txtProductoID.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    inve_MantenimientoRevisiones("1");
                    limpiarRevision();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtProductoID.Text != "")
            {
                if (MessageBox.Show("Deseas modificar la revision " + txtProductoID.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    inve_MantenimientoRevisiones("2");
                    limpiarRevision();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtProductoID.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar la revision " + txtProductoID.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    inve_MantenimientoRevisiones("3");
                    limpiarRevision();
                }
            }
        }

        private void btnLimpiarRegistro_Click(object sender, EventArgs e)
        {
            limpiarRevision();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtProductoBuscar.Text != "")
            {
                claseEntidadInventarios.inve_ProductoNombre = txtProductoBuscar.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocioInventarios.inve_BuscarProductos(claseEntidadInventarios);
                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioInventarios.inve_ListarRevisiones();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtRevisionID.Text = dgvLista[0, fila].Value.ToString();
            txtProductoID.Text = dgvLista[1, fila].Value.ToString();
            cbxProducto.Text = dgvLista[2, fila].Value.ToString();
            cbxEstado.Text = dgvLista[3, fila].Value.ToString();
            txtCantidadActual.Text = dgvLista[4, fila].Value.ToString();
            txtUbicacion.Text = dgvLista[5, fila].Value.ToString();
            txtNotas.Text = dgvLista[6, fila].Value.ToString();
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedValue != null)
            {
                selectedProducto = cbxProducto.SelectedValue.ToString();
                txtProductoID.Text = selectedProducto;
            }
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstado.SelectedValue != null)
            {
                selectedEstado = cbxEstado.SelectedValue.ToString();
                cbxEstado.Text = selectedEstado;
            }
        }
    }
}
