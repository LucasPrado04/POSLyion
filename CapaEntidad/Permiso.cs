using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso {
        public int id_permiso { get; set; }
        public Rol Rol { get; set; }
        public string nombre_menu { get; set; }
        public string fecha_registro { get; set; }
    }
}
