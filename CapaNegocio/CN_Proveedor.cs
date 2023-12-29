using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor obj_cd_proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return obj_cd_proveedor.Listar();
        }

        public int Registrar(Proveedor proveedor, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (proveedor.razon_social == "")
            {
                Mensaje += "Es necesario el nombre completo del proveedor\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_cd_proveedor.Registrar(proveedor, out Mensaje);
            }
        }

        public bool Editar(Proveedor proveedor, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (proveedor.razon_social == "")
            {
                Mensaje += "Es necesario el nombre completo del proveedor\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cd_proveedor.Editar(proveedor, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor proveedor, out string Mensaje)
        {
            return obj_cd_proveedor.Eliminar(proveedor, out Mensaje);
        }
    }
}
