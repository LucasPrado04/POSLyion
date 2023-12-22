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
}
