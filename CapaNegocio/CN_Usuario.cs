using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario {

        private CD_Usuario obj_cd_usuario = new CD_Usuario();

        public List<Usuario> Listar() {
            return obj_cd_usuario.Listar();
        }

        public int Registrar(Usuario usuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (usuario.dni == "")
            {
                Mensaje += "Es necesario el número de documento del usuario\n";
            }
            if (usuario.nombre_completo == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }
            if (usuario.clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return 0;
            } else
            {
                return obj_cd_usuario.Registrar(usuario, out Mensaje);
            }
        }

        public bool Editar(Usuario usuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (usuario.dni == "")
            {
                Mensaje += "Es necesario el número de documento del usuario\n";
            }
            if (usuario.nombre_completo == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }
            if (usuario.clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            // Si el mensaje está vacio (es decir que pasó las reglas), entonces ejecuta el procedimiento almacenado
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cd_usuario.Editar(usuario, out Mensaje);
            }
        }

        public bool Eliminar(Usuario usuario, out string Mensaje)
        {
            return obj_cd_usuario.Eliminar(usuario, out Mensaje);
        }
    }
}