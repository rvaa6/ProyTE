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
    public class MAlquileres : MBase, IAlquileres
    {
        public void ActualizarAlquiler(TbAlquileres alquiler)
        {
            _db.Update(alquiler);
        }

        public TbAlquileres BuscarAlquiler(int idAlquiler)
        {
            return _db.Select<TbAlquileres>(x => x.Id_Alquiler == idAlquiler).FirstOrDefault();
        }

        public void EliminarAlquiler(int idAlquiler)
        {
            _db.Delete<TbAlquileres>(x => x.Id_Alquiler == idAlquiler);
        }

        public void InsertarAlquiler(TbAlquileres alquiler)
        {
            _db.Insert(alquiler);
        }

        public List<TbAlquileres> ListarAlquileres()
        {
            return _db.Select<TbAlquileres>();
        }
    }
}
