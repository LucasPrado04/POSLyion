using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta {
        public int id_venta { get; set; }
        public Usuario Usuario { get; set;}
        public List<Venta_Detalle> Venta_Detalle { get; set; }
        public decimal monto_total { get; set; }
        public decimal monto_cambio { get; set; }
        public string fecha_registro { get; set; }
    }
}
