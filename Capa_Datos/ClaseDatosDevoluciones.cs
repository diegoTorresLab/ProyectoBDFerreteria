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
    public class ClaseDatosDevoluciones
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable devo_ListarDevoluciones()
        {
            SqlCommand devoSqlCommand = new SqlCommand("devo_ListarDevoluciones", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(devoSqlCommand);
            DataTable dataTableDevoluciones = new DataTable();
            dataAdapter.Fill(dataTableDevoluciones);
            return dataTableDevoluciones;
        }
        public DataTable devo_BuscarDevoluciones(ClaseEntidadDevoluciones objeto)
        {
            SqlCommand devoSqlCommand = new SqlCommand("devo_BuscarDevoluciones", connection);
            devoSqlCommand.CommandType = CommandType.StoredProcedure;
            devoSqlCommand.Parameters.AddWithValue("@devo_Producto", objeto.devo_Pedido);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(devoSqlCommand);
            DataTable dataTableDevoluciones = new DataTable();
            dataAdapter.Fill(dataTableDevoluciones);
            return dataTableDevoluciones;
        }
        public string devo_MantenimientoDevoluciones(ClaseEntidadDevoluciones objeto)
        {
            string devo_accion = "";
            SqlCommand devoSqlCommand = new SqlCommand("devo_MantenimientoDevoluciones", connection);
            devoSqlCommand.CommandType = CommandType.StoredProcedure;
            devoSqlCommand.Parameters.AddWithValue("@devo_DevolucionID", objeto.devo_DevolucionID);
            devoSqlCommand.Parameters.AddWithValue("@devo_PedidoID", objeto.devo_PedidoID);
            devoSqlCommand.Parameters.AddWithValue("@devo_Pedido", objeto.devo_Pedido);
            devoSqlCommand.Parameters.AddWithValue("@devo_Observaciones", objeto.devo_Observaciones);
            devoSqlCommand.Parameters.AddWithValue("@devo_CantidadDevolucion", objeto.devo_CantidadDevolucion);
            devoSqlCommand.Parameters.Add("@devo_accion", SqlDbType.VarChar, 50).Value = objeto.devo_accion;
            devoSqlCommand.Parameters["@devo_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            devoSqlCommand.ExecuteNonQuery();
            devo_accion = devoSqlCommand.Parameters["@devo_accion"].Value.ToString();
            connection.Close();
            return devo_accion;
        }
    }
}
