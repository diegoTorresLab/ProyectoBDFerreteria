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
    public class ClaseDatosProveedores
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable prov_ListarProveedores()
        {
            SqlCommand provSqlCommand = new SqlCommand("prov_ListarProveedores",connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(provSqlCommand);
            DataTable dataTableProveedores = new DataTable();
            dataAdapter.Fill(dataTableProveedores);
            return dataTableProveedores;
        }
        public DataTable prov_BuscarProveedores(ClaseEntidadProveedor objeto)
        {
            SqlCommand provSqlCommand = new SqlCommand("prov_BuscarProveedores", connection);
            provSqlCommand.CommandType = CommandType.StoredProcedure;
            provSqlCommand.Parameters.AddWithValue("@prov_Nombre", objeto.prov_Nombre);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(provSqlCommand);
            DataTable dataTableProveedores = new DataTable();
            dataAdapter.Fill(dataTableProveedores);
            return dataTableProveedores;
        }
        public string prov_MantenimientoProveedores(ClaseEntidadProveedor objeto)
        {
            string prov_accion = "";
            SqlCommand provSqlCommand = new SqlCommand("prov_MantenimientoProveedores", connection);
            provSqlCommand.CommandType = CommandType.StoredProcedure;
            provSqlCommand.Parameters.AddWithValue("@prov_ProveedorID", objeto.prov_ProveedorID);
            provSqlCommand.Parameters.AddWithValue("@prov_Nombre", objeto.prov_Nombre);
            provSqlCommand.Parameters.AddWithValue("@prov_Direccion", objeto.prov_Direccion);
            provSqlCommand.Parameters.AddWithValue("@prov_Telefono", objeto.prov_Telefono);
            provSqlCommand.Parameters.AddWithValue("@prov_CorreoElectronico", objeto.prov_CorreoElectronico);
            provSqlCommand.Parameters.Add("@prov_accion",SqlDbType.VarChar, 50).Value = objeto.prov_accion;
            provSqlCommand.Parameters["@prov_accion"].Direction = ParameterDirection.InputOutput;
            if(connection.State == ConnectionState.Open) connection.Close(); 
            connection.Open(); 
            provSqlCommand.ExecuteNonQuery();
            prov_accion = provSqlCommand.Parameters["@prov_accion"].Value.ToString();
            connection.Close();
            return prov_accion;
        }
    }
}
