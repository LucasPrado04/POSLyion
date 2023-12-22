using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario {
        public int id_usuario { get; set; }
        public string dni { get; set; }
        public string nombre_completo { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
        public Rol Rol { get; set; }
        public bool estado { get; set; }
        public string fecha_registro { get; set; }
    }
}
