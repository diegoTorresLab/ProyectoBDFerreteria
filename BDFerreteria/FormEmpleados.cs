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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
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

        ClaseEntidadEmpleados claseEntidadEmpleados = new ClaseEntidadEmpleados();
        ClaseNegocioEmpleados claseNegocioEmpleados = new ClaseNegocioEmpleados();
        void empl_MantenimientoEmpleados(string empl_accion)
        {
            claseEntidadEmpleados.empl_EmpleadoID = txtCodigoEmpleado.Text;
            claseEntidadEmpleados.empl_Empleado = txtNombreEmpleado.Text;
            claseEntidadEmpleados.empl_Apellidos = txtApellidosEmpleado.Text;
            claseEntidadEmpleados.empl_Telefono = txtTelefonoEmpleado.Text;
            claseEntidadEmpleados.empl_CorreoElectronico = txtCorreoEmpleado.Text;
            claseEntidadEmpleados.empl_accion = empl_accion;
            string mensaje = claseNegocioEmpleados.empl_MantenimientoEmpleados(claseEntidadEmpleados);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigoEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtApellidosEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtCorreoEmpleado.Text = "";
            txtBusqueda.Text = "";
            dgvLista.DataSource = claseNegocioEmpleados.empl_ListarEmpleados();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = claseNegocioEmpleados.empl_ListarEmpleados();
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
            if (txtCodigoEmpleado.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a " + txtNombreEmpleado.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    empl_MantenimientoEmpleados("1");
                    limpiar();
                }
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoEmpleado.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a " + txtNombreEmpleado.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    empl_MantenimientoEmpleados("2");
                    limpiar();
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (txtCodigoEmpleado.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a " + txtNombreEmpleado.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    empl_MantenimientoEmpleados("3");
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
                claseEntidadEmpleados.empl_Empleado = txtBusqueda.Text;
                DataTable dataTable = new DataTable();
                dataTable = claseNegocioEmpleados.empl_BuscarEmpleados(claseEntidadEmpleados);
                dgvLista.DataSource = dataTable;

            }
            else
            {
                dgvLista.DataSource = claseNegocioEmpleados.empl_ListarEmpleados();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvLista.CurrentCell.RowIndex;
            txtCodigoEmpleado.Text = dgvLista[0, fila].Value.ToString();
            txtNombreEmpleado.Text = dgvLista[1, fila].Value.ToString();
            txtApellidosEmpleado.Text = dgvLista[2, fila].Value.ToString();
            txtTelefonoEmpleado.Text = dgvLista[3, fila].Value.ToString();
            txtCorreoEmpleado.Text = dgvLista[4, fila].Value.ToString();
        }
    }
}
