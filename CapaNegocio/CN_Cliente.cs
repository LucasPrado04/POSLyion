using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente obj_cd_cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return obj_cd_cliente.Listar();
        }

        public int Registrar(Cliente cliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (cliente.nombre_completo == "")
            {
                Mensaje += "Es necesario el nombre completo del cliente\n";
            }
            if (cliente.dni == "")
            {
                Mensaje += "Es necesario el número de documento del cliente\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_cd_cliente.Registrar(cliente, out Mensaje);
            }
        }

        public bool Editar(Cliente cliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (cliente.nombre_completo == "")
            {
                Mensaje += "Es necesario el nombre completo del cliente\n";
            }
            if (cliente.dni == "")
            {
                Mensaje += "Es necesario el número de documento del cliente\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cd_cliente.Editar(cliente, out Mensaje);
            }
        }

        public bool Eliminar(Cliente cliente, out string Mensaje)
        {
            return obj_cd_cliente.Eliminar(cliente, out Mensaje);
        }
    }
}
