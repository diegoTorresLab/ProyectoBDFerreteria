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
    public class ClaseNegocioVentas
    {
        ClaseDatosVentas vent_ClaseDatosVentas = new ClaseDatosVentas();
        public DataTable vent_ListarVentas()
        {
            return vent_ClaseDatosVentas.vent_ListarVentas();
        }
        public DataTable vent_BuscarVentas(ClaseEntidadVentas objeto)
        {
            return vent_ClaseDatosVentas.vent_BuscarVentas(objeto);
        }
        public string vent_MantenimientoVentas(ClaseEntidadVentas objeto)
        {
            return vent_ClaseDatosVentas.vent_MantenimientoVentas(objeto);
        }
    }
}
