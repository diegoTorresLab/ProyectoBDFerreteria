using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class ClaseDatosPedidos
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable pedi_ListarPedidos()
        {
            SqlCommand pediSqlCommand = new SqlCommand("pedi_ListarPedidos", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(pediSqlCommand);
            DataTable dataTablePedidos = new DataTable();
            dataAdapter.Fill(dataTablePedidos);
            return dataTablePedidos;
        }
        public DataTable pedi_BuscarPedidos(ClaseEntidadPedidos objeto)
        {
            SqlCommand pediSqlCommand = new SqlCommand("pedi_BuscarPedidos", connection);
            pediSqlCommand.CommandType = CommandType.StoredProcedure;
            pediSqlCommand.Parameters.AddWithValue("@pedi_Producto", objeto.pedi_Producto);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(pediSqlCommand);
            DataTable dataTablePedidos = new DataTable();
            dataAdapter.Fill(dataTablePedidos);
            return dataTablePedidos;
        }
        public string pedi_MantenimientoPedido(ClaseEntidadPedidos objeto)
        {
            string pedi_accion = "";
            SqlCommand pediSqlCommand = new SqlCommand("pedi_MantenimientoPedidos", connection);
            pediSqlCommand.CommandType = CommandType.StoredProcedure;
            pediSqlCommand.Parameters.AddWithValue("@pedi_PedidoID", objeto.pedi_PedidoID);
            pediSqlCommand.Parameters.AddWithValue("@pedi_ProveedorID", objeto.pedi_ProveedorID);
            pediSqlCommand.Parameters.AddWithValue("@pedi_Proveedor", objeto.pedi_Proveedor);
            pediSqlCommand.Parameters.AddWithValue("@pedi_ProductoID", objeto.pedi_ProductoID);
            pediSqlCommand.Parameters.AddWithValue("@pedi_Producto", objeto.pedi_Producto);
            pediSqlCommand.Parameters.AddWithValue("@pedi_FechaPedido", objeto.pedi_FechaPedido);
            pediSqlCommand.Parameters.AddWithValue("@pedi_FechaEntrega", objeto.pedi_FechaEntrega);
            pediSqlCommand.Parameters.AddWithValue("@pedi_Cantidad", objeto.pedi_Cantidad);
            pediSqlCommand.Parameters.Add("@pedi_accion", SqlDbType.VarChar, 50).Value = objeto.pedi_accion;
            pediSqlCommand.Parameters["@pedi_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            pediSqlCommand.ExecuteNonQuery();
            pedi_accion = pediSqlCommand.Parameters["@pedi_accion"].Value.ToString();
            connection.Close();
            return pedi_accion;
        }
    }
}
