using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClaseEntidadPedidos
    {
        public string pedi_PedidoID {  get; set; }
        public string pedi_ProveedorID { get; set; }
        public string pedi_Proveedor {  get; set; }
        public string pedi_ProductoID {  get; set; } 
        public string pedi_Producto {  get; set; }
        public string pedi_FechaPedido { get; set; }
        public string pedi_FechaEntrega { get; set; }
        public int pedi_Cantidad { get; set; }
        public string pedi_accion {  get; set; }
    }
}
