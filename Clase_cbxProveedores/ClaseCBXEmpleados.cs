using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_cbxEmpleados
{
    public class ClaseCBXEmpleados
    {
        SqlConnection connection = new SqlConnection("server=DIEK;integrated security=true;database=FerreteriaPBD");
        public DataTable CargarCBXEmpleados()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("empl_CBXEmpleados", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
