using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClaseEntidadVentas
    {
        public string vent_VentaID {  get; set; }   
        public string vent_Fecha { get; set; }
        public string vent_ClienteID { get; set; }
        public string vent_ClienteApellidos { get; set; }
        public string vent_EmpleadoID { get; set; }
        public string vent_EmpleadoApellidos { get; set; }
        public decimal vent_TotalVenta { get; set; }
        public string vent_accion {  get; set; }
    }
}
