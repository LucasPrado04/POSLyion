using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    // Método para devolver una cadena de conexión desde App.config para la base de datos.
    public class Conexion {
        public static string cadena = ConfigurationManager.ConnectionStrings["conexion_bd"].ToString();
    }
}
