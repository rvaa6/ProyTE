using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MPermisos : MBase, IPermisos
    {
        public void ActualizarPermiso(TbPermisos permiso)
        {
            permi.ActualizarPermiso(permiso);
        }

        public TbPermisos BuscarPermiso(int idPermiso)
        {
            return permi.BuscarPermiso(idPermiso);
        }

        public void EliminarPermiso(int idPermiso)
        {
            permi.EliminarPermiso(idPermiso);
        }

        public void InsertarPermiso(TbPermisos permiso)
        {
            permi.InsertarPermiso(permiso);
        }

        public List<TbPermisos> ListarPermisos()
        {
            return permi.ListarPermisos();
        }
    }
}
