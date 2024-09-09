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
    public class ClaseNegocioEmpleados
    {
        ClaseDatosEmpleados empl_ClaseDatos = new ClaseDatosEmpleados();
        public DataTable empl_ListarEmpleados()
        {
            return empl_ClaseDatos.empl_ListarEmpleados();
        }
        public DataTable empl_BuscarEmpleados(ClaseEntidadEmpleados objeto)
        {
            return empl_ClaseDatos.empl_BuscarEmpleados(objeto);
        }
        public string empl_MantenimientoEmpleados(ClaseEntidadEmpleados objeto)
        {
            return empl_ClaseDatos.empl_MantenimientoEmpleados(objeto);
        }
    }
}
