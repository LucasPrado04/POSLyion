using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria obj_cd_categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return obj_cd_categoria.Listar();
        }

        public int Registrar(Categoria categoria, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (categoria.descripcion == "")
            {
                Mensaje += "Es necesario la descripción de la categoría\n";
            }
           
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_cd_categoria.Registrar(categoria, out Mensaje);
            }
        }

        public bool Editar(Categoria categoria, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (categoria.descripcion == "")
            {
                Mensaje += "Es necesario la descripción de la categoría\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cd_categoria.Editar(categoria, out Mensaje);
            }
        }

        public bool Eliminar(Categoria categoria, out string Mensaje)
        {
            return obj_cd_categoria.Eliminar(categoria, out Mensaje);
        }
    }
}
