using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public  class CN_Permiso
    {
        private CD_Permiso permiso = new CD_Permiso();

        public List<Permiso> Listar(int id_usuario)
        {
            return permiso.Listar(id_usuario);
        }
    }
}
