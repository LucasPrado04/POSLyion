using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor {
        public int id_proveedor { get; set; }
        public string descripcion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fecha_registro { get; set; }
    }
}
