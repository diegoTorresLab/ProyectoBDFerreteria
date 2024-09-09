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
    public class ClaseNegocioDevoluciones
    {
        ClaseDatosDevoluciones devo_ClaseDatosDevoluciones = new ClaseDatosDevoluciones();
        public DataTable devo_ListarDevoluciones()
        {
            return devo_ClaseDatosDevoluciones.devo_ListarDevoluciones();
        }
        public DataTable devo_BuscarDevoluciones(ClaseEntidadDevoluciones objeto)
        {
            return devo_ClaseDatosDevoluciones.devo_BuscarDevoluciones(objeto);
        }
        public string devo_MantenimientoDevoluciones(ClaseEntidadDevoluciones objeto)
        {
            return devo_ClaseDatosDevoluciones.devo_MantenimientoDevoluciones(objeto);
        }
    }
}
