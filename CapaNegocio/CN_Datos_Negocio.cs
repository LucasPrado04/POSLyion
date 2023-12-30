using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Datos_Negocio
    {
        private CD_Datos_Negocio obj_cd_negocio = new CD_Datos_Negocio();

        public Datos_Negocio Obtener_Datos()
        {
            return obj_cd_negocio.Obtener_Datos();
        }

        public bool Guardar_Datos(Datos_Negocio negocio, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (negocio.nombre == "")
            {
                Mensaje += "Es necesario el nombre del negocio\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el método
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cd_negocio.Guardar_Datos(negocio, out Mensaje);
            }
        }

        public byte[] Obtener_Logo(out bool obtenido)
        {
            return obj_cd_negocio.Obtener_Logo(out obtenido);
        }

        public bool Actualizar_Logo(byte[] imagen, out string mensaje)
        {
            return obj_cd_negocio.Actualizar_Logo(imagen, out mensaje);
        }
    }
}
