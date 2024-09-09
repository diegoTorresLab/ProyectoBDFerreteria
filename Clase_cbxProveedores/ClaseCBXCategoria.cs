using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_cbxCategorias
{
    public class ClaseCBXCategoria
    {
        SqlConnection connection = new SqlConnection("server=DIEK;integrated security=true;database=FerreteriaPBD");
        public DataTable CargarCBXCategoria()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("cate_CBXCategoria", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
