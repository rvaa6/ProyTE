using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MRol_Permiso : MBase, IRol_Permiso
    {
        public void ActualizarRol_Permiso(TbRol_Permiso rol_permiso)
        {
            rolPermi.ActualizarRol_Permiso(rol_permiso);
        }

        public TbRol_Permiso BuscarRol_Permiso(int idRol_Permiso)
        {
            return rolPermi.BuscarRol_Permiso(idRol_Permiso);
        }

        public void EliminarRol_Permiso(int idRol_Permiso)
        {
            rolPermi.EliminarRol_Permiso(idRol_Permiso);
        }

        public void InsertarRol_Permiso(TbRol_Permiso rol_permiso)
        {
            rolPermi.InsertarRol_Permiso(rol_permiso);
        }

        public List<TbRol_Permiso> ListarRol_Permisos()
        {
            return rolPermi.ListarRol_Permisos();
        }
    }
}
