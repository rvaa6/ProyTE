using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MRoles : MBase, IRoles
    {
        public void ActualizarRol(TbRoles rol)
        {
            rols.ActualizarRol(rol);
        }

        public TbRoles BuscarRol(int idRol)
        {
            return rols.BuscarRol(idRol);
        }

        public void EliminarRol(int idRol)
        {
            rols.EliminarRol(idRol);
        }

        public void InsertarRol(TbRoles rol)
        {
            rols.InsertarRol(rol);
        }

        public List<TbRoles> ListarRoles()
        {
            return rols.ListarRoles();
        }
    }
}
