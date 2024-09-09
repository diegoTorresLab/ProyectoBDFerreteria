using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_cbxPedidos
{
    public class ClaseCBXPedidos
    {
        SqlConnection connection = new SqlConnection("server=DIEK;integrated security=true;database=FerreteriaPBD");
        public DataTable CargarCBXPedidos()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("pedi_CBXPedidos", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
