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
    public class ClaseDatosInventarios
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable inve_ListarRevisiones()
        {
            SqlCommand inveSqlCommand = new SqlCommand("inve_ListarRevisiones", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(inveSqlCommand);
            DataTable dataTableRevisiones = new DataTable();
            dataAdapter.Fill(dataTableRevisiones);
            return dataTableRevisiones;
        }
        public DataTable inve_BuscarProductos(ClaseEntidadInventarios objeto)
        {
            SqlCommand inveSqlCommand = new SqlCommand("inve_BuscarProductos", connection);
            inveSqlCommand.CommandType = CommandType.StoredProcedure;
            inveSqlCommand.Parameters.AddWithValue("@inve_ProductoNombre", objeto.inve_ProductoNombre);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(inveSqlCommand);
            DataTable dataTableRevisiones = new DataTable();
            dataAdapter.Fill(dataTableRevisiones);
            return dataTableRevisiones;
        }
        public string inve_MantenimientoRevisiones(ClaseEntidadInventarios objeto)
        {
            string inve_accion = "";
            SqlCommand inveSqlCommand = new SqlCommand("inve_MantenimientoRevisiones", connection);
            inveSqlCommand.CommandType = CommandType.StoredProcedure;
            inveSqlCommand.Parameters.AddWithValue("@inve_RevisionID", objeto.inve_RevisionID);
            inveSqlCommand.Parameters.AddWithValue("@inve_ProductoID", objeto.inve_ProductoID);
            inveSqlCommand.Parameters.AddWithValue("@inve_ProductoNombre", objeto.inve_ProductoNombre);
            inveSqlCommand.Parameters.AddWithValue("@inve_CantidadActual", objeto.inve_CantidadActual);
            inveSqlCommand.Parameters.AddWithValue("@inve_Notas", objeto.inve_Notas);
            inveSqlCommand.Parameters.AddWithValue("@inve_Estado", objeto.inve_Estado);
            inveSqlCommand.Parameters.AddWithValue("@inve_Ubicacion", objeto.inve_Ubicacion);
            inveSqlCommand.Parameters.Add("@inve_accion", SqlDbType.VarChar, 50).Value = objeto.inve_accion;
            inveSqlCommand.Parameters["@inve_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            inveSqlCommand.ExecuteNonQuery();
            inve_accion = inveSqlCommand.Parameters["@inve_accion"].Value.ToString();
            connection.Close();
            return inve_accion;
        }
    }
}
