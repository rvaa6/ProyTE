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
    public class MRoles : MBase, IRoles
    {
        public void ActualizarRol(TbRoles rol)
        {
            _db.Update(rol);
        }

        public TbRoles BuscarRol(int idRol)
        {
            return _db.Select<TbRoles>(x => x.Id_Rol == idRol).FirstOrDefault();
        }

        public void EliminarRol(int idRol)
        {
            _db.Delete<TbRoles>(x => x.Id_Rol == idRol);
        }

        public void InsertarRol(TbRoles rol)
        {
            _db.Insert(rol);
        }

        public List<TbRoles> ListarRoles()
        {
            return _db.Select<TbRoles>();
        }
    }
}
