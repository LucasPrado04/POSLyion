using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra_Detalle {
        public int id_compradetalle { get; set; }
        public Producto Producto { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
        public string fecha_registro { get; set; }
    }
}
