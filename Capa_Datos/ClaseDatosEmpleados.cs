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
    public class ClaseDatosEmpleados
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable empl_ListarEmpleados()
        {
            SqlCommand emplSqlCommand = new SqlCommand("empl_ListarEmpleados", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(emplSqlCommand);
            DataTable dataTableEmpleados = new DataTable();
            dataAdapter.Fill(dataTableEmpleados);
            return dataTableEmpleados;
        }
        public DataTable empl_BuscarEmpleados(ClaseEntidadEmpleados objeto)
        {
            SqlCommand emplSqlCommand = new SqlCommand("empl_BuscarEmpleados", connection);
            emplSqlCommand.CommandType = CommandType.StoredProcedure;
            emplSqlCommand.Parameters.AddWithValue("@empl_Empleado", objeto.empl_Empleado);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(emplSqlCommand);
            DataTable dataTableEmpleados = new DataTable();
            dataAdapter.Fill(dataTableEmpleados);
            return dataTableEmpleados;
        }
        public string empl_MantenimientoEmpleados(ClaseEntidadEmpleados objeto)
        {
            string empl_accion = "";
            SqlCommand emplSqlCommand = new SqlCommand("empl_MantenimientoEmpleados", connection);
            emplSqlCommand.CommandType = CommandType.StoredProcedure;
            emplSqlCommand.Parameters.AddWithValue("@empl_EmpleadoID", objeto.empl_EmpleadoID);
            emplSqlCommand.Parameters.AddWithValue("@empl_Empleado", objeto.empl_Empleado);
            emplSqlCommand.Parameters.AddWithValue("@empl_Apellidos", objeto.empl_Apellidos);
            emplSqlCommand.Parameters.AddWithValue("@empl_Telefono", objeto.empl_Telefono);
            emplSqlCommand.Parameters.AddWithValue("@empl_CorreoElectronico", objeto.empl_CorreoElectronico);
            emplSqlCommand.Parameters.Add("@empl_accion", SqlDbType.VarChar, 50).Value = objeto.empl_accion;
            emplSqlCommand.Parameters["@empl_accion"].Direction = ParameterDirection.InputOutput;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            emplSqlCommand.ExecuteNonQuery();
            empl_accion = emplSqlCommand.Parameters["@empl_accion"].Value.ToString();
            connection.Close();
            return empl_accion;
        }
    }
}
