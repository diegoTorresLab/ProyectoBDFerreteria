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
    public class ClaseNegocioProductos
    {
        ClaseDatosProductos prod_ClaseDatosProductos = new ClaseDatosProductos();
        public DataTable prod_ListarProductos()
        {
            return prod_ClaseDatosProductos.prod_ListarProductos();
        }
        public DataTable prod_BuscarProductos(ClaseEntidadProductos objeto)
        {
            return prod_ClaseDatosProductos.prod_BuscarProductos(objeto);
        }
        public string prod_MantenimientoProductos(ClaseEntidadProductos objeto)
        {
            return prod_ClaseDatosProductos.prod_MantenimientoProductos(objeto);
        }
    }
}
