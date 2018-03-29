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
    public class MUsuario_Tarjeta : MBase, IUsuario_Tarjeta
    {
        public void ActualizarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta)
        {
            _db.Update(usuarioTarjeta);
        }

        public TbUsuario_Tarjeta BuscarUsuario_Tarjeta(int idUsuario_Tarjeta)
        {
            return _db.Select<TbUsuario_Tarjeta>(x => x.Id_Usuario_Tarjeta == idUsuario_Tarjeta).FirstOrDefault();
        }

        public void EliminarUsuario_Tarjeta(int idUsuario_Tarjeta)
        {
            _db.Delete<TbUsuario_Tarjeta>(x => x.Id_Usuario_Tarjeta == idUsuario_Tarjeta);
        }

        public void InsertarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta)
        {
            _db.Insert(usuarioTarjeta);
        }

        public List<TbUsuario_Tarjeta> ListarUsuario_Tarjetas()
        {
            return _db.Select<TbUsuario_Tarjeta>();
        }
    }
}
