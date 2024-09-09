using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClaseEntidadInventarios
    {
        public string inve_RevisionID {  get; set; }
        public string inve_ProductoID { get; set; }
        public string inve_ProductoNombre { get; set; }
        public int inve_CantidadActual { get; set; }
        public string inve_Notas {  get; set; }
        public string inve_Estado { get; set; }
        public string inve_Ubicacion { get; set; }
        public string inve_accion {  get; set; }
    }
}
