using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Clase_cbxProductos
{
    public class ClaseCBXProductos
    {
        SqlConnection connection = new SqlConnection("server=DIEK;integrated security=true;database=FerreteriaPBD");
        public DataTable CargarCBXProductos()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("prod_CBXProductos", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
