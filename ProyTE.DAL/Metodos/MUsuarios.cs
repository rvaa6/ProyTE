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
    public class MUsuarios : MBase, IUsuarios
    {
        public void ActualizarUsuario(TbUsuarios usuario)
        {
            _db.Update(usuario);
        }

        public TbUsuarios BuscarUsuario(int idUsuario)
        {
            return _db.Select<TbUsuarios>(x => x.Id_Usuario == idUsuario).FirstOrDefault();
        }

        public void EliminarUsuario(int idUsuario)
        {
            _db.Delete<TbUsuarios>(x => x.Id_Usuario == idUsuario);
        }

        public void InsertarUsuario(TbUsuarios usuario)
        {
            _db.Insert(usuario);
        }

        public List<TbUsuarios> ListarUsuarios()
        {
            return _db.Select<TbUsuarios>();
        }
    }
}
