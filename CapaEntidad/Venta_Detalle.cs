using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta_Detalle {
        public int id_ventadetalle { get; set; }
        public Producto Producto { get; set; }
        public decimal precio_venta { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
        public string fecha_registro { get; set; }
    }
}
