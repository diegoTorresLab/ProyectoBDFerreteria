using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
using System.Globalization;

namespace Capa_Datos
{
    public class ClaseDatosClientes
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable clie_ListarClientes()
        {
            SqlCommand clieSqlCommand = new SqlCommand("clie_ListarClientes", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(clieSqlCommand);
            DataTable dataTableClientes = new DataTable();
            dataAdapter.Fill(dataTableClientes);
            return dataTableClientes;
        }
        public DataTable clie_BuscarClientes(ClaseEntidadCliente objeto)
        {
            SqlCommand clieSqlCommand = new SqlCommand("clie_BuscarClientes", connection);
            clieSqlCommand.CommandType = CommandType.StoredProcedure;
            clieSqlCommand.Parameters.AddWithValue("@clie_Nombre", objeto.clie_Nombre);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(clieSqlCommand);
            DataTable dataTableClientes = new DataTable();
            dataAdapter.Fill(dataTableClientes);
            return dataTableClientes;
        }
        public string clie_MantenimientoClientes(ClaseEntidadCliente objeto)
        {
            string clie_accion = "";
            SqlCommand clieSqlCommand = new SqlCommand("clie_MantenimientoClientes", connection);
            clieSqlCommand.CommandType = CommandType.StoredProcedure;
            clieSqlCommand.Parameters.AddWithValue("@clie_ClienteID", objeto.clie_ClienteID);
            clieSqlCommand.Parameters.AddWithValue("@clie_Nombre", objeto.clie_Nombre);
            clieSqlCommand.Parameters.AddWithValue("@clie_Apellidos", objeto.clie_Apellidos);
            clieSqlCommand.Parameters.AddWithValue("@clie_Telefono", objeto.clie_Telefono);
            clieSqlCommand.Parameters.Add("@clie_accion", SqlDbType.VarChar, 50).Value = objeto.clie_accion;
            clieSqlCommand.Parameters["@clie_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            clieSqlCommand.ExecuteNonQuery();
            clie_accion = clieSqlCommand.Parameters["@clie_accion"].Value.ToString();
            connection.Close();
            return clie_accion;
        }
    }
}
