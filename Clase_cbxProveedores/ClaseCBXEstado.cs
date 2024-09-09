using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_cbxEstado
{
    public class ClaseCBXEstado
    {
        SqlConnection connection = new SqlConnection("server=DIEK;integrated security=true;database=FerreteriaPBD");
        public DataTable CargarCBXEstados()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("esta_CBXEstados", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
