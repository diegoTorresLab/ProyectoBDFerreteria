using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ClaseNegocioPedidos
    {
        ClaseDatosPedidos pedi_ClaseDatosPedidos = new ClaseDatosPedidos();

        public DataTable pedi_ListarPedidos()
        {
            return pedi_ClaseDatosPedidos.pedi_ListarPedidos();
        }
        public DataTable pedi_BuscarPedidos(ClaseEntidadPedidos objeto)
        {
            return pedi_ClaseDatosPedidos.pedi_BuscarPedidos(objeto);
        }
        public string pedi_MantenimientoPedido(ClaseEntidadPedidos objeto)
        {
            return pedi_ClaseDatosPedidos.pedi_MantenimientoPedido(objeto);
        }
    }
}
