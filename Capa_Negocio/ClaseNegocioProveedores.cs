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
    public class ClaseNegocioProveedores
    {
        ClaseDatosProveedores prov_ClaseDatos = new ClaseDatosProveedores();

        public DataTable prov_ListarProveedores()
        {
            return prov_ClaseDatos.prov_ListarProveedores();
        }
        public DataTable prov_BuscarProveedores(ClaseEntidadProveedor objeto)
        {
            return prov_ClaseDatos.prov_BuscarProveedores(objeto);
        }
        public string prov_MantenimientoProveedores(ClaseEntidadProveedor objeto)
        {
            return prov_ClaseDatos.prov_MantenimientoProveedores(objeto);
        }
    }
}
