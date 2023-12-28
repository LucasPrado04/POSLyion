using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto obj_cd_producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return obj_cd_producto.Listar();
        }

        public int Registrar(Producto producto, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (producto.codigo == "")
            {
                Mensaje += "Es necesario el código de barras del producto\n";
            }
            if (producto.descripcion == "")
            {
                Mensaje += "Es necesario la descripción del producto\n";
            }

            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_cd_producto.Registrar(producto, out Mensaje);
            }
        }

        public bool Editar(Producto producto, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (producto.codigo == "")
            {
                Mensaje += "Es necesario el código de barras del producto\n";
            }
            if (producto.descripcion == "")
            {
                Mensaje += "Es necesario la descripción del producto\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cd_producto.Editar(producto, out Mensaje);
            }
        }

        public bool Eliminar(Producto producto, out string Mensaje)
        {
            return obj_cd_producto.Eliminar(producto, out Mensaje);
        }
    }
}
