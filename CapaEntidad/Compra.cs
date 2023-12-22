using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra {
        public int id_compra { get; set; }
        public Usuario Usuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<Compra_Detalle> Compra_Detalle { get; set; }
        public decimal monto_total { get; set; }
        public string fecha_registro { get; set; }
    }
}
