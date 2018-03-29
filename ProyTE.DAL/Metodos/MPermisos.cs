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
    public class MPermisos : MBase, IPermisos
    {
        public void ActualizarPermiso(TbPermisos permiso)
        {
            _db.Update(permiso);
        }

        public TbPermisos BuscarPermiso(int idPermiso)
        {
            return _db.Select<TbPermisos>(x => x.Id_Permiso == idPermiso).FirstOrDefault();
        }

        public void EliminarPermiso(int idPermiso)
        {
            _db.Delete<TbPermisos>(x => x.Id_Permiso == idPermiso);
        }

        public void InsertarPermiso(TbPermisos permiso)
        {
            _db.Insert(permiso);
        }

        public List<TbPermisos> ListarPermisos()
        {
            return _db.Select<TbPermisos>();
        }
    }
}
