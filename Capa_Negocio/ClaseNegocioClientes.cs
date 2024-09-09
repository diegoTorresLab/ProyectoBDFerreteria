using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClaseNegocioClientes
    {
        ClaseDatosClientes clie_ClaseDatos = new ClaseDatosClientes();

        public DataTable clie_ListarClientes()
        {
            return clie_ClaseDatos.clie_ListarClientes();
        }
        public DataTable clie_BuscarClientes(ClaseEntidadCliente objeto)
        {
            return clie_ClaseDatos.clie_BuscarClientes(objeto);
        }
        public string clie_MantenimientoClientes(ClaseEntidadCliente objeto)
        {
            return clie_ClaseDatos.clie_MantenimientoClientes(objeto);
        }
    }
}
