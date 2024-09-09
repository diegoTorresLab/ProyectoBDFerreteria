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
    public class ClaseDatosProductos
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable prod_ListarProductos()
        {
            SqlCommand prodSqlCommand = new SqlCommand("prod_ListarProductos", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(prodSqlCommand);
            DataTable dataTableProductos = new DataTable();
            dataAdapter.Fill(dataTableProductos);
            return dataTableProductos;
        }
        public DataTable prod_BuscarProductos(ClaseEntidadProductos objeto)
        {
            SqlCommand prodSqlCommand = new SqlCommand("prod_BuscarProductos", connection);
            prodSqlCommand.CommandType = CommandType.StoredProcedure;
            prodSqlCommand.Parameters.AddWithValue("@prod_Categoria", objeto.prod_Categoria);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(prodSqlCommand);
            DataTable dataTableProductos = new DataTable();
            dataAdapter.Fill(dataTableProductos);
            return dataTableProductos;
        }
        public string prod_MantenimientoProductos(ClaseEntidadProductos objeto)
        {
            string prod_accion = "";
            SqlCommand prodSqlCommand = new SqlCommand("prod_MantenimientoProductos", connection);
            prodSqlCommand.CommandType = CommandType.StoredProcedure;
            prodSqlCommand.Parameters.AddWithValue("@prod_ProductoID", objeto.prod_ProductoID);
            prodSqlCommand.Parameters.AddWithValue("@prod_Producto", objeto.prod_Producto);
            prodSqlCommand.Parameters.AddWithValue("@prod_Precio", objeto.prod_Precio);
            prodSqlCommand.Parameters.AddWithValue("@prod_ProveedorID", objeto.prod_ProveedorID);
            prodSqlCommand.Parameters.AddWithValue("@prod_Proveedor", objeto.prod_Proveedor);
            prodSqlCommand.Parameters.AddWithValue("@prod_Marca", objeto.prod_Marca);
            prodSqlCommand.Parameters.AddWithValue("@prod_CategoriaID", objeto.prod_CategoriaID);
            prodSqlCommand.Parameters.AddWithValue("@prod_Categoria", objeto.prod_Categoria);
            prodSqlCommand.Parameters.Add("@prod_accion", SqlDbType.VarChar, 50).Value = objeto.prod_accion;
            prodSqlCommand.Parameters["@prod_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            prodSqlCommand.ExecuteNonQuery();
            prod_accion = prodSqlCommand.Parameters["@prod_accion"].Value.ToString();
            connection.Close();
            return prod_accion;
        }
    }
}
