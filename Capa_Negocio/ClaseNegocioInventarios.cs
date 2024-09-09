using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class ClaseNegocioInventarios
    {
        ClaseDatosInventarios inve_ClaseDatosInventarios = new ClaseDatosInventarios();
        public DataTable inve_ListarRevisiones()
        {
            return inve_ClaseDatosInventarios.inve_ListarRevisiones();
        }
        public DataTable inve_BuscarProductos(ClaseEntidadInventarios objeto)
        {
            return inve_ClaseDatosInventarios.inve_BuscarProductos(objeto);
        }
        public string inve_MantenimientoRevisiones(ClaseEntidadInventarios objeto)
        {
            return inve_ClaseDatosInventarios.inve_MantenimientoRevisiones(objeto);
        }
    }
}
