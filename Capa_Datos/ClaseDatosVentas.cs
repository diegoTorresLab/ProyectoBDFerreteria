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
    public class ClaseDatosVentas
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable vent_ListarVentas()
        {
            SqlCommand ventSqlCommand = new SqlCommand("vent_ListarVentas", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ventSqlCommand);
            DataTable dataTableVentas = new DataTable();
            dataAdapter.Fill(dataTableVentas);
            return dataTableVentas;
        }
        public DataTable vent_BuscarVentas(ClaseEntidadVentas objeto)
        {
            SqlCommand ventSqlCommand = new SqlCommand("vent_BuscarVentas", connection);
            ventSqlCommand.CommandType = CommandType.StoredProcedure;
            ventSqlCommand.Parameters.AddWithValue("@vent_EmpleadoApellidos", objeto.vent_EmpleadoApellidos);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ventSqlCommand);
            DataTable dataTableVentas = new DataTable();
            dataAdapter.Fill(dataTableVentas);
            return dataTableVentas;
        }
        public string vent_MantenimientoVentas(ClaseEntidadVentas objeto)
        {
            string vent_accion = "";
            SqlCommand ventSqlCommand = new SqlCommand("vent_MantenimientoVentas", connection);
            ventSqlCommand.CommandType = CommandType.StoredProcedure;
            ventSqlCommand.Parameters.AddWithValue("@vent_VentaID", objeto.vent_VentaID);
            ventSqlCommand.Parameters.AddWithValue("@vent_Fecha", objeto.vent_Fecha);
            ventSqlCommand.Parameters.AddWithValue("@vent_ClienteID", objeto.vent_ClienteID);
            ventSqlCommand.Parameters.AddWithValue("@vent_ClienteApellidos", objeto.vent_ClienteApellidos);
            ventSqlCommand.Parameters.AddWithValue("@vent_EmpleadoID", objeto.vent_EmpleadoID);
            ventSqlCommand.Parameters.AddWithValue("@vent_EmpleadoApellidos", objeto.vent_EmpleadoApellidos);
            ventSqlCommand.Parameters.AddWithValue("@vent_TotalVenta", objeto.vent_TotalVenta);
            ventSqlCommand.Parameters.Add("@vent_accion", SqlDbType.VarChar, 50).Value = objeto.vent_accion;
            ventSqlCommand.Parameters["@vent_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            ventSqlCommand.ExecuteNonQuery();
            vent_accion = ventSqlCommand.Parameters["@vent_accion"].Value.ToString();
            connection.Close();
            return vent_accion;
        }
    }
}
