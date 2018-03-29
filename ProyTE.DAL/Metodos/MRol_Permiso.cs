using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.DAL.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace ProyTE.DAL.Metodos
{
    public class MRol_Permiso : MBase, IRol_Permiso
    {
        public void ActualizarRol_Permiso(TbRol_Permiso rol_permiso)
        {
            _db.Update(rol_permiso);
        }

        public TbRol_Permiso BuscarRol_Permiso(int idRol_Permiso)
        {
            return _db.Select<TbRol_Permiso>(x => x.Id_Rol_Permiso == idRol_Permiso).FirstOrDefault();
        }

        public void EliminarRol_Permiso(int idRol_Permiso)
        {
            _db.Delete<TbRol_Permiso>(x => x.Id_Rol_Permiso == idRol_Permiso);
        }

        public void InsertarRol_Permiso(TbRol_Permiso rol_permiso)
        {
            _db.Insert(rol_permiso);
        }

        public List<TbRol_Permiso> ListarRol_Permisos()
        {
            return _db.Select<TbRol_Permiso>();
        }
    }
}
