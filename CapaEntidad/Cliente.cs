using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente {
        public int id_cliente { get; set; }
        public string dni { get; set; }
        public string nombre_completo { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fecha_registro { get; set; }
    }
}
