using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClaseEntidadProductos
    {
        public string prod_ProductoID {  get; set; }
        public string prod_Producto {  get; set; }
        public decimal prod_Precio {  get; set; }
        public string prod_ProveedorID { get; set; }
        public string prod_Proveedor {  get; set; }
        public string prod_Marca { get; set; }
        public string prod_CategoriaID { get; set; }
        public string prod_Categoria { get; set; }
        public string prod_accion { get; set; }
    }
}
